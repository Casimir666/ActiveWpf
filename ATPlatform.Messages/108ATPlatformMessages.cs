// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetTagCategoriesNotificationProto
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
  public sealed class GetTagCategoriesNotificationProto : 
    IMessage<GetTagCategoriesNotificationProto>,
    IMessage,
    IEquatable<GetTagCategoriesNotificationProto>,
    IDeepCloneable<GetTagCategoriesNotificationProto>
  {
    private static readonly MessageParser<GetTagCategoriesNotificationProto> _parser = new MessageParser<GetTagCategoriesNotificationProto>((Func<GetTagCategoriesNotificationProto>) (() => new GetTagCategoriesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TagCategoriesFieldNumber = 1;
    private static readonly FieldCodec<TagCategoryProto> _repeated_tagCategories_codec = FieldCodec.ForMessage<TagCategoryProto>(10U, TagCategoryProto.Parser);
    private readonly RepeatedField<TagCategoryProto> tagCategories_ = new RepeatedField<TagCategoryProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetTagCategoriesNotificationProto> Parser => GetTagCategoriesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[101];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetTagCategoriesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetTagCategoriesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetTagCategoriesNotificationProto(GetTagCategoriesNotificationProto other)
      : this()
    {
      this.tagCategories_ = other.tagCategories_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetTagCategoriesNotificationProto Clone() => new GetTagCategoriesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TagCategoryProto> TagCategories => this.tagCategories_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetTagCategoriesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetTagCategoriesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.tagCategories_.Equals(other.tagCategories_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.tagCategories_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.tagCategories_.WriteTo(output, GetTagCategoriesNotificationProto._repeated_tagCategories_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.tagCategories_.CalculateSize(GetTagCategoriesNotificationProto._repeated_tagCategories_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetTagCategoriesNotificationProto other)
    {
      if (other == null)
        return;
      this.tagCategories_.Add((IEnumerable<TagCategoryProto>) other.tagCategories_);
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
          this.tagCategories_.AddEntriesFrom(input, GetTagCategoriesNotificationProto._repeated_tagCategories_codec);
      }
    }
  }
}
