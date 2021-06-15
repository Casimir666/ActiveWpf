// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AdministratorProto
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
  public sealed class AdministratorProto : 
    IMessage<AdministratorProto>,
    IMessage,
    IEquatable<AdministratorProto>,
    IDeepCloneable<AdministratorProto>
  {
    private static readonly MessageParser<AdministratorProto> _parser = new MessageParser<AdministratorProto>((Func<AdministratorProto>) (() => new AdministratorProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    public const int NameFieldNumber = 3;
    private string name_ = "";
    public const int WindowsIdentityFieldNumber = 4;
    private string windowsIdentity_ = "";
    public const int CommentFieldNumber = 5;
    private string comment_ = "";
    public const int RoleIdFieldNumber = 6;
    private int roleId_;
    public const int TenantsIdsFieldNumber = 7;
    private static readonly FieldCodec<int> _repeated_tenantsIds_codec = FieldCodec.ForInt32(58U);
    private readonly RepeatedField<int> tenantsIds_ = new RepeatedField<int>();

    [DebuggerNonUserCode]
    public static MessageParser<AdministratorProto> Parser => AdministratorProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[171];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AdministratorProto.Descriptor;

    [DebuggerNonUserCode]
    public AdministratorProto()
    {
    }

    [DebuggerNonUserCode]
    public AdministratorProto(AdministratorProto other)
      : this()
    {
      this.id_ = other.id_;
      this.email_ = other.email_;
      this.name_ = other.name_;
      this.windowsIdentity_ = other.windowsIdentity_;
      this.comment_ = other.comment_;
      this.roleId_ = other.roleId_;
      this.tenantsIds_ = other.tenantsIds_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AdministratorProto Clone() => new AdministratorProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string Email
    {
      get => this.email_;
      set => this.email_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string WindowsIdentity
    {
      get => this.windowsIdentity_;
      set => this.windowsIdentity_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int RoleId
    {
      get => this.roleId_;
      set => this.roleId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<int> TenantsIds => this.tenantsIds_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AdministratorProto);

    [DebuggerNonUserCode]
    public bool Equals(AdministratorProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Email != other.Email) && (!(this.Name != other.Name) && !(this.WindowsIdentity != other.WindowsIdentity)) && (!(this.Comment != other.Comment) && this.RoleId == other.RoleId && this.tenantsIds_.Equals(other.tenantsIds_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.Email.Length != 0)
        num1 ^= this.Email.GetHashCode();
      if (this.Name.Length != 0)
        num1 ^= this.Name.GetHashCode();
      if (this.WindowsIdentity.Length != 0)
        num1 ^= this.WindowsIdentity.GetHashCode();
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      if (this.RoleId != 0)
      {
        int num3 = num1;
        num2 = this.RoleId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      int num4 = num1 ^ this.tenantsIds_.GetHashCode();
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
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
      if (this.Email.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Email);
      }
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Name);
      }
      if (this.WindowsIdentity.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.WindowsIdentity);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Comment);
      }
      if (this.RoleId != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.RoleId);
      }
      this.tenantsIds_.WriteTo(output, AdministratorProto._repeated_tenantsIds_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Id != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.Email.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Email);
      if (this.Name.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this.WindowsIdentity.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.WindowsIdentity);
      if (this.Comment.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.RoleId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
      int num2 = num1 + this.tenantsIds_.CalculateSize(AdministratorProto._repeated_tenantsIds_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AdministratorProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Email.Length != 0)
        this.Email = other.Email;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.WindowsIdentity.Length != 0)
        this.WindowsIdentity = other.WindowsIdentity;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.RoleId != 0)
        this.RoleId = other.RoleId;
      this.tenantsIds_.Add((IEnumerable<int>) other.tenantsIds_);
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
            this.Email = input.ReadString();
            continue;
          case 26:
            this.Name = input.ReadString();
            continue;
          case 34:
            this.WindowsIdentity = input.ReadString();
            continue;
          case 42:
            this.Comment = input.ReadString();
            continue;
          case 48:
            this.RoleId = input.ReadInt32();
            continue;
          case 56:
          case 58:
            this.tenantsIds_.AddEntriesFrom(input, AdministratorProto._repeated_tenantsIds_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
