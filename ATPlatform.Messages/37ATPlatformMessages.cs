// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TrailingStopProto
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
  public sealed class TrailingStopProto : 
    IMessage<TrailingStopProto>,
    IMessage,
    IEquatable<TrailingStopProto>,
    IDeepCloneable<TrailingStopProto>
  {
    private static readonly MessageParser<TrailingStopProto> _parser = new MessageParser<TrailingStopProto>((Func<TrailingStopProto>) (() => new TrailingStopProto()));
    private UnknownFieldSet _unknownFields;
    public const int OrderIdFieldNumber = 1;
    private long orderId_;
    public const int TrailingStopFieldNumber = 2;
    private double trailingStop_;

    [DebuggerNonUserCode]
    public static MessageParser<TrailingStopProto> Parser => TrailingStopProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[19];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TrailingStopProto.Descriptor;

    [DebuggerNonUserCode]
    public TrailingStopProto()
    {
    }

    [DebuggerNonUserCode]
    public TrailingStopProto(TrailingStopProto other)
      : this()
    {
      this.orderId_ = other.orderId_;
      this.trailingStop_ = other.trailingStop_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TrailingStopProto Clone() => new TrailingStopProto(this);

    [DebuggerNonUserCode]
    public long OrderId
    {
      get => this.orderId_;
      set => this.orderId_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStop
    {
      get => this.trailingStop_;
      set => this.trailingStop_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TrailingStopProto);

    [DebuggerNonUserCode]
    public bool Equals(TrailingStopProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.OrderId == other.OrderId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStop, other.TrailingStop) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.OrderId != 0L)
        num ^= this.OrderId.GetHashCode();
      if (this.TrailingStop != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStop);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.OrderId != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.OrderId);
      }
      if (this.TrailingStop != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.TrailingStop);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.OrderId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OrderId);
      if (this.TrailingStop != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TrailingStopProto other)
    {
      if (other == null)
        return;
      if (other.OrderId != 0L)
        this.OrderId = other.OrderId;
      if (other.TrailingStop != 0.0)
        this.TrailingStop = other.TrailingStop;
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
            this.OrderId = input.ReadInt64();
            continue;
          case 17:
            this.TrailingStop = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
