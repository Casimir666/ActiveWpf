// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class OrderProto : 
    IMessage<OrderProto>,
    IMessage,
    IEquatable<OrderProto>,
    IDeepCloneable<OrderProto>
  {
    private static readonly MessageParser<OrderProto> _parser = new MessageParser<OrderProto>((Func<OrderProto>) (() => new OrderProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private long id_;
    public const int OrderExecutionIdFieldNumber = 2;
    private long orderExecutionId_;
    public const int ParentOrderIdFieldNumber = 3;
    private long parentOrderId_;
    public const int CloseHedgedOrderIdFieldNumber = 4;
    private long closeHedgedOrderId_;
    public const int AccountIdFieldNumber = 5;
    private int accountId_;
    public const int SymbolFieldNumber = 6;
    private string symbol_ = "";
    public const int OrderTypeFieldNumber = 7;
    private OrderTypeProto orderType_;
    public const int LotsFieldNumber = 8;
    private double lots_;
    public const int OpenTimeFieldNumber = 9;
    private long openTime_;
    public const int LastExecutionTimeFieldNumber = 10;
    private long lastExecutionTime_;
    public const int CloseTimeFieldNumber = 11;
    private long closeTime_;
    public const int StateFieldNumber = 12;
    private OrderStateProto state_;
    public const int OrderTransactionTypeFieldNumber = 13;
    private OrderTransactionTypeProto orderTransactionType_;
    public const int MarginConversionRateFieldNumber = 14;
    private double marginConversionRate_;
    public const int OpenPriceFieldNumber = 15;
    private double openPrice_;
    public const int ProfitConversionRateFieldNumber = 16;
    private double profitConversionRate_;
    public const int ClosePriceFieldNumber = 17;
    private double closePrice_;
    public const int StopLossFieldNumber = 18;
    private double stopLoss_;
    public const int TakeProfitFieldNumber = 19;
    private double takeProfit_;
    public const int ExpirationFieldNumber = 20;
    private long expiration_;
    public const int CommissionFieldNumber = 21;
    private double commission_;
    public const int SwapFieldNumber = 22;
    private double swap_;
    public const int ProfitFieldNumber = 23;
    private double profit_;
    public const int GuaranteedStopLossFieldNumber = 24;
    private double guaranteedStopLoss_;
    public const int StopOutEquityFieldNumber = 25;
    private double stopOutEquity_;
    public const int StopOutMarginFieldNumber = 26;
    private double stopOutMargin_;
    public const int TrailingStopTier1ThresholdFieldNumber = 27;
    private double trailingStopTier1Threshold_;
    public const int TrailingStopTier1FieldNumber = 28;
    private double trailingStopTier1_;
    public const int TrailingStopTier2ThresholdFieldNumber = 29;
    private double trailingStopTier2Threshold_;
    public const int TrailingStopTier2FieldNumber = 30;
    private double trailingStopTier2_;
    public const int TrailingStopTier3ThresholdFieldNumber = 31;
    private double trailingStopTier3Threshold_;
    public const int TrailingStopTier3FieldNumber = 32;
    private double trailingStopTier3_;
    public const int PullbackTrailingStopTier1FieldNumber = 33;
    private double pullbackTrailingStopTier1_;
    public const int PullbackTrailingStopTier1ThresholdFieldNumber = 34;
    private double pullbackTrailingStopTier1Threshold_;
    public const int PullbackTrailingStopTier2FieldNumber = 35;
    private double pullbackTrailingStopTier2_;
    public const int PullbackTrailingStopTier2ThresholdFieldNumber = 36;
    private double pullbackTrailingStopTier2Threshold_;
    public const int PullbackTrailingStopTier3FieldNumber = 37;
    private double pullbackTrailingStopTier3_;
    public const int PullbackTrailingStopTier3ThresholdFieldNumber = 38;
    private double pullbackTrailingStopTier3Threshold_;

    [DebuggerNonUserCode]
    public static MessageParser<OrderProto> Parser => OrderProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[7];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => OrderProto.Descriptor;

    [DebuggerNonUserCode]
    public OrderProto()
    {
    }

    [DebuggerNonUserCode]
    public OrderProto(OrderProto other)
      : this()
    {
      this.id_ = other.id_;
      this.orderExecutionId_ = other.orderExecutionId_;
      this.parentOrderId_ = other.parentOrderId_;
      this.closeHedgedOrderId_ = other.closeHedgedOrderId_;
      this.accountId_ = other.accountId_;
      this.symbol_ = other.symbol_;
      this.orderType_ = other.orderType_;
      this.lots_ = other.lots_;
      this.openTime_ = other.openTime_;
      this.lastExecutionTime_ = other.lastExecutionTime_;
      this.closeTime_ = other.closeTime_;
      this.state_ = other.state_;
      this.orderTransactionType_ = other.orderTransactionType_;
      this.marginConversionRate_ = other.marginConversionRate_;
      this.openPrice_ = other.openPrice_;
      this.profitConversionRate_ = other.profitConversionRate_;
      this.closePrice_ = other.closePrice_;
      this.stopLoss_ = other.stopLoss_;
      this.takeProfit_ = other.takeProfit_;
      this.expiration_ = other.expiration_;
      this.commission_ = other.commission_;
      this.swap_ = other.swap_;
      this.profit_ = other.profit_;
      this.guaranteedStopLoss_ = other.guaranteedStopLoss_;
      this.stopOutEquity_ = other.stopOutEquity_;
      this.stopOutMargin_ = other.stopOutMargin_;
      this.trailingStopTier1Threshold_ = other.trailingStopTier1Threshold_;
      this.trailingStopTier1_ = other.trailingStopTier1_;
      this.trailingStopTier2Threshold_ = other.trailingStopTier2Threshold_;
      this.trailingStopTier2_ = other.trailingStopTier2_;
      this.trailingStopTier3Threshold_ = other.trailingStopTier3Threshold_;
      this.trailingStopTier3_ = other.trailingStopTier3_;
      this.pullbackTrailingStopTier1_ = other.pullbackTrailingStopTier1_;
      this.pullbackTrailingStopTier1Threshold_ = other.pullbackTrailingStopTier1Threshold_;
      this.pullbackTrailingStopTier2_ = other.pullbackTrailingStopTier2_;
      this.pullbackTrailingStopTier2Threshold_ = other.pullbackTrailingStopTier2Threshold_;
      this.pullbackTrailingStopTier3_ = other.pullbackTrailingStopTier3_;
      this.pullbackTrailingStopTier3Threshold_ = other.pullbackTrailingStopTier3Threshold_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public OrderProto Clone() => new OrderProto(this);

    [DebuggerNonUserCode]
    public long Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public long OrderExecutionId
    {
      get => this.orderExecutionId_;
      set => this.orderExecutionId_ = value;
    }

    [DebuggerNonUserCode]
    public long ParentOrderId
    {
      get => this.parentOrderId_;
      set => this.parentOrderId_ = value;
    }

    [DebuggerNonUserCode]
    public long CloseHedgedOrderId
    {
      get => this.closeHedgedOrderId_;
      set => this.closeHedgedOrderId_ = value;
    }

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public OrderTypeProto OrderType
    {
      get => this.orderType_;
      set => this.orderType_ = value;
    }

    [DebuggerNonUserCode]
    public double Lots
    {
      get => this.lots_;
      set => this.lots_ = value;
    }

    [DebuggerNonUserCode]
    public long OpenTime
    {
      get => this.openTime_;
      set => this.openTime_ = value;
    }

    [DebuggerNonUserCode]
    public long LastExecutionTime
    {
      get => this.lastExecutionTime_;
      set => this.lastExecutionTime_ = value;
    }

    [DebuggerNonUserCode]
    public long CloseTime
    {
      get => this.closeTime_;
      set => this.closeTime_ = value;
    }

    [DebuggerNonUserCode]
    public OrderStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public OrderTransactionTypeProto OrderTransactionType
    {
      get => this.orderTransactionType_;
      set => this.orderTransactionType_ = value;
    }

    [DebuggerNonUserCode]
    public double MarginConversionRate
    {
      get => this.marginConversionRate_;
      set => this.marginConversionRate_ = value;
    }

    [DebuggerNonUserCode]
    public double OpenPrice
    {
      get => this.openPrice_;
      set => this.openPrice_ = value;
    }

    [DebuggerNonUserCode]
    public double ProfitConversionRate
    {
      get => this.profitConversionRate_;
      set => this.profitConversionRate_ = value;
    }

    [DebuggerNonUserCode]
    public double ClosePrice
    {
      get => this.closePrice_;
      set => this.closePrice_ = value;
    }

    [DebuggerNonUserCode]
    public double StopLoss
    {
      get => this.stopLoss_;
      set => this.stopLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double TakeProfit
    {
      get => this.takeProfit_;
      set => this.takeProfit_ = value;
    }

    [DebuggerNonUserCode]
    public long Expiration
    {
      get => this.expiration_;
      set => this.expiration_ = value;
    }

    [DebuggerNonUserCode]
    public double Commission
    {
      get => this.commission_;
      set => this.commission_ = value;
    }

    [DebuggerNonUserCode]
    public double Swap
    {
      get => this.swap_;
      set => this.swap_ = value;
    }

    [DebuggerNonUserCode]
    public double Profit
    {
      get => this.profit_;
      set => this.profit_ = value;
    }

    [DebuggerNonUserCode]
    public double GuaranteedStopLoss
    {
      get => this.guaranteedStopLoss_;
      set => this.guaranteedStopLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double StopOutEquity
    {
      get => this.stopOutEquity_;
      set => this.stopOutEquity_ = value;
    }

    [DebuggerNonUserCode]
    public double StopOutMargin
    {
      get => this.stopOutMargin_;
      set => this.stopOutMargin_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier1Threshold
    {
      get => this.trailingStopTier1Threshold_;
      set => this.trailingStopTier1Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier1
    {
      get => this.trailingStopTier1_;
      set => this.trailingStopTier1_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier2Threshold
    {
      get => this.trailingStopTier2Threshold_;
      set => this.trailingStopTier2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier2
    {
      get => this.trailingStopTier2_;
      set => this.trailingStopTier2_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier3Threshold
    {
      get => this.trailingStopTier3Threshold_;
      set => this.trailingStopTier3Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier3
    {
      get => this.trailingStopTier3_;
      set => this.trailingStopTier3_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier1
    {
      get => this.pullbackTrailingStopTier1_;
      set => this.pullbackTrailingStopTier1_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier1Threshold
    {
      get => this.pullbackTrailingStopTier1Threshold_;
      set => this.pullbackTrailingStopTier1Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier2
    {
      get => this.pullbackTrailingStopTier2_;
      set => this.pullbackTrailingStopTier2_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier2Threshold
    {
      get => this.pullbackTrailingStopTier2Threshold_;
      set => this.pullbackTrailingStopTier2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier3
    {
      get => this.pullbackTrailingStopTier3_;
      set => this.pullbackTrailingStopTier3_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier3Threshold
    {
      get => this.pullbackTrailingStopTier3Threshold_;
      set => this.pullbackTrailingStopTier3Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as OrderProto);

    [DebuggerNonUserCode]
    public bool Equals(OrderProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.OrderExecutionId == other.OrderExecutionId && (this.ParentOrderId == other.ParentOrderId && this.CloseHedgedOrderId == other.CloseHedgedOrderId) && (this.AccountId == other.AccountId && !(this.Symbol != other.Symbol) && (this.OrderType == other.OrderType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Lots, other.Lots))) && (this.OpenTime == other.OpenTime && this.LastExecutionTime == other.LastExecutionTime && (this.CloseTime == other.CloseTime && this.State == other.State) && (this.OrderTransactionType == other.OrderTransactionType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MarginConversionRate, other.MarginConversionRate) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.OpenPrice, other.OpenPrice) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ProfitConversionRate, other.ProfitConversionRate)))) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ClosePrice, other.ClosePrice) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StopLoss, other.StopLoss) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TakeProfit, other.TakeProfit) && this.Expiration == other.Expiration) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Commission, other.Commission) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Swap, other.Swap) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Profit, other.Profit) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.GuaranteedStopLoss, other.GuaranteedStopLoss))) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StopOutEquity, other.StopOutEquity) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StopOutMargin, other.StopOutMargin) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier1Threshold, other.TrailingStopTier1Threshold) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier1, other.TrailingStopTier1)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier2Threshold, other.TrailingStopTier2Threshold) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier2, other.TrailingStopTier2) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier3Threshold, other.TrailingStopTier3Threshold) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier3, other.TrailingStopTier3))))) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier1, other.PullbackTrailingStopTier1) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier1Threshold, other.PullbackTrailingStopTier1Threshold) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier2, other.PullbackTrailingStopTier2) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier2Threshold, other.PullbackTrailingStopTier2Threshold)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier3, other.PullbackTrailingStopTier3) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier3Threshold, other.PullbackTrailingStopTier3Threshold))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      long num2;
      if (this.Id != 0L)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.OrderExecutionId != 0L)
      {
        int num3 = num1;
        num2 = this.OrderExecutionId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ParentOrderId != 0L)
      {
        int num3 = num1;
        num2 = this.ParentOrderId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CloseHedgedOrderId != 0L)
      {
        int num3 = num1;
        num2 = this.CloseHedgedOrderId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      if (this.Symbol.Length != 0)
        num1 ^= this.Symbol.GetHashCode();
      if (this.OrderType != OrderTypeProto.Unknown)
        num1 ^= this.OrderType.GetHashCode();
      if (this.Lots != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Lots);
      if (this.OpenTime != 0L)
      {
        int num3 = num1;
        num2 = this.OpenTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.LastExecutionTime != 0L)
      {
        int num3 = num1;
        num2 = this.LastExecutionTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CloseTime != 0L)
      {
        int num3 = num1;
        num2 = this.CloseTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.State != OrderStateProto.UnknownState)
        num1 ^= this.State.GetHashCode();
      if (this.OrderTransactionType != OrderTransactionTypeProto.UnknownOrderTransactionType)
        num1 ^= this.OrderTransactionType.GetHashCode();
      if (this.MarginConversionRate != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MarginConversionRate);
      if (this.OpenPrice != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.OpenPrice);
      if (this.ProfitConversionRate != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ProfitConversionRate);
      if (this.ClosePrice != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ClosePrice);
      if (this.StopLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StopLoss);
      if (this.TakeProfit != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TakeProfit);
      if (this.Expiration != 0L)
      {
        int num3 = num1;
        num2 = this.Expiration;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Commission != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Commission);
      if (this.Swap != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Swap);
      if (this.Profit != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Profit);
      if (this.GuaranteedStopLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.GuaranteedStopLoss);
      if (this.StopOutEquity != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StopOutEquity);
      if (this.StopOutMargin != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StopOutMargin);
      if (this.TrailingStopTier1Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier1Threshold);
      if (this.TrailingStopTier1 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier1);
      if (this.TrailingStopTier2Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier2Threshold);
      if (this.TrailingStopTier2 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier2);
      if (this.TrailingStopTier3Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier3Threshold);
      if (this.TrailingStopTier3 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier3);
      if (this.PullbackTrailingStopTier1 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier1);
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier1Threshold);
      if (this.PullbackTrailingStopTier2 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier2);
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier2Threshold);
      if (this.PullbackTrailingStopTier3 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier3);
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier3Threshold);
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.Id);
      }
      if (this.OrderExecutionId != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.OrderExecutionId);
      }
      if (this.ParentOrderId != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.ParentOrderId);
      }
      if (this.CloseHedgedOrderId != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.CloseHedgedOrderId);
      }
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.AccountId);
      }
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Symbol);
      }
      if (this.OrderType != OrderTypeProto.Unknown)
      {
        output.WriteRawTag((byte) 56);
        output.WriteEnum((int) this.OrderType);
      }
      if (this.Lots != 0.0)
      {
        output.WriteRawTag((byte) 65);
        output.WriteDouble(this.Lots);
      }
      if (this.OpenTime != 0L)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt64(this.OpenTime);
      }
      if (this.LastExecutionTime != 0L)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt64(this.LastExecutionTime);
      }
      if (this.CloseTime != 0L)
      {
        output.WriteRawTag((byte) 88);
        output.WriteInt64(this.CloseTime);
      }
      if (this.State != OrderStateProto.UnknownState)
      {
        output.WriteRawTag((byte) 96);
        output.WriteEnum((int) this.State);
      }
      if (this.OrderTransactionType != OrderTransactionTypeProto.UnknownOrderTransactionType)
      {
        output.WriteRawTag((byte) 104);
        output.WriteEnum((int) this.OrderTransactionType);
      }
      if (this.MarginConversionRate != 0.0)
      {
        output.WriteRawTag((byte) 113);
        output.WriteDouble(this.MarginConversionRate);
      }
      if (this.OpenPrice != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.OpenPrice);
      }
      if (this.ProfitConversionRate != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 1);
        output.WriteDouble(this.ProfitConversionRate);
      }
      if (this.ClosePrice != 0.0)
      {
        output.WriteRawTag((byte) 137, (byte) 1);
        output.WriteDouble(this.ClosePrice);
      }
      if (this.StopLoss != 0.0)
      {
        output.WriteRawTag((byte) 145, (byte) 1);
        output.WriteDouble(this.StopLoss);
      }
      if (this.TakeProfit != 0.0)
      {
        output.WriteRawTag((byte) 153, (byte) 1);
        output.WriteDouble(this.TakeProfit);
      }
      if (this.Expiration != 0L)
      {
        output.WriteRawTag((byte) 160, (byte) 1);
        output.WriteInt64(this.Expiration);
      }
      if (this.Commission != 0.0)
      {
        output.WriteRawTag((byte) 169, (byte) 1);
        output.WriteDouble(this.Commission);
      }
      if (this.Swap != 0.0)
      {
        output.WriteRawTag((byte) 177, (byte) 1);
        output.WriteDouble(this.Swap);
      }
      if (this.Profit != 0.0)
      {
        output.WriteRawTag((byte) 185, (byte) 1);
        output.WriteDouble(this.Profit);
      }
      if (this.GuaranteedStopLoss != 0.0)
      {
        output.WriteRawTag((byte) 193, (byte) 1);
        output.WriteDouble(this.GuaranteedStopLoss);
      }
      if (this.StopOutEquity != 0.0)
      {
        output.WriteRawTag((byte) 201, (byte) 1);
        output.WriteDouble(this.StopOutEquity);
      }
      if (this.StopOutMargin != 0.0)
      {
        output.WriteRawTag((byte) 209, (byte) 1);
        output.WriteDouble(this.StopOutMargin);
      }
      if (this.TrailingStopTier1Threshold != 0.0)
      {
        output.WriteRawTag((byte) 217, (byte) 1);
        output.WriteDouble(this.TrailingStopTier1Threshold);
      }
      if (this.TrailingStopTier1 != 0.0)
      {
        output.WriteRawTag((byte) 225, (byte) 1);
        output.WriteDouble(this.TrailingStopTier1);
      }
      if (this.TrailingStopTier2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 233, (byte) 1);
        output.WriteDouble(this.TrailingStopTier2Threshold);
      }
      if (this.TrailingStopTier2 != 0.0)
      {
        output.WriteRawTag((byte) 241, (byte) 1);
        output.WriteDouble(this.TrailingStopTier2);
      }
      if (this.TrailingStopTier3Threshold != 0.0)
      {
        output.WriteRawTag((byte) 249, (byte) 1);
        output.WriteDouble(this.TrailingStopTier3Threshold);
      }
      if (this.TrailingStopTier3 != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 2);
        output.WriteDouble(this.TrailingStopTier3);
      }
      if (this.PullbackTrailingStopTier1 != 0.0)
      {
        output.WriteRawTag((byte) 137, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier1);
      }
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
      {
        output.WriteRawTag((byte) 145, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier1Threshold);
      }
      if (this.PullbackTrailingStopTier2 != 0.0)
      {
        output.WriteRawTag((byte) 153, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier2);
      }
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 161, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier2Threshold);
      }
      if (this.PullbackTrailingStopTier3 != 0.0)
      {
        output.WriteRawTag((byte) 169, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier3);
      }
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
      {
        output.WriteRawTag((byte) 177, (byte) 2);
        output.WriteDouble(this.PullbackTrailingStopTier3Threshold);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
      if (this.OrderExecutionId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OrderExecutionId);
      if (this.ParentOrderId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.ParentOrderId);
      if (this.CloseHedgedOrderId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.CloseHedgedOrderId);
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.OrderType != OrderTypeProto.Unknown)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.OrderType);
      if (this.Lots != 0.0)
        num += 9;
      if (this.OpenTime != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
      if (this.LastExecutionTime != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.LastExecutionTime);
      if (this.CloseTime != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.CloseTime);
      if (this.State != OrderStateProto.UnknownState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.OrderTransactionType != OrderTransactionTypeProto.UnknownOrderTransactionType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.OrderTransactionType);
      if (this.MarginConversionRate != 0.0)
        num += 9;
      if (this.OpenPrice != 0.0)
        num += 9;
      if (this.ProfitConversionRate != 0.0)
        num += 10;
      if (this.ClosePrice != 0.0)
        num += 10;
      if (this.StopLoss != 0.0)
        num += 10;
      if (this.TakeProfit != 0.0)
        num += 10;
      if (this.Expiration != 0L)
        num += 2 + CodedOutputStream.ComputeInt64Size(this.Expiration);
      if (this.Commission != 0.0)
        num += 10;
      if (this.Swap != 0.0)
        num += 10;
      if (this.Profit != 0.0)
        num += 10;
      if (this.GuaranteedStopLoss != 0.0)
        num += 10;
      if (this.StopOutEquity != 0.0)
        num += 10;
      if (this.StopOutMargin != 0.0)
        num += 10;
      if (this.TrailingStopTier1Threshold != 0.0)
        num += 10;
      if (this.TrailingStopTier1 != 0.0)
        num += 10;
      if (this.TrailingStopTier2Threshold != 0.0)
        num += 10;
      if (this.TrailingStopTier2 != 0.0)
        num += 10;
      if (this.TrailingStopTier3Threshold != 0.0)
        num += 10;
      if (this.TrailingStopTier3 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier1 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier2 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier3 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
        num += 10;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(OrderProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0L)
        this.Id = other.Id;
      if (other.OrderExecutionId != 0L)
        this.OrderExecutionId = other.OrderExecutionId;
      if (other.ParentOrderId != 0L)
        this.ParentOrderId = other.ParentOrderId;
      if (other.CloseHedgedOrderId != 0L)
        this.CloseHedgedOrderId = other.CloseHedgedOrderId;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.OrderType != OrderTypeProto.Unknown)
        this.OrderType = other.OrderType;
      if (other.Lots != 0.0)
        this.Lots = other.Lots;
      if (other.OpenTime != 0L)
        this.OpenTime = other.OpenTime;
      if (other.LastExecutionTime != 0L)
        this.LastExecutionTime = other.LastExecutionTime;
      if (other.CloseTime != 0L)
        this.CloseTime = other.CloseTime;
      if (other.State != OrderStateProto.UnknownState)
        this.State = other.State;
      if (other.OrderTransactionType != OrderTransactionTypeProto.UnknownOrderTransactionType)
        this.OrderTransactionType = other.OrderTransactionType;
      if (other.MarginConversionRate != 0.0)
        this.MarginConversionRate = other.MarginConversionRate;
      if (other.OpenPrice != 0.0)
        this.OpenPrice = other.OpenPrice;
      if (other.ProfitConversionRate != 0.0)
        this.ProfitConversionRate = other.ProfitConversionRate;
      if (other.ClosePrice != 0.0)
        this.ClosePrice = other.ClosePrice;
      if (other.StopLoss != 0.0)
        this.StopLoss = other.StopLoss;
      if (other.TakeProfit != 0.0)
        this.TakeProfit = other.TakeProfit;
      if (other.Expiration != 0L)
        this.Expiration = other.Expiration;
      if (other.Commission != 0.0)
        this.Commission = other.Commission;
      if (other.Swap != 0.0)
        this.Swap = other.Swap;
      if (other.Profit != 0.0)
        this.Profit = other.Profit;
      if (other.GuaranteedStopLoss != 0.0)
        this.GuaranteedStopLoss = other.GuaranteedStopLoss;
      if (other.StopOutEquity != 0.0)
        this.StopOutEquity = other.StopOutEquity;
      if (other.StopOutMargin != 0.0)
        this.StopOutMargin = other.StopOutMargin;
      if (other.TrailingStopTier1Threshold != 0.0)
        this.TrailingStopTier1Threshold = other.TrailingStopTier1Threshold;
      if (other.TrailingStopTier1 != 0.0)
        this.TrailingStopTier1 = other.TrailingStopTier1;
      if (other.TrailingStopTier2Threshold != 0.0)
        this.TrailingStopTier2Threshold = other.TrailingStopTier2Threshold;
      if (other.TrailingStopTier2 != 0.0)
        this.TrailingStopTier2 = other.TrailingStopTier2;
      if (other.TrailingStopTier3Threshold != 0.0)
        this.TrailingStopTier3Threshold = other.TrailingStopTier3Threshold;
      if (other.TrailingStopTier3 != 0.0)
        this.TrailingStopTier3 = other.TrailingStopTier3;
      if (other.PullbackTrailingStopTier1 != 0.0)
        this.PullbackTrailingStopTier1 = other.PullbackTrailingStopTier1;
      if (other.PullbackTrailingStopTier1Threshold != 0.0)
        this.PullbackTrailingStopTier1Threshold = other.PullbackTrailingStopTier1Threshold;
      if (other.PullbackTrailingStopTier2 != 0.0)
        this.PullbackTrailingStopTier2 = other.PullbackTrailingStopTier2;
      if (other.PullbackTrailingStopTier2Threshold != 0.0)
        this.PullbackTrailingStopTier2Threshold = other.PullbackTrailingStopTier2Threshold;
      if (other.PullbackTrailingStopTier3 != 0.0)
        this.PullbackTrailingStopTier3 = other.PullbackTrailingStopTier3;
      if (other.PullbackTrailingStopTier3Threshold != 0.0)
        this.PullbackTrailingStopTier3Threshold = other.PullbackTrailingStopTier3Threshold;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 8:
            this.Id = input.ReadInt64();
            continue;
          case 16:
            this.OrderExecutionId = input.ReadInt64();
            continue;
          case 24:
            this.ParentOrderId = input.ReadInt64();
            continue;
          case 32:
            this.CloseHedgedOrderId = input.ReadInt64();
            continue;
          case 40:
            this.AccountId = input.ReadInt32();
            continue;
          case 50:
            this.Symbol = input.ReadString();
            continue;
          case 56:
            this.OrderType = (OrderTypeProto) input.ReadEnum();
            continue;
          case 65:
            this.Lots = input.ReadDouble();
            continue;
          case 72:
            this.OpenTime = input.ReadInt64();
            continue;
          case 80:
            this.LastExecutionTime = input.ReadInt64();
            continue;
          case 88:
            this.CloseTime = input.ReadInt64();
            continue;
          case 96:
            this.State = (OrderStateProto) input.ReadEnum();
            continue;
          case 104:
            this.OrderTransactionType = (OrderTransactionTypeProto) input.ReadEnum();
            continue;
          case 113:
            this.MarginConversionRate = input.ReadDouble();
            continue;
          case 121:
            this.OpenPrice = input.ReadDouble();
            continue;
          case 129:
            this.ProfitConversionRate = input.ReadDouble();
            continue;
          case 137:
            this.ClosePrice = input.ReadDouble();
            continue;
          case 145:
            this.StopLoss = input.ReadDouble();
            continue;
          case 153:
            this.TakeProfit = input.ReadDouble();
            continue;
          case 160:
            this.Expiration = input.ReadInt64();
            continue;
          case 169:
            this.Commission = input.ReadDouble();
            continue;
          case 177:
            this.Swap = input.ReadDouble();
            continue;
          case 185:
            this.Profit = input.ReadDouble();
            continue;
          case 193:
            this.GuaranteedStopLoss = input.ReadDouble();
            continue;
          case 201:
            this.StopOutEquity = input.ReadDouble();
            continue;
          case 209:
            this.StopOutMargin = input.ReadDouble();
            continue;
          case 217:
            this.TrailingStopTier1Threshold = input.ReadDouble();
            continue;
          case 225:
            this.TrailingStopTier1 = input.ReadDouble();
            continue;
          case 233:
            this.TrailingStopTier2Threshold = input.ReadDouble();
            continue;
          case 241:
            this.TrailingStopTier2 = input.ReadDouble();
            continue;
          case 249:
            this.TrailingStopTier3Threshold = input.ReadDouble();
            continue;
          case 257:
            this.TrailingStopTier3 = input.ReadDouble();
            continue;
          case 265:
            this.PullbackTrailingStopTier1 = input.ReadDouble();
            continue;
          case 273:
            this.PullbackTrailingStopTier1Threshold = input.ReadDouble();
            continue;
          case 281:
            this.PullbackTrailingStopTier2 = input.ReadDouble();
            continue;
          case 289:
            this.PullbackTrailingStopTier2Threshold = input.ReadDouble();
            continue;
          case 297:
            this.PullbackTrailingStopTier3 = input.ReadDouble();
            continue;
          case 305:
            this.PullbackTrailingStopTier3Threshold = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
