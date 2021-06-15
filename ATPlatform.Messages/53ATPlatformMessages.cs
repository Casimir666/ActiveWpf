// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SmallTickProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SmallTickProto : 
    IMessage<SmallTickProto>,
    IMessage,
    IEquatable<SmallTickProto>,
    IDeepCloneable<SmallTickProto>
  {
    private static readonly MessageParser<SmallTickProto> _parser = new MessageParser<SmallTickProto>((Func<SmallTickProto>) (() => new SmallTickProto()));
    private UnknownFieldSet _unknownFields;
    public const int AskFieldNumber = 1;
    private int ask_;
    public const int BidFieldNumber = 2;
    private int bid_;
    public const int TimestampFieldNumber = 3;
    private long timestamp_;

    [DebuggerNonUserCode]
    public static MessageParser<SmallTickProto> Parser => SmallTickProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[35];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SmallTickProto.Descriptor;

    [DebuggerNonUserCode]
    public SmallTickProto()
    {
    }

    [DebuggerNonUserCode]
    public SmallTickProto(SmallTickProto other)
      : this()
    {
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.timestamp_ = other.timestamp_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SmallTickProto Clone() => new SmallTickProto(this);

    [DebuggerNonUserCode]
    public int Ask
    {
      get => this.ask_;
      set => this.ask_ = value;
    }

    [DebuggerNonUserCode]
    public int Bid
    {
      get => this.bid_;
      set => this.bid_ = value;
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SmallTickProto);

    [DebuggerNonUserCode]
    public bool Equals(SmallTickProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Ask == other.Ask && this.Bid == other.Bid && this.Timestamp == other.Timestamp && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Ask != 0)
      {
        int num3 = num1;
        num2 = this.Ask;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Bid != 0)
      {
        int num3 = num1;
        num2 = this.Bid;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Ask != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Ask);
      }
      if (this.Bid != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.Bid);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.Timestamp);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Ask != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Ask);
      if (this.Bid != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Bid);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SmallTickProto other)
    {
      if (other == null)
        return;
      if (other.Ask != 0)
        this.Ask = other.Ask;
      if (other.Bid != 0)
        this.Bid = other.Bid;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
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
            this.Ask = input.ReadInt32();
            continue;
          case 16:
            this.Bid = input.ReadInt32();
            continue;
          case 24:
            this.Timestamp = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
