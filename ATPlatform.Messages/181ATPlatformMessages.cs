// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.RolesRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class RolesRequestProto : 
    IMessage<RolesRequestProto>,
    IMessage,
    IEquatable<RolesRequestProto>,
    IDeepCloneable<RolesRequestProto>
  {
    private static readonly MessageParser<RolesRequestProto> _parser = new MessageParser<RolesRequestProto>((Func<RolesRequestProto>) (() => new RolesRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int RoleFieldNumber = 1;
    private RoleProto role_;

    [DebuggerNonUserCode]
    public static MessageParser<RolesRequestProto> Parser => RolesRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[179];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => RolesRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public RolesRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public RolesRequestProto(RolesRequestProto other)
      : this()
    {
      this.role_ = other.role_ != null ? other.role_.Clone() : (RoleProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public RolesRequestProto Clone() => new RolesRequestProto(this);

    [DebuggerNonUserCode]
    public RoleProto Role
    {
      get => this.role_;
      set => this.role_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as RolesRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(RolesRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Role, (object) other.Role) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.role_ != null)
        num ^= this.Role.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.role_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Role);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.role_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Role);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(RolesRequestProto other)
    {
      if (other == null)
        return;
      if (other.role_ != null)
      {
        if (this.role_ == null)
          this.Role = new RoleProto();
        this.Role.MergeFrom(other.Role);
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
          if (this.role_ == null)
            this.Role = new RoleProto();
          input.ReadMessage((IMessage) this.Role);
        }
      }
    }
  }
}
