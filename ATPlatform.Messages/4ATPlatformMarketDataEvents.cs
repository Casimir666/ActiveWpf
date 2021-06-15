// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventTagProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class MarketDataEventTagProto : 
    IMessage<MarketDataEventTagProto>,
    IMessage,
    IEquatable<MarketDataEventTagProto>,
    IDeepCloneable<MarketDataEventTagProto>
  {
    private static readonly MessageParser<MarketDataEventTagProto> _parser = new MessageParser<MarketDataEventTagProto>((Func<MarketDataEventTagProto>) (() => new MarketDataEventTagProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MarketDataEventIdFieldNumber = 2;
    private int marketDataEventId_;
    public const int TagFieldNumber = 3;
    private TagTypeProto tag_;
    public const int ValueFieldNumber = 4;
    private string value_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventTagProto> Parser => MarketDataEventTagProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[3];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventTagProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventTagProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventTagProto(MarketDataEventTagProto other)
      : this()
    {
      this.id_ = other.id_;
      this.marketDataEventId_ = other.marketDataEventId_;
      this.tag_ = other.tag_;
      this.value_ = other.value_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventTagProto Clone() => new MarketDataEventTagProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public int MarketDataEventId
    {
      get => this.marketDataEventId_;
      set => this.marketDataEventId_ = value;
    }

    [DebuggerNonUserCode]
    public TagTypeProto Tag
    {
      get => this.tag_;
      set => this.tag_ = value;
    }

    [DebuggerNonUserCode]
    public string Value
    {
      get => this.value_;
      set => this.value_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventTagProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventTagProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (this.Tag == other.Tag && !(this.Value != other.Value)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MarketDataEventId != 0)
      {
        int num3 = num1;
        num2 = this.MarketDataEventId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Tag != TagTypeProto.UnknownTagType)
        num1 ^= this.Tag.GetHashCode();
      if (this.Value.Length != 0)
        num1 ^= this.Value.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.MarketDataEventId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.MarketDataEventId);
      }
      if (this.Tag != TagTypeProto.UnknownTagType)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.Tag);
      }
      if (this.Value.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Value);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.MarketDataEventId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MarketDataEventId);
      if (this.Tag != TagTypeProto.UnknownTagType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Tag);
      if (this.Value.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventTagProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MarketDataEventId != 0)
        this.MarketDataEventId = other.MarketDataEventId;
      if (other.Tag != TagTypeProto.UnknownTagType)
        this.Tag = other.Tag;
      if (other.Value.Length != 0)
        this.Value = other.Value;
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
            this.Id = input.ReadInt32();
            continue;
          case 16:
            this.MarketDataEventId = input.ReadInt32();
            continue;
          case 24:
            this.Tag = (TagTypeProto) input.ReadEnum();
            continue;
          case 34:
            this.Value = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
