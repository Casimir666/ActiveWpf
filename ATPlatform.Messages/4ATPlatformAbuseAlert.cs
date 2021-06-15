// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AlertsFilteredRequestProto
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
  public sealed class AlertsFilteredRequestProto : 
    IMessage<AlertsFilteredRequestProto>,
    IMessage,
    IEquatable<AlertsFilteredRequestProto>,
    IDeepCloneable<AlertsFilteredRequestProto>
  {
    private static readonly MessageParser<AlertsFilteredRequestProto> _parser = new MessageParser<AlertsFilteredRequestProto>((Func<AlertsFilteredRequestProto>) (() => new AlertsFilteredRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int DateFromFieldNumber = 1;
    private long dateFrom_;
    public const int DateToFieldNumber = 2;
    private long dateTo_;
    public const int AccountIdsFieldNumber = 3;
    private static readonly FieldCodec<int> _repeated_accountIds_codec = FieldCodec.ForInt32(26U);
    private readonly RepeatedField<int> accountIds_ = new RepeatedField<int>();
    public const int RuleCodesFieldNumber = 4;
    private static readonly FieldCodec<int> _repeated_ruleCodes_codec = FieldCodec.ForInt32(34U);
    private readonly RepeatedField<int> ruleCodes_ = new RepeatedField<int>();
    public const int StatesFieldNumber = 5;
    private static readonly FieldCodec<AbuseAlertStateType> _repeated_states_codec = FieldCodec.ForEnum<AbuseAlertStateType>(42U, (Func<AbuseAlertStateType, int>) (x => (int) x), (Func<int, AbuseAlertStateType>) (x => (AbuseAlertStateType) x));
    private readonly RepeatedField<AbuseAlertStateType> states_ = new RepeatedField<AbuseAlertStateType>();

    [DebuggerNonUserCode]
    public static MessageParser<AlertsFilteredRequestProto> Parser => AlertsFilteredRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[3];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AlertsFilteredRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public AlertsFilteredRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public AlertsFilteredRequestProto(AlertsFilteredRequestProto other)
      : this()
    {
      this.dateFrom_ = other.dateFrom_;
      this.dateTo_ = other.dateTo_;
      this.accountIds_ = other.accountIds_.Clone();
      this.ruleCodes_ = other.ruleCodes_.Clone();
      this.states_ = other.states_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AlertsFilteredRequestProto Clone() => new AlertsFilteredRequestProto(this);

    [DebuggerNonUserCode]
    public long DateFrom
    {
      get => this.dateFrom_;
      set => this.dateFrom_ = value;
    }

    [DebuggerNonUserCode]
    public long DateTo
    {
      get => this.dateTo_;
      set => this.dateTo_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<int> AccountIds => this.accountIds_;

    [DebuggerNonUserCode]
    public RepeatedField<int> RuleCodes => this.ruleCodes_;

    [DebuggerNonUserCode]
    public RepeatedField<AbuseAlertStateType> States => this.states_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AlertsFilteredRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(AlertsFilteredRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.DateFrom == other.DateFrom && this.DateTo == other.DateTo && (this.accountIds_.Equals(other.accountIds_) && this.ruleCodes_.Equals(other.ruleCodes_)) && this.states_.Equals(other.states_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      long num2;
      if (this.DateFrom != 0L)
      {
        int num3 = num1;
        num2 = this.DateFrom;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.DateTo != 0L)
      {
        int num3 = num1;
        num2 = this.DateTo;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      int num4 = num1 ^ this.accountIds_.GetHashCode() ^ this.ruleCodes_.GetHashCode() ^ this.states_.GetHashCode();
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.DateFrom != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.DateFrom);
      }
      if (this.DateTo != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.DateTo);
      }
      this.accountIds_.WriteTo(output, AlertsFilteredRequestProto._repeated_accountIds_codec);
      this.ruleCodes_.WriteTo(output, AlertsFilteredRequestProto._repeated_ruleCodes_codec);
      this.states_.WriteTo(output, AlertsFilteredRequestProto._repeated_states_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.DateFrom != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.DateFrom);
      if (this.DateTo != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.DateTo);
      int num2 = num1 + this.accountIds_.CalculateSize(AlertsFilteredRequestProto._repeated_accountIds_codec) + this.ruleCodes_.CalculateSize(AlertsFilteredRequestProto._repeated_ruleCodes_codec) + this.states_.CalculateSize(AlertsFilteredRequestProto._repeated_states_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AlertsFilteredRequestProto other)
    {
      if (other == null)
        return;
      if (other.DateFrom != 0L)
        this.DateFrom = other.DateFrom;
      if (other.DateTo != 0L)
        this.DateTo = other.DateTo;
      this.accountIds_.Add((IEnumerable<int>) other.accountIds_);
      this.ruleCodes_.Add((IEnumerable<int>) other.ruleCodes_);
      this.states_.Add((IEnumerable<AbuseAlertStateType>) other.states_);
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
            this.DateFrom = input.ReadInt64();
            continue;
          case 16:
            this.DateTo = input.ReadInt64();
            continue;
          case 24:
          case 26:
            this.accountIds_.AddEntriesFrom(input, AlertsFilteredRequestProto._repeated_accountIds_codec);
            continue;
          case 32:
          case 34:
            this.ruleCodes_.AddEntriesFrom(input, AlertsFilteredRequestProto._repeated_ruleCodes_codec);
            continue;
          case 40:
          case 42:
            this.states_.AddEntriesFrom(input, AlertsFilteredRequestProto._repeated_states_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
