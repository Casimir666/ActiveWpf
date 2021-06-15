// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.Models.SymbolTradingData
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.Common.ExchangeRates;
using ATPlatform.Common.Utils;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Feed;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ActivTrades.ActivTrader.API.Models
{
  public class SymbolTradingData
  {
    private readonly IExchangeRateService _exchangeRateService;
    private readonly Account _account;
    private readonly LastTicksFilteredStorage _lastFilteredTicks;
    private readonly ConcurrentDictionary<long, Order> _ordersMap = new ConcurrentDictionary<long, Order>();

    public SymbolTradingData(
      Account account,
      Symbol symbol,
      SymbolTradingSessions symbolTradingSessions,
      LastTicksFilteredStorage lastFilteredTicks,
      IExchangeRateService exchangeRateService)
    {
      if (!symbol.Equals(lastFilteredTicks.Symbol))
        throw new ArgumentException("symbol " + symbol.Id + " does not match to the lastFilteredTicks " + lastFilteredTicks.Symbol.Id);
      this._account = account;
      this.Symbol = symbol;
      this.SymbolTradeSettings = symbol.Clone();
      this.SymbolTradingSessions = symbolTradingSessions;
      this._lastFilteredTicks = lastFilteredTicks;
      this._exchangeRateService = exchangeRateService;
    }

    public bool IsEmpty => this._ordersMap.IsEmpty;

    public bool IsInSessionAndNotExpired => this.SymbolTradingSessions.InSessionAndNotExpired;

    public bool IsInSessionAndNotExpiredAt(DateTime dateTime) => this.SymbolTradingSessions.InSessionAndNotExpiredAt(dateTime);

    public Symbol Symbol { get; }

    public Symbol SymbolTradeSettings { get; }

    public double BidMarkup { get; set; }

    public double AskMarkup { get; set; }

    public SymbolTradingSessions SymbolTradingSessions { get; }

    public IFilteredTicksStorage LastFilteredTicks => (IFilteredTicksStorage) this._lastFilteredTicks;

    public int OrdersCount => this._ordersMap.Count;

    public Order AddOrUpdateOrder(Order order)
    {
      this.ValidateOrder(order);
      return this._ordersMap.AddOrUpdate(order.Id, (Func<long, Order>) (k => order), (Func<long, Order, Order>) ((k, t) =>
      {
        t.Update(order);
        return t;
      }));
    }

    public bool TryRemoveOrder(Order order, out Order existingOrder)
    {
      this.ValidateOrder(order);
      return this._ordersMap.TryRemove(order.Id, out existingOrder);
    }

    public Order GetOrder(long orderId)
    {
      Order order1 = (Order) null;
      Order order2;
      if (this._ordersMap.TryGetValue(orderId, out order2))
        order1 = order2.Clone();
      return order1;
    }

    public ReadOnlyCollection<Order> GetOrders()
    {
      if (this._ordersMap.IsEmpty)
        return new ReadOnlyCollection<Order>((IList<Order>) new List<Order>());
      List<Order> orderList = new List<Order>(this._ordersMap.Values.Count);
      bool flag = !this._lastFilteredTicks.IsEmpty;
      List<Tick> source = flag ? this._lastFilteredTicks.GetAllOrderedByTimestampAndReset() : new List<Tick>();
      Tick tick = flag ? source.Last<Tick>() : (Tick) null;
      foreach (long key in this._ordersMap.Keys.ToList<long>())
      {
        Order order;
        if (this._ordersMap.TryGetValue(key, out order))
        {
          if (flag)
          {
            order.ClosePrice = order.IsLong() ? tick.Bid : tick.Ask;
            this.CalculateCurrentProfit(order);
            if (order.IsTrailingStop())
              this.CalculateStopLossInCaseTrailingStop(order, (IEnumerable<Tick>) source, this.Symbol);
            this._lastFilteredTicks.Reset();
          }
          orderList.Add(order.Clone());
        }
      }
      return new ReadOnlyCollection<Order>((IList<Order>) orderList);
    }

    private void ValidateOrder(Order order)
    {
      if (order.Symbol != this.Symbol.Id)
        throw new ArgumentException(string.Format("Symbol id {0} of order {1} does not match to the symbol {2}", (object) order.Symbol, (object) order.Id, (object) this.Symbol.Id));
    }

    private void CalculateCurrentProfit(Order order)
    {
      if (!order.IsMarket() || !order.IsActive())
        return;
      ExchangeRate rate = this._exchangeRateService.GetRate(this.Symbol.ProfitCurrencyIsoCode, this._account.CurrencyIsoCode);
      ProfitOrderArguments order1 = new ProfitOrderArguments(order.IsLong(), order.OpenPrice, order.ClosePrice, order.Lots);
      order.Profit = TradingUtils.CalculateOrderProfit(order1, this.Symbol.ContractSize, this.Symbol.ContractSizeDenominator, rate.Bid, rate.Ask);
    }

    private void CalculateStopLossInCaseTrailingStop(
      Order order,
      IEnumerable<Tick> lastTicks,
      Symbol symbol)
    {
      if (symbol == null || !order.IsTrailingStop() || !order.TrailingStopTier1.HasValue)
        return;
      double? nullable1;
      double? nullable2;
      double? nullable3;
      foreach (Tick lastTick in lastTicks)
      {
        if (order.IsLong())
        {
          double bid1 = lastTick.Bid;
          nullable1 = order.StopLoss;
          nullable2 = order.TrailingStopTier1;
          nullable3 = nullable1.HasValue & nullable2.HasValue ? new double?(nullable1.GetValueOrDefault() + nullable2.GetValueOrDefault()) : new double?();
          double valueOrDefault = nullable3.GetValueOrDefault();
          if (bid1 > valueOrDefault & nullable3.HasValue)
          {
            Order order1 = order;
            double bid2 = lastTick.Bid;
            nullable3 = order.TrailingStopTier1;
            double? nullable4;
            if (!nullable3.HasValue)
            {
              nullable2 = new double?();
              nullable4 = nullable2;
            }
            else
              nullable4 = new double?(bid2 - nullable3.GetValueOrDefault());
            order1.StopLoss = nullable4;
          }
        }
        else
        {
          double ask1 = lastTick.Ask;
          nullable2 = order.StopLoss;
          nullable1 = order.TrailingStopTier1;
          nullable3 = nullable2.HasValue & nullable1.HasValue ? new double?(nullable2.GetValueOrDefault() - nullable1.GetValueOrDefault()) : new double?();
          double valueOrDefault = nullable3.GetValueOrDefault();
          if (ask1 < valueOrDefault & nullable3.HasValue)
          {
            Order order1 = order;
            double ask2 = lastTick.Ask;
            nullable3 = order.TrailingStopTier1;
            double? nullable4;
            if (!nullable3.HasValue)
            {
              nullable1 = new double?();
              nullable4 = nullable1;
            }
            else
              nullable4 = new double?(ask2 + nullable3.GetValueOrDefault());
            order1.StopLoss = nullable4;
          }
        }
      }
    }
  }
}
