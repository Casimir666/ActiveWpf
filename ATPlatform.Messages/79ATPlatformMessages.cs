// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TradeSettingsProto
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
  public sealed class TradeSettingsProto : 
    IMessage<TradeSettingsProto>,
    IMessage,
    IEquatable<TradeSettingsProto>,
    IDeepCloneable<TradeSettingsProto>
  {
    private static readonly MessageParser<TradeSettingsProto> _parser = new MessageParser<TradeSettingsProto>((Func<TradeSettingsProto>) (() => new TradeSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolGroupIdFieldNumber = 1;
    private int symbolGroupId_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int MaxLotsFieldNumber = 5;
    private double maxLots_;
    public const int MinLotsFieldNumber = 6;
    private double minLots_;
    public const int StepFieldNumber = 7;
    private double step_;
    public const int TradeTypeFieldNumber = 8;
    private TradeTypeProto tradeType_;
    public const int MarginTiersLotsCoefFieldNumber = 10;
    private double marginTiersLotsCoef_;
    public const int MarginTiersMarginCoefFieldNumber = 11;
    private double marginTiersMarginCoef_;
    public const int UseFixedMarginPercentageFieldNumber = 12;
    private bool useFixedMarginPercentage_;
    public const int Level2ThresholdFieldNumber = 13;
    private double level2Threshold_;
    public const int ApplySwapsFieldNumber = 14;
    private bool applySwaps_;
    public const int MaxPositionNotionalValueFieldNumber = 15;
    private double maxPositionNotionalValue_;
    public const int TagIdFieldNumber = 16;
    private int tagId_;

    [DebuggerNonUserCode]
    public static MessageParser<TradeSettingsProto> Parser => TradeSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[67];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TradeSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public TradeSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public TradeSettingsProto(TradeSettingsProto other)
      : this()
    {
      this.symbolGroupId_ = other.symbolGroupId_;
      this.symbolId_ = other.symbolId_;
      this.maxLots_ = other.maxLots_;
      this.minLots_ = other.minLots_;
      this.step_ = other.step_;
      this.tradeType_ = other.tradeType_;
      this.marginTiersLotsCoef_ = other.marginTiersLotsCoef_;
      this.marginTiersMarginCoef_ = other.marginTiersMarginCoef_;
      this.useFixedMarginPercentage_ = other.useFixedMarginPercentage_;
      this.level2Threshold_ = other.level2Threshold_;
      this.applySwaps_ = other.applySwaps_;
      this.maxPositionNotionalValue_ = other.maxPositionNotionalValue_;
      this.tagId_ = other.tagId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TradeSettingsProto Clone() => new TradeSettingsProto(this);

    [DebuggerNonUserCode]
    public int SymbolGroupId
    {
      get => this.symbolGroupId_;
      set => this.symbolGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double MaxLots
    {
      get => this.maxLots_;
      set => this.maxLots_ = value;
    }

    [DebuggerNonUserCode]
    public double MinLots
    {
      get => this.minLots_;
      set => this.minLots_ = value;
    }

    [DebuggerNonUserCode]
    public double Step
    {
      get => this.step_;
      set => this.step_ = value;
    }

    [DebuggerNonUserCode]
    public TradeTypeProto TradeType
    {
      get => this.tradeType_;
      set => this.tradeType_ = value;
    }

    [DebuggerNonUserCode]
    public double MarginTiersLotsCoef
    {
      get => this.marginTiersLotsCoef_;
      set => this.marginTiersLotsCoef_ = value;
    }

    [DebuggerNonUserCode]
    public double MarginTiersMarginCoef
    {
      get => this.marginTiersMarginCoef_;
      set => this.marginTiersMarginCoef_ = value;
    }

    [DebuggerNonUserCode]
    public bool UseFixedMarginPercentage
    {
      get => this.useFixedMarginPercentage_;
      set => this.useFixedMarginPercentage_ = value;
    }

    [DebuggerNonUserCode]
    public double Level2Threshold
    {
      get => this.level2Threshold_;
      set => this.level2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public bool ApplySwaps
    {
      get => this.applySwaps_;
      set => this.applySwaps_ = value;
    }

    [DebuggerNonUserCode]
    public double MaxPositionNotionalValue
    {
      get => this.maxPositionNotionalValue_;
      set => this.maxPositionNotionalValue_ = value;
    }

    [DebuggerNonUserCode]
    public int TagId
    {
      get => this.tagId_;
      set => this.tagId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TradeSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(TradeSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.SymbolGroupId == other.SymbolGroupId && !(this.SymbolId != other.SymbolId) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxLots, other.MaxLots) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinLots, other.MinLots)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Step, other.Step) && this.TradeType == other.TradeType && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MarginTiersLotsCoef, other.MarginTiersLotsCoef) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MarginTiersMarginCoef, other.MarginTiersMarginCoef))) && (this.UseFixedMarginPercentage == other.UseFixedMarginPercentage && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Level2Threshold, other.Level2Threshold) && (this.ApplySwaps == other.ApplySwaps && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxPositionNotionalValue, other.MaxPositionNotionalValue)) && this.TagId == other.TagId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.SymbolGroupId != 0)
      {
        int num3 = num1;
        num2 = this.SymbolGroupId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      if (this.MaxLots != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxLots);
      if (this.MinLots != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinLots);
      if (this.Step != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Step);
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
        num1 ^= this.TradeType.GetHashCode();
      if (this.MarginTiersLotsCoef != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MarginTiersLotsCoef);
      if (this.MarginTiersMarginCoef != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MarginTiersMarginCoef);
      bool flag;
      if (this.UseFixedMarginPercentage)
      {
        int num3 = num1;
        flag = this.UseFixedMarginPercentage;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Level2Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Level2Threshold);
      if (this.ApplySwaps)
      {
        int num3 = num1;
        flag = this.ApplySwaps;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MaxPositionNotionalValue != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxPositionNotionalValue);
      if (this.TagId != 0)
      {
        int num3 = num1;
        num2 = this.TagId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolGroupId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.SymbolGroupId);
      }
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.SymbolId);
      }
      if (this.MaxLots != 0.0)
      {
        output.WriteRawTag((byte) 41);
        output.WriteDouble(this.MaxLots);
      }
      if (this.MinLots != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.MinLots);
      }
      if (this.Step != 0.0)
      {
        output.WriteRawTag((byte) 57);
        output.WriteDouble(this.Step);
      }
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
      {
        output.WriteRawTag((byte) 64);
        output.WriteEnum((int) this.TradeType);
      }
      if (this.MarginTiersLotsCoef != 0.0)
      {
        output.WriteRawTag((byte) 81);
        output.WriteDouble(this.MarginTiersLotsCoef);
      }
      if (this.MarginTiersMarginCoef != 0.0)
      {
        output.WriteRawTag((byte) 89);
        output.WriteDouble(this.MarginTiersMarginCoef);
      }
      if (this.UseFixedMarginPercentage)
      {
        output.WriteRawTag((byte) 96);
        output.WriteBool(this.UseFixedMarginPercentage);
      }
      if (this.Level2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 105);
        output.WriteDouble(this.Level2Threshold);
      }
      if (this.ApplySwaps)
      {
        output.WriteRawTag((byte) 112);
        output.WriteBool(this.ApplySwaps);
      }
      if (this.MaxPositionNotionalValue != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.MaxPositionNotionalValue);
      }
      if (this.TagId != 0)
      {
        output.WriteRawTag((byte) 128, (byte) 1);
        output.WriteInt32(this.TagId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.SymbolGroupId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolGroupId);
      if (this.SymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this.MaxLots != 0.0)
        num += 9;
      if (this.MinLots != 0.0)
        num += 9;
      if (this.Step != 0.0)
        num += 9;
      if (this.TradeType != TradeTypeProto.UnknownTradeType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.TradeType);
      if (this.MarginTiersLotsCoef != 0.0)
        num += 9;
      if (this.MarginTiersMarginCoef != 0.0)
        num += 9;
      if (this.UseFixedMarginPercentage)
        num += 2;
      if (this.Level2Threshold != 0.0)
        num += 9;
      if (this.ApplySwaps)
        num += 2;
      if (this.MaxPositionNotionalValue != 0.0)
        num += 9;
      if (this.TagId != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.TagId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TradeSettingsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolGroupId != 0)
        this.SymbolGroupId = other.SymbolGroupId;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.MaxLots != 0.0)
        this.MaxLots = other.MaxLots;
      if (other.MinLots != 0.0)
        this.MinLots = other.MinLots;
      if (other.Step != 0.0)
        this.Step = other.Step;
      if (other.TradeType != TradeTypeProto.UnknownTradeType)
        this.TradeType = other.TradeType;
      if (other.MarginTiersLotsCoef != 0.0)
        this.MarginTiersLotsCoef = other.MarginTiersLotsCoef;
      if (other.MarginTiersMarginCoef != 0.0)
        this.MarginTiersMarginCoef = other.MarginTiersMarginCoef;
      if (other.UseFixedMarginPercentage)
        this.UseFixedMarginPercentage = other.UseFixedMarginPercentage;
      if (other.Level2Threshold != 0.0)
        this.Level2Threshold = other.Level2Threshold;
      if (other.ApplySwaps)
        this.ApplySwaps = other.ApplySwaps;
      if (other.MaxPositionNotionalValue != 0.0)
        this.MaxPositionNotionalValue = other.MaxPositionNotionalValue;
      if (other.TagId != 0)
        this.TagId = other.TagId;
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
            this.SymbolGroupId = input.ReadInt32();
            continue;
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          case 41:
            this.MaxLots = input.ReadDouble();
            continue;
          case 49:
            this.MinLots = input.ReadDouble();
            continue;
          case 57:
            this.Step = input.ReadDouble();
            continue;
          case 64:
            this.TradeType = (TradeTypeProto) input.ReadEnum();
            continue;
          case 81:
            this.MarginTiersLotsCoef = input.ReadDouble();
            continue;
          case 89:
            this.MarginTiersMarginCoef = input.ReadDouble();
            continue;
          case 96:
            this.UseFixedMarginPercentage = input.ReadBool();
            continue;
          case 105:
            this.Level2Threshold = input.ReadDouble();
            continue;
          case 112:
            this.ApplySwaps = input.ReadBool();
            continue;
          case 121:
            this.MaxPositionNotionalValue = input.ReadDouble();
            continue;
          case 128:
            this.TagId = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
