// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolTradingSessionsProto
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
  public sealed class SymbolTradingSessionsProto : 
    IMessage<SymbolTradingSessionsProto>,
    IMessage,
    IEquatable<SymbolTradingSessionsProto>,
    IDeepCloneable<SymbolTradingSessionsProto>
  {
    private static readonly MessageParser<SymbolTradingSessionsProto> _parser = new MessageParser<SymbolTradingSessionsProto>((Func<SymbolTradingSessionsProto>) (() => new SymbolTradingSessionsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";
    public const int TradingSessionFieldNumber = 2;
    private static readonly FieldCodec<TradingSessionProto> _repeated_tradingSession_codec = FieldCodec.ForMessage<TradingSessionProto>(18U, TradingSessionProto.Parser);
    private readonly RepeatedField<TradingSessionProto> tradingSession_ = new RepeatedField<TradingSessionProto>();

    [DebuggerNonUserCode]
    public static MessageParser<SymbolTradingSessionsProto> Parser => SymbolTradingSessionsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[94];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolTradingSessionsProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolTradingSessionsProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolTradingSessionsProto(SymbolTradingSessionsProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.tradingSession_ = other.tradingSession_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolTradingSessionsProto Clone() => new SymbolTradingSessionsProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<TradingSessionProto> TradingSession => this.tradingSession_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolTradingSessionsProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolTradingSessionsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && this.tradingSession_.Equals(other.tradingSession_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      int num2 = num1 ^ this.tradingSession_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.SymbolId);
      }
      this.tradingSession_.WriteTo(output, SymbolTradingSessionsProto._repeated_tradingSession_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.SymbolId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      int num2 = num1 + this.tradingSession_.CalculateSize(SymbolTradingSessionsProto._repeated_tradingSession_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolTradingSessionsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      this.tradingSession_.Add((IEnumerable<TradingSessionProto>) other.tradingSession_);
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
          case 10:
            this.SymbolId = input.ReadString();
            continue;
          case 18:
            this.tradingSession_.AddEntriesFrom(input, SymbolTradingSessionsProto._repeated_tradingSession_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
