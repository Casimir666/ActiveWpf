// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetRolesNotificationProto
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
  public sealed class GetRolesNotificationProto : 
    IMessage<GetRolesNotificationProto>,
    IMessage,
    IEquatable<GetRolesNotificationProto>,
    IDeepCloneable<GetRolesNotificationProto>
  {
    private static readonly MessageParser<GetRolesNotificationProto> _parser = new MessageParser<GetRolesNotificationProto>((Func<GetRolesNotificationProto>) (() => new GetRolesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int RolesFieldNumber = 1;
    private static readonly FieldCodec<RoleProto> _repeated_roles_codec = FieldCodec.ForMessage<RoleProto>(10U, RoleProto.Parser);
    private readonly RepeatedField<RoleProto> roles_ = new RepeatedField<RoleProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetRolesNotificationProto> Parser => GetRolesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[178];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetRolesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetRolesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetRolesNotificationProto(GetRolesNotificationProto other)
      : this()
    {
      this.roles_ = other.roles_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetRolesNotificationProto Clone() => new GetRolesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<RoleProto> Roles => this.roles_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetRolesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetRolesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.roles_.Equals(other.roles_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.roles_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.roles_.WriteTo(output, GetRolesNotificationProto._repeated_roles_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.roles_.CalculateSize(GetRolesNotificationProto._repeated_roles_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetRolesNotificationProto other)
    {
      if (other == null)
        return;
      this.roles_.Add((IEnumerable<RoleProto>) other.roles_);
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
          this.roles_.AddEntriesFrom(input, GetRolesNotificationProto._repeated_roles_codec);
      }
    }
  }
}
