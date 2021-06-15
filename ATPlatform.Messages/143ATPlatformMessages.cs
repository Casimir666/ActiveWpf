// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolTradingSessionsForAccountRequestProto
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
  public sealed class GetSymbolTradingSessionsForAccountRequestProto : 
    IMessage<GetSymbolTradingSessionsForAccountRequestProto>,
    IMessage,
    IEquatable<GetSymbolTradingSessionsForAccountRequestProto>,
    IDeepCloneable<GetSymbolTradingSessionsForAccountRequestProto>
  {
    private static readonly MessageParser<GetSymbolTradingSessionsForAccountRequestProto> _parser = new MessageParser<GetSymbolTradingSessionsForAccountRequestProto>((Func<GetSymbolTradingSessionsForAccountRequestProto>) (() => new GetSymbolTradingSessionsForAccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int SymbolsFieldNumber = 2;
    private static readonly FieldCodec<string> _repeated_symbols_codec = FieldCodec.ForString(18U);
    private readonly RepeatedField<string> symbols_ = new RepeatedField<string>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolTradingSessionsForAccountRequestProto> Parser => GetSymbolTradingSessionsForAccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[136];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolTradingSessionsForAccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountRequestProto(
      GetSymbolTradingSessionsForAccountRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.symbols_ = other.symbols_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolTradingSessionsForAccountRequestProto Clone() => new GetSymbolTradingSessionsForAccountRequestProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolTradingSessionsForAccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetSymbolTradingSessionsForAccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.symbols_.Equals(other.symbols_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      int num2 = num1 ^ this.symbols_.GetHashCode();
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
      this.symbols_.WriteTo(output, GetSymbolTradingSessionsForAccountRequestProto._repeated_symbols_codec);
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
      int num2 = num1 + this.symbols_.CalculateSize(GetSymbolTradingSessionsForAccountRequestProto._repeated_symbols_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetSymbolTradingSessionsForAccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      this.symbols_.Add((IEnumerable<string>) other.symbols_);
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
            this.symbols_.AddEntriesFrom(input, GetSymbolTradingSessionsForAccountRequestProto._repeated_symbols_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
