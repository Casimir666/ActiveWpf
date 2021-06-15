// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TradingSessionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class TradingSessionProto : 
    IMessage<TradingSessionProto>,
    IMessage,
    IEquatable<TradingSessionProto>,
    IDeepCloneable<TradingSessionProto>
  {
    private static readonly MessageParser<TradingSessionProto> _parser = new MessageParser<TradingSessionProto>((Func<TradingSessionProto>) (() => new TradingSessionProto()));
    private UnknownFieldSet _unknownFields;
    public const int DayOfWeekFieldNumber = 1;
    private int dayOfWeek_;
    public const int StartHourFieldNumber = 2;
    private int startHour_;
    public const int EndHourFieldNumber = 3;
    private int endHour_;
    public const int StartMinuteFieldNumber = 4;
    private int startMinute_;
    public const int EndMinuteFieldNumber = 5;
    private int endMinute_;

    [DebuggerNonUserCode]
    public static MessageParser<TradingSessionProto> Parser => TradingSessionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[93];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TradingSessionProto.Descriptor;

    [DebuggerNonUserCode]
    public TradingSessionProto()
    {
    }

    [DebuggerNonUserCode]
    public TradingSessionProto(TradingSessionProto other)
      : this()
    {
      this.dayOfWeek_ = other.dayOfWeek_;
      this.startHour_ = other.startHour_;
      this.endHour_ = other.endHour_;
      this.startMinute_ = other.startMinute_;
      this.endMinute_ = other.endMinute_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TradingSessionProto Clone() => new TradingSessionProto(this);

    [DebuggerNonUserCode]
    public int DayOfWeek
    {
      get => this.dayOfWeek_;
      set => this.dayOfWeek_ = value;
    }

    [DebuggerNonUserCode]
    public int StartHour
    {
      get => this.startHour_;
      set => this.startHour_ = value;
    }

    [DebuggerNonUserCode]
    public int EndHour
    {
      get => this.endHour_;
      set => this.endHour_ = value;
    }

    [DebuggerNonUserCode]
    public int StartMinute
    {
      get => this.startMinute_;
      set => this.startMinute_ = value;
    }

    [DebuggerNonUserCode]
    public int EndMinute
    {
      get => this.endMinute_;
      set => this.endMinute_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TradingSessionProto);

    [DebuggerNonUserCode]
    public bool Equals(TradingSessionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.DayOfWeek == other.DayOfWeek && this.StartHour == other.StartHour && (this.EndHour == other.EndHour && this.StartMinute == other.StartMinute) && this.EndMinute == other.EndMinute && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.DayOfWeek != 0)
      {
        int num3 = num1;
        num2 = this.DayOfWeek;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.StartHour != 0)
      {
        int num3 = num1;
        num2 = this.StartHour;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.EndHour != 0)
      {
        int num3 = num1;
        num2 = this.EndHour;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.StartMinute != 0)
      {
        int num3 = num1;
        num2 = this.StartMinute;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.EndMinute != 0)
      {
        int num3 = num1;
        num2 = this.EndMinute;
        int hashCode = num2.GetHashCode();
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
      if (this.DayOfWeek != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.DayOfWeek);
      }
      if (this.StartHour != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.StartHour);
      }
      if (this.EndHour != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.EndHour);
      }
      if (this.StartMinute != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.StartMinute);
      }
      if (this.EndMinute != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.EndMinute);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.DayOfWeek != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.DayOfWeek);
      if (this.StartHour != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.StartHour);
      if (this.EndHour != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.EndHour);
      if (this.StartMinute != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.StartMinute);
      if (this.EndMinute != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.EndMinute);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TradingSessionProto other)
    {
      if (other == null)
        return;
      if (other.DayOfWeek != 0)
        this.DayOfWeek = other.DayOfWeek;
      if (other.StartHour != 0)
        this.StartHour = other.StartHour;
      if (other.EndHour != 0)
        this.EndHour = other.EndHour;
      if (other.StartMinute != 0)
        this.StartMinute = other.StartMinute;
      if (other.EndMinute != 0)
        this.EndMinute = other.EndMinute;
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
            this.DayOfWeek = input.ReadInt32();
            continue;
          case 16:
            this.StartHour = input.ReadInt32();
            continue;
          case 24:
            this.EndHour = input.ReadInt32();
            continue;
          case 32:
            this.StartMinute = input.ReadInt32();
            continue;
          case 40:
            this.EndMinute = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
