// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetOrdersFilterProto
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
  public sealed class GetOrdersFilterProto : 
    IMessage<GetOrdersFilterProto>,
    IMessage,
    IEquatable<GetOrdersFilterProto>,
    IDeepCloneable<GetOrdersFilterProto>
  {
    private static readonly MessageParser<GetOrdersFilterProto> _parser = new MessageParser<GetOrdersFilterProto>((Func<GetOrdersFilterProto>) (() => new GetOrdersFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int OpenStartDateFieldNumber = 1;
    private long openStartDate_;
    public const int OpenEndDateFieldNumber = 2;
    private long openEndDate_;
    public const int CloseStartDateFieldNumber = 3;
    private long closeStartDate_;
    public const int CloseEndDateFieldNumber = 4;
    private long closeEndDate_;
    public const int SymbolsFieldNumber = 5;
    private static readonly FieldCodec<string> _repeated_symbols_codec = FieldCodec.ForString(42U);
    private readonly RepeatedField<string> symbols_ = new RepeatedField<string>();
    public const int AccountIdsFieldNumber = 6;
    private static readonly FieldCodec<int> _repeated_accountIds_codec = FieldCodec.ForInt32(50U);
    private readonly RepeatedField<int> accountIds_ = new RepeatedField<int>();
    public const int MinLotsFieldNumber = 7;
    private double minLots_;
    public const int MaxLotsFieldNumber = 8;
    private double maxLots_;
    public const int OrderCurrentStatesFieldNumber = 9;
    private static readonly FieldCodec<OrderStateProto> _repeated_orderCurrentStates_codec = FieldCodec.ForEnum<OrderStateProto>(74U, (Func<OrderStateProto, int>) (x => (int) x), (Func<int, OrderStateProto>) (x => (OrderStateProto) x));
    private readonly RepeatedField<OrderStateProto> orderCurrentStates_ = new RepeatedField<OrderStateProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetOrdersFilterProto> Parser => GetOrdersFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[15];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetOrdersFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetOrdersFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetOrdersFilterProto(GetOrdersFilterProto other)
      : this()
    {
      this.openStartDate_ = other.openStartDate_;
      this.openEndDate_ = other.openEndDate_;
      this.closeStartDate_ = other.closeStartDate_;
      this.closeEndDate_ = other.closeEndDate_;
      this.symbols_ = other.symbols_.Clone();
      this.accountIds_ = other.accountIds_.Clone();
      this.minLots_ = other.minLots_;
      this.maxLots_ = other.maxLots_;
      this.orderCurrentStates_ = other.orderCurrentStates_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetOrdersFilterProto Clone() => new GetOrdersFilterProto(this);

    [DebuggerNonUserCode]
    public long OpenStartDate
    {
      get => this.openStartDate_;
      set => this.openStartDate_ = value;
    }

    [DebuggerNonUserCode]
    public long OpenEndDate
    {
      get => this.openEndDate_;
      set => this.openEndDate_ = value;
    }

    [DebuggerNonUserCode]
    public long CloseStartDate
    {
      get => this.closeStartDate_;
      set => this.closeStartDate_ = value;
    }

    [DebuggerNonUserCode]
    public long CloseEndDate
    {
      get => this.closeEndDate_;
      set => this.closeEndDate_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public RepeatedField<int> AccountIds => this.accountIds_;

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
    public RepeatedField<OrderStateProto> OrderCurrentStates => this.orderCurrentStates_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetOrdersFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetOrdersFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.OpenStartDate == other.OpenStartDate && this.OpenEndDate == other.OpenEndDate && (this.CloseStartDate == other.CloseStartDate && this.CloseEndDate == other.CloseEndDate) && (this.symbols_.Equals(other.symbols_) && this.accountIds_.Equals(other.accountIds_) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinLots, other.MinLots) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxLots, other.MaxLots))) && this.orderCurrentStates_.Equals(other.orderCurrentStates_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      long num2;
      if (this.OpenStartDate != 0L)
      {
        int num3 = num1;
        num2 = this.OpenStartDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.OpenEndDate != 0L)
      {
        int num3 = num1;
        num2 = this.OpenEndDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CloseStartDate != 0L)
      {
        int num3 = num1;
        num2 = this.CloseStartDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CloseEndDate != 0L)
      {
        int num3 = num1;
        num2 = this.CloseEndDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      int num4 = num1 ^ this.symbols_.GetHashCode() ^ this.accountIds_.GetHashCode();
      if (this.MinLots != 0.0)
        num4 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinLots);
      if (this.MaxLots != 0.0)
        num4 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxLots);
      int num5 = num4 ^ this.orderCurrentStates_.GetHashCode();
      if (this._unknownFields != null)
        num5 ^= this._unknownFields.GetHashCode();
      return num5;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.OpenStartDate != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.OpenStartDate);
      }
      if (this.OpenEndDate != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.OpenEndDate);
      }
      if (this.CloseStartDate != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.CloseStartDate);
      }
      if (this.CloseEndDate != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.CloseEndDate);
      }
      this.symbols_.WriteTo(output, GetOrdersFilterProto._repeated_symbols_codec);
      this.accountIds_.WriteTo(output, GetOrdersFilterProto._repeated_accountIds_codec);
      if (this.MinLots != 0.0)
      {
        output.WriteRawTag((byte) 57);
        output.WriteDouble(this.MinLots);
      }
      if (this.MaxLots != 0.0)
      {
        output.WriteRawTag((byte) 65);
        output.WriteDouble(this.MaxLots);
      }
      this.orderCurrentStates_.WriteTo(output, GetOrdersFilterProto._repeated_orderCurrentStates_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.OpenStartDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.OpenStartDate);
      if (this.OpenEndDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.OpenEndDate);
      if (this.CloseStartDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.CloseStartDate);
      if (this.CloseEndDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.CloseEndDate);
      int num2 = num1 + this.symbols_.CalculateSize(GetOrdersFilterProto._repeated_symbols_codec) + this.accountIds_.CalculateSize(GetOrdersFilterProto._repeated_accountIds_codec);
      if (this.MinLots != 0.0)
        num2 += 9;
      if (this.MaxLots != 0.0)
        num2 += 9;
      int num3 = num2 + this.orderCurrentStates_.CalculateSize(GetOrdersFilterProto._repeated_orderCurrentStates_codec);
      if (this._unknownFields != null)
        num3 += this._unknownFields.CalculateSize();
      return num3;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetOrdersFilterProto other)
    {
      if (other == null)
        return;
      if (other.OpenStartDate != 0L)
        this.OpenStartDate = other.OpenStartDate;
      if (other.OpenEndDate != 0L)
        this.OpenEndDate = other.OpenEndDate;
      if (other.CloseStartDate != 0L)
        this.CloseStartDate = other.CloseStartDate;
      if (other.CloseEndDate != 0L)
        this.CloseEndDate = other.CloseEndDate;
      this.symbols_.Add((IEnumerable<string>) other.symbols_);
      this.accountIds_.Add((IEnumerable<int>) other.accountIds_);
      if (other.MinLots != 0.0)
        this.MinLots = other.MinLots;
      if (other.MaxLots != 0.0)
        this.MaxLots = other.MaxLots;
      this.orderCurrentStates_.Add((IEnumerable<OrderStateProto>) other.orderCurrentStates_);
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
            this.OpenStartDate = input.ReadInt64();
            continue;
          case 16:
            this.OpenEndDate = input.ReadInt64();
            continue;
          case 24:
            this.CloseStartDate = input.ReadInt64();
            continue;
          case 32:
            this.CloseEndDate = input.ReadInt64();
            continue;
          case 42:
            this.symbols_.AddEntriesFrom(input, GetOrdersFilterProto._repeated_symbols_codec);
            continue;
          case 48:
          case 50:
            this.accountIds_.AddEntriesFrom(input, GetOrdersFilterProto._repeated_accountIds_codec);
            continue;
          case 57:
            this.MinLots = input.ReadDouble();
            continue;
          case 65:
            this.MaxLots = input.ReadDouble();
            continue;
          case 72:
          case 74:
            this.orderCurrentStates_.AddEntriesFrom(input, GetOrdersFilterProto._repeated_orderCurrentStates_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
