// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountBalanceOperationProto
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
  public sealed class AccountBalanceOperationProto : 
    IMessage<AccountBalanceOperationProto>,
    IMessage,
    IEquatable<AccountBalanceOperationProto>,
    IDeepCloneable<AccountBalanceOperationProto>
  {
    private static readonly MessageParser<AccountBalanceOperationProto> _parser = new MessageParser<AccountBalanceOperationProto>((Func<AccountBalanceOperationProto>) (() => new AccountBalanceOperationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int IdFieldNumber = 2;
    private long id_;
    public const int AmountFieldNumber = 3;
    private double amount_;
    public const int BalanceChangeTypeFieldNumber = 4;
    private BalanceChangeTypeProto balanceChangeType_;
    public const int ExternalOperationIdFieldNumber = 5;
    private long externalOperationId_;
    public const int TimestampFieldNumber = 6;
    private long timestamp_;
    public const int CommentFieldNumber = 7;
    private string comment_ = "";
    public const int InverseOperationIdFieldNumber = 8;
    private long inverseOperationId_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountBalanceOperationProto> Parser => AccountBalanceOperationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[55];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountBalanceOperationProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountBalanceOperationProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountBalanceOperationProto(AccountBalanceOperationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.id_ = other.id_;
      this.amount_ = other.amount_;
      this.balanceChangeType_ = other.balanceChangeType_;
      this.externalOperationId_ = other.externalOperationId_;
      this.timestamp_ = other.timestamp_;
      this.comment_ = other.comment_;
      this.inverseOperationId_ = other.inverseOperationId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountBalanceOperationProto Clone() => new AccountBalanceOperationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public long Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public double Amount
    {
      get => this.amount_;
      set => this.amount_ = value;
    }

    [DebuggerNonUserCode]
    public BalanceChangeTypeProto BalanceChangeType
    {
      get => this.balanceChangeType_;
      set => this.balanceChangeType_ = value;
    }

    [DebuggerNonUserCode]
    public long ExternalOperationId
    {
      get => this.externalOperationId_;
      set => this.externalOperationId_ = value;
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long InverseOperationId
    {
      get => this.inverseOperationId_;
      set => this.inverseOperationId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountBalanceOperationProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountBalanceOperationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.Id == other.Id && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Amount, other.Amount) && this.BalanceChangeType == other.BalanceChangeType) && (this.ExternalOperationId == other.ExternalOperationId && this.Timestamp == other.Timestamp && (!(this.Comment != other.Comment) && this.InverseOperationId == other.InverseOperationId)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      long num2;
      if (this.Id != 0L)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Amount != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Amount);
      if (this.BalanceChangeType != BalanceChangeTypeProto.UndefinedBalanceChange)
        num1 ^= this.BalanceChangeType.GetHashCode();
      if (this.ExternalOperationId != 0L)
      {
        int num3 = num1;
        num2 = this.ExternalOperationId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Timestamp != 0L)
      {
        int num3 = num1;
        num2 = this.Timestamp;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      if (this.InverseOperationId != 0L)
      {
        int num3 = num1;
        num2 = this.InverseOperationId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.Id != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.Id);
      }
      if (this.Amount != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.Amount);
      }
      if (this.BalanceChangeType != BalanceChangeTypeProto.UndefinedBalanceChange)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.BalanceChangeType);
      }
      if (this.ExternalOperationId != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.ExternalOperationId);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.Timestamp);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.Comment);
      }
      if (this.InverseOperationId != 0L)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt64(this.InverseOperationId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.Id != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
      if (this.Amount != 0.0)
        num += 9;
      if (this.BalanceChangeType != BalanceChangeTypeProto.UndefinedBalanceChange)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.BalanceChangeType);
      if (this.ExternalOperationId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.ExternalOperationId);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.Comment.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.InverseOperationId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.InverseOperationId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountBalanceOperationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.Id != 0L)
        this.Id = other.Id;
      if (other.Amount != 0.0)
        this.Amount = other.Amount;
      if (other.BalanceChangeType != BalanceChangeTypeProto.UndefinedBalanceChange)
        this.BalanceChangeType = other.BalanceChangeType;
      if (other.ExternalOperationId != 0L)
        this.ExternalOperationId = other.ExternalOperationId;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.InverseOperationId != 0L)
        this.InverseOperationId = other.InverseOperationId;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 16:
            this.Id = input.ReadInt64();
            continue;
          case 25:
            this.Amount = input.ReadDouble();
            continue;
          case 32:
            this.BalanceChangeType = (BalanceChangeTypeProto) input.ReadEnum();
            continue;
          case 40:
            this.ExternalOperationId = input.ReadInt64();
            continue;
          case 48:
            this.Timestamp = input.ReadInt64();
            continue;
          case 58:
            this.Comment = input.ReadString();
            continue;
          case 64:
            this.InverseOperationId = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
