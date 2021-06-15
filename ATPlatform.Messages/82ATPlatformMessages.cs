// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TradeSettingsSetRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TradeSettingsSetRequestProto : 
    IMessage<TradeSettingsSetRequestProto>,
    IMessage,
    IEquatable<TradeSettingsSetRequestProto>,
    IDeepCloneable<TradeSettingsSetRequestProto>
  {
    private static readonly MessageParser<TradeSettingsSetRequestProto> _parser = new MessageParser<TradeSettingsSetRequestProto>((Func<TradeSettingsSetRequestProto>) (() => new TradeSettingsSetRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int TradeSettingsSetFieldNumber = 1;
    private TradeSettingsSetProto tradeSettingsSet_;

    [DebuggerNonUserCode]
    public static MessageParser<TradeSettingsSetRequestProto> Parser => TradeSettingsSetRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[70];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TradeSettingsSetRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public TradeSettingsSetRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public TradeSettingsSetRequestProto(TradeSettingsSetRequestProto other)
      : this()
    {
      this.tradeSettingsSet_ = other.tradeSettingsSet_ != null ? other.tradeSettingsSet_.Clone() : (TradeSettingsSetProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TradeSettingsSetRequestProto Clone() => new TradeSettingsSetRequestProto(this);

    [DebuggerNonUserCode]
    public TradeSettingsSetProto TradeSettingsSet
    {
      get => this.tradeSettingsSet_;
      set => this.tradeSettingsSet_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TradeSettingsSetRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(TradeSettingsSetRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.TradeSettingsSet, (object) other.TradeSettingsSet) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.tradeSettingsSet_ != null)
        num ^= this.TradeSettingsSet.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.tradeSettingsSet_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.TradeSettingsSet);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.tradeSettingsSet_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.TradeSettingsSet);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TradeSettingsSetRequestProto other)
    {
      if (other == null)
        return;
      if (other.tradeSettingsSet_ != null)
      {
        if (this.tradeSettingsSet_ == null)
          this.TradeSettingsSet = new TradeSettingsSetProto();
        this.TradeSettingsSet.MergeFrom(other.TradeSettingsSet);
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
          if (this.tradeSettingsSet_ == null)
            this.TradeSettingsSet = new TradeSettingsSetProto();
          input.ReadMessage((IMessage) this.TradeSettingsSet);
        }
      }
    }
  }
}
