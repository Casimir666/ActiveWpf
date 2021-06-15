// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TagRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TagRequestProto : 
    IMessage<TagRequestProto>,
    IMessage,
    IEquatable<TagRequestProto>,
    IDeepCloneable<TagRequestProto>
  {
    private static readonly MessageParser<TagRequestProto> _parser = new MessageParser<TagRequestProto>((Func<TagRequestProto>) (() => new TagRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int TagFieldNumber = 1;
    private TagProto tag_;

    [DebuggerNonUserCode]
    public static MessageParser<TagRequestProto> Parser => TagRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[103];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TagRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public TagRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public TagRequestProto(TagRequestProto other)
      : this()
    {
      this.tag_ = other.tag_ != null ? other.tag_.Clone() : (TagProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TagRequestProto Clone() => new TagRequestProto(this);

    [DebuggerNonUserCode]
    public TagProto Tag
    {
      get => this.tag_;
      set => this.tag_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TagRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(TagRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Tag, (object) other.Tag) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.tag_ != null)
        num ^= this.Tag.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.tag_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Tag);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.tag_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Tag);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TagRequestProto other)
    {
      if (other == null)
        return;
      if (other.tag_ != null)
      {
        if (this.tag_ == null)
          this.Tag = new TagProto();
        this.Tag.MergeFrom(other.Tag);
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
          if (this.tag_ == null)
            this.Tag = new TagProto();
          input.ReadMessage((IMessage) this.Tag);
        }
      }
    }
  }
}
