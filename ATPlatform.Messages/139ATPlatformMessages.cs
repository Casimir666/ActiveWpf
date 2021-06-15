// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCurrencyNotificationProto
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
  public sealed class GetCurrencyNotificationProto : 
    IMessage<GetCurrencyNotificationProto>,
    IMessage,
    IEquatable<GetCurrencyNotificationProto>,
    IDeepCloneable<GetCurrencyNotificationProto>
  {
    private static readonly MessageParser<GetCurrencyNotificationProto> _parser = new MessageParser<GetCurrencyNotificationProto>((Func<GetCurrencyNotificationProto>) (() => new GetCurrencyNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CurrenciesFieldNumber = 1;
    private static readonly FieldCodec<CurrencyProto> _repeated_currencies_codec = FieldCodec.ForMessage<CurrencyProto>(10U, CurrencyProto.Parser);
    private readonly RepeatedField<CurrencyProto> currencies_ = new RepeatedField<CurrencyProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetCurrencyNotificationProto> Parser => GetCurrencyNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[132];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCurrencyNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCurrencyNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCurrencyNotificationProto(GetCurrencyNotificationProto other)
      : this()
    {
      this.currencies_ = other.currencies_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCurrencyNotificationProto Clone() => new GetCurrencyNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<CurrencyProto> Currencies => this.currencies_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCurrencyNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCurrencyNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.currencies_.Equals(other.currencies_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.currencies_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.currencies_.WriteTo(output, GetCurrencyNotificationProto._repeated_currencies_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.currencies_.CalculateSize(GetCurrencyNotificationProto._repeated_currencies_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCurrencyNotificationProto other)
    {
      if (other == null)
        return;
      this.currencies_.Add((IEnumerable<CurrencyProto>) other.currencies_);
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
          this.currencies_.AddEntriesFrom(input, GetCurrencyNotificationProto._repeated_currencies_codec);
      }
    }
  }
}
