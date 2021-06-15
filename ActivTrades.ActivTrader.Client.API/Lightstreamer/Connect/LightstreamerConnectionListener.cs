// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Connect.LightstreamerConnectionListener
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Connection.Models;
using ATPlatform.Common.Utils.Logging;
using Lightstreamer.DotNet.Client;
using System;
using System.Reflection;

namespace ActivTrades.ActivTrader.Lightstreamer.Connect
{
  public abstract class LightstreamerConnectionListener : 
    ILightstreamerConnectionListener,
    IConnectionListener
  {
    protected ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public event EventHandler<APIChannelStateChangedEventArgs> ConnectionStatusChanged;

    public APIChannelState ChannelState { get; private set; }

    public void OnActivityWarning(bool warningOn)
    {
    }

    public void OnClose()
    {
      this._logger.Warn((object) "On close");
      this.RaiseStatusChangedEvent(this.ChangeConnectionStatus(APIChannelState.Disconnected));
    }

    public void OnConnectionEstablished() => this._logger.Info((object) "On connection established");

    public void OnDataError(PushServerException e) => throw e;

    public void OnEnd(int cause)
    {
      this._logger.Info((object) "On end.");
      this.RaiseStatusChangedEvent(this.ChangeConnectionStatus(APIChannelState.Disconnected, cause.ToString()));
    }

    public void OnFailure(PushConnException e)
    {
      this._logger.Error((object) e);
      this.RaiseStatusChangedEvent(this.ChangeConnectionStatus(APIChannelState.Error, "On push connection failure. Reason:" + e.Message, (Exception) e));
    }

    public void OnFailure(PushServerException e)
    {
      this._logger.Error((object) e);
      this.RaiseStatusChangedEvent(this.ChangeConnectionStatus(APIChannelState.Error, "On push server failure. Reason:" + e.Message, (Exception) e));
    }

    public void OnNewBytes(long bytes)
    {
    }

    public void OnSessionStarted(bool isPolling)
    {
      this._logger.WarnFormat("On session started. IsPooling:{0}", (object) isPolling);
      this.RaiseStatusChangedEvent(this.ChangeConnectionStatus(APIChannelState.Connected));
    }

    private APIChannelStateChangedEventArgs ChangeConnectionStatus(
      APIChannelState newState,
      string reason = null,
      Exception exception = null)
    {
      this._logger.InfoFormat("status changed from {0} to {1}.", (object) this.ChannelState, (object) newState);
      APIChannelState channelState = this.ChannelState;
      this.ChannelState = newState;
      return new APIChannelStateChangedEventArgs()
      {
        NewState = newState,
        OldState = channelState,
        Reason = reason,
        Exception = exception
      };
    }

    private void RaiseStatusChangedEvent(APIChannelStateChangedEventArgs args)
    {
      EventHandler<APIChannelStateChangedEventArgs> connectionStatusChanged = this.ConnectionStatusChanged;
      if (connectionStatusChanged == null)
        return;
      connectionStatusChanged((object) this, args);
    }
  }
}
