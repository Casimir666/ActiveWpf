// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastPricesNotificationProto
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
  public sealed class GetLastPricesNotificationProto : 
    IMessage<GetLastPricesNotificationProto>,
    IMessage,
    IEquatable<GetLastPricesNotificationProto>,
    IDeepCloneable<GetLastPricesNotificationProto>
  {
    private static readonly MessageParser<GetLastPricesNotificationProto> _parser = new MessageParser<GetLastPricesNotificationProto>((Func<GetLastPricesNotificationProto>) (() => new GetLastPricesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int PricesFieldNumber = 1;
    private static readonly FieldCodec<LastPricesProto> _repeated_prices_codec = FieldCodec.ForMessage<LastPricesProto>(10U, LastPricesProto.Parser);
    private readonly RepeatedField<LastPricesProto> prices_ = new RepeatedField<LastPricesProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetLastPricesNotificationProto> Parser => GetLastPricesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[30];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastPricesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastPricesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastPricesNotificationProto(GetLastPricesNotificationProto other)
      : this()
    {
      this.prices_ = other.prices_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastPricesNotificationProto Clone() => new GetLastPricesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<LastPricesProto> Prices => this.prices_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastPricesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastPricesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.prices_.Equals(other.prices_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.prices_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.prices_.WriteTo(output, GetLastPricesNotificationProto._repeated_prices_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.prices_.CalculateSize(GetLastPricesNotificationProto._repeated_prices_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastPricesNotificationProto other)
    {
      if (other == null)
        return;
      this.prices_.Add((IEnumerable<LastPricesProto>) other.prices_);
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
          this.prices_.AddEntriesFrom(input, GetLastPricesNotificationProto._repeated_prices_codec);
      }
    }
  }
}
