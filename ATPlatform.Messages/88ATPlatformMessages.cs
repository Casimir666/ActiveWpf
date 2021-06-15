// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetMarkupSettingsSetsNotificationProto
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
  public sealed class GetMarkupSettingsSetsNotificationProto : 
    IMessage<GetMarkupSettingsSetsNotificationProto>,
    IMessage,
    IEquatable<GetMarkupSettingsSetsNotificationProto>,
    IDeepCloneable<GetMarkupSettingsSetsNotificationProto>
  {
    private static readonly MessageParser<GetMarkupSettingsSetsNotificationProto> _parser = new MessageParser<GetMarkupSettingsSetsNotificationProto>((Func<GetMarkupSettingsSetsNotificationProto>) (() => new GetMarkupSettingsSetsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarkupSettingsSetsFieldNumber = 1;
    private static readonly FieldCodec<MarkupSettingsSetProto> _repeated_markupSettingsSets_codec = FieldCodec.ForMessage<MarkupSettingsSetProto>(10U, MarkupSettingsSetProto.Parser);
    private readonly RepeatedField<MarkupSettingsSetProto> markupSettingsSets_ = new RepeatedField<MarkupSettingsSetProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetMarkupSettingsSetsNotificationProto> Parser => GetMarkupSettingsSetsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[77];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetMarkupSettingsSetsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetMarkupSettingsSetsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetMarkupSettingsSetsNotificationProto(GetMarkupSettingsSetsNotificationProto other)
      : this()
    {
      this.markupSettingsSets_ = other.markupSettingsSets_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetMarkupSettingsSetsNotificationProto Clone() => new GetMarkupSettingsSetsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<MarkupSettingsSetProto> MarkupSettingsSets => this.markupSettingsSets_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetMarkupSettingsSetsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetMarkupSettingsSetsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.markupSettingsSets_.Equals(other.markupSettingsSets_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.markupSettingsSets_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.markupSettingsSets_.WriteTo(output, GetMarkupSettingsSetsNotificationProto._repeated_markupSettingsSets_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.markupSettingsSets_.CalculateSize(GetMarkupSettingsSetsNotificationProto._repeated_markupSettingsSets_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetMarkupSettingsSetsNotificationProto other)
    {
      if (other == null)
        return;
      this.markupSettingsSets_.Add((IEnumerable<MarkupSettingsSetProto>) other.markupSettingsSets_);
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
          this.markupSettingsSets_.AddEntriesFrom(input, GetMarkupSettingsSetsNotificationProto._repeated_markupSettingsSets_codec);
      }
    }
  }
}
