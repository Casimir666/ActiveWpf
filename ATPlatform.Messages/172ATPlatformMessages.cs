// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCommissionSettingsSetsNotificationProto
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
  public sealed class GetCommissionSettingsSetsNotificationProto : 
    IMessage<GetCommissionSettingsSetsNotificationProto>,
    IMessage,
    IEquatable<GetCommissionSettingsSetsNotificationProto>,
    IDeepCloneable<GetCommissionSettingsSetsNotificationProto>
  {
    private static readonly MessageParser<GetCommissionSettingsSetsNotificationProto> _parser = new MessageParser<GetCommissionSettingsSetsNotificationProto>((Func<GetCommissionSettingsSetsNotificationProto>) (() => new GetCommissionSettingsSetsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CommissionSettingsSetsFieldNumber = 1;
    private static readonly FieldCodec<CommissionSettingsSetProto> _repeated_commissionSettingsSets_codec = FieldCodec.ForMessage<CommissionSettingsSetProto>(10U, CommissionSettingsSetProto.Parser);
    private readonly RepeatedField<CommissionSettingsSetProto> commissionSettingsSets_ = new RepeatedField<CommissionSettingsSetProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetCommissionSettingsSetsNotificationProto> Parser => GetCommissionSettingsSetsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[168];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCommissionSettingsSetsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCommissionSettingsSetsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCommissionSettingsSetsNotificationProto(
      GetCommissionSettingsSetsNotificationProto other)
      : this()
    {
      this.commissionSettingsSets_ = other.commissionSettingsSets_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCommissionSettingsSetsNotificationProto Clone() => new GetCommissionSettingsSetsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<CommissionSettingsSetProto> CommissionSettingsSets => this.commissionSettingsSets_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCommissionSettingsSetsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCommissionSettingsSetsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.commissionSettingsSets_.Equals(other.commissionSettingsSets_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.commissionSettingsSets_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.commissionSettingsSets_.WriteTo(output, GetCommissionSettingsSetsNotificationProto._repeated_commissionSettingsSets_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.commissionSettingsSets_.CalculateSize(GetCommissionSettingsSetsNotificationProto._repeated_commissionSettingsSets_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCommissionSettingsSetsNotificationProto other)
    {
      if (other == null)
        return;
      this.commissionSettingsSets_.Add((IEnumerable<CommissionSettingsSetProto>) other.commissionSettingsSets_);
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
          this.commissionSettingsSets_.AddEntriesFrom(input, GetCommissionSettingsSetsNotificationProto._repeated_commissionSettingsSets_codec);
      }
    }
  }
}
