// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.GetAbuseAlertRulesSettingsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class GetAbuseAlertRulesSettingsNotificationProto : 
    IMessage<GetAbuseAlertRulesSettingsNotificationProto>,
    IMessage,
    IEquatable<GetAbuseAlertRulesSettingsNotificationProto>,
    IDeepCloneable<GetAbuseAlertRulesSettingsNotificationProto>
  {
    private static readonly MessageParser<GetAbuseAlertRulesSettingsNotificationProto> _parser = new MessageParser<GetAbuseAlertRulesSettingsNotificationProto>((Func<GetAbuseAlertRulesSettingsNotificationProto>) (() => new GetAbuseAlertRulesSettingsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AllRulesSettingsFieldNumber = 1;
    private static readonly FieldCodec<AbuseAlertRuleSettingsProto> _repeated_allRulesSettings_codec = FieldCodec.ForMessage<AbuseAlertRuleSettingsProto>(10U, AbuseAlertRuleSettingsProto.Parser);
    private readonly RepeatedField<AbuseAlertRuleSettingsProto> allRulesSettings_ = new RepeatedField<AbuseAlertRuleSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetAbuseAlertRulesSettingsNotificationProto> Parser => GetAbuseAlertRulesSettingsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[13];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAbuseAlertRulesSettingsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsNotificationProto(
      GetAbuseAlertRulesSettingsNotificationProto other)
      : this()
    {
      this.allRulesSettings_ = other.allRulesSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsNotificationProto Clone() => new GetAbuseAlertRulesSettingsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AbuseAlertRuleSettingsProto> AllRulesSettings => this.allRulesSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAbuseAlertRulesSettingsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAbuseAlertRulesSettingsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.allRulesSettings_.Equals(other.allRulesSettings_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.allRulesSettings_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.allRulesSettings_.WriteTo(output, GetAbuseAlertRulesSettingsNotificationProto._repeated_allRulesSettings_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.allRulesSettings_.CalculateSize(GetAbuseAlertRulesSettingsNotificationProto._repeated_allRulesSettings_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAbuseAlertRulesSettingsNotificationProto other)
    {
      if (other == null)
        return;
      this.allRulesSettings_.Add((IEnumerable<AbuseAlertRuleSettingsProto>) other.allRulesSettings_);
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
          this.allRulesSettings_.AddEntriesFrom(input, GetAbuseAlertRulesSettingsNotificationProto._repeated_allRulesSettings_codec);
      }
    }
  }
}
