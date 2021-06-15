// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.LightstreamerClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Authentication.Models;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer.MarketData;
using ActivTrades.ActivTrader.Lightstreamer.Trade;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.Common.Utils;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.IDL;
using ATPlatform.IDL.MarketDataEvents;
using Google.Protobuf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Lightstreamer
{
  public class LightstreamerClient : ILightstreamerClient, IAPIChannel, IDisposable
  {
    private readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly TimeSpan _sendRequestTimeoutDefault = ApplicationSettings.RequestTimeout;
    private readonly TimeSpan _configurationDataRequestTimeoutDefault = ApplicationSettings.ConfigurationDataRequestTimeout;
    private readonly AuthenticationResult _authenticationResult;
    private readonly ILsTradeClient _tradingClient;
    private readonly ILsMarketDataClient _feedClient;
    private ServiceStatusProto _serviceStatus;
    private readonly ConcurrentDictionary<string, SymbolProto> _symbolConfigurations = new ConcurrentDictionary<string, SymbolProto>();
    private readonly List<SymbolGroupProto> _symbolGroups = new List<SymbolGroupProto>();
    private readonly ConcurrentDictionary<long, OrderProto> _orders = new ConcurrentDictionary<long, OrderProto>();
    private readonly ConcurrentDictionary<int, ClientMessageProto> _clientMessages = new ConcurrentDictionary<int, ClientMessageProto>();
    private CancellationTokenSource _initializationCancellationTokenSource = new CancellationTokenSource();
    private bool _disposed;

    public LightstreamerClient(
      AuthenticationResult authenticationResult,
      int clientType = 2,
      string preferredLanguage = null)
    {
      this._authenticationResult = authenticationResult;
      this.AccountId = this._authenticationResult.SelectedAccountId;
      this.Token = this._authenticationResult.Token;
      this._feedClient = (ILsMarketDataClient) new LsMarketDataClient((IMarketDataSession) this._authenticationResult);
      this._feedClient.TickReceived += new EventHandler<LsTickReceivedEventArgs>(this.OnPriceUpdateReceived);
      this._tradingClient = (ILsTradeClient) new LsTradeClient((ITradingSession) this._authenticationResult, preferredLanguage);
      this._tradingClient.ClientNotificationReceived += new EventHandler<ClientNotificationEventArgs>(this.OnTradingNotificationReceived);
    }

    public event EventHandler<ClientNotificationEventArgs> TradingNotificationReceived;

    public event EventHandler<ServiceStatusEventArg> ServiceStatusNotificationReceived;

    public event EventHandler<LsTickReceivedEventArgs> PriceUpdated;

    public event EventHandler<APIChannelStateChangedEventArgs> ConnectionStatusChangeNotification;

    public event EventHandler<APIChannelStateChangedEventArgs> StateChanged;

    public event EventHandler<ClientNotificationEventArgs> MarketDataEventNotification;

    public int AccountId { get; }

    public int ReloadTradeSettingsForAccountNotificationRequestId { get; private set; }

    public string Token { get; }

    public APIChannelState State { get; private set; }

    public bool IsConnected => this._tradingClient != null && this._tradingClient.IsConnected && this._feedClient != null && this._feedClient.IsConnected;

    public void Connect() => this.ConnectAsync().ExecuteOnThreadPoolAndWait();

    private void EnsureServiceIsUp()
    {
      int checkMaxAttempts = ApplicationSettings.ServiceStatusCheckMaxAttempts;
      TimeSpan statusCheckInterval = ApplicationSettings.ServiceStatusCheckInterval;
      ServiceStatusProto serviceStatusProto = ServiceStatusProto.UnknownServiceStatus;
      bool flag = true;
      int num = 0;
      while (flag)
      {
        if (this.SendRequest(MessageTypeProto.ServiceStatusRequest, (IMessage) new ServiceStatusRequestProto()
        {
          ServiceId = this._authenticationResult.LsTradingAdapter
        }).Message is ServiceStatusNotificationProto message2)
          serviceStatusProto = message2.ServiceStatus;
        ++num;
        flag = serviceStatusProto != ServiceStatusProto.Up && num < checkMaxAttempts;
        if (flag)
          Thread.Sleep(statusCheckInterval);
      }
      if (num >= checkMaxAttempts || serviceStatusProto != ServiceStatusProto.Up)
        throw new ApplicationException(string.Format("Client initialization failed. The service status should be UP, but the status is {0} after {1} check attempts in interval of {2} milliseconds.", (object) serviceStatusProto, (object) checkMaxAttempts, (object) statusCheckInterval));
    }

    public async Task ConnectAsync()
    {
      this.ValidateConnectionStatus(false);
      this._feedClient.Connect();
      this._tradingClient.Connect();
      await this.InitializeClient();
    }

    public void Disconnect()
    {
      if (this._feedClient.IsConnected)
        this._feedClient.Disconnect();
      if (!this._tradingClient.IsConnected)
        return;
      this._tradingClient.Disconnect();
    }

    public ClientNotification SendRequest(MessageTypeProto type, IMessage request)
    {
      try
      {
        Task<ClientNotification> task = this.SendRequestAsync(type, request);
        task.Wait();
        return task.Result;
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
    }

    public async Task<ClientNotification> SendRequestAsync(
      MessageTypeProto type,
      IMessage request)
    {
      return await this.SendRequestAsync(type, request, this._sendRequestTimeoutDefault);
    }

    public ClientNotification SendRequest(
      MessageTypeProto type,
      IMessage request,
      TimeSpan timeout)
    {
      try
      {
        return this.SendRequestAsync(type, request, timeout).ExecuteOnThreadPoolAndGetResult<ClientNotification>();
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
    }

    public async Task<ClientNotification> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      TimeSpan timeout)
    {
      ClientNotification clientNotification;
      try
      {
        ILsTradeClient tradingClient = this._tradingClient;
        ClientRequest request1 = new ClientRequest();
        request1.Type = type;
        request1.Message = request;
        TimeSpan requestTimeout = timeout;
        clientNotification = await tradingClient.RequestAsync(request1, requestTimeout);
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
      return clientNotification;
    }

    public IEnumerable<ClientNotification> SendRequest(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications)
    {
      try
      {
        return this.SendRequestAsync(type, request, expectedNotifications).ExecuteOnThreadPoolAndGetResult<IEnumerable<ClientNotification>>();
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
    }

    public async Task<IEnumerable<ClientNotification>> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications)
    {
      return await this.SendRequestAsync(type, request, expectedNotifications, this._sendRequestTimeoutDefault);
    }

    public IEnumerable<ClientNotification> SendRequest(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications,
      TimeSpan timeout)
    {
      try
      {
        return this.SendRequestAsync(type, request, expectedNotifications, timeout).ExecuteOnThreadPoolAndGetResult<IEnumerable<ClientNotification>>();
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
    }

    public async Task<IEnumerable<ClientNotification>> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications,
      TimeSpan timeout)
    {
      IEnumerable<ClientNotification> notifications;
      try
      {
        ILsTradeClient tradingClient = this._tradingClient;
        ClientRequest request1 = new ClientRequest();
        request1.Type = type;
        request1.Message = request;
        int expectedNotifications1 = expectedNotifications;
        TimeSpan requestTimeout = timeout;
        notifications = (IEnumerable<ClientNotification>) (await tradingClient.RequestManyAsync(request1, expectedNotifications1, requestTimeout)).Notifications;
      }
      catch (AggregateException ex)
      {
        this._logger.Error((object) ex);
        throw ex.InnerExceptions.First<Exception>();
      }
      return notifications;
    }

    public AccountProto Account { get; private set; }

    public AccountTradeSummaryProto BalanceInfo { get; private set; } = new AccountTradeSummaryProto();

    public GetServerPublicInfoNotificationProto ServerPublicInfo { get; private set; }

    public MarkupSettingsSetProto MarkupSettingsSet { get; private set; }

    public HedgeSettingsSetProto HedgeSettingsSet { get; private set; }

    public IDictionary<long, OrderProto> ClosedOrders => (IDictionary<long, OrderProto>) this._orders.Values.Where<OrderProto>((Func<OrderProto, bool>) (o => o.State == OrderStateProto.Canceled || o.State == OrderStateProto.Closed)).ToDictionary<OrderProto, long>((Func<OrderProto, long>) (k => k.Id));

    public IDictionary<long, OrderProto> OpenedOrders => (IDictionary<long, OrderProto>) this._orders.Values.Where<OrderProto>((Func<OrderProto, bool>) (o => o.State == OrderStateProto.Open)).ToDictionary<OrderProto, long>((Func<OrderProto, long>) (k => k.Id));

    public IDictionary<long, OrderProto> PendingOrders => (IDictionary<long, OrderProto>) this._orders.Values.Where<OrderProto>((Func<OrderProto, bool>) (o => o.State == OrderStateProto.Pending)).ToDictionary<OrderProto, long>((Func<OrderProto, long>) (k => k.Id));

    public IDictionary<int, ClientMessageProto> ClientMessages => (IDictionary<int, ClientMessageProto>) this._clientMessages.Values.ToDictionary<ClientMessageProto, int>((Func<ClientMessageProto, int>) (k => k.Id));

    public IDictionary<string, SymbolProto> SymbolConfigurations => (IDictionary<string, SymbolProto>) this._symbolConfigurations;

    public IEnumerable<SymbolGroupProto> SymbolGroups => (IEnumerable<SymbolGroupProto>) this._symbolGroups;

    public ConcurrentDictionary<string, SymbolTradingSessionsProto> SymbolTradingSessions { get; } = new ConcurrentDictionary<string, SymbolTradingSessionsProto>();

    public ConcurrentDictionary<string, SymbolMarginTiersProto> SymbolMarginTiers { get; } = new ConcurrentDictionary<string, SymbolMarginTiersProto>();

    public NewTickNotificationProto LastNewTickNotification { get; private set; }

    public void SubscribeForPriceUpdates(string symbol)
    {
      this.ValidateConnectionStatus(true);
      this._feedClient.Subscribe(symbol);
    }

    private void processNotification(ClientNotification notification)
    {
      this._logger.DebugFormat("{0} received. RequestId:{1}", (object) notification.Type, (object) notification.RequestId);
      switch (notification.Type)
      {
        case MessageTypeProto.GetServerPublicInfoNotification:
          this.ProcessServerPublicInfoNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.ServiceStatusNotification:
          this.ProcessServiceStatusNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.OpenOrderNotification:
        case MessageTypeProto.ActivateOrderNotification:
        case MessageTypeProto.CloseOrderNotification:
        case MessageTypeProto.CancelOrderNotification:
        case MessageTypeProto.UpdateOrderNotification:
          this.ProcessOrderNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.MarginRequirementCheckNotification:
        case MessageTypeProto.GetOpenedOrdersForAccountNotification:
        case MessageTypeProto.GetClosedOrdersForAccountNotification:
        case MessageTypeProto.GetAccountDetailsForAccountNotification:
        case MessageTypeProto.GetSymbolTradingSessionsForAccountNotification:
          this._logger.DebugFormat("{0} processed. RequestId:{1}", (object) notification.Type, (object) notification.RequestId);
          break;
        case MessageTypeProto.UpdateAccountBalanceNotification:
          this.ProcessAccountBalanceNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.AccountTradeConditionsUpdatedNotification:
          this.ProcessAccountTradeConditionsUpdated(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.ReloadTradeSettingsForAccountNotification:
          this.ProcessReload(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.NewTickNotification:
          this.ProcessNewTickNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.CreateSymbolNotification:
        case MessageTypeProto.UpdateSymbolNotification:
          this.ProcessSymbolNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetSymbolsByTradeSetNotification:
          this.ProcessSymbolsByTradeSet(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetNotification:
          this.ProcessSymbolsMarkupSettings(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.GetSymbolsHedgeSettingsByHedgeSetNotification:
          this.ProcessSymbolsHedgeSettings(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.UpdateAccountNotification:
        case MessageTypeProto.CloseAccountNotification:
        case MessageTypeProto.ReOpenAccountNotification:
          this.ProcessAccountNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.UpdateClientMessageNotification:
        case MessageTypeProto.DeleteClientMessageNotification:
          this.ProcessClientMessageNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        case MessageTypeProto.MarketDataEventNotification:
          this.ProcessMarketDataEventNotification(notification);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
        default:
          this._logger.DebugFormat("{0} not supported by the client! RequestId:{1}", (object) notification.Type, (object) notification.RequestId);
          goto case MessageTypeProto.MarginRequirementCheckNotification;
      }
    }

    private async void ProcessReload(ClientNotification clientNotification = null) => await this.DoReloadAsync(clientNotification);

    public async Task DoReloadAsync(ClientNotification clientNotification = null)
    {
      LightstreamerClient lightstreamerClient = this;
      lightstreamerClient.IsReloadInProgress = false;
      lightstreamerClient._initializationCancellationTokenSource?.Cancel();
      Thread.Sleep(600);
      lightstreamerClient.ReloadTradeSettingsForAccountNotificationRequestId = clientNotification != null ? clientNotification.RequestId : 0;
      lightstreamerClient._initializationCancellationTokenSource = new CancellationTokenSource();
      // ISSUE: reference to a compiler-generated method
      // await Task.Run(new Func<Task>(lightstreamerClient.\u003CDoReloadAsync\u003Eb__104_0), lightstreamerClient._initializationCancellationTokenSource.Token);
      await Task.Run(() => lightstreamerClient.DoReloadAsync(), lightstreamerClient._initializationCancellationTokenSource.Token);
    }

    public bool IsReloadInProgress { get; private set; }

    public async Task ReloadDataAsync()
    {
      this.IsReloadInProgress = true;
      await this.LoadData();
      this.IsReloadInProgress = false;
    }

    public void Reload() => this.DoReloadAsync().ExecuteOnThreadPoolAndWait();

    private void ProcessNewTickNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is NewTickNotificationProto message))
        throw new ArgumentNullException("Message");
      this.LastNewTickNotification = message;
    }

    private void ProcessServerPublicInfoNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is GetServerPublicInfoNotificationProto message))
        throw new ArgumentNullException("Message");
      this.ServerPublicInfo = message;
    }

    private void ProcessServiceStatusNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is ServiceStatusNotificationProto message))
        throw new ArgumentNullException("Message");
      this._serviceStatus = message.ServiceStatus;
      if (this.ServiceStatusNotificationReceived == null)
        return;
      this.ServiceStatusNotificationReceived((object) this, new ServiceStatusEventArg()
      {
        ServiceStatus = this._serviceStatus
      });
    }

    private void ProcessAccountTradeConditionsUpdated(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountTradeConditionsUpdatedNotificationProto message))
        throw new ArgumentNullException("Message");
      this.UpdateBalanceInfo(message.AccountTradeSummary);
    }

    private void ProcessAccountNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is AccountNotificationProto message))
        throw new ArgumentNullException("Message");
      this.Account = message.Account;
    }

    private void ProcessSymbolsMarkupSettings(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is GetSymbolsMarkupSettingsByMarkupSetNotificationProto message))
        throw new ArgumentNullException("Message");
      if (this.MarkupSettingsSet == null)
        this.MarkupSettingsSet = new MarkupSettingsSetProto();
      this.MarkupSettingsSet.Name = message.MarkupSetName;
      this.MarkupSettingsSet.MarkupSettings.Clear();
      foreach (MarkupSettingsProto markupSettingsProto in (IEnumerable<MarkupSettingsProto>) message.SymbolsMarkupSettings.Values)
        this.MarkupSettingsSet.MarkupSettings.Add(markupSettingsProto);
    }

    private void ProcessSymbolsHedgeSettings(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is GetSymbolsHedgeSettingsByHedgeSetNotificationProto message))
        throw new ArgumentNullException("Message");
      if (this.HedgeSettingsSet == null)
        this.HedgeSettingsSet = new HedgeSettingsSetProto();
      this.HedgeSettingsSet.Name = message.HedgeSetName;
      this.HedgeSettingsSet.HedgeSettings.Clear();
      foreach (HedgeSettingsProto hedgeSettingsProto in (IEnumerable<HedgeSettingsProto>) message.SymbolsHedgeSettings.Values)
        this.HedgeSettingsSet.HedgeSettings.Add(hedgeSettingsProto);
    }

    private void ProcessSymbolsByTradeSet(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is GetSymbolsByTradeSetNotificationProto message))
        throw new ArgumentNullException("Message");
      this._symbolGroups.Clear();
      foreach (SymbolGroupProto symbolGroup in message.SymbolGroups)
        this._symbolGroups.Add(symbolGroup);
      this._symbolConfigurations.Clear();
      foreach (SymbolProto symbol in message.Symbols)
        this._symbolConfigurations[symbol.SymbolId] = symbol;
    }

    private void ProcessSymbolNotification(ClientNotification clientNotification)
    {
      SymbolNotificationProto notification = clientNotification.Message as SymbolNotificationProto;
      if (notification == null)
        throw new ArgumentNullException("Message");
      this._symbolConfigurations.AddOrUpdate(notification.Symbol.SymbolId, notification.Symbol, (Func<string, SymbolProto, SymbolProto>) ((k, v) => notification.Symbol));
      if (notification.SymbolTradingSessions != null)
        this.UpdateSymbolTradingSessions((IEnumerable<SymbolTradingSessionsProto>) new List<SymbolTradingSessionsProto>()
        {
          notification.SymbolTradingSessions
        });
      if (notification.SymbolMarginTiers == null)
        return;
      this.UpdateSymbolMarginTiers((IEnumerable<SymbolMarginTiersProto>) new List<SymbolMarginTiersProto>()
      {
        notification.SymbolMarginTiers
      });
    }

    private void ProcessOrderNotification(ClientNotification clientNotification)
    {
      OrderNotificationProto notification = clientNotification.Message as OrderNotificationProto;
      if (notification == null)
        throw new ArgumentNullException("Message");
      this.UpdateBalanceInfo(notification.AccountTradeSummary);
      this._orders.AddOrUpdate(notification.Order.Id, notification.Order, (Func<long, OrderProto, OrderProto>) ((k, v) => notification.Order));
    }

    private void ProcessClientMessageNotification(ClientNotification clientNotification)
    {
      ClientMessageForAccountNotificationProto notification = clientNotification.Message as ClientMessageForAccountNotificationProto;
      if (notification == null)
        throw new ArgumentNullException("Message");
      if (clientNotification.CategoryId <= 0)
        throw new ArgumentNullException("CategoryId");
      if (notification.ClientMessage.State != ClientMessageStateProto.DeletedClientMessage)
        this._clientMessages.AddOrUpdate(notification.ClientMessage.Id, notification.ClientMessage, (Func<int, ClientMessageProto, ClientMessageProto>) ((k, v) => notification.ClientMessage));
      else
        this._clientMessages.TryRemove(notification.ClientMessage.Id, out ClientMessageProto _);
    }

    private void ProcessMarketDataEventNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is MarketDataEventNotificationProto))
        throw new ArgumentNullException("Message");
      EventHandler<ClientNotificationEventArgs> eventNotification = this.MarketDataEventNotification;
      if (eventNotification == null)
        return;
      eventNotification((object) this, new ClientNotificationEventArgs()
      {
        Message = clientNotification
      });
    }

    private void ProcessAccountBalanceNotification(ClientNotification clientNotification)
    {
      if (!(clientNotification.Message is UpdateAccountBalanceNotificationProto message))
        throw new ArgumentNullException("Message");
      this.UpdateBalanceInfo(message.AccountTradeSummary);
    }

    private void UpdateBalanceInfo(AccountTradeSummaryProto accountTradeSummary)
    {
      this._logger.InfoFormat("Trade summary updated {0}", (object) accountTradeSummary);
      this.BalanceInfo = accountTradeSummary;
    }

    private void UpdateOrdersInfo(IEnumerable<OrderProto> orders)
    {
      foreach (OrderProto order1 in orders)
      {
        OrderProto order = order1;
        this._orders.AddOrUpdate(order.Id, order, (Func<long, OrderProto, OrderProto>) ((k, v) => order));
      }
    }

    private void UpdateSymbolTradingSessions(IEnumerable<SymbolTradingSessionsProto> sessions)
    {
      foreach (KeyValuePair<string, SymbolTradingSessionsProto> keyValuePair in sessions.GroupBy<SymbolTradingSessionsProto, string>((Func<SymbolTradingSessionsProto, string>) (sts => sts.SymbolId)).Select<IGrouping<string, SymbolTradingSessionsProto>, KeyValuePair<string, SymbolTradingSessionsProto>>((Func<IGrouping<string, SymbolTradingSessionsProto>, KeyValuePair<string, SymbolTradingSessionsProto>>) (gr => new KeyValuePair<string, SymbolTradingSessionsProto>(gr.Key, gr.Select<SymbolTradingSessionsProto, SymbolTradingSessionsProto>((Func<SymbolTradingSessionsProto, SymbolTradingSessionsProto>) (sts => sts)).Single<SymbolTradingSessionsProto>()))))
      {
        KeyValuePair<string, SymbolTradingSessionsProto> session = keyValuePair;
        this.SymbolTradingSessions.AddOrUpdate(session.Key, session.Value, (Func<string, SymbolTradingSessionsProto, SymbolTradingSessionsProto>) ((k, v) => session.Value));
      }
    }

    private void UpdateSymbolMarginTiers(IEnumerable<SymbolMarginTiersProto> marginTiers)
    {
      foreach (KeyValuePair<string, SymbolMarginTiersProto> keyValuePair in marginTiers.GroupBy<SymbolMarginTiersProto, string>((Func<SymbolMarginTiersProto, string>) (sts => sts.SymbolId)).Select<IGrouping<string, SymbolMarginTiersProto>, KeyValuePair<string, SymbolMarginTiersProto>>((Func<IGrouping<string, SymbolMarginTiersProto>, KeyValuePair<string, SymbolMarginTiersProto>>) (gr => new KeyValuePair<string, SymbolMarginTiersProto>(gr.Key, gr.Select<SymbolMarginTiersProto, SymbolMarginTiersProto>((Func<SymbolMarginTiersProto, SymbolMarginTiersProto>) (sts => sts)).Single<SymbolMarginTiersProto>()))))
      {
        KeyValuePair<string, SymbolMarginTiersProto> marginTier = keyValuePair;
        this.SymbolMarginTiers.AddOrUpdate(marginTier.Key, marginTier.Value, (Func<string, SymbolMarginTiersProto, SymbolMarginTiersProto>) ((k, v) => marginTier.Value));
      }
    }

    private void ValidateConnectionStatus(bool expectingToBeConnected)
    {
      if (!expectingToBeConnected && this.IsConnected)
        throw new InvalidOperationException(string.Format("Lightstreamer client  {0} already connected", (object) this.AccountId));
      if (expectingToBeConnected && !this.IsConnected)
        throw new InvalidOperationException(string.Format("Lightstreamer client  {0} is not connected connected.", (object) this.AccountId));
    }

    private void OnTradingNotificationReceived(object sender, ClientNotificationEventArgs e) => this.processNotification(e.Message);

    private void OnPriceUpdateReceived(object sender, LsTickReceivedEventArgs e)
    {
      this._logger.DebugFormat("{0}", (object) e.Tick);
      EventHandler<LsTickReceivedEventArgs> priceUpdated = this.PriceUpdated;
      if (priceUpdated == null)
        return;
      priceUpdated(sender, e);
    }

    private async Task InitializeClient()
    {
      this.EnsureServiceIsUp();
      this._initializationCancellationTokenSource.Cancel();
      await this.LoadData();
    }

    private async Task LoadData()
    {
      LightstreamerClient lightstreamerClient = this;
      lightstreamerClient.ValidateConnectionStatus(true);
      // ISSUE: reference to a compiler-generated method
      await lightstreamerClient.LoadAccountAsync().ContinueWith(_ => lightstreamerClient.LoadData());
      await lightstreamerClient.LoadOrders();
    }

    private async Task LoadOrders()
    {
      LightstreamerClient lightstreamerClient1 = this;
      LightstreamerClient lightstreamerClient2 = lightstreamerClient1;
      GetOpenedOrdersForAccountRequestProto accountRequestProto1 = new GetOpenedOrdersForAccountRequestProto();
      // ISSUE: explicit non-virtual call
      accountRequestProto1.AccountId = (lightstreamerClient1.AccountId);
      TimeSpan requestTimeoutDefault1 = lightstreamerClient1._configurationDataRequestTimeoutDefault;
      // ISSUE: explicit non-virtual call
      if (!((await (lightstreamerClient2.SendRequestAsync(MessageTypeProto.GetOpenedOrdersForAccountRequest, (IMessage) accountRequestProto1, requestTimeoutDefault1))).Message is GetOpenedOrdersForAccountNotificationProto message1))
        throw new ArgumentNullException("openOrdersNotification");
      lightstreamerClient1.UpdateOrdersInfo((IEnumerable<OrderProto>) message1.Orders);
      LightstreamerClient lightstreamerClient3 = lightstreamerClient1;
      GetClosedOrdersForAccountRequestProto accountRequestProto2 = new GetClosedOrdersForAccountRequestProto();
      // ISSUE: explicit non-virtual call
      accountRequestProto2.AccountId = (lightstreamerClient1.AccountId);
      accountRequestProto2.From = 0L;
      accountRequestProto2.To = DateTimeOperations.ToUnixTimeStampMilliseconds(DateTime.Now.AddDays(1.0));
      TimeSpan requestTimeoutDefault2 = lightstreamerClient1._configurationDataRequestTimeoutDefault;
      // ISSUE: explicit non-virtual call
      if (!((await (lightstreamerClient3.SendRequestAsync(MessageTypeProto.GetClosedOrdersForAccountRequest, (IMessage) accountRequestProto2, requestTimeoutDefault2))).Message is GetClosedOrdersForAccountNotificationProto message2))
        throw new ArgumentNullException("closeOrdersNotification");
      lightstreamerClient1.UpdateOrdersInfo((IEnumerable<OrderProto>) message2.Orders);
    }

    private async Task LoadSessions()
    {
      GetSymbolTradingSessionsForAccountRequestProto accountRequestProto = new GetSymbolTradingSessionsForAccountRequestProto()
      {
        AccountId = this.Account.Id
      };
      accountRequestProto.Symbols.AddRange(this._symbolConfigurations.Where<KeyValuePair<string, SymbolProto>>((Func<KeyValuePair<string, SymbolProto>, bool>) (s => s.Value.SymbolGroupId <= 20)).Select<KeyValuePair<string, SymbolProto>, string>((Func<KeyValuePair<string, SymbolProto>, string>) (sc => sc.Key)));
      accountRequestProto.Symbols.AddRange(this._symbolConfigurations.Where<KeyValuePair<string, SymbolProto>>((Func<KeyValuePair<string, SymbolProto>, bool>) (s => s.Value.SymbolGroupId == 51)).Select<KeyValuePair<string, SymbolProto>, string>((Func<KeyValuePair<string, SymbolProto>, string>) (sc => sc.Key)));
      accountRequestProto.Symbols.AddRange(this._symbolConfigurations.Where<KeyValuePair<string, SymbolProto>>((Func<KeyValuePair<string, SymbolProto>, bool>) (s => s.Value.SymbolGroupId == (int) byte.MaxValue)).Select<KeyValuePair<string, SymbolProto>, string>((Func<KeyValuePair<string, SymbolProto>, string>) (sc => sc.Key)));
      if (!((await this.SendRequestAsync(MessageTypeProto.GetSymbolTradingSessionsForAccountRequest, (IMessage) accountRequestProto, this._configurationDataRequestTimeoutDefault)).Message is GetSymbolTradingSessionsForAccountNotificationProto message))
        throw new ArgumentNullException();
      this.UpdateSymbolTradingSessions((IEnumerable<SymbolTradingSessionsProto>) message.SymbolTradingSessions);
    }

    private async Task LoadSymbols()
    {
      LightstreamerClient lightstreamerClient1 = this;
      LightstreamerClient lightstreamerClient2 = lightstreamerClient1;
      GetSymbolsByTradeSetRequestProto tradeSetRequestProto = new GetSymbolsByTradeSetRequestProto();
      // ISSUE: explicit non-virtual call
      tradeSetRequestProto.TradeSetName = (lightstreamerClient1.Account).TradeSettingsSet;
      TimeSpan requestTimeoutDefault = lightstreamerClient1._configurationDataRequestTimeoutDefault;
      // ISSUE: explicit non-virtual call
      if (!((await (lightstreamerClient2.SendRequestAsync(MessageTypeProto.GetSymbolsByTradeSetRequest, (IMessage) tradeSetRequestProto, requestTimeoutDefault))).Message is GetSymbolsByTradeSetNotificationProto))
        throw new ArgumentNullException();
    }

    private async Task LoadMarkupSettings()
    {
      LightstreamerClient lightstreamerClient = this;
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      ClientNotification clientNotification = await (lightstreamerClient.SendRequestAsync(MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetRequest, (IMessage) new GetSymbolsMarkupSettingsByMarkupSetRequestProto()
      {
        MarkupSetName = (lightstreamerClient.Account).MarkupSettingsSet
      }));
    }

    private async Task LoadHedgeSettings()
    {
      LightstreamerClient lightstreamerClient = this;
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      ClientNotification clientNotification = await (lightstreamerClient.SendRequestAsync(MessageTypeProto.GetSymbolsHedgeSettingsByHedgeSetRequest, (IMessage) new GetSymbolsHedgeSettingsByHedgeSetRequestProto()
      {
        HedgeSetName = (lightstreamerClient.Account).HedgeSettingsSet
      }));
    }

    private async Task LoadAccountAsync()
    {
      LightstreamerClient lightstreamerClient1 = this;
      LightstreamerClient lightstreamerClient2 = lightstreamerClient1;
      GetAccountDetailsForAccountRequestProto accountRequestProto = new GetAccountDetailsForAccountRequestProto();
      // ISSUE: explicit non-virtual call
      accountRequestProto.AccountId = (lightstreamerClient1.AccountId);
      TimeSpan requestTimeoutDefault = lightstreamerClient1._configurationDataRequestTimeoutDefault;
      // ISSUE: explicit non-virtual call
      if (!((await (lightstreamerClient2.SendRequestAsync(MessageTypeProto.GetAccountDetailsForAccountRequest, (IMessage) accountRequestProto, requestTimeoutDefault))).Message is AccountNotificationProto message))
        throw new ArgumentNullException();
      lightstreamerClient1.Account = message.Account;
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      lightstreamerClient1.UpdateBalanceInfo(new AccountTradeSummaryProto()
      {
        Id = (long) (lightstreamerClient1.Account).Id,
        Balance = (lightstreamerClient1.Account).Balance,
        Equity = (lightstreamerClient1.Account).Equity,
        Margin = (lightstreamerClient1.Account).Margin
      });
    }

    public void Dispose()
    {
      if (this._disposed)
        return;
      try
      {
        this._tradingClient?.Dispose();
        this._feedClient?.Dispose();
        this._orders.Clear();
        this.Account = (AccountProto) null;
        this.BalanceInfo = (AccountTradeSummaryProto) null;
        this.MarkupSettingsSet = (MarkupSettingsSetProto) null;
        this.ServerPublicInfo = (GetServerPublicInfoNotificationProto) null;
        this.SymbolTradingSessions.Clear();
      }
      finally
      {
        this._disposed = true;
      }
    }
  }
}
