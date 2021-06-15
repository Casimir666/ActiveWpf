// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountBalanceOperationsFilterProto
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
  public sealed class GetAccountBalanceOperationsFilterProto : 
    IMessage<GetAccountBalanceOperationsFilterProto>,
    IMessage,
    IEquatable<GetAccountBalanceOperationsFilterProto>,
    IDeepCloneable<GetAccountBalanceOperationsFilterProto>
  {
    private static readonly MessageParser<GetAccountBalanceOperationsFilterProto> _parser = new MessageParser<GetAccountBalanceOperationsFilterProto>((Func<GetAccountBalanceOperationsFilterProto>) (() => new GetAccountBalanceOperationsFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int StartDateFieldNumber = 1;
    private long startDate_;
    public const int EndDateFieldNumber = 2;
    private long endDate_;
    public const int Types_FieldNumber = 3;
    private static readonly FieldCodec<BalanceChangeTypeProto> _repeated_types_codec = FieldCodec.ForEnum<BalanceChangeTypeProto>(26U, (Func<BalanceChangeTypeProto, int>) (x => (int) x), (Func<int, BalanceChangeTypeProto>) (x => (BalanceChangeTypeProto) x));
    private readonly RepeatedField<BalanceChangeTypeProto> types_ = new RepeatedField<BalanceChangeTypeProto>();
    public const int AccountIdsFieldNumber = 4;
    private static readonly FieldCodec<int> _repeated_accountIds_codec = FieldCodec.ForInt32(34U);
    private readonly RepeatedField<int> accountIds_ = new RepeatedField<int>();
    public const int BalanceIdsFieldNumber = 5;
    private static readonly FieldCodec<long> _repeated_balanceIds_codec = FieldCodec.ForInt64(42U);
    private readonly RepeatedField<long> balanceIds_ = new RepeatedField<long>();
    public const int CommentFieldNumber = 6;
    private string comment_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountBalanceOperationsFilterProto> Parser => GetAccountBalanceOperationsFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[60];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountBalanceOperationsFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilterProto(GetAccountBalanceOperationsFilterProto other)
      : this()
    {
      this.startDate_ = other.startDate_;
      this.endDate_ = other.endDate_;
      this.types_ = other.types_.Clone();
      this.accountIds_ = other.accountIds_.Clone();
      this.balanceIds_ = other.balanceIds_.Clone();
      this.comment_ = other.comment_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilterProto Clone() => new GetAccountBalanceOperationsFilterProto(this);

    [DebuggerNonUserCode]
    public long StartDate
    {
      get => this.startDate_;
      set => this.startDate_ = value;
    }

    [DebuggerNonUserCode]
    public long EndDate
    {
      get => this.endDate_;
      set => this.endDate_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<BalanceChangeTypeProto> Types_ => this.types_;

    [DebuggerNonUserCode]
    public RepeatedField<int> AccountIds => this.accountIds_;

    [DebuggerNonUserCode]
    public RepeatedField<long> BalanceIds => this.balanceIds_;

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountBalanceOperationsFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountBalanceOperationsFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.StartDate == other.StartDate && this.EndDate == other.EndDate && (this.types_.Equals(other.types_) && this.accountIds_.Equals(other.accountIds_)) && (this.balanceIds_.Equals(other.balanceIds_) && !(this.Comment != other.Comment)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      long num2;
      if (this.StartDate != 0L)
      {
        int num3 = num1;
        num2 = this.StartDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.EndDate != 0L)
      {
        int num3 = num1;
        num2 = this.EndDate;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      int num4 = num1 ^ this.types_.GetHashCode() ^ this.accountIds_.GetHashCode() ^ this.balanceIds_.GetHashCode();
      if (this.Comment.Length != 0)
        num4 ^= this.Comment.GetHashCode();
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.StartDate != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.StartDate);
      }
      if (this.EndDate != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.EndDate);
      }
      this.types_.WriteTo(output, GetAccountBalanceOperationsFilterProto._repeated_types_codec);
      this.accountIds_.WriteTo(output, GetAccountBalanceOperationsFilterProto._repeated_accountIds_codec);
      this.balanceIds_.WriteTo(output, GetAccountBalanceOperationsFilterProto._repeated_balanceIds_codec);
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Comment);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.StartDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.StartDate);
      if (this.EndDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.EndDate);
      int num2 = num1 + this.types_.CalculateSize(GetAccountBalanceOperationsFilterProto._repeated_types_codec) + this.accountIds_.CalculateSize(GetAccountBalanceOperationsFilterProto._repeated_accountIds_codec) + this.balanceIds_.CalculateSize(GetAccountBalanceOperationsFilterProto._repeated_balanceIds_codec);
      if (this.Comment.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountBalanceOperationsFilterProto other)
    {
      if (other == null)
        return;
      if (other.StartDate != 0L)
        this.StartDate = other.StartDate;
      if (other.EndDate != 0L)
        this.EndDate = other.EndDate;
      this.types_.Add((IEnumerable<BalanceChangeTypeProto>) other.types_);
      this.accountIds_.Add((IEnumerable<int>) other.accountIds_);
      this.balanceIds_.Add((IEnumerable<long>) other.balanceIds_);
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
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
            this.StartDate = input.ReadInt64();
            continue;
          case 16:
            this.EndDate = input.ReadInt64();
            continue;
          case 24:
          case 26:
            this.types_.AddEntriesFrom(input, GetAccountBalanceOperationsFilterProto._repeated_types_codec);
            continue;
          case 32:
          case 34:
            this.accountIds_.AddEntriesFrom(input, GetAccountBalanceOperationsFilterProto._repeated_accountIds_codec);
            continue;
          case 40:
          case 42:
            this.balanceIds_.AddEntriesFrom(input, GetAccountBalanceOperationsFilterProto._repeated_balanceIds_codec);
            continue;
          case 50:
            this.Comment = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
