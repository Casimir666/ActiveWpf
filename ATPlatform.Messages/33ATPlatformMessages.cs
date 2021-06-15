// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetOpenedOrdersNotificationProto
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
  public sealed class GetOpenedOrdersNotificationProto : 
    IMessage<GetOpenedOrdersNotificationProto>,
    IMessage,
    IEquatable<GetOpenedOrdersNotificationProto>,
    IDeepCloneable<GetOpenedOrdersNotificationProto>
  {
    private static readonly MessageParser<GetOpenedOrdersNotificationProto> _parser = new MessageParser<GetOpenedOrdersNotificationProto>((Func<GetOpenedOrdersNotificationProto>) (() => new GetOpenedOrdersNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int OrdersFieldNumber = 1;
    private static readonly FieldCodec<OrderProto> _repeated_orders_codec = FieldCodec.ForMessage<OrderProto>(10U, OrderProto.Parser);
    private readonly RepeatedField<OrderProto> orders_ = new RepeatedField<OrderProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetOpenedOrdersNotificationProto> Parser => GetOpenedOrdersNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[14];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetOpenedOrdersNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetOpenedOrdersNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetOpenedOrdersNotificationProto(GetOpenedOrdersNotificationProto other)
      : this()
    {
      this.orders_ = other.orders_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetOpenedOrdersNotificationProto Clone() => new GetOpenedOrdersNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<OrderProto> Orders => this.orders_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetOpenedOrdersNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetOpenedOrdersNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.orders_.Equals(other.orders_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.orders_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.orders_.WriteTo(output, GetOpenedOrdersNotificationProto._repeated_orders_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.orders_.CalculateSize(GetOpenedOrdersNotificationProto._repeated_orders_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetOpenedOrdersNotificationProto other)
    {
      if (other == null)
        return;
      this.orders_.Add((IEnumerable<OrderProto>) other.orders_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.orders_.AddEntriesFrom(input, GetOpenedOrdersNotificationProto._repeated_orders_codec);
      }
    }
  }
}
