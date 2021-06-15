// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Order
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums.Order;
using System;

namespace ATPlatform.Model.Entities
{
  public class Order : 
    IModel<ATPlatform.Model.Entities.Order, long>,
    ICloneable<ATPlatform.Model.Entities.Order>,
    IUpdatable<ATPlatform.Model.Entities.Order>,
    Contracts.IEquatable<ATPlatform.Model.Entities.Order>,
    IIdentify<long>,
    IModel
  {
    public long Id { get; set; }

    public long OrderExecutionId { get; set; }

    public long? ParentOrderId { get; set; }

    public int AccountId { get; set; }

    public long? CloseHedgedOrderId { get; set; }

    public string Symbol { get; set; }

    public OrderType OrderType { get; set; }

    public double Lots { get; set; }

    public DateTime OpenTime { get; set; }

    public DateTime? CloseTime { get; set; }

    public DateTime LastExecutionTime { get; set; }

    public OrderState State { get; set; }

    public OrderTransactionType OrderTransactionType { get; set; }

    public double MarginConversionRate { get; set; }

    public double OpenPrice { get; set; }

    public double ProfitConversionRate { get; set; }

    public double ClosePrice { get; set; }

    public double? TrailingStopTier1 { get; set; }

    public double? TrailingStopTier1Threshold { get; set; }

    public double? TrailingStopTier2 { get; set; }

    public double? TrailingStopTier2Threshold { get; set; }

    public double? TrailingStopTier3 { get; set; }

    public double? TrailingStopTier3Threshold { get; set; }

    public double? StopLoss { get; set; }

    public double? GuaranteedStopLoss { get; set; }

    public double? TakeProfit { get; set; }

    public DateTime? Expiration { get; set; }

    public double Commission { get; set; }

    public double Swap { get; set; }

    public double Profit { get; set; }

    public double? StopOutEquity { get; set; }

    public double? StopOutMargin { get; set; }

    public double? PullbackTrailingStopTier1 { get; set; }

    public double? PullbackTrailingStopTier1Threshold { get; set; }

    public double? PullbackTrailingStopTier2 { get; set; }

    public double? PullbackTrailingStopTier2Threshold { get; set; }

    public double? PullbackTrailingStopTier3 { get; set; }

    public double? PullbackTrailingStopTier3Threshold { get; set; }

    public void Update(ATPlatform.Model.Entities.Order other)
    {
      this.Id = other.Id;
      this.OrderExecutionId = other.OrderExecutionId;
      this.ParentOrderId = other.ParentOrderId;
      this.AccountId = other.AccountId;
      this.CloseHedgedOrderId = other.CloseHedgedOrderId;
      this.Symbol = other.Symbol;
      this.OrderType = other.OrderType;
      this.Lots = other.Lots;
      this.OpenTime = other.OpenTime;
      this.LastExecutionTime = other.LastExecutionTime;
      this.State = other.State;
      this.OrderTransactionType = other.OrderTransactionType;
      this.MarginConversionRate = other.MarginConversionRate;
      this.OpenPrice = other.OpenPrice;
      this.ProfitConversionRate = other.ProfitConversionRate;
      this.ClosePrice = other.ClosePrice;
      this.CloseTime = other.CloseTime;
      this.StopLoss = other.StopLoss;
      this.TakeProfit = other.TakeProfit;
      this.Expiration = other.Expiration;
      this.Commission = other.Commission;
      this.Swap = other.Swap;
      this.Profit = other.Profit;
      this.TrailingStopTier1 = other.TrailingStopTier1;
      this.TrailingStopTier1Threshold = other.TrailingStopTier1Threshold;
      this.TrailingStopTier2 = other.TrailingStopTier2;
      this.TrailingStopTier2Threshold = other.TrailingStopTier2Threshold;
      this.TrailingStopTier3 = other.TrailingStopTier3;
      this.TrailingStopTier3Threshold = other.TrailingStopTier3Threshold;
      this.StopOutEquity = other.StopOutEquity;
      this.StopOutMargin = other.StopOutMargin;
      this.GuaranteedStopLoss = other.GuaranteedStopLoss;
      this.PullbackTrailingStopTier1 = other.PullbackTrailingStopTier1;
      this.PullbackTrailingStopTier1Threshold = other.PullbackTrailingStopTier1Threshold;
      this.PullbackTrailingStopTier2 = other.PullbackTrailingStopTier2;
      this.PullbackTrailingStopTier2Threshold = other.PullbackTrailingStopTier2Threshold;
      this.PullbackTrailingStopTier3 = other.PullbackTrailingStopTier3;
      this.PullbackTrailingStopTier3Threshold = other.PullbackTrailingStopTier3Threshold;
    }

    public ATPlatform.Model.Entities.Order Clone()
    {
      ATPlatform.Model.Entities.Order order = new ATPlatform.Model.Entities.Order();
      order.Update(this);
      return order;
    }

    public bool Equals(ATPlatform.Model.Entities.Order other)
    {
      if (this.Id == other.Id && this.OrderExecutionId == other.OrderExecutionId)
      {
        long? parentOrderId1 = this.ParentOrderId;
        long? parentOrderId2 = other.ParentOrderId;
        if (parentOrderId1.GetValueOrDefault() == parentOrderId2.GetValueOrDefault() & parentOrderId1.HasValue == parentOrderId2.HasValue && this.AccountId == other.AccountId)
        {
          long? closeHedgedOrderId1 = this.CloseHedgedOrderId;
          long? closeHedgedOrderId2 = other.CloseHedgedOrderId;
          if (closeHedgedOrderId1.GetValueOrDefault() == closeHedgedOrderId2.GetValueOrDefault() & closeHedgedOrderId1.HasValue == closeHedgedOrderId2.HasValue && this.Symbol == other.Symbol && (this.OrderType == other.OrderType && DoubleComparer.AreEqual(this.Lots, other.Lots)) && (this.OpenTime == other.OpenTime && this.LastExecutionTime == other.LastExecutionTime && (this.State == other.State && this.OrderTransactionType == other.OrderTransactionType)) && (DoubleComparer.AreEqual(this.MarginConversionRate, other.MarginConversionRate) && DoubleComparer.AreEqual(this.OpenPrice, other.OpenPrice) && (DoubleComparer.AreEqual(this.ProfitConversionRate, other.ProfitConversionRate) && DoubleComparer.AreEqual(this.ClosePrice, other.ClosePrice))))
          {
            DateTime? nullable = this.CloseTime;
            DateTime? closeTime = other.CloseTime;
            if ((nullable.HasValue == closeTime.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == closeTime.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && DoubleComparer.AreEqual(this.StopLoss, other.StopLoss) && DoubleComparer.AreEqual(this.TakeProfit, other.TakeProfit))
            {
              DateTime? expiration = this.Expiration;
              nullable = other.Expiration;
              if ((expiration.HasValue == nullable.HasValue ? (expiration.HasValue ? (expiration.GetValueOrDefault() == nullable.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && DoubleComparer.AreEqual(this.Commission, other.Commission) && (DoubleComparer.AreEqual(this.Swap, other.Swap) && DoubleComparer.AreEqual(this.Profit, other.Profit)) && (DoubleComparer.AreEqual(this.TrailingStopTier1, other.TrailingStopTier1) && DoubleComparer.AreEqual(this.TrailingStopTier1Threshold, other.TrailingStopTier1Threshold) && (DoubleComparer.AreEqual(this.TrailingStopTier2, other.TrailingStopTier2) && DoubleComparer.AreEqual(this.TrailingStopTier2Threshold, other.TrailingStopTier2Threshold))) && (DoubleComparer.AreEqual(this.TrailingStopTier3, other.TrailingStopTier3) && DoubleComparer.AreEqual(this.TrailingStopTier3Threshold, other.TrailingStopTier3Threshold) && (DoubleComparer.AreEqual(this.StopOutEquity, other.StopOutEquity) && DoubleComparer.AreEqual(this.StopOutMargin, other.StopOutMargin)) && (DoubleComparer.AreEqual(this.GuaranteedStopLoss, other.GuaranteedStopLoss) && DoubleComparer.AreEqual(this.PullbackTrailingStopTier1, other.PullbackTrailingStopTier1) && (DoubleComparer.AreEqual(this.PullbackTrailingStopTier1Threshold, other.PullbackTrailingStopTier1Threshold) && DoubleComparer.AreEqual(this.PullbackTrailingStopTier2, other.PullbackTrailingStopTier2)))) && (DoubleComparer.AreEqual(this.PullbackTrailingStopTier2Threshold, other.PullbackTrailingStopTier2Threshold) && DoubleComparer.AreEqual(this.PullbackTrailingStopTier3, other.PullbackTrailingStopTier3)))
                return DoubleComparer.AreEqual(this.PullbackTrailingStopTier3Threshold, other.PullbackTrailingStopTier3Threshold);
            }
          }
        }
      }
      return false;
    }

    public long GetKey() => this.Id;
  }
}
