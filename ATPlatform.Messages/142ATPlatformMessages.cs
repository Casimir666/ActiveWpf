// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCountryNotificationProto
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
  public sealed class GetCountryNotificationProto : 
    IMessage<GetCountryNotificationProto>,
    IMessage,
    IEquatable<GetCountryNotificationProto>,
    IDeepCloneable<GetCountryNotificationProto>
  {
    private static readonly MessageParser<GetCountryNotificationProto> _parser = new MessageParser<GetCountryNotificationProto>((Func<GetCountryNotificationProto>) (() => new GetCountryNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CountriesFieldNumber = 1;
    private static readonly FieldCodec<CountryProto> _repeated_countries_codec = FieldCodec.ForMessage<CountryProto>(10U, CountryProto.Parser);
    private readonly RepeatedField<CountryProto> countries_ = new RepeatedField<CountryProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetCountryNotificationProto> Parser => GetCountryNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[135];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCountryNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCountryNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCountryNotificationProto(GetCountryNotificationProto other)
      : this()
    {
      this.countries_ = other.countries_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCountryNotificationProto Clone() => new GetCountryNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<CountryProto> Countries => this.countries_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCountryNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCountryNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.countries_.Equals(other.countries_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.countries_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.countries_.WriteTo(output, GetCountryNotificationProto._repeated_countries_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.countries_.CalculateSize(GetCountryNotificationProto._repeated_countries_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCountryNotificationProto other)
    {
      if (other == null)
        return;
      this.countries_.Add((IEnumerable<CountryProto>) other.countries_);
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
          this.countries_.AddEntriesFrom(input, GetCountryNotificationProto._repeated_countries_codec);
      }
    }
  }
}
