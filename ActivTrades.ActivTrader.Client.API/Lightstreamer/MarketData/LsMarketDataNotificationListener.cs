// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.MarketData.LsMarketDataNotificationListener
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Lightstreamer.Connect;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.Common.Utils.Threading;
using ATPlatform.IDL;
using Lightstreamer.DotNet.Client;
using System;

namespace ActivTrades.ActivTrader.Lightstreamer.MarketData
{
  public class LsMarketDataNotificationListener : 
    ILsMarketDataNotificationListener,
    IHandyTableListener,
    IDisposable
  {
    private static readonly int timestampDelimiter = ApplicationSettings.FeedTimestampDelimiter != 0 ? ApplicationSettings.FeedTimestampDelimiter : 1000;
    private static readonly int askIndex = 1;
    private static readonly int bidIndex = 2;
    private static readonly int symbolIndex = 3;
    private static readonly int digitsIndex = 4;
    private static readonly int timestampIndex = 5;
    private readonly ILogger _logger;
    private readonly ITaskExecutor _taskExecutor;
    private bool disposed;

    internal LsMarketDataNotificationListener(
      LightstreamerConnectionSettings connectionSettings,
      ILogger logger)
    {
      this.Id = connectionSettings.Alias;
      this._taskExecutor = (ITaskExecutor) new SingleThreadExecutor(this.Id);
      this._logger = logger;
    }

    public event EventHandler<LsTickReceivedEventArgs> TickReceived;

    public string Id { get; }

    public void OnRawUpdatesLost(int itemPos, string itemName, int lostUpdates) => this._logger.WarnFormat("On {0} raw updates lost. ItemPos {1}. Lost update {2}.", (object) itemName, (object) itemPos, (object) lostUpdates);

    public void OnSnapshotEnd(int itemPos, string itemName)
    {
    }

    public void OnUnsubscr(int itemPos, string itemName)
    {
    }

    public void OnUnsubscrAll()
    {
    }

    public void OnUpdate(int itemPos, string itemName, IUpdateInfo update)
    {
      string newValue1 = update.GetNewValue(LsMarketDataNotificationListener.askIndex);
      string newValue2 = update.GetNewValue(LsMarketDataNotificationListener.bidIndex);
      string newValue3 = update.GetNewValue(LsMarketDataNotificationListener.symbolIndex);
      string newValue4 = update.GetNewValue(LsMarketDataNotificationListener.digitsIndex);
      string newValue5 = update.GetNewValue(LsMarketDataNotificationListener.timestampIndex);
      TickProto tickProto = new TickProto()
      {
        Symbol = newValue3,
        Digits = (int) LightstreamerUtilities.GetByte(newValue4),
        Bid = LightstreamerUtilities.GetInt32(newValue2),
        Ask = LightstreamerUtilities.GetInt32(newValue1),
        Timestamp = LightstreamerUtilities.GetInt64(newValue5) / (long) LsMarketDataNotificationListener.timestampDelimiter
      };
      if (this._logger.IsDebugEnabled)
        this._logger.DebugFormat("{0}", (object) tickProto);
      this.OnTickReceived(new LsTickReceivedEventArgs()
      {
        Tick = tickProto
      });
    }

    protected virtual void OnTickReceived(LsTickReceivedEventArgs e)
    {
      EventHandler<LsTickReceivedEventArgs> tickReceived = this.TickReceived;
      if (tickReceived == null)
        return;
      this._taskExecutor?.EnqueueTask((Action) (() => tickReceived((object) this, e)));
    }

    public void Dispose()
    {
      if (this.disposed)
        return;
      this._taskExecutor?.Dispose();
      this.disposed = true;
    }
  }
}
