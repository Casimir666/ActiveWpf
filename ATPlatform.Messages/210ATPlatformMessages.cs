// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ATServerConfigurationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ATServerConfigurationProto : 
    IMessage<ATServerConfigurationProto>,
    IMessage,
    IEquatable<ATServerConfigurationProto>,
    IDeepCloneable<ATServerConfigurationProto>
  {
    private static readonly MessageParser<ATServerConfigurationProto> _parser = new MessageParser<ATServerConfigurationProto>((Func<ATServerConfigurationProto>) (() => new ATServerConfigurationProto()));
    private UnknownFieldSet _unknownFields;
    public const int PrimaryFeedSourceIdFieldNumber = 1;
    private int primaryFeedSourceId_;
    public const int IsStpModeFieldNumber = 2;
    private bool isStpMode_;
    public const int AggregationAccountIdFieldNumber = 3;
    private int aggregationAccountId_;
    public const int RecordTicksFieldNumber = 4;
    private bool recordTicks_;
    public const int IsSmartBridgeEnabledFieldNumber = 5;
    private bool isSmartBridgeEnabled_;
    public const int SmartBridgeAccountIdFieldNumber = 6;
    private int smartBridgeAccountId_;
    public const int SmartBridgeSettingsSetNameFieldNumber = 7;
    private string smartBridgeSettingsSetName_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<ATServerConfigurationProto> Parser => ATServerConfigurationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[210];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ATServerConfigurationProto.Descriptor;

    [DebuggerNonUserCode]
    public ATServerConfigurationProto()
    {
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationProto(ATServerConfigurationProto other)
      : this()
    {
      this.primaryFeedSourceId_ = other.primaryFeedSourceId_;
      this.isStpMode_ = other.isStpMode_;
      this.aggregationAccountId_ = other.aggregationAccountId_;
      this.recordTicks_ = other.recordTicks_;
      this.isSmartBridgeEnabled_ = other.isSmartBridgeEnabled_;
      this.smartBridgeAccountId_ = other.smartBridgeAccountId_;
      this.smartBridgeSettingsSetName_ = other.smartBridgeSettingsSetName_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationProto Clone() => new ATServerConfigurationProto(this);

    [DebuggerNonUserCode]
    public int PrimaryFeedSourceId
    {
      get => this.primaryFeedSourceId_;
      set => this.primaryFeedSourceId_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsStpMode
    {
      get => this.isStpMode_;
      set => this.isStpMode_ = value;
    }

    [DebuggerNonUserCode]
    public int AggregationAccountId
    {
      get => this.aggregationAccountId_;
      set => this.aggregationAccountId_ = value;
    }

    [DebuggerNonUserCode]
    public bool RecordTicks
    {
      get => this.recordTicks_;
      set => this.recordTicks_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsSmartBridgeEnabled
    {
      get => this.isSmartBridgeEnabled_;
      set => this.isSmartBridgeEnabled_ = value;
    }

    [DebuggerNonUserCode]
    public int SmartBridgeAccountId
    {
      get => this.smartBridgeAccountId_;
      set => this.smartBridgeAccountId_ = value;
    }

    [DebuggerNonUserCode]
    public string SmartBridgeSettingsSetName
    {
      get => this.smartBridgeSettingsSetName_;
      set => this.smartBridgeSettingsSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ATServerConfigurationProto);

    [DebuggerNonUserCode]
    public bool Equals(ATServerConfigurationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.PrimaryFeedSourceId == other.PrimaryFeedSourceId && this.IsStpMode == other.IsStpMode && (this.AggregationAccountId == other.AggregationAccountId && this.RecordTicks == other.RecordTicks) && (this.IsSmartBridgeEnabled == other.IsSmartBridgeEnabled && this.SmartBridgeAccountId == other.SmartBridgeAccountId && !(this.SmartBridgeSettingsSetName != other.SmartBridgeSettingsSetName)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.PrimaryFeedSourceId != 0)
      {
        int num3 = num1;
        num2 = this.PrimaryFeedSourceId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      bool flag;
      if (this.IsStpMode)
      {
        int num3 = num1;
        flag = this.IsStpMode;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.AggregationAccountId != 0)
      {
        int num3 = num1;
        num2 = this.AggregationAccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.RecordTicks)
      {
        int num3 = num1;
        flag = this.RecordTicks;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsSmartBridgeEnabled)
      {
        int num3 = num1;
        flag = this.IsSmartBridgeEnabled;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SmartBridgeAccountId != 0)
      {
        int num3 = num1;
        num2 = this.SmartBridgeAccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SmartBridgeSettingsSetName.Length != 0)
        num1 ^= this.SmartBridgeSettingsSetName.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.PrimaryFeedSourceId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.PrimaryFeedSourceId);
      }
      if (this.IsStpMode)
      {
        output.WriteRawTag((byte) 16);
        output.WriteBool(this.IsStpMode);
      }
      if (this.AggregationAccountId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.AggregationAccountId);
      }
      if (this.RecordTicks)
      {
        output.WriteRawTag((byte) 32);
        output.WriteBool(this.RecordTicks);
      }
      if (this.IsSmartBridgeEnabled)
      {
        output.WriteRawTag((byte) 40);
        output.WriteBool(this.IsSmartBridgeEnabled);
      }
      if (this.SmartBridgeAccountId != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.SmartBridgeAccountId);
      }
      if (this.SmartBridgeSettingsSetName.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.SmartBridgeSettingsSetName);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.PrimaryFeedSourceId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.PrimaryFeedSourceId);
      if (this.IsStpMode)
        num += 2;
      if (this.AggregationAccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AggregationAccountId);
      if (this.RecordTicks)
        num += 2;
      if (this.IsSmartBridgeEnabled)
        num += 2;
      if (this.SmartBridgeAccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SmartBridgeAccountId);
      if (this.SmartBridgeSettingsSetName.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SmartBridgeSettingsSetName);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ATServerConfigurationProto other)
    {
      if (other == null)
        return;
      if (other.PrimaryFeedSourceId != 0)
        this.PrimaryFeedSourceId = other.PrimaryFeedSourceId;
      if (other.IsStpMode)
        this.IsStpMode = other.IsStpMode;
      if (other.AggregationAccountId != 0)
        this.AggregationAccountId = other.AggregationAccountId;
      if (other.RecordTicks)
        this.RecordTicks = other.RecordTicks;
      if (other.IsSmartBridgeEnabled)
        this.IsSmartBridgeEnabled = other.IsSmartBridgeEnabled;
      if (other.SmartBridgeAccountId != 0)
        this.SmartBridgeAccountId = other.SmartBridgeAccountId;
      if (other.SmartBridgeSettingsSetName.Length != 0)
        this.SmartBridgeSettingsSetName = other.SmartBridgeSettingsSetName;
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
            this.PrimaryFeedSourceId = input.ReadInt32();
            continue;
          case 16:
            this.IsStpMode = input.ReadBool();
            continue;
          case 24:
            this.AggregationAccountId = input.ReadInt32();
            continue;
          case 32:
            this.RecordTicks = input.ReadBool();
            continue;
          case 40:
            this.IsSmartBridgeEnabled = input.ReadBool();
            continue;
          case 48:
            this.SmartBridgeAccountId = input.ReadInt32();
            continue;
          case 58:
            this.SmartBridgeSettingsSetName = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
