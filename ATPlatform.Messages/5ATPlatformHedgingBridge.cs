// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.Level2PriceRequest
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
  public sealed class Level2PriceRequest : 
    IMessage<Level2PriceRequest>,
    IMessage,
    IEquatable<Level2PriceRequest>,
    IDeepCloneable<Level2PriceRequest>
  {
    private static readonly MessageParser<Level2PriceRequest> _parser = new MessageParser<Level2PriceRequest>((Func<Level2PriceRequest>) (() => new Level2PriceRequest()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int VolumeFieldNumber = 2;
    private long volume_;
    public const int PriceFieldNumber = 3;
    private double price_;
    public const int TypeFieldNumber = 4;
    private OrderTypeProto type_;
    public const int RequestIdFieldNumber = 5;
    private long requestId_;
    public const int AccumulatedVolumeFieldNumber = 6;
    private long accumulatedVolume_;
    public const int CoefficientFieldNumber = 7;
    private double coefficient_;

    [DebuggerNonUserCode]
    public static MessageParser<Level2PriceRequest> Parser => Level2PriceRequest._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[4];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => Level2PriceRequest.Descriptor;

    [DebuggerNonUserCode]
    public Level2PriceRequest()
    {
    }

    [DebuggerNonUserCode]
    public Level2PriceRequest(Level2PriceRequest other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.volume_ = other.volume_;
      this.price_ = other.price_;
      this.type_ = other.type_;
      this.requestId_ = other.requestId_;
      this.accumulatedVolume_ = other.accumulatedVolume_;
      this.coefficient_ = other.coefficient_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public Level2PriceRequest Clone() => new Level2PriceRequest(this);

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
    public long RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
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
    public override bool Equals(object other) => this.Equals(other as Level2PriceRequest);

    [DebuggerNonUserCode]
    public bool Equals(Level2PriceRequest other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.Volume == other.Volume && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && this.Type == other.Type) && (this.RequestId == other.RequestId && this.AccumulatedVolume == other.AccumulatedVolume && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Coefficient, other.Coefficient)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.RequestId != 0L)
        num ^= this.RequestId.GetHashCode();
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
      if (this.RequestId != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.RequestId);
      }
      if (this.AccumulatedVolume != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.AccumulatedVolume);
      }
      if (this.Coefficient != 0.0)
      {
        output.WriteRawTag((byte) 57);
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
      if (this.RequestId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RequestId);
      if (this.AccumulatedVolume != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.AccumulatedVolume);
      if (this.Coefficient != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(Level2PriceRequest other)
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
      if (other.RequestId != 0L)
        this.RequestId = other.RequestId;
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
            this.RequestId = input.ReadInt64();
            continue;
          case 48:
            this.AccumulatedVolume = input.ReadInt64();
            continue;
          case 57:
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
