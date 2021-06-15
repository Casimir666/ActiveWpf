﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CommissionGroupsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CommissionGroupsNotificationProto : 
    IMessage<CommissionGroupsNotificationProto>,
    IMessage,
    IEquatable<CommissionGroupsNotificationProto>,
    IDeepCloneable<CommissionGroupsNotificationProto>
  {
    private static readonly MessageParser<CommissionGroupsNotificationProto> _parser = new MessageParser<CommissionGroupsNotificationProto>((Func<CommissionGroupsNotificationProto>) (() => new CommissionGroupsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CommissionGroupFieldNumber = 1;
    private CommissionGroupProto commissionGroup_;

    [DebuggerNonUserCode]
    public static MessageParser<CommissionGroupsNotificationProto> Parser => CommissionGroupsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[166];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CommissionGroupsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public CommissionGroupsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public CommissionGroupsNotificationProto(CommissionGroupsNotificationProto other)
      : this()
    {
      this.commissionGroup_ = other.commissionGroup_ != null ? other.commissionGroup_.Clone() : (CommissionGroupProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CommissionGroupsNotificationProto Clone() => new CommissionGroupsNotificationProto(this);

    [DebuggerNonUserCode]
    public CommissionGroupProto CommissionGroup
    {
      get => this.commissionGroup_;
      set => this.commissionGroup_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CommissionGroupsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(CommissionGroupsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.CommissionGroup, (object) other.CommissionGroup) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.commissionGroup_ != null)
        num ^= this.CommissionGroup.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.commissionGroup_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.CommissionGroup);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.commissionGroup_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.CommissionGroup);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CommissionGroupsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.commissionGroup_ != null)
      {
        if (this.commissionGroup_ == null)
          this.CommissionGroup = new CommissionGroupProto();
        this.CommissionGroup.MergeFrom(other.CommissionGroup);
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
          if (this.commissionGroup_ == null)
            this.CommissionGroup = new CommissionGroupProto();
          input.ReadMessage((IMessage) this.CommissionGroup);
        }
      }
    }
  }
}
