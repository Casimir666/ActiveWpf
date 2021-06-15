// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TagCategoryProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TagCategoryProto : 
    IMessage<TagCategoryProto>,
    IMessage,
    IEquatable<TagCategoryProto>,
    IDeepCloneable<TagCategoryProto>
  {
    private static readonly MessageParser<TagCategoryProto> _parser = new MessageParser<TagCategoryProto>((Func<TagCategoryProto>) (() => new TagCategoryProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int ColorHexFieldNumber = 3;
    private string colorHex_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<TagCategoryProto> Parser => TagCategoryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[97];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TagCategoryProto.Descriptor;

    [DebuggerNonUserCode]
    public TagCategoryProto()
    {
    }

    [DebuggerNonUserCode]
    public TagCategoryProto(TagCategoryProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.colorHex_ = other.colorHex_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TagCategoryProto Clone() => new TagCategoryProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string ColorHex
    {
      get => this.colorHex_;
      set => this.colorHex_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TagCategoryProto);

    [DebuggerNonUserCode]
    public bool Equals(TagCategoryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && !(this.ColorHex != other.ColorHex) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this.Name.Length != 0)
        num ^= this.Name.GetHashCode();
      if (this.ColorHex.Length != 0)
        num ^= this.ColorHex.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Name);
      }
      if (this.ColorHex.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.ColorHex);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.Name.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this.ColorHex.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.ColorHex);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TagCategoryProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.ColorHex.Length != 0)
        this.ColorHex = other.ColorHex;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 8:
            this.Id = input.ReadInt32();
            continue;
          case 18:
            this.Name = input.ReadString();
            continue;
          case 26:
            this.ColorHex = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
