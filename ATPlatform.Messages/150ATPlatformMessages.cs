// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetJournalEntryNotificationProto
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
  public sealed class GetJournalEntryNotificationProto : 
    IMessage<GetJournalEntryNotificationProto>,
    IMessage,
    IEquatable<GetJournalEntryNotificationProto>,
    IDeepCloneable<GetJournalEntryNotificationProto>
  {
    private static readonly MessageParser<GetJournalEntryNotificationProto> _parser = new MessageParser<GetJournalEntryNotificationProto>((Func<GetJournalEntryNotificationProto>) (() => new GetJournalEntryNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int JournalRecordsFieldNumber = 1;
    private static readonly FieldCodec<JournalEntryProto> _repeated_journalRecords_codec = FieldCodec.ForMessage<JournalEntryProto>(10U, JournalEntryProto.Parser);
    private readonly RepeatedField<JournalEntryProto> journalRecords_ = new RepeatedField<JournalEntryProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetJournalEntryNotificationProto> Parser => GetJournalEntryNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[143];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetJournalEntryNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetJournalEntryNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetJournalEntryNotificationProto(GetJournalEntryNotificationProto other)
      : this()
    {
      this.journalRecords_ = other.journalRecords_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetJournalEntryNotificationProto Clone() => new GetJournalEntryNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<JournalEntryProto> JournalRecords => this.journalRecords_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetJournalEntryNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetJournalEntryNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.journalRecords_.Equals(other.journalRecords_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.journalRecords_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.journalRecords_.WriteTo(output, GetJournalEntryNotificationProto._repeated_journalRecords_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.journalRecords_.CalculateSize(GetJournalEntryNotificationProto._repeated_journalRecords_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetJournalEntryNotificationProto other)
    {
      if (other == null)
        return;
      this.journalRecords_.Add((IEnumerable<JournalEntryProto>) other.journalRecords_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.journalRecords_.AddEntriesFrom(input, GetJournalEntryNotificationProto._repeated_journalRecords_codec);
      }
    }
  }
}
