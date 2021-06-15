// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetOrdersFilteredNotificationProto
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
  public sealed class GetOrdersFilteredNotificationProto : 
    IMessage<GetOrdersFilteredNotificationProto>,
    IMessage,
    IEquatable<GetOrdersFilteredNotificationProto>,
    IDeepCloneable<GetOrdersFilteredNotificationProto>
  {
    private static readonly MessageParser<GetOrdersFilteredNotificationProto> _parser = new MessageParser<GetOrdersFilteredNotificationProto>((Func<GetOrdersFilteredNotificationProto>) (() => new GetOrdersFilteredNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int OrdersFieldNumber = 1;
    private static readonly FieldCodec<OrderProto> _repeated_orders_codec = FieldCodec.ForMessage<OrderProto>(10U, OrderProto.Parser);
    private readonly RepeatedField<OrderProto> orders_ = new RepeatedField<OrderProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetOrdersFilteredNotificationProto> Parser => GetOrdersFilteredNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[17];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetOrdersFilteredNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetOrdersFilteredNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetOrdersFilteredNotificationProto(GetOrdersFilteredNotificationProto other)
      : this()
    {
      this.orders_ = other.orders_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetOrdersFilteredNotificationProto Clone() => new GetOrdersFilteredNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<OrderProto> Orders => this.orders_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetOrdersFilteredNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetOrdersFilteredNotificationProto other)
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
      this.orders_.WriteTo(output, GetOrdersFilteredNotificationProto._repeated_orders_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.orders_.CalculateSize(GetOrdersFilteredNotificationProto._repeated_orders_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetOrdersFilteredNotificationProto other)
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
          this.orders_.AddEntriesFrom(input, GetOrdersFilteredNotificationProto._repeated_orders_codec);
      }
    }
  }
}
