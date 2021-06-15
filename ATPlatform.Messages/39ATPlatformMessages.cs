// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountEquityProto
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
  public sealed class AccountEquityProto : 
    IMessage<AccountEquityProto>,
    IMessage,
    IEquatable<AccountEquityProto>,
    IDeepCloneable<AccountEquityProto>
  {
    private static readonly MessageParser<AccountEquityProto> _parser = new MessageParser<AccountEquityProto>((Func<AccountEquityProto>) (() => new AccountEquityProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private long accountId_;
    public const int EquityFieldNumber = 2;
    private double equity_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountEquityProto> Parser => AccountEquityProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[21];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountEquityProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountEquityProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountEquityProto(AccountEquityProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.equity_ = other.equity_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountEquityProto Clone() => new AccountEquityProto(this);

    [DebuggerNonUserCode]
    public long AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public double Equity
    {
      get => this.equity_;
      set => this.equity_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountEquityProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountEquityProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Equity, other.Equity) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0L)
        num ^= this.AccountId.GetHashCode();
      if (this.Equity != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Equity);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.AccountId);
      }
      if (this.Equity != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Equity);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.AccountId);
      if (this.Equity != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountEquityProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0L)
        this.AccountId = other.AccountId;
      if (other.Equity != 0.0)
        this.Equity = other.Equity;
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
            this.AccountId = input.ReadInt64();
            continue;
          case 17:
            this.Equity = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
