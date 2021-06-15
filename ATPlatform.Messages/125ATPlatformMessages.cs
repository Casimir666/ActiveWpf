// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SymbolRequestProto : 
    IMessage<SymbolRequestProto>,
    IMessage,
    IEquatable<SymbolRequestProto>,
    IDeepCloneable<SymbolRequestProto>
  {
    private static readonly MessageParser<SymbolRequestProto> _parser = new MessageParser<SymbolRequestProto>((Func<SymbolRequestProto>) (() => new SymbolRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private SymbolProto symbol_;
    public const int SymbolTradingSessionsFieldNumber = 2;
    private SymbolTradingSessionsProto symbolTradingSessions_;
    public const int SymbolMarginTiersFieldNumber = 3;
    private SymbolMarginTiersProto symbolMarginTiers_;
    public const int SymbolTagsFieldNumber = 4;
    private SymbolTagsProto symbolTags_;

    [DebuggerNonUserCode]
    public static MessageParser<SymbolRequestProto> Parser => SymbolRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[118];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolRequestProto(SymbolRequestProto other)
      : this()
    {
      this.symbol_ = other.symbol_ != null ? other.symbol_.Clone() : (SymbolProto) null;
      this.symbolTradingSessions_ = other.symbolTradingSessions_ != null ? other.symbolTradingSessions_.Clone() : (SymbolTradingSessionsProto) null;
      this.symbolMarginTiers_ = other.symbolMarginTiers_ != null ? other.symbolMarginTiers_.Clone() : (SymbolMarginTiersProto) null;
      this.symbolTags_ = other.symbolTags_ != null ? other.symbolTags_.Clone() : (SymbolTagsProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolRequestProto Clone() => new SymbolRequestProto(this);

    [DebuggerNonUserCode]
    public SymbolProto Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = value;
    }

    [DebuggerNonUserCode]
    public SymbolTradingSessionsProto SymbolTradingSessions
    {
      get => this.symbolTradingSessions_;
      set => this.symbolTradingSessions_ = value;
    }

    [DebuggerNonUserCode]
    public SymbolMarginTiersProto SymbolMarginTiers
    {
      get => this.symbolMarginTiers_;
      set => this.symbolMarginTiers_ = value;
    }

    [DebuggerNonUserCode]
    public SymbolTagsProto SymbolTags
    {
      get => this.symbolTags_;
      set => this.symbolTags_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Symbol, (object) other.Symbol) && object.Equals((object) this.SymbolTradingSessions, (object) other.SymbolTradingSessions) && (object.Equals((object) this.SymbolMarginTiers, (object) other.SymbolMarginTiers) && object.Equals((object) this.SymbolTags, (object) other.SymbolTags)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.symbol_ != null)
        num ^= this.Symbol.GetHashCode();
      if (this.symbolTradingSessions_ != null)
        num ^= this.SymbolTradingSessions.GetHashCode();
      if (this.symbolMarginTiers_ != null)
        num ^= this.SymbolMarginTiers.GetHashCode();
      if (this.symbolTags_ != null)
        num ^= this.SymbolTags.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.symbol_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Symbol);
      }
      if (this.symbolTradingSessions_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.SymbolTradingSessions);
      }
      if (this.symbolMarginTiers_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.SymbolMarginTiers);
      }
      if (this.symbolTags_ != null)
      {
        output.WriteRawTag((byte) 34);
        output.WriteMessage((IMessage) this.SymbolTags);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.symbol_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Symbol);
      if (this.symbolTradingSessions_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.SymbolTradingSessions);
      if (this.symbolMarginTiers_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.SymbolMarginTiers);
      if (this.symbolTags_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.SymbolTags);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolRequestProto other)
    {
      if (other == null)
        return;
      if (other.symbol_ != null)
      {
        if (this.symbol_ == null)
          this.Symbol = new SymbolProto();
        this.Symbol.MergeFrom(other.Symbol);
      }
      if (other.symbolTradingSessions_ != null)
      {
        if (this.symbolTradingSessions_ == null)
          this.SymbolTradingSessions = new SymbolTradingSessionsProto();
        this.SymbolTradingSessions.MergeFrom(other.SymbolTradingSessions);
      }
      if (other.symbolMarginTiers_ != null)
      {
        if (this.symbolMarginTiers_ == null)
          this.SymbolMarginTiers = new SymbolMarginTiersProto();
        this.SymbolMarginTiers.MergeFrom(other.SymbolMarginTiers);
      }
      if (other.symbolTags_ != null)
      {
        if (this.symbolTags_ == null)
          this.SymbolTags = new SymbolTagsProto();
        this.SymbolTags.MergeFrom(other.SymbolTags);
      }
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
            if (this.symbol_ == null)
              this.Symbol = new SymbolProto();
            input.ReadMessage((IMessage) this.Symbol);
            continue;
          case 18:
            if (this.symbolTradingSessions_ == null)
              this.SymbolTradingSessions = new SymbolTradingSessionsProto();
            input.ReadMessage((IMessage) this.SymbolTradingSessions);
            continue;
          case 26:
            if (this.symbolMarginTiers_ == null)
              this.SymbolMarginTiers = new SymbolMarginTiersProto();
            input.ReadMessage((IMessage) this.SymbolMarginTiers);
            continue;
          case 34:
            if (this.symbolTags_ == null)
              this.SymbolTags = new SymbolTagsProto();
            input.ReadMessage((IMessage) this.SymbolTags);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
