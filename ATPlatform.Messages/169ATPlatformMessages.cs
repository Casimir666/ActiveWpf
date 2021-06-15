// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCommissionGroupsNotificationProto
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
  public sealed class GetCommissionGroupsNotificationProto : 
    IMessage<GetCommissionGroupsNotificationProto>,
    IMessage,
    IEquatable<GetCommissionGroupsNotificationProto>,
    IDeepCloneable<GetCommissionGroupsNotificationProto>
  {
    private static readonly MessageParser<GetCommissionGroupsNotificationProto> _parser = new MessageParser<GetCommissionGroupsNotificationProto>((Func<GetCommissionGroupsNotificationProto>) (() => new GetCommissionGroupsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CommissionGroupsFieldNumber = 1;
    private static readonly FieldCodec<CommissionGroupProto> _repeated_commissionGroups_codec = FieldCodec.ForMessage<CommissionGroupProto>(10U, CommissionGroupProto.Parser);
    private readonly RepeatedField<CommissionGroupProto> commissionGroups_ = new RepeatedField<CommissionGroupProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetCommissionGroupsNotificationProto> Parser => GetCommissionGroupsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[164];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCommissionGroupsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCommissionGroupsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCommissionGroupsNotificationProto(GetCommissionGroupsNotificationProto other)
      : this()
    {
      this.commissionGroups_ = other.commissionGroups_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCommissionGroupsNotificationProto Clone() => new GetCommissionGroupsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<CommissionGroupProto> CommissionGroups => this.commissionGroups_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCommissionGroupsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCommissionGroupsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.commissionGroups_.Equals(other.commissionGroups_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.commissionGroups_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.commissionGroups_.WriteTo(output, GetCommissionGroupsNotificationProto._repeated_commissionGroups_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.commissionGroups_.CalculateSize(GetCommissionGroupsNotificationProto._repeated_commissionGroups_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCommissionGroupsNotificationProto other)
    {
      if (other == null)
        return;
      this.commissionGroups_.Add((IEnumerable<CommissionGroupProto>) other.commissionGroups_);
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
          this.commissionGroups_.AddEntriesFrom(input, GetCommissionGroupsNotificationProto._repeated_commissionGroups_codec);
      }
    }
  }
}
