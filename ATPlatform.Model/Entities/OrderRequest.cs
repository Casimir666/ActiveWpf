// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.OrderRequest
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Enums.Order;
using System;

namespace ATPlatform.Model.Entities
{
  public class OrderRequest
  {
    public int AccountId { get; set; }

    public long OrderId { get; set; }

    public string Symbol { get; set; }

    public OrderType OrderType { get; set; }

    public double Lots { get; set; }

    public double Price { get; set; }

    public double StopLoss { get; set; }

    public double TakeProfit { get; set; }

    public DateTime? Expiration { get; set; }

    public long OrderById { get; set; }

    public double TrailingStopTier1Threshold { get; set; }

    public double TrailingStopTier1 { get; set; }

    public double TrailingStopTier2Threshold { get; set; }

    public double TrailingStopTier2 { get; set; }

    public double TrailingStopTier3Threshold { get; set; }

    public double TrailingStopTier3 { get; set; }
  }
}
