// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CommissionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CommissionProto : 
    IMessage<CommissionProto>,
    IMessage,
    IEquatable<CommissionProto>,
    IDeepCloneable<CommissionProto>
  {
    private static readonly MessageParser<CommissionProto> _parser = new MessageParser<CommissionProto>((Func<CommissionProto>) (() => new CommissionProto()));
    private UnknownFieldSet _unknownFields;
    public const int AgentFieldNumber = 1;
    private long agent_;
    public const int AmountFieldNumber = 2;
    private double amount_;
    public const int AmountTypeFieldNumber = 3;
    private CommissionAmountTypeProto amountType_;
    public const int VolumeTypeFieldNumber = 4;
    private VolumeTypeProto volumeType_;
    public const int CommissionTypeFieldNumber = 5;
    private CommissionTypeProto commissionType_;
    public const int MinimumAmountFieldNumber = 6;
    private double minimumAmount_;
    public const int CommissionCurrencyFieldNumber = 7;
    private string commissionCurrency_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<CommissionProto> Parser => CommissionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[161];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CommissionProto.Descriptor;

    [DebuggerNonUserCode]
    public CommissionProto()
    {
    }

    [DebuggerNonUserCode]
    public CommissionProto(CommissionProto other)
      : this()
    {
      this.agent_ = other.agent_;
      this.amount_ = other.amount_;
      this.amountType_ = other.amountType_;
      this.volumeType_ = other.volumeType_;
      this.commissionType_ = other.commissionType_;
      this.minimumAmount_ = other.minimumAmount_;
      this.commissionCurrency_ = other.commissionCurrency_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CommissionProto Clone() => new CommissionProto(this);

    [DebuggerNonUserCode]
    public long Agent
    {
      get => this.agent_;
      set => this.agent_ = value;
    }

    [DebuggerNonUserCode]
    public double Amount
    {
      get => this.amount_;
      set => this.amount_ = value;
    }

    [DebuggerNonUserCode]
    public CommissionAmountTypeProto AmountType
    {
      get => this.amountType_;
      set => this.amountType_ = value;
    }

    [DebuggerNonUserCode]
    public VolumeTypeProto VolumeType
    {
      get => this.volumeType_;
      set => this.volumeType_ = value;
    }

    [DebuggerNonUserCode]
    public CommissionTypeProto CommissionType
    {
      get => this.commissionType_;
      set => this.commissionType_ = value;
    }

    [DebuggerNonUserCode]
    public double MinimumAmount
    {
      get => this.minimumAmount_;
      set => this.minimumAmount_ = value;
    }

    [DebuggerNonUserCode]
    public string CommissionCurrency
    {
      get => this.commissionCurrency_;
      set => this.commissionCurrency_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CommissionProto);

    [DebuggerNonUserCode]
    public bool Equals(CommissionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Agent == other.Agent && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Amount, other.Amount) && (this.AmountType == other.AmountType && this.VolumeType == other.VolumeType) && (this.CommissionType == other.CommissionType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinimumAmount, other.MinimumAmount) && !(this.CommissionCurrency != other.CommissionCurrency)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Agent != 0L)
        num ^= this.Agent.GetHashCode();
      if (this.Amount != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Amount);
      if (this.AmountType != CommissionAmountTypeProto.UndefinedCommissionAmountType)
        num ^= this.AmountType.GetHashCode();
      if (this.VolumeType != VolumeTypeProto.UndefinedVolumeType)
        num ^= this.VolumeType.GetHashCode();
      if (this.CommissionType != CommissionTypeProto.UndefinedCommissionType)
        num ^= this.CommissionType.GetHashCode();
      if (this.MinimumAmount != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinimumAmount);
      if (this.CommissionCurrency.Length != 0)
        num ^= this.CommissionCurrency.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Agent != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.Agent);
      }
      if (this.Amount != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Amount);
      }
      if (this.AmountType != CommissionAmountTypeProto.UndefinedCommissionAmountType)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.AmountType);
      }
      if (this.VolumeType != VolumeTypeProto.UndefinedVolumeType)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.VolumeType);
      }
      if (this.CommissionType != CommissionTypeProto.UndefinedCommissionType)
      {
        output.WriteRawTag((byte) 40);
        output.WriteEnum((int) this.CommissionType);
      }
      if (this.MinimumAmount != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.MinimumAmount);
      }
      if (this.CommissionCurrency.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.CommissionCurrency);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Agent != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Agent);
      if (this.Amount != 0.0)
        num += 9;
      if (this.AmountType != CommissionAmountTypeProto.UndefinedCommissionAmountType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.AmountType);
      if (this.VolumeType != VolumeTypeProto.UndefinedVolumeType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.VolumeType);
      if (this.CommissionType != CommissionTypeProto.UndefinedCommissionType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.CommissionType);
      if (this.MinimumAmount != 0.0)
        num += 9;
      if (this.CommissionCurrency.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.CommissionCurrency);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CommissionProto other)
    {
      if (other == null)
        return;
      if (other.Agent != 0L)
        this.Agent = other.Agent;
      if (other.Amount != 0.0)
        this.Amount = other.Amount;
      if (other.AmountType != CommissionAmountTypeProto.UndefinedCommissionAmountType)
        this.AmountType = other.AmountType;
      if (other.VolumeType != VolumeTypeProto.UndefinedVolumeType)
        this.VolumeType = other.VolumeType;
      if (other.CommissionType != CommissionTypeProto.UndefinedCommissionType)
        this.CommissionType = other.CommissionType;
      if (other.MinimumAmount != 0.0)
        this.MinimumAmount = other.MinimumAmount;
      if (other.CommissionCurrency.Length != 0)
        this.CommissionCurrency = other.CommissionCurrency;
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
            this.Agent = input.ReadInt64();
            continue;
          case 17:
            this.Amount = input.ReadDouble();
            continue;
          case 24:
            this.AmountType = (CommissionAmountTypeProto) input.ReadEnum();
            continue;
          case 32:
            this.VolumeType = (VolumeTypeProto) input.ReadEnum();
            continue;
          case 40:
            this.CommissionType = (CommissionTypeProto) input.ReadEnum();
            continue;
          case 49:
            this.MinimumAmount = input.ReadDouble();
            continue;
          case 58:
            this.CommissionCurrency = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
