// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class AccountRequestProto : 
    IMessage<AccountRequestProto>,
    IMessage,
    IEquatable<AccountRequestProto>,
    IDeepCloneable<AccountRequestProto>
  {
    private static readonly MessageParser<AccountRequestProto> _parser = new MessageParser<AccountRequestProto>((Func<AccountRequestProto>) (() => new AccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountFieldNumber = 1;
    private AccountProto account_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountRequestProto> Parser => AccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[53];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountRequestProto(AccountRequestProto other)
      : this()
    {
      this.account_ = other.account_ != null ? other.account_.Clone() : (AccountProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountRequestProto Clone() => new AccountRequestProto(this);

    [DebuggerNonUserCode]
    public AccountProto Account
    {
      get => this.account_;
      set => this.account_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Account, (object) other.Account) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.account_ != null)
        num ^= this.Account.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.account_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Account);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.account_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Account);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.account_ != null)
      {
        if (this.account_ == null)
          this.Account = new AccountProto();
        this.Account.MergeFrom(other.Account);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.account_ == null)
            this.Account = new AccountProto();
          input.ReadMessage((IMessage) this.Account);
        }
      }
    }
  }
}
