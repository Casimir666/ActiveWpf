// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.Level2PriceNotification
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
  public sealed class Level2PriceNotification : 
    IMessage<Level2PriceNotification>,
    IMessage,
    IEquatable<Level2PriceNotification>,
    IDeepCloneable<Level2PriceNotification>
  {
    private static readonly MessageParser<Level2PriceNotification> _parser = new MessageParser<Level2PriceNotification>((Func<Level2PriceNotification>) (() => new Level2PriceNotification()));
    private UnknownFieldSet _unknownFields;
    public const int PriceFieldNumber = 1;
    private double price_;
    public const int RequestIdFieldNumber = 2;
    private long requestId_;

    [DebuggerNonUserCode]
    public static MessageParser<Level2PriceNotification> Parser => Level2PriceNotification._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[5];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => Level2PriceNotification.Descriptor;

    [DebuggerNonUserCode]
    public Level2PriceNotification()
    {
    }

    [DebuggerNonUserCode]
    public Level2PriceNotification(Level2PriceNotification other)
      : this()
    {
      this.price_ = other.price_;
      this.requestId_ = other.requestId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public Level2PriceNotification Clone() => new Level2PriceNotification(this);

    [DebuggerNonUserCode]
    public double Price
    {
      get => this.price_;
      set => this.price_ = value;
    }

    [DebuggerNonUserCode]
    public long RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as Level2PriceNotification);

    [DebuggerNonUserCode]
    public bool Equals(Level2PriceNotification other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && this.RequestId == other.RequestId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Price != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this.RequestId != 0L)
        num ^= this.RequestId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Price != 0.0)
      {
        output.WriteRawTag((byte) 9);
        output.WriteDouble(this.Price);
      }
      if (this.RequestId != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.RequestId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Price != 0.0)
        num += 9;
      if (this.RequestId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RequestId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(Level2PriceNotification other)
    {
      if (other == null)
        return;
      if (other.Price != 0.0)
        this.Price = other.Price;
      if (other.RequestId != 0L)
        this.RequestId = other.RequestId;
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
          case 9:
            this.Price = input.ReadDouble();
            continue;
          case 16:
            this.RequestId = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
