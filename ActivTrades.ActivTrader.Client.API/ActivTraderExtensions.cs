// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.ActivTraderExtensions
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.IDL;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using ATPlatform.Model.Proto;
using Google.Protobuf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader
{
  public static class ActivTraderExtensions
  {
    private static readonly int _checkTimeoutPercentage = ApplicationSettings.NextCheckTimeoutIntervalBasedOnTimeoutPercentage;
    private static readonly double _checkTimeoutMultiplier = (double) ActivTraderExtensions._checkTimeoutPercentage / 100.0;
    private static readonly TimeSpan _minNextCheckInterval = ApplicationSettings.NextCheckMinTimeout;
    private static readonly TimeSpan _defaultWaitTimeout = ApplicationSettings.RequestTimeout;
    private static readonly HashSet<OrderType> marketOrderTypes = new HashSet<OrderType>()
    {
      OrderType.Buy,
      OrderType.Sell
    };
    private static readonly HashSet<OrderState> inactiveOrderStates = new HashSet<OrderState>()
    {
      OrderState.Closed,
      OrderState.Canceled,
      OrderState.Deleted,
      OrderState.Rejected
    };

    public static void ExecuteOnThreadPoolAndWait(this Task t) => Task.Run((Func<Task>) (async () => await t)).Wait();

    public static T ExecuteOnThreadPoolAndGetResult<T>(this Task<T> t) => Task.Run<T>((Func<Task<T>>) (async () => await t)).Result;

    public static void UpdateTradeSummary(
      this Account account,
      AccountTradeSummaryProto accountTradeSummary)
    {
      if (accountTradeSummary == null)
        return;
      account.UpdateTradeSummary(accountTradeSummary.Balance, accountTradeSummary.Margin, accountTradeSummary.Equity);
    }

    public static void UpdateTradeSummary(
      this Account account,
      double balance,
      double margin,
      double equity)
    {
      account.Balance = balance;
      account.Margin = margin;
      account.Equity = equity;
    }

    public static bool IsPosition(this ATPlatform.Model.Entities.Order order) => order.OrderType == OrderType.Buy || order.OrderType == OrderType.Sell;

    public static bool IsPending(this ATPlatform.Model.Entities.Order order)
    {
      string str = order.OrderType.ToString();
      return str.EndsWith("Stop") || str.EndsWith("Limit");
    }

    public static bool IsTrailingStop(this ATPlatform.Model.Entities.Order order) => order.TrailingStopTier1.HasValue;

    public static bool IsMarket(this ATPlatform.Model.Entities.Order order) => ActivTraderExtensions.marketOrderTypes.Contains(order.OrderType);

    public static bool IsLong(this ATPlatform.Model.Entities.Order order)
    {
      switch (order.OrderType)
      {
        case OrderType.Buy:
        case OrderType.BuyLimit:
        case OrderType.BuyStop:
          return true;
        case OrderType.Sell:
        case OrderType.SellLimit:
        case OrderType.SellStop:
          return false;
        default:
          throw new ArgumentException(string.Format("{0} not supported", (object) order.OrderType));
      }
    }

    public static bool IsShort(this ATPlatform.Model.Entities.Order order) => !order.IsLong();

    public static bool IsActive(this ATPlatform.Model.Entities.Order order) => order.State != OrderState.Unknown && !ActivTraderExtensions.inactiveOrderStates.Contains(order.State);

    public static ReadOnlyCollection<TEntity> CloneEntities<TEntity, TIdentity>(
      this IDictionary<TIdentity, TEntity> entities)
      where TEntity : IModel<TEntity, TIdentity>
    {
      return entities.CloneEntities<TEntity, TIdentity>((Func<TEntity, bool>) null);
    }

    public static ReadOnlyCollection<TEntity> CloneEntities<TEntity, TIdentity>(
      this IDictionary<TIdentity, TEntity> entities,
      Func<TEntity, bool> predicate)
      where TEntity : IModel<TEntity, TIdentity>
    {
      List<TEntity> entityList = new List<TEntity>();
      foreach (TIdentity key in (IEnumerable<TIdentity>) entities.Keys)
      {
        TEntity entity;
        if (entities.TryGetValue(key, out entity) && (predicate == null || predicate(entity)))
          entityList.Add(entity.Clone());
      }
      return new ReadOnlyCollection<TEntity>((IList<TEntity>) entityList);
    }

    public static bool TryLoadAllEntities<TEntity, TIdentity, TProto>(
      this ConcurrentDictionary<TIdentity, TEntity> entities,
      List<TProto> protoCollection,
      out List<TIdentity> failed)
      where TEntity : IIdentify<TIdentity>
      where TProto : IMessage, IMessage<TProto>
    {
      failed = new List<TIdentity>();
      foreach (TProto proto in protoCollection)
      {
        TEntity entity = proto.ModelFromProto<TProto, TEntity>();
        if (!entities.TryAdd(entity.GetKey(), entity))
          failed.Add(entity.GetKey());
      }
      return failed.Count == 0;
    }

    public static bool TryGetAllEntities<TEntity, TIdentity>(
      this ConcurrentDictionary<TIdentity, TEntity> entities,
      out List<TEntity> result,
      out List<TIdentity> failed)
      where TEntity : IIdentify<TIdentity>
    {
      result = new List<TEntity>();
      failed = new List<TIdentity>();
      foreach (TIdentity key in entities.Keys.ToList<TIdentity>())
      {
        TEntity entity;
        if (entities.TryGetValue(key, out entity))
          result.Add(entity);
        else
          failed.Add(key);
      }
      return failed.Count == 0;
    }

    public static void Ensure(this Func<bool> peridcate) => peridcate.Ensure(ActivTraderExtensions._defaultWaitTimeout);

    public static async Task EnsureAsync(this Func<bool> peridcate) => await peridcate.EnsureAsync(ActivTraderExtensions._defaultWaitTimeout);

    public static void Ensure(this Func<bool> peridcate, TimeSpan timeout)
    {
      int numberOfAttempts = 100 / ActivTraderExtensions._checkTimeoutPercentage;
      TimeSpan interval = TimeSpan.FromMilliseconds(ActivTraderExtensions._checkTimeoutMultiplier * timeout.TotalMilliseconds);
      peridcate.Ensure(numberOfAttempts, interval);
    }

    public static async Task EnsureAsync(this Func<bool> peridcate, TimeSpan timeout) => await peridcate.EnsureAsync(100 / ActivTraderExtensions._checkTimeoutPercentage, TimeSpan.FromMilliseconds(ActivTraderExtensions._checkTimeoutMultiplier * timeout.TotalMilliseconds));

    public static void Ensure(this Func<bool> peridcate, TimeSpan timeout, TimeSpan interval)
    {
      double num = timeout.TotalMilliseconds / interval.TotalMilliseconds;
      peridcate.Ensure((int) num, interval);
    }

    public static async Task EnsureAsync(
      this Func<bool> peridcate,
      TimeSpan timeout,
      TimeSpan interval)
    {
      await peridcate.EnsureAsync((int) (timeout.TotalMilliseconds / interval.TotalMilliseconds), interval);
    }

    public static void Ensure(this Func<bool> peridcate, int numberOfAttempts, TimeSpan interval)
    {
      TimeSpan timeSpan = TimeSpan.FromMilliseconds(interval.TotalMilliseconds * (double) numberOfAttempts);
      if (timeSpan < ActivTraderExtensions._minNextCheckInterval || numberOfAttempts == 0)
        throw new ArgumentException(string.Format("{0} cannot be less than {1}. Current is {2}.", (object) "timeout", (object) ActivTraderExtensions._minNextCheckInterval, (object) timeSpan), "timeout");
      AutoResetEvent autoResetEvent = new AutoResetEvent(false);
      CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeSpan.Add(interval));
      cancellationTokenSource.Token.Register((Action) (() => autoResetEvent.Set()));
      bool success = false;
      Task.Run((Func<Task>) (async () =>
      {
        while (!success)
        {
          success = peridcate();
          await Task.Delay(interval, cancellationTokenSource.Token);
        }
        autoResetEvent.Set();
      }), cancellationTokenSource.Token);
      autoResetEvent.WaitOne();
      if (!success)
        throw new TimeoutException(string.Format("{0} failed with timeout {1}", (object) nameof (Ensure), (object) timeSpan));
    }

    public static async Task EnsureAsync(
      this Func<bool> peridcate,
      int numberOfAttempts,
      TimeSpan interval)
    {
      TimeSpan timeout = TimeSpan.FromMilliseconds(interval.TotalMilliseconds * (double) numberOfAttempts);
      if (timeout < ActivTraderExtensions._minNextCheckInterval || numberOfAttempts == 0)
        throw new ArgumentException(string.Format("{0} cannot be less than {1}. Current is {2}.", (object) "timeout", (object) ActivTraderExtensions._minNextCheckInterval, (object) timeout), "timeout");
      AutoResetEvent autoResetEvent = new AutoResetEvent(false);
      CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout.Add(interval));
      cancellationTokenSource.Token.Register((Action) (() => autoResetEvent.Set()));
      bool success = false;
      await Task.Run((Func<Task>) (async () =>
      {
        while (!success)
        {
          success = peridcate();
          await Task.Delay(interval, cancellationTokenSource.Token);
        }
        autoResetEvent.Set();
      }), cancellationTokenSource.Token);
      autoResetEvent.WaitOne();
      if (!success)
        throw new TimeoutException(string.Format("{0} failed with timeout {1}", (object) "Ensure", (object) timeout));
    }
  }
}
