// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountBalanceOperationNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetAccountBalanceOperationNotificationProto : 
    IMessage<GetAccountBalanceOperationNotificationProto>,
    IMessage,
    IEquatable<GetAccountBalanceOperationNotificationProto>,
    IDeepCloneable<GetAccountBalanceOperationNotificationProto>
  {
    private static readonly MessageParser<GetAccountBalanceOperationNotificationProto> _parser = new MessageParser<GetAccountBalanceOperationNotificationProto>((Func<GetAccountBalanceOperationNotificationProto>) (() => new GetAccountBalanceOperationNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int BalanceOperationFieldNumber = 1;
    private AccountBalanceOperationProto balanceOperation_;

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountBalanceOperationNotificationProto> Parser => GetAccountBalanceOperationNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[59];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountBalanceOperationNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationNotificationProto(
      GetAccountBalanceOperationNotificationProto other)
      : this()
    {
      this.balanceOperation_ = other.balanceOperation_ != null ? other.balanceOperation_.Clone() : (AccountBalanceOperationProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationNotificationProto Clone() => new GetAccountBalanceOperationNotificationProto(this);

    [DebuggerNonUserCode]
    public AccountBalanceOperationProto BalanceOperation
    {
      get => this.balanceOperation_;
      set => this.balanceOperation_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountBalanceOperationNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountBalanceOperationNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.BalanceOperation, (object) other.BalanceOperation) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.balanceOperation_ != null)
        num ^= this.BalanceOperation.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.balanceOperation_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.BalanceOperation);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.balanceOperation_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.BalanceOperation);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountBalanceOperationNotificationProto other)
    {
      if (other == null)
        return;
      if (other.balanceOperation_ != null)
      {
        if (this.balanceOperation_ == null)
          this.BalanceOperation = new AccountBalanceOperationProto();
        this.BalanceOperation.MergeFrom(other.BalanceOperation);
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
          if (this.balanceOperation_ == null)
            this.BalanceOperation = new AccountBalanceOperationProto();
          input.ReadMessage((IMessage) this.BalanceOperation);
        }
      }
    }
  }
}
