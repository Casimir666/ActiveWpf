// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.UpdateAccountBalanceRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class UpdateAccountBalanceRequestProto : 
    IMessage<UpdateAccountBalanceRequestProto>,
    IMessage,
    IEquatable<UpdateAccountBalanceRequestProto>,
    IDeepCloneable<UpdateAccountBalanceRequestProto>
  {
    private static readonly MessageParser<UpdateAccountBalanceRequestProto> _parser = new MessageParser<UpdateAccountBalanceRequestProto>((Func<UpdateAccountBalanceRequestProto>) (() => new UpdateAccountBalanceRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountBalanceOperationFieldNumber = 1;
    private AccountBalanceOperationProto accountBalanceOperation_;

    [DebuggerNonUserCode]
    public static MessageParser<UpdateAccountBalanceRequestProto> Parser => UpdateAccountBalanceRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[56];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => UpdateAccountBalanceRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public UpdateAccountBalanceRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public UpdateAccountBalanceRequestProto(UpdateAccountBalanceRequestProto other)
      : this()
    {
      this.accountBalanceOperation_ = other.accountBalanceOperation_ != null ? other.accountBalanceOperation_.Clone() : (AccountBalanceOperationProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public UpdateAccountBalanceRequestProto Clone() => new UpdateAccountBalanceRequestProto(this);

    [DebuggerNonUserCode]
    public AccountBalanceOperationProto AccountBalanceOperation
    {
      get => this.accountBalanceOperation_;
      set => this.accountBalanceOperation_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as UpdateAccountBalanceRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(UpdateAccountBalanceRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.AccountBalanceOperation, (object) other.AccountBalanceOperation) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.accountBalanceOperation_ != null)
        num ^= this.AccountBalanceOperation.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.accountBalanceOperation_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.AccountBalanceOperation);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.accountBalanceOperation_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AccountBalanceOperation);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(UpdateAccountBalanceRequestProto other)
    {
      if (other == null)
        return;
      if (other.accountBalanceOperation_ != null)
      {
        if (this.accountBalanceOperation_ == null)
          this.AccountBalanceOperation = new AccountBalanceOperationProto();
        this.AccountBalanceOperation.MergeFrom(other.AccountBalanceOperation);
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
          if (this.accountBalanceOperation_ == null)
            this.AccountBalanceOperation = new AccountBalanceOperationProto();
          input.ReadMessage((IMessage) this.AccountBalanceOperation);
        }
      }
    }
  }
}
