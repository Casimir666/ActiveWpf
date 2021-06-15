// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.RoleProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class RoleProto : 
    IMessage<RoleProto>,
    IMessage,
    IEquatable<RoleProto>,
    IDeepCloneable<RoleProto>
  {
    private static readonly MessageParser<RoleProto> _parser = new MessageParser<RoleProto>((Func<RoleProto>) (() => new RoleProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int CommentFieldNumber = 3;
    private string comment_ = "";
    public const int PermissionFieldNumber = 4;
    private long permission_;

    [DebuggerNonUserCode]
    public static MessageParser<RoleProto> Parser => RoleProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[176];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => RoleProto.Descriptor;

    [DebuggerNonUserCode]
    public RoleProto()
    {
    }

    [DebuggerNonUserCode]
    public RoleProto(RoleProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.comment_ = other.comment_;
      this.permission_ = other.permission_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public RoleProto Clone() => new RoleProto(this);

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
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Permission
    {
      get => this.permission_;
      set => this.permission_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as RoleProto);

    [DebuggerNonUserCode]
    public bool Equals(RoleProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && (!(this.Comment != other.Comment) && this.Permission == other.Permission) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this.Name.Length != 0)
        num ^= this.Name.GetHashCode();
      if (this.Comment.Length != 0)
        num ^= this.Comment.GetHashCode();
      if (this.Permission != 0L)
        num ^= this.Permission.GetHashCode();
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
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Comment);
      }
      if (this.Permission != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.Permission);
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
      if (this.Comment.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.Permission != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Permission);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(RoleProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.Permission != 0L)
        this.Permission = other.Permission;
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
            this.Comment = input.ReadString();
            continue;
          case 32:
            this.Permission = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
