// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetJournalEntryRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetJournalEntryRequestProto : 
    IMessage<GetJournalEntryRequestProto>,
    IMessage,
    IEquatable<GetJournalEntryRequestProto>,
    IDeepCloneable<GetJournalEntryRequestProto>
  {
    private static readonly MessageParser<GetJournalEntryRequestProto> _parser = new MessageParser<GetJournalEntryRequestProto>((Func<GetJournalEntryRequestProto>) (() => new GetJournalEntryRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int TypeFieldNumber = 1;
    private MessageTypeProto type_;
    public const int RequestIdFieldNumber = 2;
    private int requestId_;
    public const int InitiatorUserIdFieldNumber = 3;
    private int initiatorUserId_;
    public const int SessionIdFieldNumber = 4;
    private int sessionId_;
    public const int MinSequenceNumberFieldNumber = 5;
    private int minSequenceNumber_;
    public const int MaxSequenceNumberFieldNumber = 6;
    private int maxSequenceNumber_;
    public const int MinTimestampFieldNumber = 7;
    private long minTimestamp_;
    public const int MaxTimestampFieldNumber = 8;
    private long maxTimestamp_;
    public const int SearchTextFieldNumber = 9;
    private string searchText_ = "";
    public const int TypesListFieldNumber = 10;
    private static readonly FieldCodec<MessageTypeProto> _repeated_typesList_codec = FieldCodec.ForEnum<MessageTypeProto>(82U, (Func<MessageTypeProto, int>) (x => (int) x), (Func<int, MessageTypeProto>) (x => (MessageTypeProto) x));
    private readonly RepeatedField<MessageTypeProto> typesList_ = new RepeatedField<MessageTypeProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetJournalEntryRequestProto> Parser => GetJournalEntryRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[141];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetJournalEntryRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetJournalEntryRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetJournalEntryRequestProto(GetJournalEntryRequestProto other)
      : this()
    {
      this.type_ = other.type_;
      this.requestId_ = other.requestId_;
      this.initiatorUserId_ = other.initiatorUserId_;
      this.sessionId_ = other.sessionId_;
      this.minSequenceNumber_ = other.minSequenceNumber_;
      this.maxSequenceNumber_ = other.maxSequenceNumber_;
      this.minTimestamp_ = other.minTimestamp_;
      this.maxTimestamp_ = other.maxTimestamp_;
      this.searchText_ = other.searchText_;
      this.typesList_ = other.typesList_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetJournalEntryRequestProto Clone() => new GetJournalEntryRequestProto(this);

    [DebuggerNonUserCode]
    public MessageTypeProto Type
    {
      get => this.type_;
      set => this.type_ = value;
    }

    [DebuggerNonUserCode]
    public int RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public int InitiatorUserId
    {
      get => this.initiatorUserId_;
      set => this.initiatorUserId_ = value;
    }

    [DebuggerNonUserCode]
    public int SessionId
    {
      get => this.sessionId_;
      set => this.sessionId_ = value;
    }

    [DebuggerNonUserCode]
    public int MinSequenceNumber
    {
      get => this.minSequenceNumber_;
      set => this.minSequenceNumber_ = value;
    }

    [DebuggerNonUserCode]
    public int MaxSequenceNumber
    {
      get => this.maxSequenceNumber_;
      set => this.maxSequenceNumber_ = value;
    }

    [DebuggerNonUserCode]
    public long MinTimestamp
    {
      get => this.minTimestamp_;
      set => this.minTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public long MaxTimestamp
    {
      get => this.maxTimestamp_;
      set => this.maxTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string SearchText
    {
      get => this.searchText_;
      set => this.searchText_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<MessageTypeProto> TypesList => this.typesList_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetJournalEntryRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetJournalEntryRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Type == other.Type && this.RequestId == other.RequestId && (this.InitiatorUserId == other.InitiatorUserId && this.SessionId == other.SessionId) && (this.MinSequenceNumber == other.MinSequenceNumber && this.MaxSequenceNumber == other.MaxSequenceNumber && (this.MinTimestamp == other.MinTimestamp && this.MaxTimestamp == other.MaxTimestamp)) && (!(this.SearchText != other.SearchText) && this.typesList_.Equals(other.typesList_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Type != MessageTypeProto.UndefinedMessageType)
        num1 ^= this.Type.GetHashCode();
      int num2;
      if (this.RequestId != 0)
      {
        int num3 = num1;
        num2 = this.RequestId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.InitiatorUserId != 0)
      {
        int num3 = num1;
        num2 = this.InitiatorUserId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SessionId != 0)
      {
        int num3 = num1;
        num2 = this.SessionId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MinSequenceNumber != 0)
      {
        int num3 = num1;
        num2 = this.MinSequenceNumber;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MaxSequenceNumber != 0)
      {
        int num3 = num1;
        num2 = this.MaxSequenceNumber;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      long num4;
      if (this.MinTimestamp != 0L)
      {
        int num3 = num1;
        num4 = this.MinTimestamp;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MaxTimestamp != 0L)
      {
        int num3 = num1;
        num4 = this.MaxTimestamp;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SearchText.Length != 0)
        num1 ^= this.SearchText.GetHashCode();
      int num5 = num1 ^ this.typesList_.GetHashCode();
      if (this._unknownFields != null)
        num5 ^= this._unknownFields.GetHashCode();
      return num5;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Type != MessageTypeProto.UndefinedMessageType)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.Type);
      }
      if (this.RequestId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.RequestId);
      }
      if (this.InitiatorUserId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.InitiatorUserId);
      }
      if (this.SessionId != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.SessionId);
      }
      if (this.MinSequenceNumber != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.MinSequenceNumber);
      }
      if (this.MaxSequenceNumber != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.MaxSequenceNumber);
      }
      if (this.MinTimestamp != 0L)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt64(this.MinTimestamp);
      }
      if (this.MaxTimestamp != 0L)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt64(this.MaxTimestamp);
      }
      if (this.SearchText.Length != 0)
      {
        output.WriteRawTag((byte) 74);
        output.WriteString(this.SearchText);
      }
      this.typesList_.WriteTo(output, GetJournalEntryRequestProto._repeated_typesList_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Type != MessageTypeProto.UndefinedMessageType)
        num1 += 1 + CodedOutputStream.ComputeEnumSize((int) this.Type);
      if (this.RequestId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
      if (this.InitiatorUserId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.InitiatorUserId);
      if (this.SessionId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.SessionId);
      if (this.MinSequenceNumber != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.MinSequenceNumber);
      if (this.MaxSequenceNumber != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.MaxSequenceNumber);
      if (this.MinTimestamp != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.MinTimestamp);
      if (this.MaxTimestamp != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.MaxTimestamp);
      if (this.SearchText.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SearchText);
      int num2 = num1 + this.typesList_.CalculateSize(GetJournalEntryRequestProto._repeated_typesList_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetJournalEntryRequestProto other)
    {
      if (other == null)
        return;
      if (other.Type != MessageTypeProto.UndefinedMessageType)
        this.Type = other.Type;
      if (other.RequestId != 0)
        this.RequestId = other.RequestId;
      if (other.InitiatorUserId != 0)
        this.InitiatorUserId = other.InitiatorUserId;
      if (other.SessionId != 0)
        this.SessionId = other.SessionId;
      if (other.MinSequenceNumber != 0)
        this.MinSequenceNumber = other.MinSequenceNumber;
      if (other.MaxSequenceNumber != 0)
        this.MaxSequenceNumber = other.MaxSequenceNumber;
      if (other.MinTimestamp != 0L)
        this.MinTimestamp = other.MinTimestamp;
      if (other.MaxTimestamp != 0L)
        this.MaxTimestamp = other.MaxTimestamp;
      if (other.SearchText.Length != 0)
        this.SearchText = other.SearchText;
      this.typesList_.Add((IEnumerable<MessageTypeProto>) other.typesList_);
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
            this.Type = (MessageTypeProto) input.ReadEnum();
            continue;
          case 16:
            this.RequestId = input.ReadInt32();
            continue;
          case 24:
            this.InitiatorUserId = input.ReadInt32();
            continue;
          case 32:
            this.SessionId = input.ReadInt32();
            continue;
          case 40:
            this.MinSequenceNumber = input.ReadInt32();
            continue;
          case 48:
            this.MaxSequenceNumber = input.ReadInt32();
            continue;
          case 56:
            this.MinTimestamp = input.ReadInt64();
            continue;
          case 64:
            this.MaxTimestamp = input.ReadInt64();
            continue;
          case 74:
            this.SearchText = input.ReadString();
            continue;
          case 80:
          case 82:
            this.typesList_.AddEntriesFrom(input, GetJournalEntryRequestProto._repeated_typesList_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
