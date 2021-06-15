// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ExposureProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ExposureProto : 
    IMessage<ExposureProto>,
    IMessage,
    IEquatable<ExposureProto>,
    IDeepCloneable<ExposureProto>
  {
    private static readonly MessageParser<ExposureProto> _parser = new MessageParser<ExposureProto>((Func<ExposureProto>) (() => new ExposureProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int LotsBuyFieldNumber = 2;
    private double lotsBuy_;
    public const int LotsSellFieldNumber = 3;
    private double lotsSell_;
    public const int PositionsBuyFieldNumber = 4;
    private int positionsBuy_;
    public const int PositionsSellFieldNumber = 5;
    private int positionsSell_;
    public const int OpenPriceWeightedAverageFieldNumber = 6;
    private double openPriceWeightedAverage_;
    public const int AccountsBuyFieldNumber = 7;
    private static readonly FieldCodec<long> _repeated_accountsBuy_codec = FieldCodec.ForInt64(58U);
    private readonly RepeatedField<long> accountsBuy_ = new RepeatedField<long>();
    public const int AccountsSellFieldNumber = 8;
    private static readonly FieldCodec<long> _repeated_accountsSell_codec = FieldCodec.ForInt64(66U);
    private readonly RepeatedField<long> accountsSell_ = new RepeatedField<long>();

    [DebuggerNonUserCode]
    public static MessageParser<ExposureProto> Parser => ExposureProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[181];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ExposureProto.Descriptor;

    [DebuggerNonUserCode]
    public ExposureProto()
    {
    }

    [DebuggerNonUserCode]
    public ExposureProto(ExposureProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.lotsBuy_ = other.lotsBuy_;
      this.lotsSell_ = other.lotsSell_;
      this.positionsBuy_ = other.positionsBuy_;
      this.positionsSell_ = other.positionsSell_;
      this.openPriceWeightedAverage_ = other.openPriceWeightedAverage_;
      this.accountsBuy_ = other.accountsBuy_.Clone();
      this.accountsSell_ = other.accountsSell_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ExposureProto Clone() => new ExposureProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double LotsBuy
    {
      get => this.lotsBuy_;
      set => this.lotsBuy_ = value;
    }

    [DebuggerNonUserCode]
    public double LotsSell
    {
      get => this.lotsSell_;
      set => this.lotsSell_ = value;
    }

    [DebuggerNonUserCode]
    public int PositionsBuy
    {
      get => this.positionsBuy_;
      set => this.positionsBuy_ = value;
    }

    [DebuggerNonUserCode]
    public int PositionsSell
    {
      get => this.positionsSell_;
      set => this.positionsSell_ = value;
    }

    [DebuggerNonUserCode]
    public double OpenPriceWeightedAverage
    {
      get => this.openPriceWeightedAverage_;
      set => this.openPriceWeightedAverage_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<long> AccountsBuy => this.accountsBuy_;

    [DebuggerNonUserCode]
    public RepeatedField<long> AccountsSell => this.accountsSell_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ExposureProto);

    [DebuggerNonUserCode]
    public bool Equals(ExposureProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LotsBuy, other.LotsBuy) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LotsSell, other.LotsSell) && this.PositionsBuy == other.PositionsBuy) && (this.PositionsSell == other.PositionsSell && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.OpenPriceWeightedAverage, other.OpenPriceWeightedAverage) && (this.accountsBuy_.Equals(other.accountsBuy_) && this.accountsSell_.Equals(other.accountsSell_))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Symbol.Length != 0)
        num1 ^= this.Symbol.GetHashCode();
      if (this.LotsBuy != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LotsBuy);
      if (this.LotsSell != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LotsSell);
      if (this.PositionsBuy != 0)
        num1 ^= this.PositionsBuy.GetHashCode();
      if (this.PositionsSell != 0)
        num1 ^= this.PositionsSell.GetHashCode();
      if (this.OpenPriceWeightedAverage != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.OpenPriceWeightedAverage);
      int num2 = num1 ^ this.accountsBuy_.GetHashCode() ^ this.accountsSell_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.Symbol);
      }
      if (this.LotsBuy != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.LotsBuy);
      }
      if (this.LotsSell != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.LotsSell);
      }
      if (this.PositionsBuy != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.PositionsBuy);
      }
      if (this.PositionsSell != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.PositionsSell);
      }
      if (this.OpenPriceWeightedAverage != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.OpenPriceWeightedAverage);
      }
      this.accountsBuy_.WriteTo(output, ExposureProto._repeated_accountsBuy_codec);
      this.accountsSell_.WriteTo(output, ExposureProto._repeated_accountsSell_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Symbol.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.LotsBuy != 0.0)
        num1 += 9;
      if (this.LotsSell != 0.0)
        num1 += 9;
      if (this.PositionsBuy != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.PositionsBuy);
      if (this.PositionsSell != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.PositionsSell);
      if (this.OpenPriceWeightedAverage != 0.0)
        num1 += 9;
      int num2 = num1 + this.accountsBuy_.CalculateSize(ExposureProto._repeated_accountsBuy_codec) + this.accountsSell_.CalculateSize(ExposureProto._repeated_accountsSell_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ExposureProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.LotsBuy != 0.0)
        this.LotsBuy = other.LotsBuy;
      if (other.LotsSell != 0.0)
        this.LotsSell = other.LotsSell;
      if (other.PositionsBuy != 0)
        this.PositionsBuy = other.PositionsBuy;
      if (other.PositionsSell != 0)
        this.PositionsSell = other.PositionsSell;
      if (other.OpenPriceWeightedAverage != 0.0)
        this.OpenPriceWeightedAverage = other.OpenPriceWeightedAverage;
      this.accountsBuy_.Add((IEnumerable<long>) other.accountsBuy_);
      this.accountsSell_.Add((IEnumerable<long>) other.accountsSell_);
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
          case 10:
            this.Symbol = input.ReadString();
            continue;
          case 17:
            this.LotsBuy = input.ReadDouble();
            continue;
          case 25:
            this.LotsSell = input.ReadDouble();
            continue;
          case 32:
            this.PositionsBuy = input.ReadInt32();
            continue;
          case 40:
            this.PositionsSell = input.ReadInt32();
            continue;
          case 49:
            this.OpenPriceWeightedAverage = input.ReadDouble();
            continue;
          case 56:
          case 58:
            this.accountsBuy_.AddEntriesFrom(input, ExposureProto._repeated_accountsBuy_codec);
            continue;
          case 64:
          case 66:
            this.accountsSell_.AddEntriesFrom(input, ExposureProto._repeated_accountsSell_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
