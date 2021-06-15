// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountsFilterProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetAccountsFilterProto : 
    IMessage<GetAccountsFilterProto>,
    IMessage,
    IEquatable<GetAccountsFilterProto>,
    IDeepCloneable<GetAccountsFilterProto>
  {
    private static readonly MessageParser<GetAccountsFilterProto> _parser = new MessageParser<GetAccountsFilterProto>((Func<GetAccountsFilterProto>) (() => new GetAccountsFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int CustomerEmailFieldNumber = 2;
    private string customerEmail_ = "";
    public const int FromRegistrationDateFieldNumber = 3;
    private long fromRegistrationDate_;
    public const int ToRegistrationDateFieldNumber = 4;
    private long toRegistrationDate_;
    public const int IncludeClosedFieldNumber = 5;
    private bool includeClosed_;

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountsFilterProto> Parser => GetAccountsFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[51];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountsFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountsFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountsFilterProto(GetAccountsFilterProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.customerEmail_ = other.customerEmail_;
      this.fromRegistrationDate_ = other.fromRegistrationDate_;
      this.toRegistrationDate_ = other.toRegistrationDate_;
      this.includeClosed_ = other.includeClosed_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountsFilterProto Clone() => new GetAccountsFilterProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string CustomerEmail
    {
      get => this.customerEmail_;
      set => this.customerEmail_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long FromRegistrationDate
    {
      get => this.fromRegistrationDate_;
      set => this.fromRegistrationDate_ = value;
    }

    [DebuggerNonUserCode]
    public long ToRegistrationDate
    {
      get => this.toRegistrationDate_;
      set => this.toRegistrationDate_ = value;
    }

    [DebuggerNonUserCode]
    public bool IncludeClosed
    {
      get => this.includeClosed_;
      set => this.includeClosed_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountsFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountsFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.CustomerEmail != other.CustomerEmail) && (this.FromRegistrationDate == other.FromRegistrationDate && this.ToRegistrationDate == other.ToRegistrationDate) && this.IncludeClosed == other.IncludeClosed && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      if (this.CustomerEmail.Length != 0)
        num1 ^= this.CustomerEmail.GetHashCode();
      long registrationDate;
      if (this.FromRegistrationDate != 0L)
      {
        int num2 = num1;
        registrationDate = this.FromRegistrationDate;
        int hashCode = registrationDate.GetHashCode();
        num1 = num2 ^ hashCode;
      }
      if (this.ToRegistrationDate != 0L)
      {
        int num2 = num1;
        registrationDate = this.ToRegistrationDate;
        int hashCode = registrationDate.GetHashCode();
        num1 = num2 ^ hashCode;
      }
      if (this.IncludeClosed)
        num1 ^= this.IncludeClosed.GetHashCode();
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
      if (this.CustomerEmail.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.CustomerEmail);
      }
      if (this.FromRegistrationDate != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.FromRegistrationDate);
      }
      if (this.ToRegistrationDate != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.ToRegistrationDate);
      }
      if (this.IncludeClosed)
      {
        output.WriteRawTag((byte) 40);
        output.WriteBool(this.IncludeClosed);
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
      if (this.CustomerEmail.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.CustomerEmail);
      if (this.FromRegistrationDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.FromRegistrationDate);
      if (this.ToRegistrationDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.ToRegistrationDate);
      if (this.IncludeClosed)
        num += 2;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountsFilterProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.CustomerEmail.Length != 0)
        this.CustomerEmail = other.CustomerEmail;
      if (other.FromRegistrationDate != 0L)
        this.FromRegistrationDate = other.FromRegistrationDate;
      if (other.ToRegistrationDate != 0L)
        this.ToRegistrationDate = other.ToRegistrationDate;
      if (other.IncludeClosed)
        this.IncludeClosed = other.IncludeClosed;
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
          case 18:
            this.CustomerEmail = input.ReadString();
            continue;
          case 24:
            this.FromRegistrationDate = input.ReadInt64();
            continue;
          case 32:
            this.ToRegistrationDate = input.ReadInt64();
            continue;
          case 40:
            this.IncludeClosed = input.ReadBool();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
