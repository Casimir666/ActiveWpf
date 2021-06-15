// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.BridgeOrderNotificationProto
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
  public sealed class BridgeOrderNotificationProto : 
    IMessage<BridgeOrderNotificationProto>,
    IMessage,
    IEquatable<BridgeOrderNotificationProto>,
    IDeepCloneable<BridgeOrderNotificationProto>
  {
    private static readonly MessageParser<BridgeOrderNotificationProto> _parser = new MessageParser<BridgeOrderNotificationProto>((Func<BridgeOrderNotificationProto>) (() => new BridgeOrderNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private long id_;
    public const int PriceFieldNumber = 2;
    private double price_;
    public const int SymbolFieldNumber = 3;
    private string symbol_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<BridgeOrderNotificationProto> Parser => BridgeOrderNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[1];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BridgeOrderNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public BridgeOrderNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public BridgeOrderNotificationProto(BridgeOrderNotificationProto other)
      : this()
    {
      this.id_ = other.id_;
      this.price_ = other.price_;
      this.symbol_ = other.symbol_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BridgeOrderNotificationProto Clone() => new BridgeOrderNotificationProto(this);

    [DebuggerNonUserCode]
    public long Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public double Price
    {
      get => this.price_;
      set => this.price_ = value;
    }

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BridgeOrderNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(BridgeOrderNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && !(this.Symbol != other.Symbol) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0L)
        num ^= this.Id.GetHashCode();
      if (this.Price != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this.Price != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Price);
      }
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Symbol);
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
      if (this.Price != 0.0)
        num += 9;
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BridgeOrderNotificationProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0L)
        this.Id = other.Id;
      if (other.Price != 0.0)
        this.Price = other.Price;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
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
          case 17:
            this.Price = input.ReadDouble();
            continue;
          case 26:
            this.Symbol = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
