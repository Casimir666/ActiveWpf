// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsByTradeSetNotificationProto
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
  public sealed class GetSymbolsByTradeSetNotificationProto : 
    IMessage<GetSymbolsByTradeSetNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsByTradeSetNotificationProto>,
    IDeepCloneable<GetSymbolsByTradeSetNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsByTradeSetNotificationProto> _parser = new MessageParser<GetSymbolsByTradeSetNotificationProto>((Func<GetSymbolsByTradeSetNotificationProto>) (() => new GetSymbolsByTradeSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TradeSetNameFieldNumber = 1;
    private string tradeSetName_ = "";
    public const int SymbolsFieldNumber = 2;
    private static readonly FieldCodec<SymbolProto> _repeated_symbols_codec = FieldCodec.ForMessage<SymbolProto>(18U, SymbolProto.Parser);
    private readonly RepeatedField<SymbolProto> symbols_ = new RepeatedField<SymbolProto>();
    public const int SymbolGroupsFieldNumber = 3;
    private static readonly FieldCodec<SymbolGroupProto> _repeated_symbolGroups_codec = FieldCodec.ForMessage<SymbolGroupProto>(26U, SymbolGroupProto.Parser);
    private readonly RepeatedField<SymbolGroupProto> symbolGroups_ = new RepeatedField<SymbolGroupProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsByTradeSetNotificationProto> Parser => GetSymbolsByTradeSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[111];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsByTradeSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetNotificationProto(GetSymbolsByTradeSetNotificationProto other)
      : this()
    {
      this.tradeSetName_ = other.tradeSetName_;
      this.symbols_ = other.symbols_.Clone();
      this.symbolGroups_ = other.symbolGroups_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetNotificationProto Clone() => new GetSymbolsByTradeSetNotificationProto(this);

    [DebuggerNonUserCode]
    public string TradeSetName
    {
      get => this.tradeSetName_;
      set => this.tradeSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<SymbolProto> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public RepeatedField<SymbolGroupProto> SymbolGroups => this.symbolGroups_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsByTradeSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsByTradeSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.TradeSetName != other.TradeSetName) && this.symbols_.Equals(other.symbols_) && this.symbolGroups_.Equals(other.symbolGroups_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.TradeSetName.Length != 0)
        num1 ^= this.TradeSetName.GetHashCode();
      int num2 = num1 ^ this.symbols_.GetHashCode() ^ this.symbolGroups_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.TradeSetName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.TradeSetName);
      }
      this.symbols_.WriteTo(output, GetSymbolsByTradeSetNotificationProto._repeated_symbols_codec);
      this.symbolGroups_.WriteTo(output, GetSymbolsByTradeSetNotificationProto._repeated_symbolGroups_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.TradeSetName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.TradeSetName);
      int num2 = num1 + this.symbols_.CalculateSize(GetSymbolsByTradeSetNotificationProto._repeated_symbols_codec) + this.symbolGroups_.CalculateSize(GetSymbolsByTradeSetNotificationProto._repeated_symbolGroups_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsByTradeSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.TradeSetName.Length != 0)
        this.TradeSetName = other.TradeSetName;
      this.symbols_.Add((IEnumerable<SymbolProto>) other.symbols_);
      this.symbolGroups_.Add((IEnumerable<SymbolGroupProto>) other.symbolGroups_);
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
            this.TradeSetName = input.ReadString();
            continue;
          case 18:
            this.symbols_.AddEntriesFrom(input, GetSymbolsByTradeSetNotificationProto._repeated_symbols_codec);
            continue;
          case 26:
            this.symbolGroups_.AddEntriesFrom(input, GetSymbolsByTradeSetNotificationProto._repeated_symbolGroups_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
