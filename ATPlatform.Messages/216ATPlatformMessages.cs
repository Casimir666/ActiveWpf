// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetTenantsNotificationProto
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
  public sealed class GetTenantsNotificationProto : 
    IMessage<GetTenantsNotificationProto>,
    IMessage,
    IEquatable<GetTenantsNotificationProto>,
    IDeepCloneable<GetTenantsNotificationProto>
  {
    private static readonly MessageParser<GetTenantsNotificationProto> _parser = new MessageParser<GetTenantsNotificationProto>((Func<GetTenantsNotificationProto>) (() => new GetTenantsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TenantsFieldNumber = 1;
    private static readonly FieldCodec<TenantProto> _repeated_tenants_codec = FieldCodec.ForMessage<TenantProto>(10U, TenantProto.Parser);
    private readonly RepeatedField<TenantProto> tenants_ = new RepeatedField<TenantProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetTenantsNotificationProto> Parser => GetTenantsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[217];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetTenantsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetTenantsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetTenantsNotificationProto(GetTenantsNotificationProto other)
      : this()
    {
      this.tenants_ = other.tenants_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetTenantsNotificationProto Clone() => new GetTenantsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TenantProto> Tenants => this.tenants_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetTenantsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetTenantsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.tenants_.Equals(other.tenants_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.tenants_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.tenants_.WriteTo(output, GetTenantsNotificationProto._repeated_tenants_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.tenants_.CalculateSize(GetTenantsNotificationProto._repeated_tenants_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetTenantsNotificationProto other)
    {
      if (other == null)
        return;
      this.tenants_.Add((IEnumerable<TenantProto>) other.tenants_);
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
          this.tenants_.AddEntriesFrom(input, GetTenantsNotificationProto._repeated_tenants_codec);
      }
    }
  }
}
