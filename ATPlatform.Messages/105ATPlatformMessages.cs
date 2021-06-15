// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TagCategoryRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TagCategoryRequestProto : 
    IMessage<TagCategoryRequestProto>,
    IMessage,
    IEquatable<TagCategoryRequestProto>,
    IDeepCloneable<TagCategoryRequestProto>
  {
    private static readonly MessageParser<TagCategoryRequestProto> _parser = new MessageParser<TagCategoryRequestProto>((Func<TagCategoryRequestProto>) (() => new TagCategoryRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int TagCategoryFieldNumber = 1;
    private TagCategoryProto tagCategory_;

    [DebuggerNonUserCode]
    public static MessageParser<TagCategoryRequestProto> Parser => TagCategoryRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[98];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TagCategoryRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public TagCategoryRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public TagCategoryRequestProto(TagCategoryRequestProto other)
      : this()
    {
      this.tagCategory_ = other.tagCategory_ != null ? other.tagCategory_.Clone() : (TagCategoryProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TagCategoryRequestProto Clone() => new TagCategoryRequestProto(this);

    [DebuggerNonUserCode]
    public TagCategoryProto TagCategory
    {
      get => this.tagCategory_;
      set => this.tagCategory_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TagCategoryRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(TagCategoryRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.TagCategory, (object) other.TagCategory) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.tagCategory_ != null)
        num ^= this.TagCategory.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.tagCategory_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.TagCategory);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.tagCategory_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.TagCategory);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TagCategoryRequestProto other)
    {
      if (other == null)
        return;
      if (other.tagCategory_ != null)
      {
        if (this.tagCategory_ == null)
          this.TagCategory = new TagCategoryProto();
        this.TagCategory.MergeFrom(other.TagCategory);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.tagCategory_ == null)
            this.TagCategory = new TagCategoryProto();
          input.ReadMessage((IMessage) this.TagCategory);
        }
      }
    }
  }
}
