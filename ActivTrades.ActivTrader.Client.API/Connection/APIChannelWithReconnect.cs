// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Connection.APIChannelWithReconnect
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Connection.Models;
using ATPlatform.Common.Utils.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Connection
{
  public abstract class APIChannelWithReconnect : APIChannel
  {
    private readonly ILogger _logger;
    private readonly TimeSpan _retryInterval = ApplicationSettings.ApiConnectRetryInterval;
    protected CancellationTokenSource _reconnectCancelationSource = new CancellationTokenSource();

    protected APIChannelWithReconnect(ILogger logger)
      : base(logger)
    {
      this._logger = logger;
      this._logger.InfoFormat("Retry reconnect interval {0} seconds", (object) this._retryInterval.TotalSeconds);
    }

    protected abstract void Load();

    protected virtual void ReconnectionListener(object sender, APIChannelStateChangedEventArgs e)
    {
      if (e.OldState != APIChannelState.Connected)
        return;
      this.Reconnect();
    }

    protected void Reconnect()
    {
      if (this.disposed)
      {
        this._reconnectCancelationSource?.Cancel();
      }
      else
      {
        this.OnStateChanged((object) this, new APIChannelStateChangedEventArgs()
        {
          OldState = this.State,
          NewState = APIChannelState.Connecting
        });
        this._reconnectCancelationSource?.Cancel();
        this._reconnectCancelationSource = new CancellationTokenSource();
        Task.Run((Action) (() =>
        {
          while (!this.IsConnected)
          {
            if (!this._reconnectCancelationSource.Token.IsCancellationRequested)
            {
              try
              {
                this._logger.WarnFormat("Reconnecting ...");
                this.Load();
                this._logger.WarnFormat("Successfully reconnected.");
                break;
              }
              catch (AggregateException ex)
              {
                foreach (object innerException in ex.InnerExceptions)
                  this._logger.Error(innerException);
              }
              catch (Exception ex)
              {
                this._logger.Error((object) ex);
              }
              Task.Delay(this._retryInterval, this._reconnectCancelationSource.Token);
            }
            else
              break;
          }
          if (this.IsConnected)
            return;
          this._logger.Error((object) "Reconnection failed.");
        }), this._reconnectCancelationSource.Token);
      }
    }
  }
}
