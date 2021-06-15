// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.UpdateBarsRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class UpdateBarsRequestProto : 
    IMessage<UpdateBarsRequestProto>,
    IMessage,
    IEquatable<UpdateBarsRequestProto>,
    IDeepCloneable<UpdateBarsRequestProto>
  {
    private static readonly MessageParser<UpdateBarsRequestProto> _parser = new MessageParser<UpdateBarsRequestProto>((Func<UpdateBarsRequestProto>) (() => new UpdateBarsRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int BarsFieldNumber = 1;
    private HistoryQuotesForSymbolProto bars_;

    [DebuggerNonUserCode]
    public static MessageParser<UpdateBarsRequestProto> Parser => UpdateBarsRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[155];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => UpdateBarsRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public UpdateBarsRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public UpdateBarsRequestProto(UpdateBarsRequestProto other)
      : this()
    {
      this.bars_ = other.bars_ != null ? other.bars_.Clone() : (HistoryQuotesForSymbolProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public UpdateBarsRequestProto Clone() => new UpdateBarsRequestProto(this);

    [DebuggerNonUserCode]
    public HistoryQuotesForSymbolProto Bars
    {
      get => this.bars_;
      set => this.bars_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as UpdateBarsRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(UpdateBarsRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Bars, (object) other.Bars) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.bars_ != null)
        num ^= this.Bars.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.bars_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Bars);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.bars_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Bars);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(UpdateBarsRequestProto other)
    {
      if (other == null)
        return;
      if (other.bars_ != null)
      {
        if (this.bars_ == null)
          this.Bars = new HistoryQuotesForSymbolProto();
        this.Bars.MergeFrom(other.Bars);
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
          if (this.bars_ == null)
            this.Bars = new HistoryQuotesForSymbolProto();
          input.ReadMessage((IMessage) this.Bars);
        }
      }
    }
  }
}
