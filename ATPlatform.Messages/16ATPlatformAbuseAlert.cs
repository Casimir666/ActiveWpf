// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertUpdateRuleSettingsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertUpdateRuleSettingsNotificationProto : 
    IMessage<AbuseAlertUpdateRuleSettingsNotificationProto>,
    IMessage,
    IEquatable<AbuseAlertUpdateRuleSettingsNotificationProto>,
    IDeepCloneable<AbuseAlertUpdateRuleSettingsNotificationProto>
  {
    private static readonly MessageParser<AbuseAlertUpdateRuleSettingsNotificationProto> _parser = new MessageParser<AbuseAlertUpdateRuleSettingsNotificationProto>((Func<AbuseAlertUpdateRuleSettingsNotificationProto>) (() => new AbuseAlertUpdateRuleSettingsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int RuleSettingsFieldNumber = 1;
    private AbuseAlertRuleSettingsProto ruleSettings_;

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertUpdateRuleSettingsNotificationProto> Parser => AbuseAlertUpdateRuleSettingsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[15];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertUpdateRuleSettingsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertUpdateRuleSettingsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertUpdateRuleSettingsNotificationProto(
      AbuseAlertUpdateRuleSettingsNotificationProto other)
      : this()
    {
      this.ruleSettings_ = other.ruleSettings_ != null ? other.ruleSettings_.Clone() : (AbuseAlertRuleSettingsProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertUpdateRuleSettingsNotificationProto Clone() => new AbuseAlertUpdateRuleSettingsNotificationProto(this);

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingsProto RuleSettings
    {
      get => this.ruleSettings_;
      set => this.ruleSettings_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertUpdateRuleSettingsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(
      AbuseAlertUpdateRuleSettingsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.RuleSettings, (object) other.RuleSettings) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ruleSettings_ != null)
        num ^= this.RuleSettings.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ruleSettings_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.RuleSettings);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ruleSettings_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.RuleSettings);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      AbuseAlertUpdateRuleSettingsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ruleSettings_ != null)
      {
        if (this.ruleSettings_ == null)
          this.RuleSettings = new AbuseAlertRuleSettingsProto();
        this.RuleSettings.MergeFrom(other.RuleSettings);
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
          if (this.ruleSettings_ == null)
            this.RuleSettings = new AbuseAlertRuleSettingsProto();
          input.ReadMessage((IMessage) this.RuleSettings);
        }
      }
    }
  }
}
