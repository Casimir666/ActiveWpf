// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarginRequirementCheckRequestProto
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
  public sealed class MarginRequirementCheckRequestProto : 
    IMessage<MarginRequirementCheckRequestProto>,
    IMessage,
    IEquatable<MarginRequirementCheckRequestProto>,
    IDeepCloneable<MarginRequirementCheckRequestProto>
  {
    private static readonly MessageParser<MarginRequirementCheckRequestProto> _parser = new MessageParser<MarginRequirementCheckRequestProto>((Func<MarginRequirementCheckRequestProto>) (() => new MarginRequirementCheckRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int SymbolFieldNumber = 2;
    private string symbol_ = "";
    public const int TypeFieldNumber = 3;
    private OrderTypeProto type_;
    public const int LotsFieldNumber = 4;
    private double lots_;
    public const int PriceFieldNumber = 5;
    private double price_;

    [DebuggerNonUserCode]
    public static MessageParser<MarginRequirementCheckRequestProto> Parser => MarginRequirementCheckRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[9];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarginRequirementCheckRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public MarginRequirementCheckRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public MarginRequirementCheckRequestProto(MarginRequirementCheckRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.symbol_ = other.symbol_;
      this.type_ = other.type_;
      this.lots_ = other.lots_;
      this.price_ = other.price_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarginRequirementCheckRequestProto Clone() => new MarginRequirementCheckRequestProto(this);

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
    public OrderTypeProto Type
    {
      get => this.type_;
      set => this.type_ = value;
    }

    [DebuggerNonUserCode]
    public double Lots
    {
      get => this.lots_;
      set => this.lots_ = value;
    }

    [DebuggerNonUserCode]
    public double Price
    {
      get => this.price_;
      set => this.price_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarginRequirementCheckRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(MarginRequirementCheckRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.Symbol != other.Symbol) && (this.Type == other.Type && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Lots, other.Lots)) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this.Type != OrderTypeProto.Unknown)
        num ^= this.Type.GetHashCode();
      if (this.Lots != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Lots);
      if (this.Price != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Symbol);
      }
      if (this.Type != OrderTypeProto.Unknown)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.Type);
      }
      if (this.Lots != 0.0)
      {
        output.WriteRawTag((byte) 33);
        output.WriteDouble(this.Lots);
      }
      if (this.Price != 0.0)
      {
        output.WriteRawTag((byte) 41);
        output.WriteDouble(this.Price);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.Type != OrderTypeProto.Unknown)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Type);
      if (this.Lots != 0.0)
        num += 9;
      if (this.Price != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarginRequirementCheckRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.Type != OrderTypeProto.Unknown)
        this.Type = other.Type;
      if (other.Lots != 0.0)
        this.Lots = other.Lots;
      if (other.Price != 0.0)
        this.Price = other.Price;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 18:
            this.Symbol = input.ReadString();
            continue;
          case 24:
            this.Type = (OrderTypeProto) input.ReadEnum();
            continue;
          case 33:
            this.Lots = input.ReadDouble();
            continue;
          case 41:
            this.Price = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
