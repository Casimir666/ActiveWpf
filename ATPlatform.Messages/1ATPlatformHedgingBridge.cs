// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.BridgeOrderRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.HedgingBridge
{
  public sealed class BridgeOrderRequestProto : 
    IMessage<BridgeOrderRequestProto>,
    IMessage,
    IEquatable<BridgeOrderRequestProto>,
    IDeepCloneable<BridgeOrderRequestProto>
  {
    private static readonly MessageParser<BridgeOrderRequestProto> _parser = new MessageParser<BridgeOrderRequestProto>((Func<BridgeOrderRequestProto>) (() => new BridgeOrderRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int VolumeFieldNumber = 2;
    private long volume_;
    public const int PriceFieldNumber = 3;
    private double price_;
    public const int TypeFieldNumber = 4;
    private OrderTypeProto type_;
    public const int AccountIdFieldNumber = 5;
    private int accountId_;
    public const int ContractSizeFieldNumber = 6;
    private double contractSize_;
    public const int HedgeSettingsSetFieldNumber = 7;
    private string hedgeSettingsSet_ = "";
    public const int SymbolDigitsFieldNumber = 8;
    private int symbolDigits_;
    public const int HedgeLiquidityProviderFieldNumber = 9;
    private string hedgeLiquidityProvider_ = "";
    public const int AccumulatedVolumeFieldNumber = 10;
    private long accumulatedVolume_;
    public const int CoefficientFieldNumber = 11;
    private double coefficient_;

    [DebuggerNonUserCode]
    public static MessageParser<BridgeOrderRequestProto> Parser => BridgeOrderRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[0];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BridgeOrderRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public BridgeOrderRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public BridgeOrderRequestProto(BridgeOrderRequestProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.volume_ = other.volume_;
      this.price_ = other.price_;
      this.type_ = other.type_;
      this.accountId_ = other.accountId_;
      this.contractSize_ = other.contractSize_;
      this.hedgeSettingsSet_ = other.hedgeSettingsSet_;
      this.symbolDigits_ = other.symbolDigits_;
      this.hedgeLiquidityProvider_ = other.hedgeLiquidityProvider_;
      this.accumulatedVolume_ = other.accumulatedVolume_;
      this.coefficient_ = other.coefficient_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BridgeOrderRequestProto Clone() => new BridgeOrderRequestProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Volume
    {
      get => this.volume_;
      set => this.volume_ = value;
    }

    [DebuggerNonUserCode]
    public double Price
    {
      get => this.price_;
      set => this.price_ = value;
    }

    [DebuggerNonUserCode]
    public OrderTypeProto Type
    {
      get => this.type_;
      set => this.type_ = value;
    }

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public double ContractSize
    {
      get => this.contractSize_;
      set => this.contractSize_ = value;
    }

    [DebuggerNonUserCode]
    public string HedgeSettingsSet
    {
      get => this.hedgeSettingsSet_;
      set => this.hedgeSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int SymbolDigits
    {
      get => this.symbolDigits_;
      set => this.symbolDigits_ = value;
    }

    [DebuggerNonUserCode]
    public string HedgeLiquidityProvider
    {
      get => this.hedgeLiquidityProvider_;
      set => this.hedgeLiquidityProvider_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long AccumulatedVolume
    {
      get => this.accumulatedVolume_;
      set => this.accumulatedVolume_ = value;
    }

    [DebuggerNonUserCode]
    public double Coefficient
    {
      get => this.coefficient_;
      set => this.coefficient_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BridgeOrderRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(BridgeOrderRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.Volume == other.Volume && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && this.Type == other.Type) && (this.AccountId == other.AccountId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ContractSize, other.ContractSize) && (!(this.HedgeSettingsSet != other.HedgeSettingsSet) && this.SymbolDigits == other.SymbolDigits)) && (!(this.HedgeLiquidityProvider != other.HedgeLiquidityProvider) && this.AccumulatedVolume == other.AccumulatedVolume && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Coefficient, other.Coefficient)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this.Volume != 0L)
        num ^= this.Volume.GetHashCode();
      if (this.Price != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this.Type != OrderTypeProto.Unknown)
        num ^= this.Type.GetHashCode();
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.ContractSize != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ContractSize);
      if (this.HedgeSettingsSet.Length != 0)
        num ^= this.HedgeSettingsSet.GetHashCode();
      if (this.SymbolDigits != 0)
        num ^= this.SymbolDigits.GetHashCode();
      if (this.HedgeLiquidityProvider.Length != 0)
        num ^= this.HedgeLiquidityProvider.GetHashCode();
      if (this.AccumulatedVolume != 0L)
        num ^= this.AccumulatedVolume.GetHashCode();
      if (this.Coefficient != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Coefficient);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this.Volume != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.Volume);
      }
      if (this.Price != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.Price);
      }
      if (this.Type != OrderTypeProto.Unknown)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.Type);
      }
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.AccountId);
      }
      if (this.ContractSize != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.ContractSize);
      }
      if (this.HedgeSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.HedgeSettingsSet);
      }
      if (this.SymbolDigits != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.SymbolDigits);
      }
      if (this.HedgeLiquidityProvider.Length != 0)
      {
        output.WriteRawTag((byte) 74);
        output.WriteString(this.HedgeLiquidityProvider);
      }
      if (this.AccumulatedVolume != 0L)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt64(this.AccumulatedVolume);
      }
      if (this.Coefficient != 0.0)
      {
        output.WriteRawTag((byte) 89);
        output.WriteDouble(this.Coefficient);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.Volume != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Volume);
      if (this.Price != 0.0)
        num += 9;
      if (this.Type != OrderTypeProto.Unknown)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Type);
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.ContractSize != 0.0)
        num += 9;
      if (this.HedgeSettingsSet.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.HedgeSettingsSet);
      if (this.SymbolDigits != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolDigits);
      if (this.HedgeLiquidityProvider.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.HedgeLiquidityProvider);
      if (this.AccumulatedVolume != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.AccumulatedVolume);
      if (this.Coefficient != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BridgeOrderRequestProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.Volume != 0L)
        this.Volume = other.Volume;
      if (other.Price != 0.0)
        this.Price = other.Price;
      if (other.Type != OrderTypeProto.Unknown)
        this.Type = other.Type;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.ContractSize != 0.0)
        this.ContractSize = other.ContractSize;
      if (other.HedgeSettingsSet.Length != 0)
        this.HedgeSettingsSet = other.HedgeSettingsSet;
      if (other.SymbolDigits != 0)
        this.SymbolDigits = other.SymbolDigits;
      if (other.HedgeLiquidityProvider.Length != 0)
        this.HedgeLiquidityProvider = other.HedgeLiquidityProvider;
      if (other.AccumulatedVolume != 0L)
        this.AccumulatedVolume = other.AccumulatedVolume;
      if (other.Coefficient != 0.0)
        this.Coefficient = other.Coefficient;
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
          case 16:
            this.Volume = input.ReadInt64();
            continue;
          case 25:
            this.Price = input.ReadDouble();
            continue;
          case 32:
            this.Type = (OrderTypeProto) input.ReadEnum();
            continue;
          case 40:
            this.AccountId = input.ReadInt32();
            continue;
          case 49:
            this.ContractSize = input.ReadDouble();
            continue;
          case 58:
            this.HedgeSettingsSet = input.ReadString();
            continue;
          case 64:
            this.SymbolDigits = input.ReadInt32();
            continue;
          case 74:
            this.HedgeLiquidityProvider = input.ReadString();
            continue;
          case 80:
            this.AccumulatedVolume = input.ReadInt64();
            continue;
          case 89:
            this.Coefficient = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
