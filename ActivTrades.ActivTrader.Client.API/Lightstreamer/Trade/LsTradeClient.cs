// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.LsTradeClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer.Connect;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.IDL;
using ATPlatform.Messages;
using Lightstreamer.DotNet.Client;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade
{
  public class LsTradeClient : APIChannel, ILsTradeClient, IAPIChannel, IDisposable
  {
    private static readonly string tradingSubscriptionMode = "RAW";
    private static readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly TimeSpan _defaultRequestTimeout = ApplicationSettings.RequestTimeout;
    private readonly ITradingSession _tradingSession;
    private readonly LightstreamerConnectionSettings _connectionSettings;
    private readonly ILsTradeConnectionListener _connectionListener = (ILsTradeConnectionListener) new LsTradeConnectionListener(LsTradeClient._logger);
    private readonly ILsTradeNotificationListener _tradingNotificationListener;
    private readonly List<SubscribedTableKey> _subscribedTableKeys = new List<SubscribedTableKey>();
    private readonly ConcurrentDictionary<int, TaskCompletionSource<ClientNotification>> _requestsMap = new ConcurrentDictionary<int, TaskCompletionSource<ClientNotification>>();
    private readonly ConcurrentDictionary<int, Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>>> _requestsWithManyNotificationsMap = new ConcurrentDictionary<int, Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>>>();
    private LSClient _lsClientTrading;
    private new bool disposed;
    private static readonly string _categoryIdField = "CategoryId";

    public LsTradeClient(ITradingSession tradingSession, string preferredLanguage = null)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      this._tradingSession = tradingSession;
      this._connectionSettings = new LightstreamerConnectionSettings()
      {
        Adapter = this._tradingSession.LsTradingAdapter,
        AdapterSet = this._tradingSession.LsTradingAdapterSet,
        Fields = ApplicationSettings.FieldsTrading,
        isFormatBinary = true,
        Prefix = ApplicationSettings.TradePrefix,
        NotifyPrefix = ApplicationSettings.TradeNotifyPrefix,
        ServerHost = this._tradingSession.LsTradingHost,
        User = this._tradingSession.SelectedAccountId.ToString(),
        UserKey = this._tradingSession.Token,
        PreferredLanguage = string.IsNullOrEmpty(preferredLanguage) ? ApplicationSettings.PreferredLanguage : preferredLanguage,
        NotifiMarketDataEventsPerfix = ApplicationSettings.MarketDataEventsNotifyPrefix,
        NotifiClientMessagesPerfix = ApplicationSettings.ClientMessagesNotifyPrefix,
        NotifiClientMessagesCategories = ApplicationSettings.ClientMessagesNotifyCategories
      };
      this._tradingNotificationListener = (ILsTradeNotificationListener) new LsTradeNotificationListener(this._connectionSettings, LsTradeClient._logger);
      LightstreamerUtilities.ConfigureLightstreamerClientDefaultSettings();
    }

    protected string Token => this._tradingSession.Token;

    public event EventHandler<ClientNotificationEventArgs> ClientNotificationReceived;

    public ClientNotification Request(ClientRequest request)
    {
      Task<ClientNotification> task = this.RequestAsync(request);
      task.Wait();
      return task.Result;
    }

    public async Task<ClientNotification> RequestAsync(ClientRequest request) => await this.RequestAsync(request, this._defaultRequestTimeout);

    public ClientNotification Request(
      ClientRequest request,
      TimeSpan requestTimeout)
    {
      Task<ClientNotification> task = this.RequestAsync(request, this._defaultRequestTimeout);
      task.Wait();
      return task.Result;
    }

    public async Task<ClientNotification> RequestAsync(
      ClientRequest request,
      TimeSpan requestTimeout)
    {
      int requestId = this.GenerateRequestId();
      TaskCompletionSource<ClientNotification> completionSource = new TaskCompletionSource<ClientNotification>();
      if (!this._requestsMap.TryAdd(requestId, completionSource))
      {
        string str = string.Format("Unable to add request {0} to completion sources dictionary", (object) requestId);
        LsTradeClient._logger.ErrorFormat(str, (object) requestId);
        throw new ApplicationException(str);
      }
      LsMessage lsMessage = request.ToLsMessage(requestId);
      this._lsClientTrading.SendMessage(lsMessage.ToJson());
      LsTradeClient._logger.InfoFormat("Request {0} with requestId {1} sent.", (object) lsMessage.Type, (object) lsMessage.LsRequestId);
      if (LsTradeClient._logger.IsDebugEnabled)
        LsTradeClient._logger.Debug((object) lsMessage);
      ClientNotification task;
      try
      {
        if (!completionSource.Task.IsCompleted)
          new CancellationTokenSource(requestTimeout).Token.Register((Action) (() =>
          {
            if (completionSource.Task.IsCompleted)
              return;
            LsTradeClient._logger.DebugFormat("Completion source task for {0} is in state {1}", (object) requestId, (object) completionSource.Task.Status);
            this.SetException<ClientNotification>(completionSource, requestId, (Exception) new TimeoutException(string.Format("No notification for request {0}. Timeout {1}", (object) requestId, (object) requestTimeout.TotalMilliseconds)));
          }));
        task = await completionSource.Task;
      }
      catch (Exception ex)
      {
        LsTradeClient._logger.Error((object) ex);
        if (this._requestsMap.ContainsKey(requestId))
        {
          if (!this._requestsMap.TryRemove(requestId, out TaskCompletionSource<ClientNotification> _))
            LsTradeClient._logger.ErrorFormat("Failed to remove the requested task {0} from the requested tasks map.", (object) requestId);
          else
            LsTradeClient._logger.InfoFormat("Task {0} removed from the requests map.", (object) requestId);
        }
        else
          LsTradeClient._logger.DebugFormat("Task {0} already removed from requested tasks map", (object) requestId);
        throw;
      }
      return task;
    }

    public ClientNotifications RequestMany(
      ClientRequest request,
      int expectedNotifications)
    {
      Task<ClientNotifications> task = this.RequestManyAsync(request, expectedNotifications, this._defaultRequestTimeout);
      task.Wait();
      return task.Result;
    }

    public async Task<ClientNotifications> RequestManyAsync(
      ClientRequest request,
      int expectedNotifications)
    {
      return await this.RequestManyAsync(request, expectedNotifications, this._defaultRequestTimeout);
    }

    public ClientNotifications RequestMany(
      ClientRequest request,
      TimeSpan requestTimeout)
    {
      Task<ClientNotifications> task = this.RequestManyAsync(request, 0, requestTimeout);
      task.Wait();
      return task.Result;
    }

    public async Task<ClientNotifications> RequestManyAsync(
      TimeSpan requestTimeout,
      ClientRequest request)
    {
      return await this.RequestManyAsync(request, 0, requestTimeout);
    }

    public ClientNotifications RequestMany(
      ClientRequest request,
      int expectedNotifications,
      TimeSpan requestTimeout)
    {
      Task<ClientNotifications> task = this.RequestManyAsync(request, expectedNotifications, this._defaultRequestTimeout);
      task.Wait();
      return task.Result;
    }

    public async Task<ClientNotifications> RequestManyAsync(
      ClientRequest request,
      int expectedNotifications,
      TimeSpan requestTimeout)
    {
      int requestId = this.GenerateRequestId();
      int? nullable = expectedNotifications > 0 ? new int?(expectedNotifications) : new int?();
      ClientNotifications cleintNotifications = new ClientNotifications()
      {
        ExpectedNotificationsCount = nullable,
        RequestId = requestId,
        Notifications = (IList<ClientNotification>) new List<ClientNotification>()
      };
      TaskCompletionSource<ClientNotifications> completionSource = new TaskCompletionSource<ClientNotifications>();
      if (!this._requestsWithManyNotificationsMap.TryAdd(requestId, new Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>>(cleintNotifications, completionSource)))
      {
        string str = string.Format("Unable to add request {0} to one request to many notifications dictionary", (object) requestId);
        LsTradeClient._logger.ErrorFormat(str, (object) requestId);
        throw new ApplicationException(str);
      }
      LsMessage lsMessage = request.ToLsMessage(requestId);
      this._lsClientTrading.SendMessage(lsMessage.ToJson());
      LsTradeClient._logger.InfoFormat("Request {0} with requestId {1} sent. Expected notifications {2}", (object) lsMessage.Type, (object) lsMessage.LsRequestId, (object) expectedNotifications);
      if (LsTradeClient._logger.IsDebugEnabled)
        LsTradeClient._logger.Debug((object) lsMessage);
      ClientNotifications task;
      try
      {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(requestTimeout);
        if (nullable.HasValue)
          cancellationTokenSource.Token.Register((Action) (() => this.SetException<ClientNotifications>(completionSource, requestId, (Exception) new TimeoutException(string.Format("No {0} notifications for request {1}. Timeout {2}", (object) cleintNotifications.ExpectedNotificationsCount, (object) requestId, (object) requestTimeout.TotalMilliseconds)))));
        else
          cancellationTokenSource.Token.Register((Action) (() =>
          {
            Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>> tuple;
            if (this._requestsWithManyNotificationsMap.TryRemove(requestId, out tuple))
            {
              LsTradeClient._logger.DebugFormat("{0} notifications based on local request will be processed. RequestId {1}. Timeout {2}.", (object) tuple.Item1.Notifications?.Count, (object) requestId, (object) requestTimeout.TotalMilliseconds);
              completionSource.SetResult(tuple.Item1);
            }
            else
              this.SetException<ClientNotifications>(completionSource, requestId, (Exception) new ApplicationException(string.Format("Task completion source not found for {0}.", (object) requestId)));
          }));
        task = await completionSource.Task;
      }
      catch (Exception ex)
      {
        LsTradeClient._logger.Error((object) ex);
        if (this._requestsWithManyNotificationsMap.ContainsKey(requestId))
        {
          Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>> tuple;
          if (!this._requestsWithManyNotificationsMap.TryRemove(requestId, out tuple))
            LsTradeClient._logger.ErrorFormat("Failed to remove the requested task {0} from one request to many notifications tasks map.", (object) requestId);
          else
            LsTradeClient._logger.InfoFormat("Task {0} removed from one request to many notifications tasks map. . Received notifications {1}", (object) requestId, (object) tuple.Item1.Notifications.Count);
        }
        else
          LsTradeClient._logger.DebugFormat("Task {0} already removed from one request to many notifications tasks map.", (object) requestId);
        throw;
      }
      return task;
    }

    public override void Connect()
    {
      LightstreamerUtilities.ValidateConnectionStatus(false, this.IsConnected);
      this._connectionListener.ConnectionStatusChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      this._connectCancelTokenSource?.Cancel();
      this._connectCancelTokenSource = new CancellationTokenSource();
      int num = LightstreamerUtilities.TryConnect(this._connectCancelTokenSource.Token, this._connectionSettings.ServerHost, this._connectionSettings.User, this.Token, this._connectionSettings.Adapter, this._connectionSettings.AdapterSet, ApplicationSettings.ReconnectionMaxAttempts, ApplicationSettings.LightstreamerReconnectInterval, (IConnectionListener) this._connectionListener, out this._lsClientTrading) ? 1 : 0;
      if (num != 0)
        ((Func<bool>) (() => this.IsConnected || this._connectCancelTokenSource.IsCancellationRequested)).Ensure(this._connectTimeout);
      if (num == 0)
        throw new ApplicationException(string.Format("Unable to connect to {0}. Ls host {1}. Account:{2}", (object) LightstreamerUtilities.GetAdapterId(this._connectionSettings.AdapterSet, this._connectionSettings.Adapter), (object) this._connectionSettings.ServerHost, (object) this._tradingSession.SelectedAccountId));
      this._tradingNotificationListener.TradingNotificationReceived += new EventHandler<LsNotificationEventArgs>(this.OnTradingNotificationListenerReceived);
      this._subscribedTableKeys.Clear();
      this._subscribedTableKeys.AddRange(LightstreamerUtilities.Subscribe(true, this._lsClientTrading, (IEnumerable<string>) new string[1]
      {
        this.Token
      }, this._connectionSettings.Prefix, this._connectionSettings.Adapter, (IEnumerable<string>) this._connectionSettings.Fields, LsTradeClient.tradingSubscriptionMode, ApplicationSettings.SubscriptionMaxAttempts, ApplicationSettings.SubscriptionAttemptsInterval, (IHandyTableListener) this._tradingNotificationListener));
      this._subscribedTableKeys.AddRange(LightstreamerUtilities.Subscribe(true, this._lsClientTrading, (IEnumerable<string>) new string[1]
      {
        this._tradingSession.SelectedAccountId.ToString()
      }, this._connectionSettings.NotifyPrefix, this._connectionSettings.Adapter, (IEnumerable<string>) this._connectionSettings.Fields, LsTradeClient.tradingSubscriptionMode, ApplicationSettings.SubscriptionMaxAttempts, ApplicationSettings.SubscriptionAttemptsInterval, (IHandyTableListener) this._tradingNotificationListener));
      if (this._connectionSettings.NotifiClientMessagesCategories.Any<int>())
      {
        List<string> stringList = new List<string>((IEnumerable<string>) this._connectionSettings.Fields);
        if (!stringList.Contains(LsTradeClient._categoryIdField))
          stringList.Add(LsTradeClient._categoryIdField);
        foreach (int messagesCategory in this._connectionSettings.NotifiClientMessagesCategories)
        {
          string suffix = string.Format("_{0}|{1}", (object) messagesCategory, (object) this._connectionSettings.PreferredLanguage);
          this._subscribedTableKeys.AddRange(LightstreamerUtilities.Subscribe(true, this._lsClientTrading, (IEnumerable<string>) new string[1]
          {
            this._tradingSession.SelectedAccountId.ToString()
          }, this._connectionSettings.NotifiClientMessagesPerfix, this._connectionSettings.Adapter, (IEnumerable<string>) stringList, LsTradeClient.tradingSubscriptionMode, ApplicationSettings.SubscriptionMaxAttempts, ApplicationSettings.SubscriptionAttemptsInterval, (IHandyTableListener) this._tradingNotificationListener, suffix));
        }
      }
      List<string> stringList1 = new List<string>((IEnumerable<string>) this._connectionSettings.Fields);
      string suffix1 = "|" + this._connectionSettings.PreferredLanguage;
      this._subscribedTableKeys.AddRange(LightstreamerUtilities.Subscribe(true, this._lsClientTrading, (IEnumerable<string>) new string[1]
      {
        string.Empty
      }, this._connectionSettings.NotifiMarketDataEventsPerfix, this._connectionSettings.Adapter, (IEnumerable<string>) stringList1, LsTradeClient.tradingSubscriptionMode, ApplicationSettings.SubscriptionMaxAttempts, ApplicationSettings.SubscriptionAttemptsInterval, (IHandyTableListener) this._tradingNotificationListener, suffix1));
      LsTradeClient._logger.DebugFormat("{0} connected with token {1}", (object) this._tradingSession.SelectedAccountId, (object) this._tradingSession.Token);
    }

    public override void Disconnect()
    {
      if (this.IsConnected)
      {
        this._connectCancelTokenSource?.Cancel();
        this._tradingNotificationListener.TradingNotificationReceived -= new EventHandler<LsNotificationEventArgs>(this.OnTradingNotificationListenerReceived);
        this._connectionListener.ConnectionStatusChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
        this._lsClientTrading.CloseConnection();
        this._requestsMap.CancelAllTasks<ClientNotification>(LsTradeClient._logger);
        this._subscribedTableKeys.Clear();
        this._requestsWithManyNotificationsMap.CancelAllTasks<ClientNotifications>(LsTradeClient._logger);
        this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
        {
          NewState = APIChannelState.Disconnected,
          OldState = this.State
        });
      }
      LsTradeClient._logger.Info((object) "Ls client disconnected.");
    }

    public override void Dispose()
    {
      if (this.disposed)
        return;
      if (this.IsConnected)
      {
        try
        {
          this.Disconnect();
          this._tradingNotificationListener.Dispose();
        }
        catch (Exception ex)
        {
          LsTradeClient._logger.Error((object) ex);
        }
      }
      this.disposed = true;
    }

    private int GenerateRequestId() => Guid.NewGuid().ToString("N").GetHashCode();

    private void OnTradingNotificationListenerReceived(object sender, LsNotificationEventArgs e)
    {
      LsMessage message = e.Message;
      ClientNotification notification = message.ParseNotification();
      if (notification == null)
      {
        LsTradeClient._logger.WarnFormat("{0} not supported because the parser not found. Request id {1}", (object) message.Type, (object) message.LsRequestId);
      }
      else
      {
        bool flag = notification.Type == MessageTypeProto.ErrorNotification;
        if (!flag)
        {
          flag = this._requestsMap.ContainsKey(message.LsRequestId) || this._requestsWithManyNotificationsMap.ContainsKey(message.LsRequestId);
          if (this.ClientNotificationReceived != null)
          {
            LsTradeClient._logger.DebugFormat("{0} received. RequestId {1}. Is based on local request:{2}", (object) e.Message.Type, (object) e.Message.LsRequestId, (object) flag);
            EventHandler<ClientNotificationEventArgs> notificationReceived = this.ClientNotificationReceived;
            if (notificationReceived != null)
              notificationReceived((object) this, new ClientNotificationEventArgs()
              {
                Message = notification,
                RequestedByClient = flag
              });
          }
          else
            LsTradeClient._logger.WarnFormat("No event listener {0} found. MessageType:{1}, RequestId:{2}", (object) "ClientNotificationReceived", (object) e.Message.Type, (object) e.Message.LsRequestId);
        }
        if (!flag)
          return;
        if (this.TryProcessSingleNotification(notification))
          LsTradeClient._logger.DebugFormat("Request {0} processed as single notification. RequestId {1};", (object) notification.Type, (object) notification.RequestId);
        else if (this.TryProcessesManyNotifications(notification))
          LsTradeClient._logger.DebugFormat("Request {0} processed as one of many notifications. RequestId {1};", (object) notification.Type, (object) notification.RequestId);
        else
          LsTradeClient._logger.WarnFormat("Failed to process notification {0} based on local request {1}", (object) notification.Type, (object) notification.RequestId);
      }
    }

    private bool TryProcessSingleNotification(ClientNotification clientNotification)
    {
      TaskCompletionSource<ClientNotification> completionSource;
      if (!this._requestsMap.TryRemove(clientNotification.RequestId, out completionSource))
        return false;
      LsTradeClient._logger.DebugFormat("Task {0} found.", (object) clientNotification.RequestId);
      if (clientNotification.Type == MessageTypeProto.ErrorNotification)
      {
        ErrorNotificationProto message = clientNotification.Message as ErrorNotificationProto;
        LsTradeClient._logger.ErrorFormat("{0} based on local request received. RequestId {1}; ErorrCode:{2}", (object) clientNotification.Type, (object) clientNotification.RequestId, (object) message?.ErrorCode);
        completionSource.SetException((Exception) new ErrorNotificationException(((ErrorNotificationProto) clientNotification.Message).ErrorCode));
      }
      else
        completionSource.SetResult(clientNotification);
      return true;
    }

    private bool TryProcessesManyNotifications(ClientNotification clientNotification)
    {
      Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>> tuple;
      if (!this._requestsWithManyNotificationsMap.TryGetValue(clientNotification.RequestId, out tuple))
        return false;
      if (clientNotification.Type == MessageTypeProto.ErrorNotification)
      {
        ErrorNotificationProto message = clientNotification.Message as ErrorNotificationProto;
        LsTradeClient._logger.ErrorFormat("{0} based on local request received. RequestId {1}; ErorrCode:{2}", (object) clientNotification.Type, (object) clientNotification.RequestId, (object) message?.ErrorCode);
        this.SetException<ClientNotifications>(tuple.Item2, clientNotification.RequestId, (Exception) new ErrorNotificationException(((ErrorNotificationProto) clientNotification.Message).ErrorCode));
        if (this._requestsWithManyNotificationsMap.TryRemove(clientNotification.RequestId, out tuple))
          LsTradeClient._logger.DebugFormat("Removed from many notifications map because error received. RequestId {0}", (object) clientNotification.RequestId);
        else
          LsTradeClient._logger.ErrorFormat("Unable to remove task from many notification the map. RequestId {0}", (object) clientNotification.RequestId);
      }
      else
      {
        tuple.Item1.Notifications.Add(clientNotification);
        if (tuple.Item1.IsCompleted)
        {
          if (this._requestsWithManyNotificationsMap.TryRemove(clientNotification.RequestId, out tuple))
          {
            LsTradeClient._logger.DebugFormat("{0} notifications based on local request will be processed. RequestId {1};", (object) tuple.Item1.ExpectedNotificationsCount, (object) clientNotification.RequestId);
            tuple.Item2.SetResult(tuple.Item1);
          }
          else
            LsTradeClient._logger.WarnFormat("Notification {0} associated to {1} was added to the receievd client notifications list. {1} notifications remains. All {1} notifications were receieved;", (object) clientNotification.RequestId, (object) tuple.Item1.ExpectedNotificationsCount);
        }
        else
          LsTradeClient._logger.DebugFormat("One request to many notifications processed {0} of {1}.", (object) tuple.Item1.Notifications.Count, (object) tuple.Item1.ExpectedNotificationsCount);
      }
      return true;
    }

    private void SetException<T>(
      TaskCompletionSource<T> completionsTask,
      int requestId,
      Exception ex)
    {
      completionsTask.SetException(ex);
    }
  }
}
