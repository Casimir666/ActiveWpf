// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertStatelessAlertDataProto
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
  public sealed class AbuseAlertStatelessAlertDataProto : 
    IMessage<AbuseAlertStatelessAlertDataProto>,
    IMessage,
    IEquatable<AbuseAlertStatelessAlertDataProto>,
    IDeepCloneable<AbuseAlertStatelessAlertDataProto>
  {
    private static readonly MessageParser<AbuseAlertStatelessAlertDataProto> _parser = new MessageParser<AbuseAlertStatelessAlertDataProto>((Func<AbuseAlertStatelessAlertDataProto>) (() => new AbuseAlertStatelessAlertDataProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int RuleCodeFieldNumber = 2;
    private int ruleCode_;
    public const int RuleNameFieldNumber = 3;
    private string ruleName_ = "";
    public const int AccountIdFieldNumber = 4;
    private int accountId_;
    public const int AlertKeyFieldNumber = 5;
    private string alertKey_ = "";
    public const int TimestampFieldNumber = 6;
    private long timestamp_;
    public const int DataSnapshotFieldNumber = 7;
    private string dataSnapshot_ = "";
    public const int SettingsSnapshotFieldNumber = 8;
    private string settingsSnapshot_ = "";
    public const int AdditionalDataFieldNumber = 9;
    private static readonly FieldCodec<string> _repeated_additionalData_codec = FieldCodec.ForString(74U);
    private readonly RepeatedField<string> additionalData_ = new RepeatedField<string>();
    public const int AccountNameFieldNumber = 10;
    private string accountName_ = "";
    public const int AccountTradeSettingsFieldNumber = 11;
    private string accountTradeSettings_ = "";
    public const int AccountHedgeSettingsFieldNumber = 12;
    private string accountHedgeSettings_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertStatelessAlertDataProto> Parser => AbuseAlertStatelessAlertDataProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[0];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertStatelessAlertDataProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertStatelessAlertDataProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertStatelessAlertDataProto(AbuseAlertStatelessAlertDataProto other)
      : this()
    {
      this.id_ = other.id_;
      this.ruleCode_ = other.ruleCode_;
      this.ruleName_ = other.ruleName_;
      this.accountId_ = other.accountId_;
      this.alertKey_ = other.alertKey_;
      this.timestamp_ = other.timestamp_;
      this.dataSnapshot_ = other.dataSnapshot_;
      this.settingsSnapshot_ = other.settingsSnapshot_;
      this.additionalData_ = other.additionalData_.Clone();
      this.accountName_ = other.accountName_;
      this.accountTradeSettings_ = other.accountTradeSettings_;
      this.accountHedgeSettings_ = other.accountHedgeSettings_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertStatelessAlertDataProto Clone() => new AbuseAlertStatelessAlertDataProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

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
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string AlertKey
    {
      get => this.alertKey_;
      set => this.alertKey_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string DataSnapshot
    {
      get => this.dataSnapshot_;
      set => this.dataSnapshot_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string SettingsSnapshot
    {
      get => this.settingsSnapshot_;
      set => this.settingsSnapshot_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> AdditionalData => this.additionalData_;

    [DebuggerNonUserCode]
    public string AccountName
    {
      get => this.accountName_;
      set => this.accountName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string AccountTradeSettings
    {
      get => this.accountTradeSettings_;
      set => this.accountTradeSettings_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string AccountHedgeSettings
    {
      get => this.accountHedgeSettings_;
      set => this.accountHedgeSettings_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertStatelessAlertDataProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertStatelessAlertDataProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.RuleCode == other.RuleCode && (!(this.RuleName != other.RuleName) && this.AccountId == other.AccountId) && (!(this.AlertKey != other.AlertKey) && this.Timestamp == other.Timestamp && (!(this.DataSnapshot != other.DataSnapshot) && !(this.SettingsSnapshot != other.SettingsSnapshot))) && (this.additionalData_.Equals(other.additionalData_) && !(this.AccountName != other.AccountName) && (!(this.AccountTradeSettings != other.AccountTradeSettings) && !(this.AccountHedgeSettings != other.AccountHedgeSettings))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.RuleCode != 0)
      {
        int num3 = num1;
        num2 = this.RuleCode;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.RuleName.Length != 0)
        num1 ^= this.RuleName.GetHashCode();
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.AlertKey.Length != 0)
        num1 ^= this.AlertKey.GetHashCode();
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this.DataSnapshot.Length != 0)
        num1 ^= this.DataSnapshot.GetHashCode();
      if (this.SettingsSnapshot.Length != 0)
        num1 ^= this.SettingsSnapshot.GetHashCode();
      int num4 = num1 ^ this.additionalData_.GetHashCode();
      if (this.AccountName.Length != 0)
        num4 ^= this.AccountName.GetHashCode();
      if (this.AccountTradeSettings.Length != 0)
        num4 ^= this.AccountTradeSettings.GetHashCode();
      if (this.AccountHedgeSettings.Length != 0)
        num4 ^= this.AccountHedgeSettings.GetHashCode();
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.RuleCode != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.RuleCode);
      }
      if (this.RuleName.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.RuleName);
      }
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.AccountId);
      }
      if (this.AlertKey.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.AlertKey);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.Timestamp);
      }
      if (this.DataSnapshot.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.DataSnapshot);
      }
      if (this.SettingsSnapshot.Length != 0)
      {
        output.WriteRawTag((byte) 66);
        output.WriteString(this.SettingsSnapshot);
      }
      this.additionalData_.WriteTo(output, AbuseAlertStatelessAlertDataProto._repeated_additionalData_codec);
      if (this.AccountName.Length != 0)
      {
        output.WriteRawTag((byte) 82);
        output.WriteString(this.AccountName);
      }
      if (this.AccountTradeSettings.Length != 0)
      {
        output.WriteRawTag((byte) 90);
        output.WriteString(this.AccountTradeSettings);
      }
      if (this.AccountHedgeSettings.Length != 0)
      {
        output.WriteRawTag((byte) 98);
        output.WriteString(this.AccountHedgeSettings);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Id != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.RuleCode != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.RuleCode);
      if (this.RuleName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.RuleName);
      if (this.AccountId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.AlertKey.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.AlertKey);
      if (this.Timestamp != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.DataSnapshot.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.DataSnapshot);
      if (this.SettingsSnapshot.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SettingsSnapshot);
      int num2 = num1 + this.additionalData_.CalculateSize(AbuseAlertStatelessAlertDataProto._repeated_additionalData_codec);
      if (this.AccountName.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.AccountName);
      if (this.AccountTradeSettings.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.AccountTradeSettings);
      if (this.AccountHedgeSettings.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.AccountHedgeSettings);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertStatelessAlertDataProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.RuleCode != 0)
        this.RuleCode = other.RuleCode;
      if (other.RuleName.Length != 0)
        this.RuleName = other.RuleName;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.AlertKey.Length != 0)
        this.AlertKey = other.AlertKey;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.DataSnapshot.Length != 0)
        this.DataSnapshot = other.DataSnapshot;
      if (other.SettingsSnapshot.Length != 0)
        this.SettingsSnapshot = other.SettingsSnapshot;
      this.additionalData_.Add((IEnumerable<string>) other.additionalData_);
      if (other.AccountName.Length != 0)
        this.AccountName = other.AccountName;
      if (other.AccountTradeSettings.Length != 0)
        this.AccountTradeSettings = other.AccountTradeSettings;
      if (other.AccountHedgeSettings.Length != 0)
        this.AccountHedgeSettings = other.AccountHedgeSettings;
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
            this.Id = input.ReadInt32();
            continue;
          case 16:
            this.RuleCode = input.ReadInt32();
            continue;
          case 26:
            this.RuleName = input.ReadString();
            continue;
          case 32:
            this.AccountId = input.ReadInt32();
            continue;
          case 42:
            this.AlertKey = input.ReadString();
            continue;
          case 48:
            this.Timestamp = input.ReadInt64();
            continue;
          case 58:
            this.DataSnapshot = input.ReadString();
            continue;
          case 66:
            this.SettingsSnapshot = input.ReadString();
            continue;
          case 74:
            this.additionalData_.AddEntriesFrom(input, AbuseAlertStatelessAlertDataProto._repeated_additionalData_codec);
            continue;
          case 82:
            this.AccountName = input.ReadString();
            continue;
          case 90:
            this.AccountTradeSettings = input.ReadString();
            continue;
          case 98:
            this.AccountHedgeSettings = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
