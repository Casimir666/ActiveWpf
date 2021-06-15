// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetOrderExecutionsNotificationProto
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
  public sealed class GetOrderExecutionsNotificationProto : 
    IMessage<GetOrderExecutionsNotificationProto>,
    IMessage,
    IEquatable<GetOrderExecutionsNotificationProto>,
    IDeepCloneable<GetOrderExecutionsNotificationProto>
  {
    private static readonly MessageParser<GetOrderExecutionsNotificationProto> _parser = new MessageParser<GetOrderExecutionsNotificationProto>((Func<GetOrderExecutionsNotificationProto>) (() => new GetOrderExecutionsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int OrderIdFieldNumber = 1;
    private long orderId_;
    public const int ExecutionsFieldNumber = 2;
    private static readonly FieldCodec<OrderProto> _repeated_executions_codec = FieldCodec.ForMessage<OrderProto>(18U, OrderProto.Parser);
    private readonly RepeatedField<OrderProto> executions_ = new RepeatedField<OrderProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetOrderExecutionsNotificationProto> Parser => GetOrderExecutionsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[158];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetOrderExecutionsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetOrderExecutionsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetOrderExecutionsNotificationProto(GetOrderExecutionsNotificationProto other)
      : this()
    {
      this.orderId_ = other.orderId_;
      this.executions_ = other.executions_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetOrderExecutionsNotificationProto Clone() => new GetOrderExecutionsNotificationProto(this);

    [DebuggerNonUserCode]
    public long OrderId
    {
      get => this.orderId_;
      set => this.orderId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<OrderProto> Executions => this.executions_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetOrderExecutionsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetOrderExecutionsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.OrderId == other.OrderId && this.executions_.Equals(other.executions_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.OrderId != 0L)
        num1 ^= this.OrderId.GetHashCode();
      int num2 = num1 ^ this.executions_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
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
      this.executions_.WriteTo(output, GetOrderExecutionsNotificationProto._repeated_executions_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.OrderId != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.OrderId);
      int num2 = num1 + this.executions_.CalculateSize(GetOrderExecutionsNotificationProto._repeated_executions_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetOrderExecutionsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.OrderId != 0L)
        this.OrderId = other.OrderId;
      this.executions_.Add((IEnumerable<OrderProto>) other.executions_);
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
          case 18:
            this.executions_.AddEntriesFrom(input, GetOrderExecutionsNotificationProto._repeated_executions_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
