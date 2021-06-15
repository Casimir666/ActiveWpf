﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TenantNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TenantNotificationProto : 
    IMessage<TenantNotificationProto>,
    IMessage,
    IEquatable<TenantNotificationProto>,
    IDeepCloneable<TenantNotificationProto>
  {
    private static readonly MessageParser<TenantNotificationProto> _parser = new MessageParser<TenantNotificationProto>((Func<TenantNotificationProto>) (() => new TenantNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TenantFieldNumber = 1;
    private TenantProto tenant_;

    [DebuggerNonUserCode]
    public static MessageParser<TenantNotificationProto> Parser => TenantNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[219];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TenantNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public TenantNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public TenantNotificationProto(TenantNotificationProto other)
      : this()
    {
      this.tenant_ = other.tenant_ != null ? other.tenant_.Clone() : (TenantProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TenantNotificationProto Clone() => new TenantNotificationProto(this);

    [DebuggerNonUserCode]
    public TenantProto Tenant
    {
      get => this.tenant_;
      set => this.tenant_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TenantNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(TenantNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Tenant, (object) other.Tenant) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.tenant_ != null)
        num ^= this.Tenant.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.tenant_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Tenant);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.tenant_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Tenant);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TenantNotificationProto other)
    {
      if (other == null)
        return;
      if (other.tenant_ != null)
      {
        if (this.tenant_ == null)
          this.Tenant = new TenantProto();
        this.Tenant.MergeFrom(other.Tenant);
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
          if (this.tenant_ == null)
            this.Tenant = new TenantProto();
          input.ReadMessage((IMessage) this.Tenant);
        }
      }
    }
  }
}
