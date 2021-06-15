// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolTradingSessionsForAccountNotificationProto
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
  public sealed class GetSymbolTradingSessionsForAccountNotificationProto : 
    IMessage<GetSymbolTradingSessionsForAccountNotificationProto>,
    IMessage,
    IEquatable<GetSymbolTradingSessionsForAccountNotificationProto>,
    IDeepCloneable<GetSymbolTradingSessionsForAccountNotificationProto>
  {
    private static readonly MessageParser<GetSymbolTradingSessionsForAccountNotificationProto> _parser = new MessageParser<GetSymbolTradingSessionsForAccountNotificationProto>((Func<GetSymbolTradingSessionsForAccountNotificationProto>) (() => new GetSymbolTradingSessionsForAccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int SymbolTradingSessionsFieldNumber = 2;
    private static readonly FieldCodec<SymbolTradingSessionsProto> _repeated_symbolTradingSessions_codec = FieldCodec.ForMessage<SymbolTradingSessionsProto>(18U, SymbolTradingSessionsProto.Parser);
    private readonly RepeatedField<SymbolTradingSessionsProto> symbolTradingSessions_ = new RepeatedField<SymbolTradingSessionsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolTradingSessionsForAccountNotificationProto> Parser => GetSymbolTradingSessionsForAccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[137];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolTradingSessionsForAccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountNotificationProto(
      GetSymbolTradingSessionsForAccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.symbolTradingSessions_ = other.symbolTradingSessions_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountNotificationProto Clone() => new GetSymbolTradingSessionsForAccountNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<SymbolTradingSessionsProto> SymbolTradingSessions => this.symbolTradingSessions_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolTradingSessionsForAccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetSymbolTradingSessionsForAccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.symbolTradingSessions_.Equals(other.symbolTradingSessions_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      int num2 = num1 ^ this.symbolTradingSessions_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
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
      this.symbolTradingSessions_.WriteTo(output, GetSymbolTradingSessionsForAccountNotificationProto._repeated_symbolTradingSessions_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.AccountId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      int num2 = num1 + this.symbolTradingSessions_.CalculateSize(GetSymbolTradingSessionsForAccountNotificationProto._repeated_symbolTradingSessions_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetSymbolTradingSessionsForAccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      this.symbolTradingSessions_.Add((IEnumerable<SymbolTradingSessionsProto>) other.symbolTradingSessions_);
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
            this.symbolTradingSessions_.AddEntriesFrom(input, GetSymbolTradingSessionsForAccountNotificationProto._repeated_symbolTradingSessions_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
