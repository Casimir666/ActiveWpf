// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetTagsNotificationProto
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
  public sealed class GetTagsNotificationProto : 
    IMessage<GetTagsNotificationProto>,
    IMessage,
    IEquatable<GetTagsNotificationProto>,
    IDeepCloneable<GetTagsNotificationProto>
  {
    private static readonly MessageParser<GetTagsNotificationProto> _parser = new MessageParser<GetTagsNotificationProto>((Func<GetTagsNotificationProto>) (() => new GetTagsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TagsFieldNumber = 1;
    private static readonly FieldCodec<TagProto> _repeated_tags_codec = FieldCodec.ForMessage<TagProto>(10U, TagProto.Parser);
    private readonly RepeatedField<TagProto> tags_ = new RepeatedField<TagProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetTagsNotificationProto> Parser => GetTagsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[106];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetTagsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetTagsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetTagsNotificationProto(GetTagsNotificationProto other)
      : this()
    {
      this.tags_ = other.tags_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetTagsNotificationProto Clone() => new GetTagsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TagProto> Tags => this.tags_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetTagsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetTagsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.tags_.Equals(other.tags_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.tags_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.tags_.WriteTo(output, GetTagsNotificationProto._repeated_tags_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.tags_.CalculateSize(GetTagsNotificationProto._repeated_tags_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetTagsNotificationProto other)
    {
      if (other == null)
        return;
      this.tags_.Add((IEnumerable<TagProto>) other.tags_);
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
          this.tags_.AddEntriesFrom(input, GetTagsNotificationProto._repeated_tags_codec);
      }
    }
  }
}
