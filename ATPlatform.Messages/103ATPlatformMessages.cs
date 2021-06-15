// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsTradingSessionsNotificationProto
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
  public sealed class GetSymbolsTradingSessionsNotificationProto : 
    IMessage<GetSymbolsTradingSessionsNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsTradingSessionsNotificationProto>,
    IDeepCloneable<GetSymbolsTradingSessionsNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsTradingSessionsNotificationProto> _parser = new MessageParser<GetSymbolsTradingSessionsNotificationProto>((Func<GetSymbolsTradingSessionsNotificationProto>) (() => new GetSymbolsTradingSessionsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolTradingSessionsFieldNumber = 1;
    private static readonly FieldCodec<SymbolTradingSessionsProto> _repeated_symbolTradingSessions_codec = FieldCodec.ForMessage<SymbolTradingSessionsProto>(10U, SymbolTradingSessionsProto.Parser);
    private readonly RepeatedField<SymbolTradingSessionsProto> symbolTradingSessions_ = new RepeatedField<SymbolTradingSessionsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsTradingSessionsNotificationProto> Parser => GetSymbolsTradingSessionsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[96];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsTradingSessionsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsTradingSessionsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsTradingSessionsNotificationProto(
      GetSymbolsTradingSessionsNotificationProto other)
      : this()
    {
      this.symbolTradingSessions_ = other.symbolTradingSessions_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsTradingSessionsNotificationProto Clone() => new GetSymbolsTradingSessionsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolTradingSessionsProto> SymbolTradingSessions => this.symbolTradingSessions_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsTradingSessionsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsTradingSessionsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.symbolTradingSessions_.Equals(other.symbolTradingSessions_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.symbolTradingSessions_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.symbolTradingSessions_.WriteTo(output, GetSymbolsTradingSessionsNotificationProto._repeated_symbolTradingSessions_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbolTradingSessions_.CalculateSize(GetSymbolsTradingSessionsNotificationProto._repeated_symbolTradingSessions_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsTradingSessionsNotificationProto other)
    {
      if (other == null)
        return;
      this.symbolTradingSessions_.Add((IEnumerable<SymbolTradingSessionsProto>) other.symbolTradingSessions_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.symbolTradingSessions_.AddEntriesFrom(input, GetSymbolsTradingSessionsNotificationProto._repeated_symbolTradingSessions_codec);
      }
    }
  }
}
