// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HistoryQuoteProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class HistoryQuoteProto : 
    IMessage<HistoryQuoteProto>,
    IMessage,
    IEquatable<HistoryQuoteProto>,
    IDeepCloneable<HistoryQuoteProto>
  {
    private static readonly MessageParser<HistoryQuoteProto> _parser = new MessageParser<HistoryQuoteProto>((Func<HistoryQuoteProto>) (() => new HistoryQuoteProto()));
    private UnknownFieldSet _unknownFields;
    public const int CloseFieldNumber = 1;
    private int close_;
    public const int CloseAskFieldNumber = 2;
    private int closeAsk_;
    public const int HighFieldNumber = 3;
    private int high_;
    public const int LowFieldNumber = 4;
    private int low_;
    public const int OpenFieldNumber = 5;
    private int open_;
    public const int StartTimestampFieldNumber = 6;
    private long startTimestamp_;
    public const int VolumeFieldNumber = 7;
    private long volume_;

    [DebuggerNonUserCode]
    public static MessageParser<HistoryQuoteProto> Parser => HistoryQuoteProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[28];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HistoryQuoteProto.Descriptor;

    [DebuggerNonUserCode]
    public HistoryQuoteProto()
    {
    }

    [DebuggerNonUserCode]
    public HistoryQuoteProto(HistoryQuoteProto other)
      : this()
    {
      this.close_ = other.close_;
      this.closeAsk_ = other.closeAsk_;
      this.high_ = other.high_;
      this.low_ = other.low_;
      this.open_ = other.open_;
      this.startTimestamp_ = other.startTimestamp_;
      this.volume_ = other.volume_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HistoryQuoteProto Clone() => new HistoryQuoteProto(this);

    [DebuggerNonUserCode]
    public int Close
    {
      get => this.close_;
      set => this.close_ = value;
    }

    [DebuggerNonUserCode]
    public int CloseAsk
    {
      get => this.closeAsk_;
      set => this.closeAsk_ = value;
    }

    [DebuggerNonUserCode]
    public int High
    {
      get => this.high_;
      set => this.high_ = value;
    }

    [DebuggerNonUserCode]
    public int Low
    {
      get => this.low_;
      set => this.low_ = value;
    }

    [DebuggerNonUserCode]
    public int Open
    {
      get => this.open_;
      set => this.open_ = value;
    }

    [DebuggerNonUserCode]
    public long StartTimestamp
    {
      get => this.startTimestamp_;
      set => this.startTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public long Volume
    {
      get => this.volume_;
      set => this.volume_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HistoryQuoteProto);

    [DebuggerNonUserCode]
    public bool Equals(HistoryQuoteProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Close == other.Close && this.CloseAsk == other.CloseAsk && (this.High == other.High && this.Low == other.Low) && (this.Open == other.Open && this.StartTimestamp == other.StartTimestamp && this.Volume == other.Volume) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Close != 0)
      {
        int num3 = num1;
        num2 = this.Close;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CloseAsk != 0)
      {
        int num3 = num1;
        num2 = this.CloseAsk;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.High != 0)
      {
        int num3 = num1;
        num2 = this.High;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Low != 0)
      {
        int num3 = num1;
        num2 = this.Low;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Open != 0)
      {
        int num3 = num1;
        num2 = this.Open;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      long num4;
      if (this.StartTimestamp != 0L)
      {
        int num3 = num1;
        num4 = this.StartTimestamp;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Volume != 0L)
      {
        int num3 = num1;
        num4 = this.Volume;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Close != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Close);
      }
      if (this.CloseAsk != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.CloseAsk);
      }
      if (this.High != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.High);
      }
      if (this.Low != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.Low);
      }
      if (this.Open != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.Open);
      }
      if (this.StartTimestamp != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.StartTimestamp);
      }
      if (this.Volume != 0L)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt64(this.Volume);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Close != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Close);
      if (this.CloseAsk != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.CloseAsk);
      if (this.High != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
      if (this.Low != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Low);
      if (this.Open != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Open);
      if (this.StartTimestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTimestamp);
      if (this.Volume != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Volume);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HistoryQuoteProto other)
    {
      if (other == null)
        return;
      if (other.Close != 0)
        this.Close = other.Close;
      if (other.CloseAsk != 0)
        this.CloseAsk = other.CloseAsk;
      if (other.High != 0)
        this.High = other.High;
      if (other.Low != 0)
        this.Low = other.Low;
      if (other.Open != 0)
        this.Open = other.Open;
      if (other.StartTimestamp != 0L)
        this.StartTimestamp = other.StartTimestamp;
      if (other.Volume != 0L)
        this.Volume = other.Volume;
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
            this.Close = input.ReadInt32();
            continue;
          case 16:
            this.CloseAsk = input.ReadInt32();
            continue;
          case 24:
            this.High = input.ReadInt32();
            continue;
          case 32:
            this.Low = input.ReadInt32();
            continue;
          case 40:
            this.Open = input.ReadInt32();
            continue;
          case 48:
            this.StartTimestamp = input.ReadInt64();
            continue;
          case 56:
            this.Volume = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
