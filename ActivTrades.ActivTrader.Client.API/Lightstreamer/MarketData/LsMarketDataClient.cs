// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.MarketData.LsMarketDataClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer.Connect;
using ATPlatform.Common.Utils.Logging;
using Lightstreamer.DotNet.Client;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace ActivTrades.ActivTrader.Lightstreamer.MarketData
{
  public class LsMarketDataClient : APIChannel, ILsMarketDataClient, IAPIChannel, IDisposable
  {
    private static readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private static readonly string feedSubscriptionMode = "MERGE";
    private readonly ILsMarketDataConnectionListener _connectionListener = (ILsMarketDataConnectionListener) new LsMarketDataConnectionListener(LsMarketDataClient._logger);
    private readonly ILsMarketDataNotificationListener _notificationListener;
    private readonly IMarketDataSession _marketDataSession;
    private readonly LightstreamerConnectionSettings _connectionSettings;
    private LSClient _lsClientFeed;
    private ConcurrentDictionary<string, IEnumerable<SubscribedTableKey>> _subscriptions = new ConcurrentDictionary<string, IEnumerable<SubscribedTableKey>>();

    public LsMarketDataClient(IMarketDataSession marketDataSession)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      this._marketDataSession = marketDataSession;
      this._connectionSettings = new LightstreamerConnectionSettings()
      {
        Adapter = this._marketDataSession.LsMarketDataAdapter,
        AdapterSet = this._marketDataSession.LsMarketDataAdapterSet,
        Fields = ApplicationSettings.FieldsMarketData,
        isFormatBinary = true,
        Prefix = ApplicationSettings.FeedPrefix,
        NotifyPrefix = ApplicationSettings.FeedPrefix,
        ServerHost = this._marketDataSession.LsMarketDataHost,
        User = this._marketDataSession.SelectedAccountId.ToString(),
        UserKey = this._marketDataSession.Token
      };
      this._notificationListener = (ILsMarketDataNotificationListener) new LsMarketDataNotificationListener(this._connectionSettings, LsMarketDataClient._logger);
      LightstreamerUtilities.ConfigureLightstreamerClientDefaultSettings();
    }

    public event EventHandler<LsTickReceivedEventArgs> TickReceived;

    protected string Token => this._marketDataSession?.Token;

    public HashSet<int> AllowedSymbolGroups { get; } = new HashSet<int>();

    public override void Connect()
    {
      this._connectCancelTokenSource?.Cancel();
      this._connectCancelTokenSource = new CancellationTokenSource();
      LightstreamerUtilities.ValidateConnectionStatus(false, this.IsConnected);
      this._connectionListener.ConnectionStatusChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      bool connectionOpened = false;
      this.AllowedSymbolGroups.Clear();
      AutoResetEvent resetEvent = new AutoResetEvent(false);
      Func<bool> func = null;
      APIChannel._worker.EnqueueTask((Action) (async () =>
      {
        connectionOpened = LightstreamerUtilities.TryConnect(this._connectCancelTokenSource.Token, this._connectionSettings.ServerHost, this._connectionSettings.User, this._connectionSettings.UserKey, this._connectionSettings.Adapter, this._connectionSettings.AdapterSet, ApplicationSettings.ReconnectionMaxAttempts, ApplicationSettings.LightstreamerReconnectInterval, (IConnectionListener) this._connectionListener, out this._lsClientFeed);
        if (!connectionOpened)
          return;
        foreach (int allowedSymbolGroup in LightstreamerUtilities.GetClientApiMarketDataAllowedSymbolGroups(this._connectionSettings.ServerHost))
          this.AllowedSymbolGroups.Add(allowedSymbolGroup);
        await (func ?? (func = (Func<bool>) (() => this.IsConnected || this._connectCancelTokenSource.Token.IsCancellationRequested))).EnsureAsync(this._connectTimeout);
        resetEvent.Set();
      }));
      if (!resetEvent.WaitOne(this._connectTimeout) || !connectionOpened)
        throw new ApplicationException(string.Format("Unable to connect to {0}. Ls host {1}. Account:{2}", (object) LightstreamerUtilities.GetAdapterId(this._connectionSettings.AdapterSet, this._connectionSettings.Adapter), (object) this._connectionSettings.ServerHost, (object) this._marketDataSession.SelectedAccountId));
      this._notificationListener.TickReceived += new EventHandler<LsTickReceivedEventArgs>(this.OnTickReceivedEvent);
      LsMarketDataClient._logger.DebugFormat("{0} connected with token {1}", (object) this._marketDataSession.SelectedAccountId, (object) this._marketDataSession.Token);
    }

    public void Subscribe(string symbol)
    {
      LightstreamerUtilities.ValidateConnectionStatus(true, this.IsConnected);
      if (!this._subscriptions.ContainsKey(symbol))
      {
        ConcurrentDictionary<string, IEnumerable<SubscribedTableKey>> subscriptions = this._subscriptions;
        string key = symbol;
        LSClient lsClientFeed = this._lsClientFeed;
        List<string> stringList = new List<string>();
        stringList.Add(symbol);
        string prefix = this._connectionSettings.Prefix;
        string adapter = this._connectionSettings.Adapter;
        string[] fields = this._connectionSettings.Fields;
        string subscriptionMode = LsMarketDataClient.feedSubscriptionMode;
        int subscriptionMaxAttempts = ApplicationSettings.SubscriptionMaxAttempts;
        TimeSpan attemptsInterval = ApplicationSettings.SubscriptionAttemptsInterval;
        ILsMarketDataNotificationListener notificationListener = this._notificationListener;
        IEnumerable<SubscribedTableKey> subscribedTableKeys = LightstreamerUtilities.Subscribe(false, lsClientFeed, (IEnumerable<string>) stringList, prefix, adapter, (IEnumerable<string>) fields, subscriptionMode, subscriptionMaxAttempts, attemptsInterval, (IHandyTableListener) notificationListener);
        if (!subscriptions.TryAdd(key, subscribedTableKeys))
          throw new ApplicationException("Unable to add ls subscription for " + symbol);
      }
      else
        LsMarketDataClient._logger.WarnFormat("{0} already subscribed. Subscription request unsuccessful.", (object) symbol);
    }

    public void Subscribe(IEnumerable<string> symbols)
    {
      if (symbols == null)
        throw new ArgumentNullException(nameof (symbols));
      foreach (string symbol in symbols)
        this.Subscribe(symbol);
    }

    public void Unsubscribe(string symbol)
    {
      LightstreamerUtilities.ValidateConnectionStatus(true, this.IsConnected);
      IEnumerable<SubscribedTableKey> keys;
      if (!this._subscriptions.TryRemove(symbol, out keys))
        return;
      LightstreamerUtilities.Unsubscribe(this._lsClientFeed, keys, ApplicationSettings.SubscriptionMaxAttempts, ApplicationSettings.SubscriptionAttemptsInterval);
    }

    public void Unsubscribe(IEnumerable<string> symbols)
    {
      if (symbols == null)
        throw new ArgumentNullException(nameof (symbols));
      foreach (string symbol in symbols)
        this.Unsubscribe(symbol);
    }

    public override void Disconnect()
    {
      if (this.IsConnected)
      {
        this._connectCancelTokenSource?.Cancel();
        this._notificationListener.TickReceived -= new EventHandler<LsTickReceivedEventArgs>(this.OnTickReceivedEvent);
        this._connectionListener.ConnectionStatusChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
        this._lsClientFeed.CloseConnection();
        this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
        {
          NewState = APIChannelState.Disconnected,
          OldState = this.State
        });
      }
      LsMarketDataClient._logger.Info((object) "Ls client disconnected.");
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
          this._notificationListener.Dispose();
        }
        catch (Exception ex)
        {
          LsMarketDataClient._logger.Error((object) ex);
        }
      }
      this.disposed = true;
    }

    private void OnTickReceivedEvent(object sender, LsTickReceivedEventArgs e)
    {
      if (LsMarketDataClient._logger.IsDebugEnabled)
        LsMarketDataClient._logger.DebugFormat("{0}", (object) e.Tick);
      EventHandler<LsTickReceivedEventArgs> tickReceived = this.TickReceived;
      if (tickReceived == null)
        return;
      tickReceived((object) this, e);
    }
  }
}
