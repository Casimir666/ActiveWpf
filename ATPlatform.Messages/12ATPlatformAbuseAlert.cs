// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertRuleSettingsProto
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
  public sealed class AbuseAlertRuleSettingsProto : 
    IMessage<AbuseAlertRuleSettingsProto>,
    IMessage,
    IEquatable<AbuseAlertRuleSettingsProto>,
    IDeepCloneable<AbuseAlertRuleSettingsProto>
  {
    private static readonly MessageParser<AbuseAlertRuleSettingsProto> _parser = new MessageParser<AbuseAlertRuleSettingsProto>((Func<AbuseAlertRuleSettingsProto>) (() => new AbuseAlertRuleSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int RuleCodeFieldNumber = 1;
    private int ruleCode_;
    public const int RuleNameFieldNumber = 2;
    private string ruleName_ = "";
    public const int RuleSettingsFieldsFieldNumber = 3;
    private static readonly FieldCodec<AbuseAlertRuleSettingKeyValueProto> _repeated_ruleSettingsFields_codec = FieldCodec.ForMessage<AbuseAlertRuleSettingKeyValueProto>(26U, AbuseAlertRuleSettingKeyValueProto.Parser);
    private readonly RepeatedField<AbuseAlertRuleSettingKeyValueProto> ruleSettingsFields_ = new RepeatedField<AbuseAlertRuleSettingKeyValueProto>();

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertRuleSettingsProto> Parser => AbuseAlertRuleSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[11];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertRuleSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingsProto(AbuseAlertRuleSettingsProto other)
      : this()
    {
      this.ruleCode_ = other.ruleCode_;
      this.ruleName_ = other.ruleName_;
      this.ruleSettingsFields_ = other.ruleSettingsFields_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingsProto Clone() => new AbuseAlertRuleSettingsProto(this);

    [DebuggerNonUserCode]
    public int RuleCode
    {
      get => this.ruleCode_;
      set => this.ruleCode_ = value;
    }

    [DebuggerNonUserCode]
    public string RuleName
    {
      get => this.ruleName_;
      set => this.ruleName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<AbuseAlertRuleSettingKeyValueProto> RuleSettingsFields => this.ruleSettingsFields_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertRuleSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertRuleSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.RuleCode == other.RuleCode && !(this.RuleName != other.RuleName) && this.ruleSettingsFields_.Equals(other.ruleSettingsFields_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.RuleCode != 0)
        num1 ^= this.RuleCode.GetHashCode();
      if (this.RuleName.Length != 0)
        num1 ^= this.RuleName.GetHashCode();
      int num2 = num1 ^ this.ruleSettingsFields_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.RuleCode != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.RuleCode);
      }
      if (this.RuleName.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.RuleName);
      }
      this.ruleSettingsFields_.WriteTo(output, AbuseAlertRuleSettingsProto._repeated_ruleSettingsFields_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.RuleCode != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.RuleCode);
      if (this.RuleName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.RuleName);
      int num2 = num1 + this.ruleSettingsFields_.CalculateSize(AbuseAlertRuleSettingsProto._repeated_ruleSettingsFields_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertRuleSettingsProto other)
    {
      if (other == null)
        return;
      if (other.RuleCode != 0)
        this.RuleCode = other.RuleCode;
      if (other.RuleName.Length != 0)
        this.RuleName = other.RuleName;
      this.ruleSettingsFields_.Add((IEnumerable<AbuseAlertRuleSettingKeyValueProto>) other.ruleSettingsFields_);
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
            this.RuleCode = input.ReadInt32();
            continue;
          case 18:
            this.RuleName = input.ReadString();
            continue;
          case 26:
            this.ruleSettingsFields_.AddEntriesFrom(input, AbuseAlertRuleSettingsProto._repeated_ruleSettingsFields_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
