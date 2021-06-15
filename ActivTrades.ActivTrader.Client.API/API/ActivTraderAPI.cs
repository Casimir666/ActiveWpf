// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.ActivTraderAPI
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.API.MarketData;
using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.API.Trade;
using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Authentication.Models;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.Common.Utils.Threading;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Enums.ClientMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.API
{
  public sealed class ActivTraderAPI : 
    APIChannelWithReconnect,
    IActivTraderAPI,
    ITradeChannel,
    IAPIChannel,
    IDisposable,
    IMarketDataChannel,
    IMarketDataSubscriptions
  {
    private static readonly string _apiVersion = typeof (ActivTraderAPI).Assembly.GetName().Version.ToString();
    private readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly TimeSpan _apiConnectTimeout = ApplicationSettings.ApiConnectTimeout;
    private readonly HashSet<string> _marketDataSubscriptions = new HashSet<string>();
    private readonly string _platform;
    private readonly string _password;
    private readonly string _email;
    private readonly int _accountId;
    private readonly string _preferredLanguage;
    private readonly IPlatformAuthentication _platformAuthentication;
    private readonly ITaskExecutor _marketDataEventsWorker;
    private readonly ITaskExecutor _tradingEventsWorker;
    private ITradeClient _tradeChannel;
    private MarketDataClient _feedChannel;
    private HashSet<int> _marketDataAuthorizedSymbolGroups = new HashSet<int>();
    private bool forceDisconnect;

    public ActivTraderAPI(
      string host,
      string email,
      string password,
      int accountId,
      string preferredLanguage = null)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      if (string.IsNullOrEmpty(host))
        throw new ArgumentNullException(nameof (host));
      if (string.IsNullOrEmpty(email))
        throw new ArgumentNullException(nameof (email));
      if (accountId <= 0)
        throw new ArgumentException(string.Format("{0} {1} is invalid.", (object) nameof (accountId), (object) accountId));
      this._email = email;
      this._accountId = accountId;
      this._password = password;
      this._platform = (string) null;
      this._preferredLanguage = preferredLanguage;
      this._platformAuthentication = (IPlatformAuthentication) new ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication(host);
      ActivTraderAPI.InitializeAPIWorkers(accountId, out this._marketDataEventsWorker, out this._tradingEventsWorker);
    }

    public ActivTraderAPI(
      string host,
      string platform,
      int accountId,
      string password,
      string preferredLanguage = null)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      if (string.IsNullOrEmpty(host))
        throw new ArgumentNullException(nameof (host));
      if (string.IsNullOrEmpty(platform))
        throw new ArgumentNullException(nameof (platform));
      if (accountId <= 0)
        throw new ArgumentException(string.Format("{0} {1} is invalid.", (object) nameof (accountId), (object) accountId));
      this._platform = platform;
      this._accountId = accountId;
      this._password = password;
      this._email = (string) null;
      this._preferredLanguage = preferredLanguage;
      this._platformAuthentication = (IPlatformAuthentication) new ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication(host);
      ActivTraderAPI.InitializeAPIWorkers(accountId, out this._marketDataEventsWorker, out this._tradingEventsWorker);
    }

    internal ActivTraderAPI(
      string email,
      string password,
      int accountId,
      IPlatformAuthentication platformAuthentication,
      string preferredLanguage = null)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      if (string.IsNullOrEmpty(email))
        throw new ArgumentNullException(nameof (email));
      if (accountId <= 0)
        throw new ArgumentException(string.Format("{0} {1} is invalid.", (object) nameof (accountId), (object) accountId));
      this._platform = (string) null;
      this._accountId = accountId;
      this._password = password;
      this._email = email;
      this._preferredLanguage = preferredLanguage;
      this._platformAuthentication = platformAuthentication;
      ActivTraderAPI.InitializeAPIWorkers(accountId, out this._marketDataEventsWorker, out this._tradingEventsWorker);
    }

    public event EventHandler<OrderNotificationEventArgs> OrderNotification;

    public event EventHandler<MarketDataUpdateEventArgs> MarketDataUpdate;

    public event EventHandler<ClientMessageNotificationEventArgs> ClientMessageNotification;

    public event EventHandler<MarketDataEventNotificationEventArgs> MarketDataEventNotification;

    public TimeZoneInfo GetTimeZoneInfo()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetTimeZoneInfo();
    }

    public ATPlatform.Model.Entities.Account GetAccount()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetAccount();
    }

    public TradeSummary GetTradeSummary()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetTradeSummary();
    }

    public IReadOnlyCollection<SymbolGroup> GetSymbolGroups()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetSymbolGroups();
    }

    public SymbolGroup GetSymbolGroup(int id)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetSymbolGroup(id);
    }

    public IReadOnlyCollection<Symbol> GetSymbols()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetSymbols();
    }

    public Symbol GetSymbol(string symbol)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetSymbol(symbol);
    }

    public bool IsInSessionAndNotExpired(string symbol)
    {
      this.ValidateChannelState();
      return this._tradeChannel.IsInSessionAndNotExpired(symbol);
    }

    public IReadOnlyCollection<TradingSession> GetSymbolTradingSessions(
      string symbol)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetSymbolTradingSessions(symbol);
    }

    public IReadOnlyCollection<Order> GetOrders()
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetOrders();
    }

    public IReadOnlyCollection<Order> GetOrders(string symbol)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetOrders(symbol);
    }

    public Order GetOrder(string symbol, long orderId)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetOrder(symbol, orderId);
    }

    public ClosedOrdersAndBalanceOperations GetClosedOrdersAndBalanceOperations(
      DateTime fromDateTime,
      DateTime toDateTime)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetClosedOrdersAndBalanceOperations(fromDateTime, toDateTime);
    }

    public async Task<ClosedOrdersAndBalanceOperations> GetClosedOrdersAndBalanceOperationsAsync(
      DateTime fromDateTime,
      DateTime toDateTime)
    {
      ActivTraderAPI activTraderApi = this;
      activTraderApi.ValidateChannelState();
      return await activTraderApi._tradeChannel.GetClosedOrdersAndBalanceOperationsAsync(fromDateTime, toDateTime);
    }

    public double RequiredMarginGet(OrderRequest orderRequest)
    {
      this.ValidateChannelState();
      return this._tradeChannel.RequiredMarginGet(orderRequest);
    }

    public Task<double> RequiredMarginGetAsync(OrderRequest orderRequest)
    {
      this.ValidateChannelState();
      return this._tradeChannel.RequiredMarginGetAsync(orderRequest);
    }

    public IReadOnlyCollection<Bar> GetBars(
      string symbol,
      HistoryQuotesPeriod period)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetBars(symbol, period);
    }

    public async Task<IReadOnlyCollection<Bar>> GetBarsAsync(
      string symbol,
      HistoryQuotesPeriod period)
    {
      ActivTraderAPI activTraderApi = this;
      activTraderApi.ValidateChannelState();
      return await activTraderApi._tradeChannel.GetBarsAsync(symbol, period);
    }

    public IList<string> GetCurrentSubsciptions() => this._feedChannel?.GetCurrentSubsciptions();

    public void Subscribe(string symbol)
    {
      this.ValidateMarketDataSubscription(symbol);
      this._feedChannel?.Subscribe(symbol);
      this._marketDataSubscriptions.Add(symbol);
    }

    public void Subscribe(IList<string> symbols)
    {
      foreach (string symbol in (IEnumerable<string>) symbols)
        this.ValidateMarketDataSubscription(symbol);
      if (this._feedChannel == null)
        return;
      this._feedChannel.Subscribe(symbols);
      foreach (string symbol in (IEnumerable<string>) symbols)
        this._marketDataSubscriptions.Add(symbol);
    }

    public void Unsubscribe(string symbol)
    {
      this._marketDataSubscriptions.Remove(symbol);
      this._feedChannel?.Unsubscribe(symbol);
    }

    public void Unsubscribe(IList<string> symbols)
    {
      foreach (string symbol in (IEnumerable<string>) symbols)
        this._marketDataSubscriptions.Remove(symbol);
      this._feedChannel?.Unsubscribe(symbols);
    }

    public void SubscribeAll()
    {
      try
      {
        List<string> list = this.GetSymbols().Select<Symbol, string>((Func<Symbol, string>) (s => s.Id)).Where<string>((Func<string, bool>) (s => this.SubscriptionAuthorized(s))).ToList<string>();
        this._logger.DebugFormat("Starting to subscribe {0} symbols", (object) list.Count);
        this.Subscribe((IList<string>) list);
        this._logger.WarnFormat("Subscription for {0} symbols done.", (object) list.Count);
      }
      catch (Exception ex)
      {
        this._logger.Error((object) ex);
      }
    }

    public void UnsubscribeAll()
    {
      try
      {
        this.Unsubscribe((IList<string>) this.GetSymbols().Select<Symbol, string>((Func<Symbol, string>) (s => s.Id)).Where<string>((Func<string, bool>) (s => this.SubscriptionAuthorized(s))).ToList<string>());
      }
      catch (Exception ex)
      {
        this._logger.Error((object) ex);
      }
    }

    protected override void Load()
    {
      this.Disconnect();
      this.Connect();
    }

    private void ValidateMarketDataSubscription(string symbol)
    {
      if (!this.SubscriptionAuthorized(symbol))
        throw new InvalidCredentialException("You are not authorized to subscribe for " + symbol + " market data.");
    }

    private bool SubscriptionAuthorized(string symbol) => !this._marketDataAuthorizedSymbolGroups.Any<int>() || (this._tradeChannel.GetAccount().IsAPIConnectionAllowed || this._marketDataAuthorizedSymbolGroups.Contains(this._tradeChannel.GetSymbol(symbol).GroupId));

    public override void Connect() => this.ConnectAsync().ExecuteOnThreadPoolAndWait();

    public async Task ConnectAsync()
    {
      ActivTraderAPI activTraderApi = this;
      if (activTraderApi.IsConnected)
        throw new InvalidOperationException(string.Format("{0} is already connected.", (object) activTraderApi._accountId));
      activTraderApi._logger.WarnFormat("Connecting {0} with version {1}.", (object) activTraderApi.GetType().FullName, (object) ActivTraderAPI._apiVersion);
      try
      {
        activTraderApi._connectCancelTokenSource?.Cancel();
        activTraderApi._connectCancelTokenSource = new CancellationTokenSource();
        activTraderApi.forceDisconnect = false;
        bool invalidCredentials = false;
        AuthenticationResult authenticationResult = (AuthenticationResult) null;
        if (string.IsNullOrEmpty(activTraderApi._platform) && !string.IsNullOrEmpty(activTraderApi._email))
          authenticationResult = await activTraderApi._platformAuthentication.LoginAsync(activTraderApi._email, activTraderApi._password, activTraderApi._accountId);
        else if (string.IsNullOrEmpty(activTraderApi._email) && !string.IsNullOrEmpty(activTraderApi._platform))
          authenticationResult = await activTraderApi._platformAuthentication.LoginAsync(activTraderApi._accountId, activTraderApi._password, activTraderApi._platform);
        else
          invalidCredentials = true;
        if (authenticationResult == null)
          invalidCredentials = true;
        if (invalidCredentials)
          throw new InvalidCredentialException();
        activTraderApi._feedChannel = new MarketDataClient((IMarketDataSession) authenticationResult);
        activTraderApi._feedChannel.StateChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) activTraderApi).OnStateChanged);
        activTraderApi._feedChannel.MarketDataUpdate += new EventHandler<MarketDataUpdateEventArgs>(activTraderApi.OnFeedChannelUpdateReceived);
        activTraderApi._feedChannel.Connect();
        foreach (int allowedSymbolGroup in activTraderApi._feedChannel.GetAllowedSymbolGroups())
          activTraderApi._marketDataAuthorizedSymbolGroups.Add(allowedSymbolGroup);
        activTraderApi._tradeChannel = (ITradeClient) new TradeClient((ITradingSession) authenticationResult);
        activTraderApi._tradeChannel.StateChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) activTraderApi).OnStateChanged);
        await activTraderApi._tradeChannel.ConnectAsync();
        activTraderApi._tradeChannel.OrderNotification += new EventHandler<OrderNotificationEventArgs>(activTraderApi.OnOrderNotificationReceived);
        activTraderApi._tradeChannel.ClientMessageNotification += new EventHandler<ClientMessageNotificationEventArgs>(activTraderApi.OnClientMessageNotificationReceived);
        activTraderApi._tradeChannel.MarketDataEventNotification += new EventHandler<MarketDataEventNotificationEventArgs>(activTraderApi.OnMarketDataEventNotificationReceived);
        // ISSUE: reference to a compiler-generated method
        // new Func<bool>(activTraderApi.\u003CConnectAsync\u003Eb__60_0).Ensure(activTraderApi._apiConnectTimeout);        TODO : check this!
      }
      catch (Exception ex)
      {
        activTraderApi._logger.Error((object) ex);
      }
      if (!activTraderApi.IsConnected)
        throw new ApplicationException("API failed to connect");
      activTraderApi.Resubscribe();
    }

    public override void Disconnect()
    {
      this._connectCancelTokenSource?.Cancel();
      this.forceDisconnect = true;
      this._marketDataAuthorizedSymbolGroups.Clear();
      if (this._tradeChannel != null)
      {
        this._tradeChannel.OrderNotification -= new EventHandler<OrderNotificationEventArgs>(this.OnOrderNotificationReceived);
        this._tradeChannel.ClientMessageNotification -= new EventHandler<ClientMessageNotificationEventArgs>(this.OnClientMessageNotificationReceived);
        this._tradeChannel.MarketDataEventNotification -= new EventHandler<MarketDataEventNotificationEventArgs>(this.OnMarketDataEventNotificationReceived);
        this._tradeChannel.Disconnect();
        this._tradeChannel.StateChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      }
      if (this._feedChannel != null)
      {
        this._feedChannel.MarketDataUpdate -= new EventHandler<MarketDataUpdateEventArgs>(this.OnFeedChannelUpdateReceived);
        this._feedChannel.Disconnect();
        this._feedChannel.StateChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      }
      this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
      {
        NewState = APIChannelState.Disconnected,
        OldState = this.State
      });
    }

    public override void Dispose()
    {
      if (this.disposed)
        return;
      try
      {
        if (this.IsConnected)
          this.Disconnect();
        this._reconnectCancelationSource?.Cancel();
        this._marketDataEventsWorker?.Dispose();
        this._tradeChannel?.Dispose();
        this._tradeChannel = (ITradeClient) null;
        this._feedChannel?.Dispose();
        this._feedChannel = (MarketDataClient) null;
      }
      catch (Exception ex)
      {
        this._logger.Error((object) ex);
      }
      finally
      {
        this.disposed = true;
      }
    }

    public Order OpenOrder(OrderRequest orderRequest) => this._tradeChannel.OpenOrder(orderRequest);

    public async Task<Order> OpenOrderAsync(OrderRequest orderRequest) => await this._tradeChannel.OpenOrderAsync(orderRequest);

    public Order ModifyOrder(OrderRequest orderRequest) => this._tradeChannel.ModifyOrder(orderRequest);

    public async Task<Order> ModifyOrderAsync(OrderRequest orderRequest) => await this._tradeChannel.ModifyOrderAsync(orderRequest);

    public Order CloseMarketOrder(OrderRequest orderRequest) => this._tradeChannel.CloseMarketOrder(orderRequest);

    public async Task<Order> CloseMarketOrderAsync(OrderRequest orderRequest) => await this._tradeChannel.CloseMarketOrderAsync(orderRequest);

    public Order CancelPendingOrder(OrderRequest orderRequest) => this._tradeChannel.CancelPendingOrder(orderRequest);

    public async Task<Order> CancelPendingOrderAsync(OrderRequest orderRequest) => await this._tradeChannel.CancelPendingOrderAsync(orderRequest);

    public IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage> GetClientMessages(
      GetClientMessagesForAccountRequest request)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetClientMessages(request);
    }

    public Task<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>> GetClientMessagesAsync(
      GetClientMessagesForAccountRequest request)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetClientMessagesAsync(request);
    }

    public int GetClientMessagesCount(GetClientMessagesForAccountRequest request)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetClientMessagesCount(request);
    }

    public Task<int> GetClientMessagesCountAsync(GetClientMessagesForAccountRequest request)
    {
      this.ValidateChannelState();
      return this._tradeChannel.GetClientMessagesCountAsync(request);
    }

    public void SetClientMessageAccountState(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState)
    {
      this.ValidateChannelState();
      this._tradeChannel.SetClientMessageAccountState(clientMessage, clientMessageAccountState);
    }

    public async Task SetClientMessageAccountStateAsync(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState)
    {
      ActivTraderAPI activTraderApi = this;
      activTraderApi.ValidateChannelState();
      await activTraderApi._tradeChannel.SetClientMessageAccountStateAsync(clientMessage, clientMessageAccountState);
    }

    public override void OnStateChanged(object sender, APIChannelStateChangedEventArgs e)
    {
      bool isConnected = this.IsConnected;
      APIChannelState currentState = this.State;
      APIChannelState newState = this._feedChannel == null || this._tradeChannel == null ? APIChannelState.Disconnected : (!this._feedChannel.IsConnected || !this._tradeChannel.IsConnected ? (this._tradeChannel.State < this._feedChannel.State ? this._tradeChannel.State : this._feedChannel.State) : APIChannelState.Connected);
      if (currentState == newState)
        return;
      this._logger.InfoFormat("API state changed from {0} to {1}", (object) currentState, (object) newState);
      this.State = newState;
      this._tradingEventsWorker.EnqueueTask((Action) (() => this.RaiseStatusChangedEvent(new APIChannelStateChangedEventArgs()
      {
        NewState = newState,
        OldState = currentState
      })));
      if (isConnected == this.IsConnected || this.IsConnected)
        return;
      if (e.Reason == ApplicationSettings.LsSessionKilledCode)
        this._logger.ErrorFormat("Session killed.");
      if (this.forceDisconnect)
        return;
      this._logger.WarnFormat("Will try to reconnect.");
      this.Reconnect();
    }

    private static void InitializeAPIWorkers(
      int accountId,
      out ITaskExecutor marketDataEvents,
      out ITaskExecutor tradingEvents)
    {
      marketDataEvents = (ITaskExecutor) new SingleThreadExecutor(string.Format("APIMarketDataEvents-{0}", (object) accountId));
      tradingEvents = (ITaskExecutor) new SingleThreadExecutor(string.Format("APITradingEvents-{0}", (object) accountId));
    }

    private void OnFeedChannelUpdateReceived(object sender, MarketDataUpdateEventArgs e)
    {
      if (this._logger.IsDebugEnabled)
        this._logger.DebugFormat("New {0}", (object) e.Tick);
      double maxEntrySize;
      if (this._tradeChannel == null || !this._tradeChannel.TryProcessTick(e.Tick, out maxEntrySize))
        return;
      this._marketDataEventsWorker?.EnqueueTask((Action) (() =>
      {
        EventHandler<MarketDataUpdateEventArgs> marketDataUpdate = this.MarketDataUpdate;
        if (marketDataUpdate == null)
          return;
        marketDataUpdate((object) this, new MarketDataUpdateEventArgs()
        {
          Tick = e.Tick,
          EntrySize = maxEntrySize
        });
      }));
    }

    private void OnOrderNotificationReceived(object sender, OrderNotificationEventArgs e) => this._tradingEventsWorker.EnqueueTask((Action) (() =>
    {
      EventHandler<OrderNotificationEventArgs> orderNotification = this.OrderNotification;
      if (orderNotification == null)
        return;
      orderNotification((object) this, new OrderNotificationEventArgs()
      {
        Order = e.Order.Clone(),
        RequestedByClient = e.RequestedByClient
      });
    }));

    private void OnClientMessageNotificationReceived(
      object sender,
      ClientMessageNotificationEventArgs e)
    {
      this._tradingEventsWorker.EnqueueTask((Action) (() =>
      {
        EventHandler<ClientMessageNotificationEventArgs> messageNotification = this.ClientMessageNotification;
        if (messageNotification == null)
          return;
        messageNotification((object) this, new ClientMessageNotificationEventArgs()
        {
          ClientMessage = e.ClientMessage.Clone()
        });
      }));
    }

    private void OnMarketDataEventNotificationReceived(
      object sender,
      MarketDataEventNotificationEventArgs e)
    {
      this._tradingEventsWorker.EnqueueTask((Action) (() =>
      {
        EventHandler<MarketDataEventNotificationEventArgs> eventNotification = this.MarketDataEventNotification;
        if (eventNotification == null)
          return;
        eventNotification((object) this, new MarketDataEventNotificationEventArgs()
        {
          MarketDataEvent = e.MarketDataEvent.Clone()
        });
      }));
    }

    private void Resubscribe() => this._marketDataSubscriptions.ToList<string>().ForEach((Action<string>) (s =>
    {
      try
      {
        this._logger.DebugFormat("Subscribing for {0}", (object) s);
        this.Subscribe(s);
        this._logger.DebugFormat("Subscribed for {0}", (object) s);
      }
      catch (Exception ex)
      {
        this._logger.Error((object) ex);
      }
    }));
  }
}
