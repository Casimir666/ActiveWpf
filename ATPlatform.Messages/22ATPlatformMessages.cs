// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountTradeSummaryProto
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
  public sealed class AccountTradeSummaryProto : 
    IMessage<AccountTradeSummaryProto>,
    IMessage,
    IEquatable<AccountTradeSummaryProto>,
    IDeepCloneable<AccountTradeSummaryProto>
  {
    private static readonly MessageParser<AccountTradeSummaryProto> _parser = new MessageParser<AccountTradeSummaryProto>((Func<AccountTradeSummaryProto>) (() => new AccountTradeSummaryProto()));
    private UnknownFieldSet _unknownFields;
    public const int BalanceFieldNumber = 1;
    private double balance_;
    public const int MarginFieldNumber = 2;
    private double margin_;
    public const int EquityFieldNumber = 3;
    private double equity_;
    public const int IdFieldNumber = 4;
    private long id_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountTradeSummaryProto> Parser => AccountTradeSummaryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[3];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountTradeSummaryProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountTradeSummaryProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountTradeSummaryProto(AccountTradeSummaryProto other)
      : this()
    {
      this.balance_ = other.balance_;
      this.margin_ = other.margin_;
      this.equity_ = other.equity_;
      this.id_ = other.id_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountTradeSummaryProto Clone() => new AccountTradeSummaryProto(this);

    [DebuggerNonUserCode]
    public double Balance
    {
      get => this.balance_;
      set => this.balance_ = value;
    }

    [DebuggerNonUserCode]
    public double Margin
    {
      get => this.margin_;
      set => this.margin_ = value;
    }

    [DebuggerNonUserCode]
    public double Equity
    {
      get => this.equity_;
      set => this.equity_ = value;
    }

    [DebuggerNonUserCode]
    public long Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountTradeSummaryProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountTradeSummaryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Balance, other.Balance) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Margin, other.Margin) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Equity, other.Equity) && this.Id == other.Id) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Balance != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Balance);
      if (this.Margin != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Margin);
      if (this.Equity != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Equity);
      if (this.Id != 0L)
        num ^= this.Id.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Balance != 0.0)
      {
        output.WriteRawTag((byte) 9);
        output.WriteDouble(this.Balance);
      }
      if (this.Margin != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Margin);
      }
      if (this.Equity != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.Equity);
      }
      if (this.Id != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.Id);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Balance != 0.0)
        num += 9;
      if (this.Margin != 0.0)
        num += 9;
      if (this.Equity != 0.0)
        num += 9;
      if (this.Id != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountTradeSummaryProto other)
    {
      if (other == null)
        return;
      if (other.Balance != 0.0)
        this.Balance = other.Balance;
      if (other.Margin != 0.0)
        this.Margin = other.Margin;
      if (other.Equity != 0.0)
        this.Equity = other.Equity;
      if (other.Id != 0L)
        this.Id = other.Id;
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
          case 9:
            this.Balance = input.ReadDouble();
            continue;
          case 17:
            this.Margin = input.ReadDouble();
            continue;
          case 25:
            this.Equity = input.ReadDouble();
            continue;
          case 32:
            this.Id = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
