// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class MarketDataEventProto : 
    IMessage<MarketDataEventProto>,
    IMessage,
    IEquatable<MarketDataEventProto>,
    IDeepCloneable<MarketDataEventProto>
  {
    private static readonly MessageParser<MarketDataEventProto> _parser = new MessageParser<MarketDataEventProto>((Func<MarketDataEventProto>) (() => new MarketDataEventProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MarketDataEventTypeFieldNumber = 2;
    private MarketDataEventTypeProto marketDataEventType_;
    public const int NameFieldNumber = 3;
    private string name_ = "";
    public const int StateFieldNumber = 4;
    private MarketDataEventStateProto state_;
    public const int SubjectFieldNumber = 5;
    private string subject_ = "";
    public const int BodyFieldNumber = 6;
    private string body_ = "";
    public const int TimestampFieldNumber = 7;
    private long timestamp_;
    public const int InitiatorIdFieldNumber = 8;
    private string initiatorId_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventProto> Parser => MarketDataEventProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[0];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventProto(MarketDataEventProto other)
      : this()
    {
      this.id_ = other.id_;
      this.marketDataEventType_ = other.marketDataEventType_;
      this.name_ = other.name_;
      this.state_ = other.state_;
      this.subject_ = other.subject_;
      this.body_ = other.body_;
      this.timestamp_ = other.timestamp_;
      this.initiatorId_ = other.initiatorId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventProto Clone() => new MarketDataEventProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public MarketDataEventTypeProto MarketDataEventType
    {
      get => this.marketDataEventType_;
      set => this.marketDataEventType_ = value;
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public MarketDataEventStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public string Subject
    {
      get => this.subject_;
      set => this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Body
    {
      get => this.body_;
      set => this.body_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string InitiatorId
    {
      get => this.initiatorId_;
      set => this.initiatorId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MarketDataEventType == other.MarketDataEventType && (!(this.Name != other.Name) && this.State == other.State) && (!(this.Subject != other.Subject) && !(this.Body != other.Body) && (this.Timestamp == other.Timestamp && !(this.InitiatorId != other.InitiatorId))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this.MarketDataEventType != MarketDataEventTypeProto.UndefinedMarketDataEventType)
        num ^= this.MarketDataEventType.GetHashCode();
      if (this.Name.Length != 0)
        num ^= this.Name.GetHashCode();
      if (this.State != MarketDataEventStateProto.UndefinedState)
        num ^= this.State.GetHashCode();
      if (this.Subject.Length != 0)
        num ^= this.Subject.GetHashCode();
      if (this.Body.Length != 0)
        num ^= this.Body.GetHashCode();
      if (this.Timestamp != 0L)
        num ^= this.Timestamp.GetHashCode();
      if (this.InitiatorId.Length != 0)
        num ^= this.InitiatorId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this.MarketDataEventType != MarketDataEventTypeProto.UndefinedMarketDataEventType)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.MarketDataEventType);
      }
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Name);
      }
      if (this.State != MarketDataEventStateProto.UndefinedState)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.State);
      }
      if (this.Subject.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Subject);
      }
      if (this.Body.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Body);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt64(this.Timestamp);
      }
      if (this.InitiatorId.Length != 0)
      {
        output.WriteRawTag((byte) 66);
        output.WriteString(this.InitiatorId);
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
      if (this.MarketDataEventType != MarketDataEventTypeProto.UndefinedMarketDataEventType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.MarketDataEventType);
      if (this.Name.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this.State != MarketDataEventStateProto.UndefinedState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.Subject.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Subject);
      if (this.Body.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Body);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.InitiatorId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.InitiatorId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MarketDataEventType != MarketDataEventTypeProto.UndefinedMarketDataEventType)
        this.MarketDataEventType = other.MarketDataEventType;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.State != MarketDataEventStateProto.UndefinedState)
        this.State = other.State;
      if (other.Subject.Length != 0)
        this.Subject = other.Subject;
      if (other.Body.Length != 0)
        this.Body = other.Body;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.InitiatorId.Length != 0)
        this.InitiatorId = other.InitiatorId;
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
            this.MarketDataEventType = (MarketDataEventTypeProto) input.ReadEnum();
            continue;
          case 26:
            this.Name = input.ReadString();
            continue;
          case 32:
            this.State = (MarketDataEventStateProto) input.ReadEnum();
            continue;
          case 42:
            this.Subject = input.ReadString();
            continue;
          case 50:
            this.Body = input.ReadString();
            continue;
          case 56:
            this.Timestamp = input.ReadInt64();
            continue;
          case 66:
            this.InitiatorId = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
