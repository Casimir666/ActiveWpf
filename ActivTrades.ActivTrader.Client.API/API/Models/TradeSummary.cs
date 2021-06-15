// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.Models.TradeSummary
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ActivTrades.ActivTrader.API.Models
{
  public class TradeSummary
  {
    public TradeSummary(Account account, IReadOnlyCollection<Order> orders)
    {
      this.Margin = account.Margin;
      this.Balance = account.Balance;
      this.Swap = orders.Sum<Order>((Func<Order, double>) (order => order.Swap));
      this.Profit = orders.Sum<Order>((Func<Order, double>) (order => order.Profit)) + this.Swap;
      this.Equity = account.Balance + this.Profit;
      this.FreeMargin = this.Equity - account.Margin;
      this.MarginPercentage = (int) (account.Margin * 100.0) != 0 ? this.Equity * 100.0 / account.Margin : 0.0;
    }

    public double Balance { get; }

    public double Profit { get; }

    public double Equity { get; }

    public double Swap { get; }

    public double FreeMargin { get; }

    public double Margin { get; }

    public double MarginPercentage { get; }

    public override string ToString() => string.Format("{0}:{1} ", (object) "Balance", (object) this.Balance) + string.Format("{0}:{1} ", (object) "Profit", (object) this.Profit) + string.Format("{0}:{1} ", (object) "Equity", (object) this.Equity) + string.Format("{0}:{1} ", (object) "Margin", (object) this.Margin);
  }
}
