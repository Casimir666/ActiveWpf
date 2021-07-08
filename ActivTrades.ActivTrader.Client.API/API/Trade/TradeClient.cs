// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.Trade.TradeClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer;
using ActivTrades.ActivTrader.Lightstreamer.Trade;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.Common.ExchangeRates;
using ATPlatform.Common.Feed;
using ATPlatform.Common.Utils;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.IDL;
using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Enums.ClientMessage;
using ATPlatform.Model.Feed;
using ATPlatform.Model.Proto;
using Google.Protobuf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.API.Trade
{
  public class TradeClient : 
    APIChannel,
    ITradeClient,
    ITradeChannel,
    IAPIChannel,
    IDisposable,
    ITickProcessing
  {
    private const string allSymbolsLastPricesFlag = "*";
    private const int freshBarsCount = 2;
    private const int firstFreshBarIndex = 0;
    private const int lastFreshBarIndex = 1;
    private static readonly HashSet<MessageTypeProto> lotsValidationReqiredMessageTypes = new HashSet<MessageTypeProto>((IEnumerable<MessageTypeProto>) new MessageTypeProto[2]
    {
      MessageTypeProto.OpenOrderRequest,
      MessageTypeProto.MarginRequirementCheckRequest
    });
    private readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly ServerPublicInfo _serverInfo = new ServerPublicInfo();
    private readonly Account _account;
    private readonly string _platformId;
    private readonly string _preferredLanguage;
    private readonly ConcurrentDictionary<string, ATPlatform.Model.Entities.Currency> _currencies = new ConcurrentDictionary<string, ATPlatform.Model.Entities.Currency>();
    private readonly ConcurrentDictionary<string, SymbolTradingData> _symbolTradingData = new ConcurrentDictionary<string, SymbolTradingData>();
    private readonly ConcurrentDictionary<int, SymbolGroup> _symbolGroups = new ConcurrentDictionary<int, SymbolGroup>();
    private readonly IExchangeRateService _exchangeRateService = (IExchangeRateService) new ExchangeRateService();
    private readonly ITradingSession _session;
    private ServiceState _serviceState;
    private TimeZoneInfo _serverTimeZoneInfo;
    private ILsTradeClient _lsTradingClient;

    public TradeClient(ITradingSession tradingSession, string preferredLanguage = null)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      this._session = tradingSession ?? throw new InvalidCredentialException();
      this._account = new Account()
      {
        Id = tradingSession.SelectedAccountId
      };
      this._platformId = tradingSession.LsTradingAdapter;
      this._preferredLanguage = preferredLanguage;
    }

    public event EventHandler<OrderNotificationEventArgs> OrderNotification;

    public event EventHandler<ClientMessageNotificationEventArgs> ClientMessageNotification;

    public event EventHandler<MarketDataEventNotificationEventArgs> MarketDataEventNotification;

    public override bool IsConnected => this.State == APIChannelState.Connected && this._serviceState == ServiceState.Up;

    public Account GetAccount() => this._account.Clone();

    public TimeZoneInfo GetTimeZoneInfo() => this._serverTimeZoneInfo;

    public override void Connect() => this.ConnectAsync().ExecuteOnThreadPoolAndWait();

    public async Task ConnectAsync()
    {
      TradeClient tradeClient = this;
      if (tradeClient.IsConnected)
        throw new InvalidOperationException(string.Format("Client {0} is already connected.", (object) tradeClient._session.SelectedAccountId));
      tradeClient.Disconnect();
      await tradeClient.LoadAsync();
    }

    protected async Task LoadAsync()
    {
      TradeClient tradeClient = this;
      if (tradeClient.IsConnected)
      {
        tradeClient._logger.Warn((object) "Already connected.");
      }
      else
      {
        tradeClient.ClearState();
        tradeClient._lsTradingClient = (ILsTradeClient) new LsTradeClient(tradeClient._session, tradeClient._preferredLanguage);
        tradeClient._lsTradingClient.StateChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) tradeClient).OnStateChanged);
        tradeClient._lsTradingClient.Connect();
        tradeClient._lsTradingClient.ClientNotificationReceived += new EventHandler<ClientNotificationEventArgs>(tradeClient.OnLsTradingClientNotificationReceived);
        await tradeClient.LoadAccountDataAsync();
        tradeClient._logger.WarnFormat("Trading data for client {0} loaded", (object) tradeClient._session.SelectedAccountId);
        // ISSUE: explicit non-virtual call
        tradeClient.OnStateChanged((object) tradeClient, new APIChannelStateChangedEventArgs()
        {
          NewState = APIChannelState.Connected,
          OldState = tradeClient.State
        });
      }
    }

    public override void Disconnect()
    {
      this.ClearState();
      this._logger.WarnFormat("Trading client {0} disconnected", (object) this._session.SelectedAccountId);
      this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
      {
        NewState = APIChannelState.Disconnected,
        OldState = this.State
      });
    }

    public override void OnStateChanged(object sender, APIChannelStateChangedEventArgs e)
    {
      APIChannelState state = this.State;
      APIChannelState apiChannelState = e.NewState;
      if (apiChannelState == APIChannelState.Connected && this._serviceState != ServiceState.Up)
        apiChannelState = APIChannelState.Connecting;
      if (state == apiChannelState)
        return;
      this._logger.InfoFormat("Connection state changed from {0} to {1}", (object) state, (object) apiChannelState);
      this.State = apiChannelState;
      this.RaiseStatusChangedEvent(new APIChannelStateChangedEventArgs()
      {
        NewState = this.State,
        OldState = state
      });
    }

    public double RequiredMarginGet(OrderRequest orderRequest)
    {
      this.ValidateChannelState();
      return this.RequiredMarginGetAsync(orderRequest).ExecuteOnThreadPoolAndGetResult<double>();
    }

    public async Task<double> RequiredMarginGetAsync(OrderRequest orderRequest)
    {
      OrderRequestProto request1 = orderRequest.ProtoFromModel();
      MessageTypeProto type = MessageTypeProto.MarginRequirementCheckRequest;
      this.ValidateOrderRequest(request1, type);
      MarginRequirementCheckRequestProto checkRequestProto = new MarginRequirementCheckRequestProto()
      {
        AccountId = request1.AccountId,
        Lots = request1.Lots,
        Symbol = request1.Symbol,
        Type = request1.Type,
        Price = request1.Price
      };
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request2 = new ClientRequest();
      request2.Message = (IMessage) checkRequestProto;
      request2.Type = type;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request2);
      if (!(clientNotification.Message is MarginRequirementCheckNotificationProto message))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
      return message.RequiredMargin;
    }

    public Order OpenOrder(OrderRequest orderRequest) => this.OpenOrderAsync(orderRequest).ExecuteOnThreadPoolAndGetResult<Order>();

    public async Task<Order> OpenOrderAsync(OrderRequest orderRequest) => await this.SendOrderRequestAsync(MessageTypeProto.OpenOrderRequest, (IMessage) orderRequest.ProtoFromModel());

    public Order ModifyOrder(OrderRequest orderRequest) => this.ModifyOrderAsync(orderRequest).ExecuteOnThreadPoolAndGetResult<Order>();

    public async Task<Order> ModifyOrderAsync(OrderRequest orderRequest) => await this.SendOrderRequestAsync(MessageTypeProto.UpdateOrderRequest, (IMessage) orderRequest.ProtoFromModel());

    public Order CloseMarketOrder(OrderRequest orderRequest) => this.CloseMarketOrderAsync(orderRequest).ExecuteOnThreadPoolAndGetResult<Order>();

    public async Task<Order> CloseMarketOrderAsync(OrderRequest orderRequest) => await this.SendOrderRequestAsync(MessageTypeProto.CloseOrderRequest, (IMessage) orderRequest.ProtoFromModel());

    public Order CancelPendingOrder(OrderRequest orderRequest) => this.CancelPendingOrderAsync(orderRequest).ExecuteOnThreadPoolAndGetResult<Order>();

    public async Task<Order> CancelPendingOrderAsync(OrderRequest orderRequest) => await this.SendOrderRequestAsync(MessageTypeProto.CancelOrderRequest, (IMessage) orderRequest.ProtoFromModel());

    public async Task<ClosedOrdersAndBalanceOperations> GetClosedOrdersAndBalanceOperationsAsync(
      DateTime fromDateTime,
      DateTime toDateTime)
    {
      GetClosedOrdersForAccountRequestProto accountRequestProto = new GetClosedOrdersForAccountRequestProto()
      {
        AccountId = this._account.Id,
        From = DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(fromDateTime, this._serverTimeZoneInfo),
        To = DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(toDateTime, this._serverTimeZoneInfo)
      };
      List<Order> closedOrders = new List<Order>();
      List<AccountBalanceOperation> accountBalanceOperations = new List<AccountBalanceOperation>();
      if ((await this.SendRequestAsync(MessageTypeProto.GetClosedOrdersForAccountRequest, (IMessage) accountRequestProto)).Message is GetClosedOrdersForAccountNotificationProto message)
      {
        closedOrders = message.Orders.Select<OrderProto, Order>((Func<OrderProto, Order>) (o => o.ModelFromProto<OrderProto, Order>())).ToList<Order>();
        accountBalanceOperations = message.AccountBalanceOperations.Select<AccountBalanceOperationProto, AccountBalanceOperation>((Func<AccountBalanceOperationProto, AccountBalanceOperation>) (bo => bo.ModelFromProto<AccountBalanceOperationProto, AccountBalanceOperation>())).ToList<AccountBalanceOperation>();
      }
      ClosedOrdersAndBalanceOperations balanceOperations = new ClosedOrdersAndBalanceOperations()
      {
        ClosedOrders = new ReadOnlyCollection<Order>((IList<Order>) closedOrders),
        AccountBalanceOperationsBalanceOperations = new ReadOnlyCollection<AccountBalanceOperation>((IList<AccountBalanceOperation>) accountBalanceOperations)
      };
      closedOrders = (List<Order>) null;
      accountBalanceOperations = (List<AccountBalanceOperation>) null;
      return balanceOperations;
    }

    public ClosedOrdersAndBalanceOperations GetClosedOrdersAndBalanceOperations(
      DateTime fromDateTime,
      DateTime toDateTime)
    {
      return this.GetClosedOrdersAndBalanceOperationsAsync(fromDateTime, toDateTime).ExecuteOnThreadPoolAndGetResult<ClosedOrdersAndBalanceOperations>();
    }

    public IReadOnlyCollection<Bar> GetBars(
      string symbol,
      HistoryQuotesPeriod period)
    {
      return this.GetBarsAsync(symbol, period).ExecuteOnThreadPoolAndGetResult<IReadOnlyCollection<Bar>>();
    }

    public async Task<IReadOnlyCollection<Bar>> GetBarsAsync(
      string symbol,
      HistoryQuotesPeriod period)
    {
      if (!this._symbolTradingData.ContainsKey(symbol))
        throw new ArgumentException("Symbol " + symbol + " not found.");
      GetHistoryQuotesRequestProto requestProto = new GetHistoryQuotesRequestProto()
      {
        Period = (HistoryQuotesPeriodProto) period
      };
      requestProto.Symbols.Add(symbol);
      List<Bar> bars = this.ExtractBarsFromNotification(await this.SendRequestAsync(MessageTypeProto.GetHistoryQuotesRequest, (IMessage) requestProto));
      requestProto.CountOfTheLastBars = 2;
      List<Bar> fromNotification = this.ExtractBarsFromNotification(await this.SendRequestAsync(MessageTypeProto.GetHistoryQuotesRequest, (IMessage) requestProto));
      if (bars.Count > fromNotification.Count)
      {
        if (fromNotification.Count > 0)
        {
          if (bars.Last<Bar>().Timestamp == fromNotification.First<Bar>().Timestamp)
          {
            bars.Last<Bar>().Update(fromNotification.First<Bar>());
            if (fromNotification.Count == 2)
              bars.Add(fromNotification.Last<Bar>());
          }
          else
          {
            bars[bars.Count - 2].Update(fromNotification[0]);
            if (fromNotification.Count == 2)
              bars[bars.Count - 1].Update(fromNotification[1]);
          }
        }
      }
      else
        bars = fromNotification;
      IReadOnlyCollection<Bar> bars1 = (IReadOnlyCollection<Bar>) new ReadOnlyCollection<Bar>((IList<Bar>) bars);
      requestProto = (GetHistoryQuotesRequestProto) null;
      bars = (List<Bar>) null;
      return bars1;
    }

    private List<Bar> ExtractBarsFromNotification(ClientNotification clientNotification)
    {
      List<Bar> barList = new List<Bar>();
      if (clientNotification.Message is GetHistoryQuotesNotificationProto message)
      {
        foreach (HistoryQuotesForSymbolProto quote in message.Quotes)
          barList.AddRange((IEnumerable<Bar>) quote.Quotes.ModelFromProto<HistoryQuoteProto, Bar>());
      }
      return barList;
    }

    public IReadOnlyCollection<SymbolGroup> GetSymbolGroups() => (IReadOnlyCollection<SymbolGroup>) this._symbolGroups.CloneEntities<SymbolGroup, int>();

    public SymbolGroup GetSymbolGroup(int id)
    {
      SymbolGroup symbolGroup;
      if (!this._symbolGroups.TryGetValue(id, out symbolGroup))
        throw new ArgumentException(string.Format("Symbol group with id {0} not found.", (object) id), nameof (id));
      return symbolGroup.Clone();
    }

    public IReadOnlyCollection<Symbol> GetSymbols()
    {
      List<Symbol> symbolList = new List<Symbol>();
      foreach (string key in this._symbolTradingData.Keys.ToList<string>())
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(key, out symbolTradingData))
          symbolList.Add(symbolTradingData.SymbolTradeSettings.Clone());
      }
      return (IReadOnlyCollection<Symbol>) new ReadOnlyCollection<Symbol>((IList<Symbol>) symbolList);
    }

    public Symbol GetSymbol(string symbol)
    {
      if (string.IsNullOrEmpty(symbol))
        throw new ArgumentNullException(nameof (symbol));
      SymbolTradingData symbolTradingData;
      if (!this._symbolTradingData.TryGetValue(symbol, out symbolTradingData))
        throw new ArgumentException("Symbol " + symbol + " not found.", nameof (symbol));
      return symbolTradingData.SymbolTradeSettings.Clone();
    }

    public SymbolTradingData GetSymbolTradingData(string symbol)
    {
        if (_symbolTradingData.TryGetValue(symbol, out SymbolTradingData symbolTradingData))
            return symbolTradingData;
        return null;
    }

    public IReadOnlyCollection<TradingSession> GetSymbolTradingSessions(
      string symbol)
    {
      if (string.IsNullOrEmpty(symbol))
        throw new ArgumentNullException(nameof (symbol));
      SymbolTradingData symbolTradingData;
      if (!this._symbolTradingData.TryGetValue(symbol, out symbolTradingData))
        throw new ArgumentException("Symbol " + symbol + " not found.", nameof (symbol));
      return (IReadOnlyCollection<TradingSession>) new ReadOnlyCollection<TradingSession>((IList<TradingSession>) symbolTradingData.SymbolTradingSessions.Sessions.Select<TradingSession, TradingSession>((Func<TradingSession, TradingSession>) (s => s.Clone())).ToList<TradingSession>());
    }

    public bool IsInSessionAndNotExpired(string symbol)
    {
      if (string.IsNullOrEmpty(symbol))
        throw new ArgumentNullException(nameof (symbol));
      SymbolTradingData symbolTradingData;
      if (!this._symbolTradingData.TryGetValue(symbol, out symbolTradingData))
        throw new ArgumentException("Symbol " + symbol + " not found.", nameof (symbol));
      return symbolTradingData.IsInSessionAndNotExpired;
    }

    public IReadOnlyCollection<Order> GetOrders()
    {
      List<Order> orderList = new List<Order>();
      foreach (string key in this._symbolTradingData.Keys.ToList<string>())
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(key, out symbolTradingData) && !symbolTradingData.IsEmpty)
          orderList.AddRange((IEnumerable<Order>) symbolTradingData.GetOrders());
      }
      return (IReadOnlyCollection<Order>) new ReadOnlyCollection<Order>((IList<Order>) orderList);
    }

    public IReadOnlyCollection<Order> GetOrders(string symbol)
    {
      IReadOnlyCollection<Order> orders = (IReadOnlyCollection<Order>) new ReadOnlyCollection<Order>((IList<Order>) new List<Order>());
      SymbolTradingData symbolTradingData;
      if (this._symbolTradingData.TryGetValue(symbol, out symbolTradingData))
        orders = (IReadOnlyCollection<Order>) symbolTradingData.GetOrders();
      return orders;
    }

    public Order GetOrder(string symbol, long orderId)
    {
      Order order = (Order) null;
      SymbolTradingData symbolTradingData;
      if (this._symbolTradingData.TryGetValue(symbol, out symbolTradingData))
        order = symbolTradingData.GetOrder(orderId);
      return order;
    }

    public bool TryProcessTick(Tick tick, out double maxEntrySize)
    {
      SymbolTradingData symbolTradingData;
      if (this._symbolTradingData.TryGetValue(tick.SymbolId, out symbolTradingData) && symbolTradingData.IsInSessionAndNotExpired)
      {
        maxEntrySize = symbolTradingData.Symbol.GetMaxEntrySize();
        this._exchangeRateService.UpdateExchangeRate((IExchangeRateSymbol) symbolTradingData.SymbolTradeSettings, (ITick) tick);
        tick.Ask += symbolTradingData.AskMarkup;
        tick.Bid += symbolTradingData.BidMarkup;
        symbolTradingData.LastFilteredTicks.Update(tick);
        if (this._logger.IsDebugEnabled)
          this._logger.DebugFormat("Tick {0} processed.", (object) tick);
        return true;
      }
      if (this._logger.IsDebugEnabled)
        this._logger.DebugFormat("{0} not found or is not in session.", (object) tick.SymbolId);
      maxEntrySize = 0.0;
      return false;
    }

    public TradeSummary GetTradeSummary() => new TradeSummary(this._account, this.GetOrders());

    public override void Dispose()
    {
      if (this.disposed)
        return;
      try
      {
        if (!this.IsConnected)
          return;
        this.Disconnect();
        this.ClearState();
      }
      finally
      {
        this.disposed = true;
      }
    }

    protected virtual void OnLsTradingClientNotificationReceived(
      object sender,
      ClientNotificationEventArgs e)
    {
      this.ProcessTradingNotification(e);
    }

    protected void ProcessTradingNotification(ClientNotificationEventArgs e)
    {
      bool requestedByClient = e.RequestedByClient;
      ClientNotification message = e.Message;
      this._logger.InfoFormat("{0} processing started. RequestId:{1}", (object) message.Type, (object) message.RequestId);
      switch (message.Type)
      {
        case MessageTypeProto.GetServerInfoNotification:
          this.ProcessServerInfoNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetServerPublicInfoNotification:
          this.ProcessServerPublicInfoNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.ServiceStatusNotification:
          this.ProcessServiceStatusNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.OpenOrderNotification:
        case MessageTypeProto.ActivateOrderNotification:
        case MessageTypeProto.CloseOrderNotification:
        case MessageTypeProto.CancelOrderNotification:
        case MessageTypeProto.DeleteOrderNotification:
        case MessageTypeProto.UpdateOrderNotification:
          this.ProcessOrderNotification(message, requestedByClient);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.MarginRequirementCheckNotification:
        case MessageTypeProto.GetOpenedOrdersForAccountNotification:
        case MessageTypeProto.GetAccountDetailsForAccountNotification:
        case MessageTypeProto.GetSymbolTradingSessionsForAccountNotification:
        case MessageTypeProto.GetHistoryQuotesNotification:
        case MessageTypeProto.GetLastPricesNotification:
        case MessageTypeProto.GetLastTicksNotification:
        case MessageTypeProto.GetBarsNotification:
        case MessageTypeProto.DeleteSymbolNotification:
        case MessageTypeProto.CreateAccountNotification:
        case MessageTypeProto.ReOpenAccountNotification:
        case MessageTypeProto.GetCurrenciesNotification:
          this._logger.InfoFormat("{0} processing finished. RequestId:{1}", (object) message.Type, (object) message.RequestId);
          break;
        case MessageTypeProto.UpdateAccountBalanceNotification:
          this.ProcessUpdateAccountBalanceNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.CreateClientSessionForAccountNotification:
          this.ProcessCreateClientSessionForAccountNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.EndClientSessionForAccountNotification:
          this.ProcessEndClientSessionForAccountNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.AccountTradeConditionsUpdatedNotification:
          this.ProcessAccountTradeConditionsUpdatedNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.ReloadTradeSettingsForAccountNotification:
          this.ProcessReloadTradeSettingsForAccountNotification();
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.AccountTradeConditionsInitializedNotification:
          this.ProcessAccountTradeConditionsInitializedNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.NewTickNotification:
          this.ProcessNewTickNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.CreateSymbolGroupNotification:
          this.ProcessCreateSymbolGroupNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.UpdateSymbolGroupNotification:
          this.ProcessUpdateSymbolGroupNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.DeleteSymbolGroupNotification:
          this.ProcessDeleteSymbolGroupNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.CreateSymbolNotification:
        case MessageTypeProto.UpdateSymbolNotification:
          this.ProcessSymbolNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetSymbolsByTradeSetNotification:
          this.ProcessSymbolsByTradeSet(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetNotification:
          this.ProcessSymbolMarkupSettings(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.UpdateAccountNotification:
          this.ProcessUpdateAccountNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.DeleteAccountNotification:
        case MessageTypeProto.CloseAccountNotification:
          this.ProcessCloseOrDeleteAccountNotifcations(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.UpdateClientMessageNotification:
        case MessageTypeProto.DeleteClientMessageNotification:
          this.ProcessClientMessageNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.MarketDataEventNotification:
          this.ProcessMarketDataEventNotification(message);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        default:
          this._logger.WarnFormat("{0} not supported as notification. RequestId:{1}", (object) message.Type, (object) message.RequestId);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
      }
    }

    private void ProcessSymbolNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is SymbolNotificationProto message))
        return;
      this.ProcessSymbol(message.Symbol.ModelFromProto<SymbolProto, Symbol>(), this.MapSymbolTradingSessions(message.SymbolTradingSessions));
    }

    private void ProcessClientMessageNotification(ClientNotification clientNotification)
    {
      ATPlatform.Model.Entities.ClientMessage clientMessage = (clientNotification.Message as ClientMessageForAccountNotificationProto).ModelFromProto<ClientMessageForAccountNotificationProto, ATPlatform.Model.Entities.ClientMessage>();
      EventHandler<ClientMessageNotificationEventArgs> messageNotification = this.ClientMessageNotification;
      if (messageNotification == null)
        return;
      messageNotification((object) this, new ClientMessageNotificationEventArgs()
      {
        ClientMessage = clientMessage
      });
    }

    private void ProcessMarketDataEventNotification(ClientNotification clientNotification)
    {
      MarketDataEvent marketDataEvent = (clientNotification.Message as MarketDataEventNotificationProto).ModelFromProto<MarketDataEventNotificationProto, MarketDataEvent>();
      EventHandler<MarketDataEventNotificationEventArgs> eventNotification = this.MarketDataEventNotification;
      if (eventNotification == null)
        return;
      eventNotification((object) this, new MarketDataEventNotificationEventArgs()
      {
        MarketDataEvent = marketDataEvent
      });
    }

    private void ProcessReloadTradeSettingsForAccountNotification()
    {
      this._serviceState = ServiceState.Down;
      this._logger.WarnFormat("Trade settings for account changed. Will reload. The service state changed to {0}", (object) this._serviceState);
      this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
      {
        OldState = this.State,
        NewState = APIChannelState.ServiceDown
      });
    }

    private async Task<ClientNotification> SendRequestAsync(
      MessageTypeProto type,
      IMessage request)
    {
      TradeClient tradeClient = this;
      tradeClient.ValidateChannelState();
      ILsTradeClient lsTradingClient = tradeClient._lsTradingClient;
      ClientRequest request1 = new ClientRequest();
      request1.Message = request;
      request1.Type = type;
      return await lsTradingClient.RequestAsync(request1);
    }

    private async Task<Order> SendOrderRequestAsync(
      MessageTypeProto type,
      IMessage request)
    {
      this.ValidateOrderRequest(request as OrderRequestProto, type);
      if (!((await this.SendRequestAsync(type, request))?.Message is OrderNotificationProto message))
        throw new InvalidCastException();
      return message.Order.ModelFromProto<OrderProto, Order>();
    }

    private void ValidateOrderRequest(OrderRequestProto request, MessageTypeProto type)
    {
      if (request == null)
        throw new ArgumentNullException(nameof (request));
      if (request.AccountId != this._account.Id)
        throw new ArgumentException(string.Format("Invalid account {0}", (object) request.AccountId), nameof (request));
      if (this._account.AccountMode == AccountMode.Netting && request.IsTrailingStop())
        throw new ArgumentException(string.Format("{0} in trading mode {1}  is not allowed", (object) request.Type, (object) this._account.AccountMode), nameof (request));
      if (type == MessageTypeProto.CancelOrderRequest)
        return;
      if (string.IsNullOrEmpty(request.Symbol))
        throw new ArgumentException("Symbol cannot be empty", nameof (request));
      SymbolTradingData symbolTradingData;
      if (!this._symbolTradingData.TryGetValue(request.Symbol, out symbolTradingData))
        throw new ArgumentException(request.Symbol + " not found", nameof (request));
      Symbol symbol = symbolTradingData.Symbol.Clone();
      if (!symbolTradingData.IsInSessionAndNotExpired)
      {
        int num;
        if (symbol.ExpirationDate.HasValue)
        {
          DateTime now = symbol.ExpirationDate.Value;
          DateTime universalTime1 = now.ToUniversalTime();
          now = DateTime.Now;
          DateTime universalTime2 = now.ToUniversalTime();
          num = universalTime1 < universalTime2 ? 1 : 0;
        }
        else
          num = 0;
        throw new ArgumentException(num != 0 ? request.Symbol + " is expired." : request.Symbol + " is out of session.", nameof (request));
      }
      double lots = request.Lots;
      if (TradeClient.lotsValidationReqiredMessageTypes.Contains(type))
      {
        double minLots = symbol.MinLots;
        double maxLots = symbol.MaxLots;
        double step = symbol.Step;
        if (lots < minLots)
          throw new ArgumentException(string.Format("{0} {1} must be great than or equal to {2}", (object) "Lots", (object) lots, (object) minLots), nameof (request));
        if (lots > maxLots)
          throw new ArgumentException(string.Format("{0} {1} must be less than or equal to {2}", (object) "Lots", (object) lots, (object) maxLots), nameof (request));
        double num = Math.Pow(10.0, (double) symbol.Digits);
        if (Math.Abs(lots % step) > num)
          throw new ArgumentException(string.Format("{0} {1} must be multiple of {2}", (object) "Lots", (object) lots, (object) step), nameof (request));
      }
      if (!this.IsMultipleOf(request.StopLoss, symbol.TickSize, (int) symbol.Digits))
        throw new ArgumentException(string.Format("{0} {1} must be multiple of {2}", (object) "StopLoss", (object) request.StopLoss, (object) symbol.TickSize), nameof (request));
      if (!this.IsMultipleOf(request.TakeProfit, symbol.TickSize, (int) symbol.Digits))
        throw new ArgumentException(string.Format("{0} {1} must be multiple of {2}", (object) "TakeProfit", (object) request.TakeProfit, (object) symbol.TickSize), nameof (request));
      if (!this.IsMultipleOf(request.Price, symbol.TickSize, (int) symbol.Digits))
        throw new ArgumentException(string.Format("{0} {1} must be multiple of {2}", (object) "Price", (object) request.Price, (object) symbol.TickSize), nameof (request));
    }

    public bool IsMultipleOf(double target, double multipleOf, int precision) => (int) (target * Math.Pow(10.0, (double) precision)) % (int) (multipleOf * Math.Pow(10.0, (double) precision)) == 0;

    private void LoadAccountData() => this.LoadAccountDataAsync().ExecuteOnThreadPoolAndWait();

    private async Task LoadAccountDataAsync()
    {
      TradeClient tradeClient = this;
      await tradeClient.LoadServerStatusAsync();
      await tradeClient.LoadServerInfoAsync();
      await tradeClient.LoadAccountDetailsAsync();
      await tradeClient.LoadCurrenciesAsync();
      // ISSUE: reference to a compiler-generated method
      //Task task = await tradeClient.LoadSymbolsByTradeSetAsync().ContinueWith<Task>(new Func<Task, Task>(tradeClient.\u003CLoadAccountDataAsync\u003Eb__75_0));
      await tradeClient.LoadSymbolsByTradeSetAsync();
      await tradeClient.LoadSymbolsTradingSessionsAsync();
      await tradeClient.LoadOpenedOrdersAsync();
      await tradeClient.LoadLastPricesAsync();
      await tradeClient.LoadMarkupSettingsAsync();
    }

    private async Task LoadServerStatusAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new ServiceStatusRequestProto();
      request.Type = MessageTypeProto.ServiceStatusRequest;
      if (!((await lsTradingClient.RequestAsync(request)).Message is ServiceStatusNotificationProto))
        throw new InvalidCastException();
    }

    private async Task LoadServerInfoAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetServerPublicInfoRequestProto();
      request.Type = MessageTypeProto.GetServerPublicInfoRequest;
      if (!((await lsTradingClient.RequestAsync(request)).Message is GetServerPublicInfoNotificationProto))
        throw new InvalidCastException();
    }

    private async Task LoadCurrenciesAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetCurrencyRequestProto()
      {
        AccountId = this._account.Id
      };
      request.Type = MessageTypeProto.GetCurrenciesRequest;
      if (!((await lsTradingClient.RequestAsync(request)).Message is GetCurrencyNotificationProto message))
        throw new InvalidCastException();
      this._currencies.Clear();
      foreach (CurrencyProto currency in message.Currencies)
      {
        ATPlatform.Model.Entities.Currency ccy = currency.ModelFromProto<CurrencyProto, ATPlatform.Model.Entities.Currency>();
        this._currencies.AddOrUpdate(ccy.IsoCode, ccy, (Func<string, ATPlatform.Model.Entities.Currency, ATPlatform.Model.Entities.Currency>) ((k, v) =>
        {
          v.Update(ccy);
          return v;
        }));
      }
      this.LoadExchangeRateService();
    }

    private void LoadExchangeRateService()
    {
      List<ATPlatform.Model.Entities.Currency> result;
      List<string> failed;
      if (this._currencies.TryGetAllEntities<ATPlatform.Model.Entities.Currency, string>(out result, out failed))
        this._exchangeRateService.Initialize((IEnumerable<ICurrency>) result);
      else
        this._logger.ErrorFormat("Failed to load currencies {0} from local storage.", (object) string.Join(";", (IEnumerable<string>) failed));
    }

    private async Task LoadAccountDetailsAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetAccountDetailsForAccountRequestProto()
      {
        AccountId = this._session.SelectedAccountId
      };
      request.Type = MessageTypeProto.GetAccountDetailsForAccountRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
      if (!(clientNotification.Message is AccountNotificationProto message))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
      this._account.Update(message.Account.ModelFromProto<AccountProto, Account>());
    }

    private async Task LoadSymbolsByTradeSetAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetSymbolsByTradeSetRequestProto()
      {
        TradeSetName = this._account.TradeSettingsSet
      };
      request.Type = MessageTypeProto.GetSymbolsByTradeSetRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
      if (!(clientNotification.Message is GetSymbolsByTradeSetNotificationProto))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
    }

    private async Task LoadSymbolsTradingSessionsAsync()
    {
      List<string> symbolsKeys = this._symbolTradingData.Keys.ToList<string>();
      Dictionary<string, SymbolTradingSessions> tradingSessionsAsync = await this.GetSymbolTradingSessionsAsync((IEnumerable<string>) symbolsKeys);
      foreach (string str in symbolsKeys)
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(str, out symbolTradingData))
        {
          SymbolTradingSessions other;
          if (!tradingSessionsAsync.TryGetValue(str, out other))
            other = new SymbolTradingSessions(str, this._serverTimeZoneInfo);
          symbolTradingData.SymbolTradingSessions.Update(other);
        }
      }
      symbolsKeys = (List<string>) null;
    }

    private async Task<Dictionary<string, SymbolTradingSessions>> GetSymbolTradingSessionsAsync(
      IEnumerable<string> symbols)
    {
      GetSymbolTradingSessionsForAccountRequestProto accountRequestProto = new GetSymbolTradingSessionsForAccountRequestProto()
      {
        AccountId = this._session.SelectedAccountId
      };
      accountRequestProto.Symbols.AddRange((IEnumerable<string>) symbols.ToList<string>());
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) accountRequestProto;
      request.Type = MessageTypeProto.GetSymbolTradingSessionsForAccountRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
      if (!(clientNotification.Message is GetSymbolTradingSessionsForAccountNotificationProto message))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
      Dictionary<string, SymbolTradingSessions> dictionary = new Dictionary<string, SymbolTradingSessions>();
      foreach (SymbolTradingSessionsProto symbolTradingSession in message.SymbolTradingSessions)
      {
        SymbolTradingSessions symbolTradingSessions = this.MapSymbolTradingSessions(symbolTradingSession);
        dictionary.Add(symbolTradingSession.SymbolId, symbolTradingSessions);
      }
      return dictionary;
    }

    private SymbolTradingSessions MapSymbolTradingSessions(
      SymbolTradingSessionsProto symbolTradingSession)
    {
      SymbolTradingSessions symbolTradingSessions = new SymbolTradingSessions(symbolTradingSession.SymbolId, this._serverTimeZoneInfo);
      symbolTradingSessions.AddTradingSessions((IReadOnlyCollection<TradingSession>) symbolTradingSession.TradingSession.ModelFromProto<TradingSessionProto, TradingSession>().ToList<TradingSession>());
      return symbolTradingSessions;
    }

    private async Task LoadLastPricesAsync()
    {
      GetLastPricesRequestProto pricesRequestProto = new GetLastPricesRequestProto();
      pricesRequestProto.Symbols.Add("*");
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) pricesRequestProto;
      request.Type = MessageTypeProto.GetLastPricesRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
      if (!(clientNotification.Message is GetLastPricesNotificationProto message))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
      foreach (LastPricesProto price in message.Prices)
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(price.Symbol, out symbolTradingData))
        {
          Symbol symbol = symbolTradingData.Symbol;
          Tick newTick = new Tick()
          {
            SymbolId = symbol.Id,
            Ask = (double) price.Ask / Math.Pow(10.0, (double) symbol.Digits) + symbolTradingData.AskMarkup,
            Bid = (double) price.Bid / Math.Pow(10.0, (double) symbol.Digits) + symbolTradingData.BidMarkup,
            Digits = (int) symbolTradingData.Symbol.Digits,
            TimeStamp = DateTimeOperations.GetTimeZoneSpecificDateTimeFromUnixMilliseconds(price.Timestamp, this._serverTimeZoneInfo)
          };
          symbolTradingData.LastFilteredTicks.Update(newTick);
          this._exchangeRateService.UpdateExchangeRate((IExchangeRateSymbol) symbol, (ITick) newTick);
        }
      }
    }

    private async Task LoadOpenedOrdersAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetOpenedOrdersForAccountRequestProto()
      {
        AccountId = this._session.SelectedAccountId
      };
      request.Type = MessageTypeProto.GetOpenedOrdersForAccountRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
      if (!(clientNotification.Message is GetOpenedOrdersForAccountNotificationProto message))
      {
        this.FailedToCast(clientNotification);
        throw new InvalidCastException();
      }
      foreach (IGrouping<string, OrderProto> grouping in message.Orders.GroupBy<OrderProto, string>((Func<OrderProto, string>) (g => g.Symbol)).ToList<IGrouping<string, OrderProto>>())
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(grouping.Key, out symbolTradingData))
        {
          foreach (OrderProto proto in (IEnumerable<OrderProto>) grouping)
          {
            Order order = proto.ModelFromProto<OrderProto, Order>();
            symbolTradingData?.AddOrUpdateOrder(order);
          }
        }
      }
    }

    private async Task LoadMarkupSettingsAsync()
    {
      ILsTradeClient lsTradingClient = this._lsTradingClient;
      ClientRequest request = new ClientRequest();
      request.Message = (IMessage) new GetSymbolsMarkupSettingsByMarkupSetRequestProto()
      {
        MarkupSetName = this._account.MarkupSettingsSet
      };
      request.Type = MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetRequest;
      ClientNotification clientNotification = await lsTradingClient.RequestAsync(request);
    }

    private void ClearState()
    {
      this._serviceState = ServiceState.Down;
      this._symbolTradingData.Clear();
      this._currencies.Clear();
      this._symbolGroups.Clear();
      if (this._lsTradingClient == null)
        return;
      this._lsTradingClient.ClientNotificationReceived -= new EventHandler<ClientNotificationEventArgs>(this.OnLsTradingClientNotificationReceived);
      this._lsTradingClient.StateChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      this._lsTradingClient?.Disconnect();
      this._lsTradingClient?.Dispose();
      this._lsTradingClient = (ILsTradeClient) null;
    }

    private void ProcessCloseOrDeleteAccountNotifcations(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountNotificationProto message) || message.Account.Id != this._account.Id)
        return;
      this._logger.WarnFormat("Account closed or account deleted notification received. Connection will be closed");
      this.Disconnect();
    }

    private void ProcessUpdateAccountNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountNotificationProto message))
        return;
      double balance = this._account.Balance;
      double margin = this._account.Margin;
      double equity = this._account.Equity;
      this._account.Update(message.Account.ModelFromProto<AccountProto, Account>());
      this._account.Balance = balance;
      this._account.Margin = margin;
      this._account.Equity = equity;
    }

    private void ProcessDeleteSymbolGroupNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is SymbolGroupNotificationProto message))
        return;
      int id = message.SymbolGroup.Id;
      if (!this._symbolGroups.ContainsKey(id))
        return;
      this._logger.DebugFormat("Symbol group {0} found and will be removed", (object) id);
      SymbolGroup symbolGroup;
      if (this._symbolGroups.TryRemove(id, out symbolGroup))
        this._logger.DebugFormat("Symbol group {0} ({1}) found and will be removed", (object) id, (object) symbolGroup.Name);
      else
        this._logger.ErrorFormat("Failed to remove symbol group {0} ({1}).", (object) id, (object) symbolGroup.Name);
    }

    private void ProcessUpdateSymbolGroupNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is SymbolGroupNotificationProto message))
        return;
      SymbolGroup symbolGroup = message != null ? message.SymbolGroup.ModelFromProto<SymbolGroupProto, SymbolGroup>() : (SymbolGroup) null;
      if (this._symbolGroups.ContainsKey(symbolGroup.Id))
      {
        this._logger.DebugFormat("Symbol group {0} found and will be updated", (object) symbolGroup.Id);
        if (this._symbolGroups.TryUpdate(symbolGroup.Id, symbolGroup, symbolGroup))
          this._logger.DebugFormat("Symbol group {0} ({1}) updated successfully", (object) symbolGroup.Id, (object) symbolGroup.Name);
        else
          this._logger.ErrorFormat("Failed to update symbol group {0} ({1}).", (object) symbolGroup.Id, (object) symbolGroup.Name);
      }
      else
        this._logger.WarnFormat("Symbol group {0} ({1}) not found", (object) symbolGroup?.Id, (object) symbolGroup?.Name);
    }

    private void ProcessCreateSymbolGroupNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is SymbolGroupNotificationProto message))
        return;
      this._logger.WarnFormat("Create symbol group notification not processed!", (object) message.SymbolGroup);
    }

    private void ProcessNewTickNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is NewTickNotificationProto message))
        return;
      Tick tick = message.Tick.ModelFromProto<TickProto, Tick>();
      double maxEntrySize;
      if (this.TryProcessTick(tick, out maxEntrySize))
        this._logger.WarnFormat("New tick notification processed successfully. {0}. Max entry size:{1}", (object) tick, (object) maxEntrySize);
      else
        this._logger.ErrorFormat("New tick notification processing failed. {0}", (object) tick);
    }

    private void ProcessAccountTradeConditionsInitializedNotification(
      ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountTradeConditionsUpdatedNotificationProto message))
        return;
      this._account.UpdateTradeSummary(message.AccountTradeSummary);
    }

    private void ProcessAccountTradeConditionsUpdatedNotification(
      ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountTradeConditionsUpdatedNotificationProto message))
        return;
      this._account.UpdateTradeSummary(message.AccountTradeSummary);
    }

    private void ProcessEndClientSessionForAccountNotification(ClientNotification clientNotification) => this._logger.InfoFormat("{0}", (object) (clientNotification.Message as ClientSessionNotificationProto));

    private void ProcessCreateClientSessionForAccountNotification(
      ClientNotification clientNotification)
    {
      this._logger.InfoFormat("{0}", (object) (clientNotification.Message as ClientSessionNotificationProto));
    }

    private void ProcessUpdateAccountBalanceNotification(ClientNotification clientNotification) => this._account.UpdateTradeSummary((clientNotification.Message as UpdateAccountBalanceNotificationProto)?.AccountTradeSummary);

    private void ProcessServiceStatusNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is ServiceStatusNotificationProto message))
        return;
      switch (message.ServiceStatus)
      {
        case ServiceStatusProto.Up:
          this._serviceState = ServiceState.Up;
          if (this.IsConnected)
            break;
          this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
          {
            NewState = APIChannelState.Connecting,
            OldState = this.State
          });
          break;
        case ServiceStatusProto.Down:
          this._serviceState = ServiceState.Down;
          this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
          {
            NewState = APIChannelState.ServiceDown,
            OldState = this.State
          });
          break;
        default:
          this._logger.ErrorFormat("{0} is not supported {1}", (object) message.ServiceStatus, (object) typeof (ServiceStatusProto).Name);
          break;
      }
    }

    private void ProcessServerPublicInfoNotification(ClientNotification clientNotification)
    {
      this._serverInfo.Update((clientNotification.Message as GetServerPublicInfoNotificationProto).ModelFromProto<GetServerPublicInfoNotificationProto, ServerPublicInfo>());
      this.UpdateTimeZone();
    }

    private void ProcessServerInfoNotification(ClientNotification clientNotification)
    {
      this._serverInfo.Update((ServerPublicInfo) (clientNotification.Message as GetServerInfoNotificationProto).ModelFromProto<GetServerInfoNotificationProto, ServerInfo>());
      this.UpdateTimeZone();
    }

    private void ProcessOrderNotification(
      ClientNotification clientNotification,
      bool basedOnLocalRequest)
    {
      if (!(clientNotification.Message is OrderNotificationProto message))
        return;
      this._account.UpdateTradeSummary(message.AccountTradeSummary);
      Order order = message.Order.ModelFromProto<OrderProto, Order>();
      SymbolTradingData symbolTradingData;
      if (this._symbolTradingData.TryGetValue(order.Symbol, out symbolTradingData))
      {
        if (order.IsActive())
        {
          order = symbolTradingData.AddOrUpdateOrder(order);
          this._logger.DebugFormat("Order {0} added or updated", (object) order.Id);
        }
        else
        {
          Order existingOrder;
          if (symbolTradingData.TryRemoveOrder(order, out existingOrder))
          {
            existingOrder.Update(order);
            this._logger.DebugFormat("Order {0} removed", (object) existingOrder.Id);
          }
          else
            this._logger.ErrorFormat("Failed to remove order {0}.", (object) order.Id);
        }
      }
      else
        this._logger.ErrorFormat("Trading data for symbol {0} not found.", (object) order.Symbol);
      EventHandler<OrderNotificationEventArgs> orderNotification = this.OrderNotification;
      if (orderNotification == null)
        return;
      orderNotification((object) this, new OrderNotificationEventArgs()
      {
        Order = order.Clone(),
        RequestedByClient = basedOnLocalRequest
      });
    }

    private void ProcessSymbol(Symbol symbol, SymbolTradingSessions symbolTradingSessions)
    {
      if (!this._symbolGroups.ContainsKey(symbol.GroupId))
        this._logger.WarnFormat("{0} symbol group for symbol {1} not found in the current list of allowed symbol groups", (object) symbol.GroupId, (object) symbol.Id);
      LastTicksFilteredStorage lastFilteredTicks = new LastTicksFilteredStorage(symbol);
      SymbolTradingData addValue = new SymbolTradingData(this._account, symbol, symbolTradingSessions, lastFilteredTicks, this._exchangeRateService);
      this._symbolTradingData.AddOrUpdate(symbol.Id, addValue, (Func<string, SymbolTradingData, SymbolTradingData>) ((k, existingTradingData) =>
      {
        existingTradingData.Symbol.Update(symbol);
        existingTradingData.SymbolTradingSessions.Update(symbolTradingSessions);
        return existingTradingData;
      }));
    }

    private void ProcessSymbol(Symbol symbol)
    {
      if (!this._symbolGroups.ContainsKey(symbol.GroupId))
        this._logger.WarnFormat("{0} symbol group for symbol {1} not found in the current list of allowed symbol groups", (object) symbol.GroupId, (object) symbol.Id);
      LastTicksFilteredStorage lastFilteredTicks = new LastTicksFilteredStorage(symbol);
      SymbolTradingData addValue = new SymbolTradingData(this._account, symbol, new SymbolTradingSessions(symbol.Id, this._serverTimeZoneInfo), lastFilteredTicks, this._exchangeRateService);
      this._symbolTradingData.AddOrUpdate(symbol.Id, addValue, (Func<string, SymbolTradingData, SymbolTradingData>) ((k, existingTradingData) =>
      {
        existingTradingData.Symbol.Update(symbol);
        return existingTradingData;
      }));
    }

    private void ProcessSymbolsByTradeSet(ClientNotification result)
    {
      if (!(result.Message is GetSymbolsByTradeSetNotificationProto message))
      {
        this.FailedToCast(result);
        throw new InvalidCastException();
      }
      this.ProcessSymbolGroups(message);
      foreach (SymbolProto symbol in message.Symbols)
        this.ProcessSymbol(symbol.ModelFromProto<SymbolProto, Symbol>());
    }

    private void ProcessSymbolGroups(GetSymbolsByTradeSetNotificationProto notification)
    {
      this._symbolGroups.Clear();
      foreach (SymbolGroupProto symbolGroup in notification.SymbolGroups)
        this._symbolGroups[symbolGroup.Id] = symbolGroup.ModelFromProto<SymbolGroupProto, SymbolGroup>();
    }

    private void ProcessSymbolMarkupSettings(ClientNotification result)
    {
      if (!(result.Message is GetSymbolsMarkupSettingsByMarkupSetNotificationProto message))
      {
        this.FailedToCast(result);
        throw new InvalidCastException();
      }
      foreach (string key in (IEnumerable<string>) message.SymbolsMarkupSettings.Keys)
      {
        SymbolTradingData symbolTradingData;
        if (this._symbolTradingData.TryGetValue(key, out symbolTradingData))
        {
          MarkupSettingsProto symbolsMarkupSetting = message.SymbolsMarkupSettings[key];
          symbolTradingData.AskMarkup = Math.Round((double) symbolsMarkupSetting.AskMarkup / Math.Pow(10.0, (double) symbolTradingData.Symbol.Digits), (int) symbolTradingData.Symbol.Digits);
          symbolTradingData.BidMarkup = -Math.Round((double) symbolsMarkupSetting.BidMarkup / Math.Pow(10.0, (double) symbolTradingData.Symbol.Digits), (int) symbolTradingData.Symbol.Digits);
          this._logger.DebugFormat("{0} markup settings processed", (object) key);
        }
        else
          this._logger.InfoFormat("{0} markup settings processing failed. Symbol not found", (object) key);
      }
    }

    private void UpdateTimeZone()
    {
      this._serverTimeZoneInfo = TimeZoneHelper.GetTimeZoneById((int) this._serverInfo.PlatformTimeZone);
      MappingExtensions.SetTimeZone(this._serverTimeZoneInfo);
    }

    private void FailedToCast(ClientNotification clientNotification)
    {
      this._logger.ErrorFormat("Unable to cast {0}. RequestId:{1}", (object) clientNotification.Type, (object) clientNotification.RequestId);
      if (!this._logger.IsInfoEnabled)
        return;
      this._logger.InfoFormat("Message with request id {0}:{1}{2}", (object) clientNotification.RequestId, (object) Environment.NewLine, (object) clientNotification.Message.ToString());
    }

    public IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage> GetClientMessages(
      GetClientMessagesForAccountRequest request)
    {
      return this.GetClientMessagesAsync(request).ExecuteOnThreadPoolAndGetResult<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>>();
    }

    public IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage> GetClientMessagesFiltered(
      GetClientMessagesFilteredForAccountRequest filter)
    {
      return this.GetClientMessagesAsync((GetClientMessagesForAccountRequest) filter).ExecuteOnThreadPoolAndGetResult<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>>();
    }

    public async Task<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>> GetClientMessagesAsync(
      GetClientMessagesForAccountRequest request)
    {
      return (IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>) new ReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>((IList<ATPlatform.Model.Entities.ClientMessage>) ((await this.SendRequestAsync(MessageTypeProto.GetClientMessagesForAccountRequest, (IMessage) this.MapClientMessageForAccountRequest(request))).Message as GetClientMessagesForAccountNotificationProto).ClientMessagesForAccount.Select<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>((Func<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>) (cm => cm.ModelFromProto<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>())).ToList<ATPlatform.Model.Entities.ClientMessage>());
    }

    public async Task<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>> GetClientMessagesFilteredAsync(
      GetClientMessagesFilteredForAccountRequest filter)
    {
      return (IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>) new ReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>((IList<ATPlatform.Model.Entities.ClientMessage>) ((await this.SendRequestAsync(MessageTypeProto.GetClientMessagesForAccountRequest, (IMessage) this.MapClientMessageForAccountRequest((GetClientMessagesForAccountRequest) filter))).Message as GetClientMessagesForAccountNotificationProto).ClientMessagesForAccount.Select<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>((Func<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>) (cm => cm.ModelFromProto<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>())).ToList<ATPlatform.Model.Entities.ClientMessage>());
    }

    public int GetClientMessagesCount(GetClientMessagesForAccountRequest request) => this.GetClientMessagesCountAsync(request).ExecuteOnThreadPoolAndGetResult<int>();

    public int GetClientMessagesFilteredCount(GetClientMessagesFilteredForAccountRequest request) => this.GetClientMessagesCountAsync((GetClientMessagesForAccountRequest) request).ExecuteOnThreadPoolAndGetResult<int>();

    public async Task<int> GetClientMessagesCountAsync(
      GetClientMessagesForAccountRequest request)
    {
      return ((await this.SendRequestAsync(MessageTypeProto.GetClientMessagesCountForAccountRequest, (IMessage) this.MapClientMessageForAccountRequest(request))).Message as GetClientMessagesForAccountNotificationProto).ClientMessagesCount;
    }

    public async Task<int> GetClientMessagesFilteredCountAsync(
      GetClientMessagesFilteredForAccountRequest filter)
    {
      return ((await this.SendRequestAsync(MessageTypeProto.GetClientMessagesCountForAccountRequest, (IMessage) this.MapClientMessageFilteredForAccountRequest(filter))).Message as GetClientMessagesForAccountNotificationProto).ClientMessagesCount;
    }

    private GetClientMessagesForAccountRequestProto MapClientMessageForAccountRequest(
      GetClientMessagesForAccountRequest request)
    {
      GetClientMessagesForAccountRequestProto accountRequestProto = new GetClientMessagesForAccountRequestProto();
      accountRequestProto.AccountId = this._account.Id;
      accountRequestProto.PlatformId = this._platformId;
      accountRequestProto.FromDate = request.FromDate.HasValue ? DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(request.FromDate.Value, this._serverTimeZoneInfo) : 0L;
      DateTime? nullable = request.FromDate;
      long num;
      if (!nullable.HasValue)
      {
        num = 0L;
      }
      else
      {
        nullable = request.ToDate;
        num = DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(nullable.Value, this._serverTimeZoneInfo);
      }
      accountRequestProto.ToDate = num;
      accountRequestProto.Skip = request.Skip;
      accountRequestProto.Take = request.Take;
      accountRequestProto.UnreadOnly = request.UnreadOnly;
      accountRequestProto.Language = string.IsNullOrEmpty(this._preferredLanguage) ? ApplicationSettings.PreferredLanguage : this._preferredLanguage;
      return accountRequestProto;
    }

    private GetClientMessagesFilteredForAccountRequestProto MapClientMessageFilteredForAccountRequest(
      GetClientMessagesFilteredForAccountRequest filter)
    {
      GetClientMessagesFilteredForAccountRequestProto accountRequestProto1 = new GetClientMessagesFilteredForAccountRequestProto();
      accountRequestProto1.AccountId = this._account.Id;
      accountRequestProto1.PlatformId = this._platformId;
      accountRequestProto1.FromDate = filter.FromDate.HasValue ? DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(filter.FromDate.Value, this._serverTimeZoneInfo) : 0L;
      DateTime? nullable = filter.FromDate;
      long num;
      if (!nullable.HasValue)
      {
        num = 0L;
      }
      else
      {
        nullable = filter.ToDate;
        num = DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(nullable.Value, this._serverTimeZoneInfo);
      }
      accountRequestProto1.ToDate = num;
      accountRequestProto1.Skip = filter.Skip;
      accountRequestProto1.Take = filter.Take;
      accountRequestProto1.UnreadOnly = filter.UnreadOnly;
      accountRequestProto1.Language = string.IsNullOrEmpty(this._preferredLanguage) ? ApplicationSettings.PreferredLanguage : this._preferredLanguage;
      GetClientMessagesFilteredForAccountRequestProto accountRequestProto2 = accountRequestProto1;
      if (filter.Categories != null)
        accountRequestProto2.Catgories.AddRange((IEnumerable<ClientMessageCategoryProto>) filter.Categories.Select<ClientMessageCategory, ClientMessageCategoryProto>((Func<ClientMessageCategory, ClientMessageCategoryProto>) (c => (ClientMessageCategoryProto) c)).ToList<ClientMessageCategoryProto>());
      if (filter.Importance != null)
        accountRequestProto2.Importance.AddRange((IEnumerable<ClientMessageImportanceProto>) filter.Importance.Select<ClientMessageImportance, ClientMessageImportanceProto>((Func<ClientMessageImportance, ClientMessageImportanceProto>) (i => (ClientMessageImportanceProto) i)).ToList<ClientMessageImportanceProto>());
      if (filter.Tags != null)
        accountRequestProto2.Tags.AddRange((IEnumerable<ClientMessageTagProto>) filter.Tags.Select<KeyValuePair<string, string>, ClientMessageTagProto>((Func<KeyValuePair<string, string>, ClientMessageTagProto>) (t => new ClientMessageTagProto()
        {
          Tag = t.Key,
          Value = t.Value
        })).ToList<ClientMessageTagProto>());
      return accountRequestProto2;
    }

    public void SetClientMessageAccountState(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState)
    {
      this.SetClientMessageAccountStateAsync(clientMessage, clientMessageAccountState).ExecuteOnThreadPoolAndWait();
    }

    public async Task SetClientMessageAccountStateAsync(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState)
    {
      if (clientMessage == null)
        throw new ArgumentNullException(nameof (clientMessage));
      if (clientMessage.Id <= 0)
        throw new ArgumentException(nameof (clientMessage), string.Format("Invalid client message id {0}", (object) clientMessage.Id));
      if (clientMessageAccountState == ClientMessageAccountState.Undefined)
        throw new ArgumentException(nameof (clientMessageAccountState), string.Format("Invalid client message account state {0}", (object) clientMessageAccountState));
      if (await this.SendRequestAsync(MessageTypeProto.ClientMessageReadForAccountRequest, (IMessage) new ClientMessageReadForAccountRequestProto()
      {
        AccountId = this._account.Id,
        ClientMessageId = clientMessage.Id,
        PlatformId = this._platformId,
        State = (ClientMessageAccountStateProto) clientMessageAccountState
      }) == null)
        throw new InvalidCastException();
    }
  }
}
