// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolProto
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
  public sealed class SymbolProto : 
    IMessage<SymbolProto>,
    IMessage,
    IEquatable<SymbolProto>,
    IDeepCloneable<SymbolProto>
  {
    private static readonly MessageParser<SymbolProto> _parser = new MessageParser<SymbolProto>((Func<SymbolProto>) (() => new SymbolProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    public const int SymbolGroupIdFieldNumber = 4;
    private int symbolGroupId_;
    public const int DigitsFieldNumber = 5;
    private int digits_;
    public const int BaseCurrencyIsoCodeFieldNumber = 6;
    private string baseCurrencyIsoCode_ = "";
    public const int ProfitCurrencyIsoCodeFieldNumber = 7;
    private string profitCurrencyIsoCode_ = "";
    public const int ContractSizeFieldNumber = 8;
    private int contractSize_;
    public const int ContractSizeDenominatorFieldNumber = 9;
    private int contractSizeDenominator_;
    public const int TickSizeFieldNumber = 10;
    private double tickSize_;
    public const int TickPriceFieldNumber = 11;
    private double tickPrice_;
    public const int TradeTypeFieldNumber = 12;
    private TradeTypeProto tradeType_;
    public const int HedgedMarginPercentageFieldNumber = 13;
    private int hedgedMarginPercentage_;
    public const int SwapTypeFieldNumber = 15;
    private SwapAmountTypeProto swapType_;
    public const int LongPositionsSwapFieldNumber = 16;
    private double longPositionsSwap_;
    public const int ShortPositionsSwapFieldNumber = 17;
    private double shortPositionsSwap_;
    public const int ThreeDaySwapFieldNumber = 18;
    private int threeDaySwap_;
    public const int StartingDateFieldNumber = 19;
    private long startingDate_;
    public const int ExpirationDateFieldNumber = 20;
    private long expirationDate_;
    public const int CategoryTypeFieldNumber = 21;
    private CategoryTypeProto categoryType_;
    public const int MinLotsFieldNumber = 22;
    private double minLots_;
    public const int MaxLotsFieldNumber = 23;
    private double maxLots_;
    public const int StepFieldNumber = 24;
    private double step_;
    public const int AvailableOnBridgeFieldNumber = 27;
    private bool availableOnBridge_;
    public const int OffQuotesThresholdSecondsFieldNumber = 28;
    private int offQuotesThresholdSeconds_;
    public const int CommissionGroupIdFieldNumber = 29;
    private int commissionGroupId_;
    public const int TargetSpreadFieldNumber = 30;
    private double targetSpread_;
    public const int AverageSpreadFieldNumber = 31;
    private double averageSpread_;
    public const int TrailingStopMaxRangeFieldNumber = 32;
    private double trailingStopMaxRange_;
    public const int TickSizeMultiplierFieldNumber = 33;
    private int tickSizeMultiplier_;
    public const int PriceUnitTypeFieldNumber = 34;
    private PriceUnitTypeProto priceUnitType_;
    public const int Level2ThresholdFieldNumber = 35;
    private double level2Threshold_;

    [DebuggerNonUserCode]
    public static MessageParser<SymbolProto> Parser => SymbolProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[47];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolProto(SymbolProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.description_ = other.description_;
      this.symbolGroupId_ = other.symbolGroupId_;
      this.digits_ = other.digits_;
      this.baseCurrencyIsoCode_ = other.baseCurrencyIsoCode_;
      this.profitCurrencyIsoCode_ = other.profitCurrencyIsoCode_;
      this.contractSize_ = other.contractSize_;
      this.contractSizeDenominator_ = other.contractSizeDenominator_;
      this.tickSize_ = other.tickSize_;
      this.tickPrice_ = other.tickPrice_;
      this.tradeType_ = other.tradeType_;
      this.hedgedMarginPercentage_ = other.hedgedMarginPercentage_;
      this.swapType_ = other.swapType_;
      this.longPositionsSwap_ = other.longPositionsSwap_;
      this.shortPositionsSwap_ = other.shortPositionsSwap_;
      this.threeDaySwap_ = other.threeDaySwap_;
      this.startingDate_ = other.startingDate_;
      this.expirationDate_ = other.expirationDate_;
      this.categoryType_ = other.categoryType_;
      this.minLots_ = other.minLots_;
      this.maxLots_ = other.maxLots_;
      this.step_ = other.step_;
      this.availableOnBridge_ = other.availableOnBridge_;
      this.offQuotesThresholdSeconds_ = other.offQuotesThresholdSeconds_;
      this.commissionGroupId_ = other.commissionGroupId_;
      this.targetSpread_ = other.targetSpread_;
      this.averageSpread_ = other.averageSpread_;
      this.trailingStopMaxRange_ = other.trailingStopMaxRange_;
      this.tickSizeMultiplier_ = other.tickSizeMultiplier_;
      this.priceUnitType_ = other.priceUnitType_;
      this.level2Threshold_ = other.level2Threshold_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolProto Clone() => new SymbolProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Description
    {
      get => this.description_;
      set => this.description_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int SymbolGroupId
    {
      get => this.symbolGroupId_;
      set => this.symbolGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public int Digits
    {
      get => this.digits_;
      set => this.digits_ = value;
    }

    [DebuggerNonUserCode]
    public string BaseCurrencyIsoCode
    {
      get => this.baseCurrencyIsoCode_;
      set => this.baseCurrencyIsoCode_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string ProfitCurrencyIsoCode
    {
      get => this.profitCurrencyIsoCode_;
      set => this.profitCurrencyIsoCode_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int ContractSize
    {
      get => this.contractSize_;
      set => this.contractSize_ = value;
    }

    [DebuggerNonUserCode]
    public int ContractSizeDenominator
    {
      get => this.contractSizeDenominator_;
      set => this.contractSizeDenominator_ = value;
    }

    [DebuggerNonUserCode]
    public double TickSize
    {
      get => this.tickSize_;
      set => this.tickSize_ = value;
    }

    [DebuggerNonUserCode]
    public double TickPrice
    {
      get => this.tickPrice_;
      set => this.tickPrice_ = value;
    }

    [DebuggerNonUserCode]
    public TradeTypeProto TradeType
    {
      get => this.tradeType_;
      set => this.tradeType_ = value;
    }

    [DebuggerNonUserCode]
    public int HedgedMarginPercentage
    {
      get => this.hedgedMarginPercentage_;
      set => this.hedgedMarginPercentage_ = value;
    }

    [DebuggerNonUserCode]
    public SwapAmountTypeProto SwapType
    {
      get => this.swapType_;
      set => this.swapType_ = value;
    }

    [DebuggerNonUserCode]
    public double LongPositionsSwap
    {
      get => this.longPositionsSwap_;
      set => this.longPositionsSwap_ = value;
    }

    [DebuggerNonUserCode]
    public double ShortPositionsSwap
    {
      get => this.shortPositionsSwap_;
      set => this.shortPositionsSwap_ = value;
    }

    [DebuggerNonUserCode]
    public int ThreeDaySwap
    {
      get => this.threeDaySwap_;
      set => this.threeDaySwap_ = value;
    }

    [DebuggerNonUserCode]
    public long StartingDate
    {
      get => this.startingDate_;
      set => this.startingDate_ = value;
    }

    [DebuggerNonUserCode]
    public long ExpirationDate
    {
      get => this.expirationDate_;
      set => this.expirationDate_ = value;
    }

    [DebuggerNonUserCode]
    public CategoryTypeProto CategoryType
    {
      get => this.categoryType_;
      set => this.categoryType_ = value;
    }

    [DebuggerNonUserCode]
    public double MinLots
    {
      get => this.minLots_;
      set => this.minLots_ = value;
    }

    [DebuggerNonUserCode]
    public double MaxLots
    {
      get => this.maxLots_;
      set => this.maxLots_ = value;
    }

    [DebuggerNonUserCode]
    public double Step
    {
      get => this.step_;
      set => this.step_ = value;
    }

    [DebuggerNonUserCode]
    public bool AvailableOnBridge
    {
      get => this.availableOnBridge_;
      set => this.availableOnBridge_ = value;
    }

    [DebuggerNonUserCode]
    public int OffQuotesThresholdSeconds
    {
      get => this.offQuotesThresholdSeconds_;
      set => this.offQuotesThresholdSeconds_ = value;
    }

    [DebuggerNonUserCode]
    public int CommissionGroupId
    {
      get => this.commissionGroupId_;
      set => this.commissionGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public double TargetSpread
    {
      get => this.targetSpread_;
      set => this.targetSpread_ = value;
    }

    [DebuggerNonUserCode]
    public double AverageSpread
    {
      get => this.averageSpread_;
      set => this.averageSpread_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopMaxRange
    {
      get => this.trailingStopMaxRange_;
      set => this.trailingStopMaxRange_ = value;
    }

    [DebuggerNonUserCode]
    public int TickSizeMultiplier
    {
      get => this.tickSizeMultiplier_;
      set => this.tickSizeMultiplier_ = value;
    }

    [DebuggerNonUserCode]
    public PriceUnitTypeProto PriceUnitType
    {
      get => this.priceUnitType_;
      set => this.priceUnitType_ = value;
    }

    [DebuggerNonUserCode]
    public double Level2Threshold
    {
      get => this.level2Threshold_;
      set => this.level2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && !(this.Description != other.Description) && (this.SymbolGroupId == other.SymbolGroupId && this.Digits == other.Digits) && (!(this.BaseCurrencyIsoCode != other.BaseCurrencyIsoCode) && !(this.ProfitCurrencyIsoCode != other.ProfitCurrencyIsoCode) && (this.ContractSize == other.ContractSize && this.ContractSizeDenominator == other.ContractSizeDenominator)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TickSize, other.TickSize) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TickPrice, other.TickPrice) && (this.TradeType == other.TradeType && this.HedgedMarginPercentage == other.HedgedMarginPercentage) && (this.SwapType == other.SwapType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LongPositionsSwap, other.LongPositionsSwap) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ShortPositionsSwap, other.ShortPositionsSwap) && this.ThreeDaySwap == other.ThreeDaySwap))) && (this.StartingDate == other.StartingDate && this.ExpirationDate == other.ExpirationDate && (this.CategoryType == other.CategoryType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinLots, other.MinLots)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxLots, other.MaxLots) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Step, other.Step) && (this.AvailableOnBridge == other.AvailableOnBridge && this.OffQuotesThresholdSeconds == other.OffQuotesThresholdSeconds)) && (this.CommissionGroupId == other.CommissionGroupId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TargetSpread, other.TargetSpread) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AverageSpread, other.AverageSpread) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopMaxRange, other.TrailingStopMaxRange)) && (this.TickSizeMultiplier == other.TickSizeMultiplier && this.PriceUnitType == other.PriceUnitType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Level2Threshold, other.Level2Threshold)))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.SymbolId.Length != 0)
        num ^= this.SymbolId.GetHashCode();
      if (this.Description.Length != 0)
        num ^= this.Description.GetHashCode();
      if (this.SymbolGroupId != 0)
        num ^= this.SymbolGroupId.GetHashCode();
      if (this.Digits != 0)
        num ^= this.Digits.GetHashCode();
      if (this.BaseCurrencyIsoCode.Length != 0)
        num ^= this.BaseCurrencyIsoCode.GetHashCode();
      if (this.ProfitCurrencyIsoCode.Length != 0)
        num ^= this.ProfitCurrencyIsoCode.GetHashCode();
      if (this.ContractSize != 0)
        num ^= this.ContractSize.GetHashCode();
      if (this.ContractSizeDenominator != 0)
        num ^= this.ContractSizeDenominator.GetHashCode();
      if (this.TickSize != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TickSize);
      if (this.TickPrice != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TickPrice);
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
        num ^= this.TradeType.GetHashCode();
      if (this.HedgedMarginPercentage != 0)
        num ^= this.HedgedMarginPercentage.GetHashCode();
      if (this.SwapType != SwapAmountTypeProto.NoSwap)
        num ^= this.SwapType.GetHashCode();
      if (this.LongPositionsSwap != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LongPositionsSwap);
      if (this.ShortPositionsSwap != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ShortPositionsSwap);
      if (this.ThreeDaySwap != 0)
        num ^= this.ThreeDaySwap.GetHashCode();
      if (this.StartingDate != 0L)
        num ^= this.StartingDate.GetHashCode();
      if (this.ExpirationDate != 0L)
        num ^= this.ExpirationDate.GetHashCode();
      if (this.CategoryType != CategoryTypeProto.UndefinedCategoryType)
        num ^= this.CategoryType.GetHashCode();
      if (this.MinLots != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinLots);
      if (this.MaxLots != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxLots);
      if (this.Step != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Step);
      if (this.AvailableOnBridge)
        num ^= this.AvailableOnBridge.GetHashCode();
      if (this.OffQuotesThresholdSeconds != 0)
        num ^= this.OffQuotesThresholdSeconds.GetHashCode();
      if (this.CommissionGroupId != 0)
        num ^= this.CommissionGroupId.GetHashCode();
      if (this.TargetSpread != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TargetSpread);
      if (this.AverageSpread != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AverageSpread);
      if (this.TrailingStopMaxRange != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopMaxRange);
      if (this.TickSizeMultiplier != 0)
        num ^= this.TickSizeMultiplier.GetHashCode();
      if (this.PriceUnitType != PriceUnitTypeProto.UnknownPriceUnitType)
        num ^= this.PriceUnitType.GetHashCode();
      if (this.Level2Threshold != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Level2Threshold);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.SymbolId);
      }
      if (this.Description.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Description);
      }
      if (this.SymbolGroupId != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.SymbolGroupId);
      }
      if (this.Digits != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.Digits);
      }
      if (this.BaseCurrencyIsoCode.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.BaseCurrencyIsoCode);
      }
      if (this.ProfitCurrencyIsoCode.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.ProfitCurrencyIsoCode);
      }
      if (this.ContractSize != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.ContractSize);
      }
      if (this.ContractSizeDenominator != 0)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt32(this.ContractSizeDenominator);
      }
      if (this.TickSize != 0.0)
      {
        output.WriteRawTag((byte) 81);
        output.WriteDouble(this.TickSize);
      }
      if (this.TickPrice != 0.0)
      {
        output.WriteRawTag((byte) 89);
        output.WriteDouble(this.TickPrice);
      }
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
      {
        output.WriteRawTag((byte) 96);
        output.WriteEnum((int) this.TradeType);
      }
      if (this.HedgedMarginPercentage != 0)
      {
        output.WriteRawTag((byte) 104);
        output.WriteInt32(this.HedgedMarginPercentage);
      }
      if (this.SwapType != SwapAmountTypeProto.NoSwap)
      {
        output.WriteRawTag((byte) 120);
        output.WriteEnum((int) this.SwapType);
      }
      if (this.LongPositionsSwap != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 1);
        output.WriteDouble(this.LongPositionsSwap);
      }
      if (this.ShortPositionsSwap != 0.0)
      {
        output.WriteRawTag((byte) 137, (byte) 1);
        output.WriteDouble(this.ShortPositionsSwap);
      }
      if (this.ThreeDaySwap != 0)
      {
        output.WriteRawTag((byte) 144, (byte) 1);
        output.WriteInt32(this.ThreeDaySwap);
      }
      if (this.StartingDate != 0L)
      {
        output.WriteRawTag((byte) 152, (byte) 1);
        output.WriteInt64(this.StartingDate);
      }
      if (this.ExpirationDate != 0L)
      {
        output.WriteRawTag((byte) 160, (byte) 1);
        output.WriteInt64(this.ExpirationDate);
      }
      if (this.CategoryType != CategoryTypeProto.UndefinedCategoryType)
      {
        output.WriteRawTag((byte) 168, (byte) 1);
        output.WriteEnum((int) this.CategoryType);
      }
      if (this.MinLots != 0.0)
      {
        output.WriteRawTag((byte) 177, (byte) 1);
        output.WriteDouble(this.MinLots);
      }
      if (this.MaxLots != 0.0)
      {
        output.WriteRawTag((byte) 185, (byte) 1);
        output.WriteDouble(this.MaxLots);
      }
      if (this.Step != 0.0)
      {
        output.WriteRawTag((byte) 193, (byte) 1);
        output.WriteDouble(this.Step);
      }
      if (this.AvailableOnBridge)
      {
        output.WriteRawTag((byte) 216, (byte) 1);
        output.WriteBool(this.AvailableOnBridge);
      }
      if (this.OffQuotesThresholdSeconds != 0)
      {
        output.WriteRawTag((byte) 224, (byte) 1);
        output.WriteInt32(this.OffQuotesThresholdSeconds);
      }
      if (this.CommissionGroupId != 0)
      {
        output.WriteRawTag((byte) 232, (byte) 1);
        output.WriteInt32(this.CommissionGroupId);
      }
      if (this.TargetSpread != 0.0)
      {
        output.WriteRawTag((byte) 241, (byte) 1);
        output.WriteDouble(this.TargetSpread);
      }
      if (this.AverageSpread != 0.0)
      {
        output.WriteRawTag((byte) 249, (byte) 1);
        output.WriteDouble(this.AverageSpread);
      }
      if (this.TrailingStopMaxRange != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 2);
        output.WriteDouble(this.TrailingStopMaxRange);
      }
      if (this.TickSizeMultiplier != 0)
      {
        output.WriteRawTag((byte) 136, (byte) 2);
        output.WriteInt32(this.TickSizeMultiplier);
      }
      if (this.PriceUnitType != PriceUnitTypeProto.UnknownPriceUnitType)
      {
        output.WriteRawTag((byte) 144, (byte) 2);
        output.WriteEnum((int) this.PriceUnitType);
      }
      if (this.Level2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 153, (byte) 2);
        output.WriteDouble(this.Level2Threshold);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.SymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this.Description.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
      if (this.SymbolGroupId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolGroupId);
      if (this.Digits != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Digits);
      if (this.BaseCurrencyIsoCode.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.BaseCurrencyIsoCode);
      if (this.ProfitCurrencyIsoCode.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.ProfitCurrencyIsoCode);
      if (this.ContractSize != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.ContractSize);
      if (this.ContractSizeDenominator != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.ContractSizeDenominator);
      if (this.TickSize != 0.0)
        num += 9;
      if (this.TickPrice != 0.0)
        num += 9;
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.TradeType);
      if (this.HedgedMarginPercentage != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.HedgedMarginPercentage);
      if (this.SwapType != SwapAmountTypeProto.NoSwap)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.SwapType);
      if (this.LongPositionsSwap != 0.0)
        num += 10;
      if (this.ShortPositionsSwap != 0.0)
        num += 10;
      if (this.ThreeDaySwap != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.ThreeDaySwap);
      if (this.StartingDate != 0L)
        num += 2 + CodedOutputStream.ComputeInt64Size(this.StartingDate);
      if (this.ExpirationDate != 0L)
        num += 2 + CodedOutputStream.ComputeInt64Size(this.ExpirationDate);
      if (this.CategoryType != CategoryTypeProto.UndefinedCategoryType)
        num += 2 + CodedOutputStream.ComputeEnumSize((int) this.CategoryType);
      if (this.MinLots != 0.0)
        num += 10;
      if (this.MaxLots != 0.0)
        num += 10;
      if (this.Step != 0.0)
        num += 10;
      if (this.AvailableOnBridge)
        num += 3;
      if (this.OffQuotesThresholdSeconds != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.OffQuotesThresholdSeconds);
      if (this.CommissionGroupId != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.CommissionGroupId);
      if (this.TargetSpread != 0.0)
        num += 10;
      if (this.AverageSpread != 0.0)
        num += 10;
      if (this.TrailingStopMaxRange != 0.0)
        num += 10;
      if (this.TickSizeMultiplier != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.TickSizeMultiplier);
      if (this.PriceUnitType != PriceUnitTypeProto.UnknownPriceUnitType)
        num += 2 + CodedOutputStream.ComputeEnumSize((int) this.PriceUnitType);
      if (this.Level2Threshold != 0.0)
        num += 10;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.Description.Length != 0)
        this.Description = other.Description;
      if (other.SymbolGroupId != 0)
        this.SymbolGroupId = other.SymbolGroupId;
      if (other.Digits != 0)
        this.Digits = other.Digits;
      if (other.BaseCurrencyIsoCode.Length != 0)
        this.BaseCurrencyIsoCode = other.BaseCurrencyIsoCode;
      if (other.ProfitCurrencyIsoCode.Length != 0)
        this.ProfitCurrencyIsoCode = other.ProfitCurrencyIsoCode;
      if (other.ContractSize != 0)
        this.ContractSize = other.ContractSize;
      if (other.ContractSizeDenominator != 0)
        this.ContractSizeDenominator = other.ContractSizeDenominator;
      if (other.TickSize != 0.0)
        this.TickSize = other.TickSize;
      if (other.TickPrice != 0.0)
        this.TickPrice = other.TickPrice;
      if (other.TradeType != TradeTypeProto.UnknownTradeType)
        this.TradeType = other.TradeType;
      if (other.HedgedMarginPercentage != 0)
        this.HedgedMarginPercentage = other.HedgedMarginPercentage;
      if (other.SwapType != SwapAmountTypeProto.NoSwap)
        this.SwapType = other.SwapType;
      if (other.LongPositionsSwap != 0.0)
        this.LongPositionsSwap = other.LongPositionsSwap;
      if (other.ShortPositionsSwap != 0.0)
        this.ShortPositionsSwap = other.ShortPositionsSwap;
      if (other.ThreeDaySwap != 0)
        this.ThreeDaySwap = other.ThreeDaySwap;
      if (other.StartingDate != 0L)
        this.StartingDate = other.StartingDate;
      if (other.ExpirationDate != 0L)
        this.ExpirationDate = other.ExpirationDate;
      if (other.CategoryType != CategoryTypeProto.UndefinedCategoryType)
        this.CategoryType = other.CategoryType;
      if (other.MinLots != 0.0)
        this.MinLots = other.MinLots;
      if (other.MaxLots != 0.0)
        this.MaxLots = other.MaxLots;
      if (other.Step != 0.0)
        this.Step = other.Step;
      if (other.AvailableOnBridge)
        this.AvailableOnBridge = other.AvailableOnBridge;
      if (other.OffQuotesThresholdSeconds != 0)
        this.OffQuotesThresholdSeconds = other.OffQuotesThresholdSeconds;
      if (other.CommissionGroupId != 0)
        this.CommissionGroupId = other.CommissionGroupId;
      if (other.TargetSpread != 0.0)
        this.TargetSpread = other.TargetSpread;
      if (other.AverageSpread != 0.0)
        this.AverageSpread = other.AverageSpread;
      if (other.TrailingStopMaxRange != 0.0)
        this.TrailingStopMaxRange = other.TrailingStopMaxRange;
      if (other.TickSizeMultiplier != 0)
        this.TickSizeMultiplier = other.TickSizeMultiplier;
      if (other.PriceUnitType != PriceUnitTypeProto.UnknownPriceUnitType)
        this.PriceUnitType = other.PriceUnitType;
      if (other.Level2Threshold != 0.0)
        this.Level2Threshold = other.Level2Threshold;
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
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          case 26:
            this.Description = input.ReadString();
            continue;
          case 32:
            this.SymbolGroupId = input.ReadInt32();
            continue;
          case 40:
            this.Digits = input.ReadInt32();
            continue;
          case 50:
            this.BaseCurrencyIsoCode = input.ReadString();
            continue;
          case 58:
            this.ProfitCurrencyIsoCode = input.ReadString();
            continue;
          case 64:
            this.ContractSize = input.ReadInt32();
            continue;
          case 72:
            this.ContractSizeDenominator = input.ReadInt32();
            continue;
          case 81:
            this.TickSize = input.ReadDouble();
            continue;
          case 89:
            this.TickPrice = input.ReadDouble();
            continue;
          case 96:
            this.TradeType = (TradeTypeProto) input.ReadEnum();
            continue;
          case 104:
            this.HedgedMarginPercentage = input.ReadInt32();
            continue;
          case 120:
            this.SwapType = (SwapAmountTypeProto) input.ReadEnum();
            continue;
          case 129:
            this.LongPositionsSwap = input.ReadDouble();
            continue;
          case 137:
            this.ShortPositionsSwap = input.ReadDouble();
            continue;
          case 144:
            this.ThreeDaySwap = input.ReadInt32();
            continue;
          case 152:
            this.StartingDate = input.ReadInt64();
            continue;
          case 160:
            this.ExpirationDate = input.ReadInt64();
            continue;
          case 168:
            this.CategoryType = (CategoryTypeProto) input.ReadEnum();
            continue;
          case 177:
            this.MinLots = input.ReadDouble();
            continue;
          case 185:
            this.MaxLots = input.ReadDouble();
            continue;
          case 193:
            this.Step = input.ReadDouble();
            continue;
          case 216:
            this.AvailableOnBridge = input.ReadBool();
            continue;
          case 224:
            this.OffQuotesThresholdSeconds = input.ReadInt32();
            continue;
          case 232:
            this.CommissionGroupId = input.ReadInt32();
            continue;
          case 241:
            this.TargetSpread = input.ReadDouble();
            continue;
          case 249:
            this.AverageSpread = input.ReadDouble();
            continue;
          case 257:
            this.TrailingStopMaxRange = input.ReadDouble();
            continue;
          case 264:
            this.TickSizeMultiplier = input.ReadInt32();
            continue;
          case 272:
            this.PriceUnitType = (PriceUnitTypeProto) input.ReadEnum();
            continue;
          case 281:
            this.Level2Threshold = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
