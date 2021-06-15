// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarginTierProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class MarginTierProto : 
    IMessage<MarginTierProto>,
    IMessage,
    IEquatable<MarginTierProto>,
    IDeepCloneable<MarginTierProto>
  {
    private static readonly MessageParser<MarginTierProto> _parser = new MessageParser<MarginTierProto>((Func<MarginTierProto>) (() => new MarginTierProto()));
    private UnknownFieldSet _unknownFields;
    public const int ThresholdFieldNumber = 1;
    private double threshold_;
    public const int MarginPercentageFieldNumber = 2;
    private int marginPercentage_;

    [DebuggerNonUserCode]
    public static MessageParser<MarginTierProto> Parser => MarginTierProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[43];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarginTierProto.Descriptor;

    [DebuggerNonUserCode]
    public MarginTierProto()
    {
    }

    [DebuggerNonUserCode]
    public MarginTierProto(MarginTierProto other)
      : this()
    {
      this.threshold_ = other.threshold_;
      this.marginPercentage_ = other.marginPercentage_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarginTierProto Clone() => new MarginTierProto(this);

    [DebuggerNonUserCode]
    public double Threshold
    {
      get => this.threshold_;
      set => this.threshold_ = value;
    }

    [DebuggerNonUserCode]
    public int MarginPercentage
    {
      get => this.marginPercentage_;
      set => this.marginPercentage_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarginTierProto);

    [DebuggerNonUserCode]
    public bool Equals(MarginTierProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Threshold, other.Threshold) && this.MarginPercentage == other.MarginPercentage && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Threshold != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Threshold);
      if (this.MarginPercentage != 0)
        num ^= this.MarginPercentage.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Threshold != 0.0)
      {
        output.WriteRawTag((byte) 9);
        output.WriteDouble(this.Threshold);
      }
      if (this.MarginPercentage != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.MarginPercentage);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Threshold != 0.0)
        num += 9;
      if (this.MarginPercentage != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MarginPercentage);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarginTierProto other)
    {
      if (other == null)
        return;
      if (other.Threshold != 0.0)
        this.Threshold = other.Threshold;
      if (other.MarginPercentage != 0)
        this.MarginPercentage = other.MarginPercentage;
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
          case 9:
            this.Threshold = input.ReadDouble();
            continue;
          case 16:
            this.MarginPercentage = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
