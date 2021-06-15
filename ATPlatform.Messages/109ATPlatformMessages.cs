// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TagProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TagProto : 
    IMessage<TagProto>,
    IMessage,
    IEquatable<TagProto>,
    IDeepCloneable<TagProto>
  {
    private static readonly MessageParser<TagProto> _parser = new MessageParser<TagProto>((Func<TagProto>) (() => new TagProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int CategoryIdFieldNumber = 2;
    private int categoryId_;
    public const int NameFieldNumber = 3;
    private string name_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<TagProto> Parser => TagProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[102];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TagProto.Descriptor;

    [DebuggerNonUserCode]
    public TagProto()
    {
    }

    [DebuggerNonUserCode]
    public TagProto(TagProto other)
      : this()
    {
      this.id_ = other.id_;
      this.categoryId_ = other.categoryId_;
      this.name_ = other.name_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TagProto Clone() => new TagProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public int CategoryId
    {
      get => this.categoryId_;
      set => this.categoryId_ = value;
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TagProto);

    [DebuggerNonUserCode]
    public bool Equals(TagProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.CategoryId == other.CategoryId && !(this.Name != other.Name) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CategoryId != 0)
      {
        int num3 = num1;
        num2 = this.CategoryId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Name.Length != 0)
        num1 ^= this.Name.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
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
      if (this.CategoryId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.CategoryId);
      }
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Name);
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
      if (this.CategoryId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.CategoryId);
      if (this.Name.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TagProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.CategoryId != 0)
        this.CategoryId = other.CategoryId;
      if (other.Name.Length != 0)
        this.Name = other.Name;
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
          case 16:
            this.CategoryId = input.ReadInt32();
            continue;
          case 26:
            this.Name = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
