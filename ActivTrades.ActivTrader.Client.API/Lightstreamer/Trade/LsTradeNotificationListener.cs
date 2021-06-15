// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.LsTradeNotificationListener
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Lightstreamer.Connect;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.Common.Utils.Threading;
using Lightstreamer.DotNet.Client;
using System;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade
{
  public class LsTradeNotificationListener : 
    ILsTradeNotificationListener,
    IHandyTableListener,
    IDisposable
  {
    private static readonly int requestIdIndex = 1;
    private static readonly int typeIndex = 2;
    private static readonly int bodyIndex = 3;
    private static readonly int categoryIdIndex = 4;
    private readonly ILogger _logger;
    private readonly ITaskExecutor _tradeWorker;
    private bool disposed;

    internal LsTradeNotificationListener(
      LightstreamerConnectionSettings connectionSettings,
      ILogger logger)
    {
      this.Id = connectionSettings.Alias;
      this._tradeWorker = (ITaskExecutor) new SingleThreadExecutor(this.Id);
      this._logger = logger;
    }

    public event EventHandler<LsNotificationEventArgs> TradingNotificationReceived;

    public string Id { get; }

    public void OnRawUpdatesLost(int itemPos, string itemName, int lostUpdates) => this._logger.WarnFormat("On {0} raw updates lost. ItemPos {1}. Lost update {2}.", (object) itemName, (object) itemPos, (object) lostUpdates);

    public void OnSnapshotEnd(int itemPos, string itemName) => this._logger.InfoFormat("On {0} snapshot end. ItemPos {1}", (object) itemName, (object) itemPos);

    public void OnUnsubscr(int itemPos, string itemName) => this._logger.InfoFormat("On {0} unsubscribed. ItemPos {1}", (object) itemName, (object) itemPos);

    public void OnUnsubscrAll() => this._logger.Info((object) "On all unsubscribed");

    public void OnUpdate(int itemPos, string itemName, IUpdateInfo update)
    {
      int num1 = int.Parse(update.GetNewValue(LsTradeNotificationListener.requestIdIndex));
      int num2 = int.Parse(update.GetNewValue(LsTradeNotificationListener.typeIndex));
      string newValue = update.GetNewValue(LsTradeNotificationListener.bodyIndex);
      int num3 = update.NumFields >= 4 ? int.Parse(update.GetNewValue(LsTradeNotificationListener.categoryIdIndex)) : 0;
      if (this._logger.IsDebugEnabled)
        this._logger.DebugFormat("{0} received. RequestId:{1};", (object) num2, (object) num1);
      EventHandler<LsNotificationEventArgs> tradingNotificationReceived = this.TradingNotificationReceived;
      if (tradingNotificationReceived == null)
        return;
      LsNotificationEventArgs notificationEventArgs = new LsNotificationEventArgs()
      {
        Message = new LsMessage()
        {
          LsRequestId = num1,
          TypeId = num2,
          Body = newValue,
          CategoryId = num3
        }
      };
      this._tradeWorker.EnqueueTask((Action) (() =>
      {
        EventHandler<LsNotificationEventArgs> eventHandler = tradingNotificationReceived;
        if (eventHandler == null)
          return;
        eventHandler((object) this, notificationEventArgs);
      }));
    }

    public void Dispose()
    {
      if (this.disposed)
        return;
      this.disposed = true;
    }
  }
}
