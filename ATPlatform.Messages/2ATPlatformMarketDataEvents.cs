// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventSettingsProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class MarketDataEventSettingsProto : 
    IMessage<MarketDataEventSettingsProto>,
    IMessage,
    IEquatable<MarketDataEventSettingsProto>,
    IDeepCloneable<MarketDataEventSettingsProto>
  {
    private static readonly MessageParser<MarketDataEventSettingsProto> _parser = new MessageParser<MarketDataEventSettingsProto>((Func<MarketDataEventSettingsProto>) (() => new MarketDataEventSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MarketDataEventIdFieldNumber = 2;
    private int marketDataEventId_;
    public const int KeyFieldNumber = 3;
    private string key_ = "";
    public const int ValueFieldNumber = 4;
    private string value_ = "";
    public const int TypeFieldNumber = 5;
    private string type_ = "";
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventSettingsProto> Parser => MarketDataEventSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[1];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventSettingsProto(MarketDataEventSettingsProto other)
      : this()
    {
      this.id_ = other.id_;
      this.marketDataEventId_ = other.marketDataEventId_;
      this.key_ = other.key_;
      this.value_ = other.value_;
      this.type_ = other.type_;
      this.description_ = other.description_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventSettingsProto Clone() => new MarketDataEventSettingsProto(this);

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
    public string Key
    {
      get => this.key_;
      set => this.key_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Value
    {
      get => this.value_;
      set => this.value_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Type
    {
      get => this.type_;
      set => this.type_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Description
    {
      get => this.description_;
      set => this.description_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (!(this.Key != other.Key) && !(this.Value != other.Value)) && (!(this.Type != other.Type) && !(this.Description != other.Description)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.Key.Length != 0)
        num1 ^= this.Key.GetHashCode();
      if (this.Value.Length != 0)
        num1 ^= this.Value.GetHashCode();
      if (this.Type.Length != 0)
        num1 ^= this.Type.GetHashCode();
      if (this.Description.Length != 0)
        num1 ^= this.Description.GetHashCode();
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
      if (this.Key.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Key);
      }
      if (this.Value.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Value);
      }
      if (this.Type.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Type);
      }
      if (this.Description.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Description);
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
      if (this.Key.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
      if (this.Value.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
      if (this.Type.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
      if (this.Description.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventSettingsProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MarketDataEventId != 0)
        this.MarketDataEventId = other.MarketDataEventId;
      if (other.Key.Length != 0)
        this.Key = other.Key;
      if (other.Value.Length != 0)
        this.Value = other.Value;
      if (other.Type.Length != 0)
        this.Type = other.Type;
      if (other.Description.Length != 0)
        this.Description = other.Description;
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
          case 26:
            this.Key = input.ReadString();
            continue;
          case 34:
            this.Value = input.ReadString();
            continue;
          case 42:
            this.Type = input.ReadString();
            continue;
          case 50:
            this.Description = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
