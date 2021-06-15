// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.MarketData.MarketDataClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Authentication;
using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer.MarketData;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;

namespace ActivTrades.ActivTrader.API.MarketData
{
  public class MarketDataClient : 
    APIChannel,
    IMarketDataSubscriptions,
    IMarketDataChannel,
    IAPIChannel,
    IDisposable
  {
    private readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly HashSet<string> _subscriptions = new HashSet<string>();
    private readonly IMarketDataSession _session;
    private ILsMarketDataClient _marketData;

    public MarketDataClient(IMarketDataSession marketDataSession)
      : base(LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType))
    {
      this._session = marketDataSession ?? throw new InvalidCredentialException();
    }

    public event EventHandler<MarketDataUpdateEventArgs> MarketDataUpdate;

    public IList<string> GetCurrentSubsciptions() => (IList<string>) this._subscriptions.ToList<string>();

    public void Subscribe(string symbol)
    {
      this._marketData.Subscribe(symbol);
      this._subscriptions.Add(symbol);
    }

    public void Subscribe(IList<string> symbols)
    {
      List<string> list = symbols.ToList<string>();
      this._marketData.Subscribe((IEnumerable<string>) list);
      foreach (string str in list)
        this._subscriptions.Add(str);
    }

    public void Unsubscribe(string symbol)
    {
      this._marketData.Unsubscribe(symbol);
      this._subscriptions.Remove(symbol);
    }

    public void Unsubscribe(IList<string> symbols)
    {
      List<string> list = symbols.ToList<string>();
      this._marketData.Unsubscribe((IEnumerable<string>) list);
      foreach (string str in list)
        this._subscriptions.Remove(str);
    }

    public void UnsubscribeAll() => this.Unsubscribe((IList<string>) this._subscriptions.ToList<string>());

    public override void Connect()
    {
      if (this.IsConnected)
        throw new InvalidOperationException(string.Format("Client {0} is already connected.", (object) this._session.SelectedAccountId));
      this.Disconnect();
      this._marketData = (ILsMarketDataClient) new LsMarketDataClient(this._session);
      this._marketData.StateChanged += new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      this._marketData.TickReceived += new EventHandler<LsTickReceivedEventArgs>(this.OnMarketDataUpdateReceived);
      this._marketData.Connect();
      ((Func<bool>) (() => this.IsConnected)).Ensure(ApplicationSettings.ConfigurationDataRequestTimeout);
      this._logger.WarnFormat("Market data client {0} connected", (object) this._session.SelectedAccountId);
    }

    public HashSet<int> GetAllowedSymbolGroups() => new HashSet<int>((IEnumerable<int>) this._marketData.AllowedSymbolGroups);

    public override void Disconnect()
    {
      this.DisposeLsClients();
      this._logger.WarnFormat("Market data client {0} disconnected", (object) this._session.SelectedAccountId);
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
        if (!this.IsConnected)
          return;
        this.Disconnect();
        this.DisposeLsClients();
      }
      finally
      {
        this.disposed = true;
      }
    }

    private void DisposeLsClients()
    {
      if (this._marketData == null)
        return;
      this._marketData.TickReceived -= new EventHandler<LsTickReceivedEventArgs>(this.OnMarketDataUpdateReceived);
      this._marketData.StateChanged -= new EventHandler<APIChannelStateChangedEventArgs>(((APIChannel) this).OnStateChanged);
      this._marketData?.Disconnect();
      this._marketData?.Dispose();
      this._marketData = (ILsMarketDataClient) null;
    }

    protected virtual void OnMarketDataUpdateReceived(object sender, LsTickReceivedEventArgs e)
    {
      if (this._logger.IsDebugEnabled)
        this._logger.DebugFormat("{0}", (object) e.Tick.ToString());
      Tick tick = e.Tick.ModelFromProto<TickProto, Tick>();
      EventHandler<MarketDataUpdateEventArgs> marketDataUpdate = this.MarketDataUpdate;
      if (marketDataUpdate == null)
        return;
      marketDataUpdate((object) this, new MarketDataUpdateEventArgs()
      {
        Tick = tick
      });
    }
  }
}
