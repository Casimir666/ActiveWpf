// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.Level2MarginCheckNotification
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
  public sealed class Level2MarginCheckNotification : 
    IMessage<Level2MarginCheckNotification>,
    IMessage,
    IEquatable<Level2MarginCheckNotification>,
    IDeepCloneable<Level2MarginCheckNotification>
  {
    private static readonly MessageParser<Level2MarginCheckNotification> _parser = new MessageParser<Level2MarginCheckNotification>((Func<Level2MarginCheckNotification>) (() => new Level2MarginCheckNotification()));
    private UnknownFieldSet _unknownFields;
    public const int AskFieldNumber = 1;
    private double ask_;
    public const int BidFieldNumber = 2;
    private double bid_;
    public const int RequestIdFieldNumber = 3;
    private long requestId_;

    [DebuggerNonUserCode]
    public static MessageParser<Level2MarginCheckNotification> Parser => Level2MarginCheckNotification._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[7];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => Level2MarginCheckNotification.Descriptor;

    [DebuggerNonUserCode]
    public Level2MarginCheckNotification()
    {
    }

    [DebuggerNonUserCode]
    public Level2MarginCheckNotification(Level2MarginCheckNotification other)
      : this()
    {
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.requestId_ = other.requestId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public Level2MarginCheckNotification Clone() => new Level2MarginCheckNotification(this);

    [DebuggerNonUserCode]
    public double Ask
    {
      get => this.ask_;
      set => this.ask_ = value;
    }

    [DebuggerNonUserCode]
    public double Bid
    {
      get => this.bid_;
      set => this.bid_ = value;
    }

    [DebuggerNonUserCode]
    public long RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as Level2MarginCheckNotification);

    [DebuggerNonUserCode]
    public bool Equals(Level2MarginCheckNotification other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Ask, other.Ask) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Bid, other.Bid) && this.RequestId == other.RequestId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Ask != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Ask);
      if (this.Bid != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Bid);
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
      if (this.Ask != 0.0)
      {
        output.WriteRawTag((byte) 9);
        output.WriteDouble(this.Ask);
      }
      if (this.Bid != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Bid);
      }
      if (this.RequestId != 0L)
      {
        output.WriteRawTag((byte) 24);
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
      if (this.Ask != 0.0)
        num += 9;
      if (this.Bid != 0.0)
        num += 9;
      if (this.RequestId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RequestId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(Level2MarginCheckNotification other)
    {
      if (other == null)
        return;
      if (other.Ask != 0.0)
        this.Ask = other.Ask;
      if (other.Bid != 0.0)
        this.Bid = other.Bid;
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
            this.Ask = input.ReadDouble();
            continue;
          case 17:
            this.Bid = input.ReadDouble();
            continue;
          case 24:
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
