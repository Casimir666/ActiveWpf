// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventHistoryProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class MarketDataEventHistoryProto : 
    IMessage<MarketDataEventHistoryProto>,
    IMessage,
    IEquatable<MarketDataEventHistoryProto>,
    IDeepCloneable<MarketDataEventHistoryProto>
  {
    private static readonly MessageParser<MarketDataEventHistoryProto> _parser = new MessageParser<MarketDataEventHistoryProto>((Func<MarketDataEventHistoryProto>) (() => new MarketDataEventHistoryProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MarketDataEventIdFieldNumber = 2;
    private int marketDataEventId_;
    public const int StateFieldNumber = 3;
    private MarketDataEventStateProto state_;
    public const int TimestampFieldNumber = 4;
    private long timestamp_;
    public const int InitiatorIdFieldNumber = 5;
    private string initiatorId_ = "";
    public const int DataSnapshotFieldNumber = 6;
    private string dataSnapshot_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventHistoryProto> Parser => MarketDataEventHistoryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[4];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventHistoryProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventHistoryProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventHistoryProto(MarketDataEventHistoryProto other)
      : this()
    {
      this.id_ = other.id_;
      this.marketDataEventId_ = other.marketDataEventId_;
      this.state_ = other.state_;
      this.timestamp_ = other.timestamp_;
      this.initiatorId_ = other.initiatorId_;
      this.dataSnapshot_ = other.dataSnapshot_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventHistoryProto Clone() => new MarketDataEventHistoryProto(this);

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
    public MarketDataEventStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
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
    public string DataSnapshot
    {
      get => this.dataSnapshot_;
      set => this.dataSnapshot_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventHistoryProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventHistoryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (this.State == other.State && this.Timestamp == other.Timestamp) && (!(this.InitiatorId != other.InitiatorId) && !(this.DataSnapshot != other.DataSnapshot)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.State != MarketDataEventStateProto.UndefinedState)
        num1 ^= this.State.GetHashCode();
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this.InitiatorId.Length != 0)
        num1 ^= this.InitiatorId.GetHashCode();
      if (this.DataSnapshot.Length != 0)
        num1 ^= this.DataSnapshot.GetHashCode();
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
      if (this.State != MarketDataEventStateProto.UndefinedState)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.State);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.Timestamp);
      }
      if (this.InitiatorId.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.InitiatorId);
      }
      if (this.DataSnapshot.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.DataSnapshot);
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
      if (this.State != MarketDataEventStateProto.UndefinedState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.InitiatorId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.InitiatorId);
      if (this.DataSnapshot.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.DataSnapshot);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventHistoryProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MarketDataEventId != 0)
        this.MarketDataEventId = other.MarketDataEventId;
      if (other.State != MarketDataEventStateProto.UndefinedState)
        this.State = other.State;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.InitiatorId.Length != 0)
        this.InitiatorId = other.InitiatorId;
      if (other.DataSnapshot.Length != 0)
        this.DataSnapshot = other.DataSnapshot;
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
            this.State = (MarketDataEventStateProto) input.ReadEnum();
            continue;
          case 32:
            this.Timestamp = input.ReadInt64();
            continue;
          case 42:
            this.InitiatorId = input.ReadString();
            continue;
          case 50:
            this.DataSnapshot = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
