// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Connection.APIChannel
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.Common.Utils.Threading;
using System;
using System.Threading;

namespace ActivTrades.ActivTrader.Connection
{
  public abstract class APIChannel : IAPIChannel, IDisposable
  {
    private readonly ILogger _logger;
    protected readonly TimeSpan _connectTimeout = ApplicationSettings.ConnectTimeout;
    protected readonly TimeSpan _oneSecondTimeout = TimeSpan.FromSeconds(1.0);
    protected static SingleThreadExecutor _worker = new SingleThreadExecutor();
    protected CancellationTokenSource _connectCancelTokenSource;
    protected bool disposed;

    static APIChannel() => LightstreamerUtilities.ConfigureLightstreamerClientDefaultSettings();

    protected APIChannel(ILogger logger) => this._logger = logger;

    public event EventHandler<APIChannelStateChangedEventArgs> StateChanged;

    public APIChannelState State { get; protected set; }

    public virtual bool IsConnected => this.State == APIChannelState.Connected;

    public abstract void Connect();

    public abstract void Disconnect();

    public abstract void Dispose();

    public virtual void OnStateChanged(object sender, APIChannelStateChangedEventArgs e)
    {
      APIChannelState state = this.State;
      APIChannelState newState = e.NewState;
      if (state == newState)
        return;
      this._logger.InfoFormat("Connection state changed from {0} to {1}", (object) state, (object) newState);
      this.State = newState;
      this.RaiseStatusChangedEvent(new APIChannelStateChangedEventArgs()
      {
        NewState = this.State,
        OldState = state,
        Exception = e.Exception,
        Reason = e.Reason
      });
    }

    protected void RaiseStatusChangedEvent(APIChannelStateChangedEventArgs e)
    {
      EventHandler<APIChannelStateChangedEventArgs> stateChanged = this.StateChanged;
      if (stateChanged == null)
        return;
      stateChanged((object) this, e);
    }

    protected void RiseConnectionTimeoutError(TimeSpan timeout)
    {
      string message = string.Format("Connection failed with status {0}. Timeout:{1}", (object) this.State, (object) timeout);
      this._logger.Error((object) message);
      throw new TimeoutException(message);
    }

    protected void ValidateChannelState()
    {
      if (!this.IsConnected)
        throw new InvalidOperationException(string.Format("API is not {0}", (object) APIChannelState.Connected));
    }
  }
}
