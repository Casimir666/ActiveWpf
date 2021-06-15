// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarkupSessionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class MarkupSessionProto : 
    IMessage<MarkupSessionProto>,
    IMessage,
    IEquatable<MarkupSessionProto>,
    IDeepCloneable<MarkupSessionProto>
  {
    private static readonly MessageParser<MarkupSessionProto> _parser = new MessageParser<MarkupSessionProto>((Func<MarkupSessionProto>) (() => new MarkupSessionProto()));
    private UnknownFieldSet _unknownFields;
    public const int AskMarkupFieldNumber = 1;
    private int askMarkup_;
    public const int BidMarkupFieldNumber = 2;
    private int bidMarkup_;
    public const int TradingSessionFieldNumber = 3;
    private TradingSessionProto tradingSession_;

    [DebuggerNonUserCode]
    public static MessageParser<MarkupSessionProto> Parser => MarkupSessionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[74];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarkupSessionProto.Descriptor;

    [DebuggerNonUserCode]
    public MarkupSessionProto()
    {
    }

    [DebuggerNonUserCode]
    public MarkupSessionProto(MarkupSessionProto other)
      : this()
    {
      this.askMarkup_ = other.askMarkup_;
      this.bidMarkup_ = other.bidMarkup_;
      this.tradingSession_ = other.tradingSession_ != null ? other.tradingSession_.Clone() : (TradingSessionProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarkupSessionProto Clone() => new MarkupSessionProto(this);

    [DebuggerNonUserCode]
    public int AskMarkup
    {
      get => this.askMarkup_;
      set => this.askMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public int BidMarkup
    {
      get => this.bidMarkup_;
      set => this.bidMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public TradingSessionProto TradingSession
    {
      get => this.tradingSession_;
      set => this.tradingSession_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarkupSessionProto);

    [DebuggerNonUserCode]
    public bool Equals(MarkupSessionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AskMarkup == other.AskMarkup && this.BidMarkup == other.BidMarkup && object.Equals((object) this.TradingSession, (object) other.TradingSession) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AskMarkup != 0)
      {
        int num3 = num1;
        num2 = this.AskMarkup;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.BidMarkup != 0)
      {
        int num3 = num1;
        num2 = this.BidMarkup;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.tradingSession_ != null)
        num1 ^= this.TradingSession.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AskMarkup != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AskMarkup);
      }
      if (this.BidMarkup != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.BidMarkup);
      }
      if (this.tradingSession_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.TradingSession);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AskMarkup != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AskMarkup);
      if (this.BidMarkup != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.BidMarkup);
      if (this.tradingSession_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.TradingSession);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarkupSessionProto other)
    {
      if (other == null)
        return;
      if (other.AskMarkup != 0)
        this.AskMarkup = other.AskMarkup;
      if (other.BidMarkup != 0)
        this.BidMarkup = other.BidMarkup;
      if (other.tradingSession_ != null)
      {
        if (this.tradingSession_ == null)
          this.TradingSession = new TradingSessionProto();
        this.TradingSession.MergeFrom(other.TradingSession);
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
          case 8:
            this.AskMarkup = input.ReadInt32();
            continue;
          case 16:
            this.BidMarkup = input.ReadInt32();
            continue;
          case 26:
            if (this.tradingSession_ == null)
              this.TradingSession = new TradingSessionProto();
            input.ReadMessage((IMessage) this.TradingSession);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
