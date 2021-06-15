// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetFeedSourcesNotificationProto
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
  public sealed class GetFeedSourcesNotificationProto : 
    IMessage<GetFeedSourcesNotificationProto>,
    IMessage,
    IEquatable<GetFeedSourcesNotificationProto>,
    IDeepCloneable<GetFeedSourcesNotificationProto>
  {
    private static readonly MessageParser<GetFeedSourcesNotificationProto> _parser = new MessageParser<GetFeedSourcesNotificationProto>((Func<GetFeedSourcesNotificationProto>) (() => new GetFeedSourcesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int FeedSourcesProtoFieldNumber = 1;
    private static readonly FieldCodec<FeedSourceProto> _repeated_feedSourcesProto_codec = FieldCodec.ForMessage<FeedSourceProto>(10U, FeedSourceProto.Parser);
    private readonly RepeatedField<FeedSourceProto> feedSourcesProto_ = new RepeatedField<FeedSourceProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetFeedSourcesNotificationProto> Parser => GetFeedSourcesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[209];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetFeedSourcesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetFeedSourcesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetFeedSourcesNotificationProto(GetFeedSourcesNotificationProto other)
      : this()
    {
      this.feedSourcesProto_ = other.feedSourcesProto_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetFeedSourcesNotificationProto Clone() => new GetFeedSourcesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<FeedSourceProto> FeedSourcesProto => this.feedSourcesProto_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetFeedSourcesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetFeedSourcesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.feedSourcesProto_.Equals(other.feedSourcesProto_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.feedSourcesProto_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.feedSourcesProto_.WriteTo(output, GetFeedSourcesNotificationProto._repeated_feedSourcesProto_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.feedSourcesProto_.CalculateSize(GetFeedSourcesNotificationProto._repeated_feedSourcesProto_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetFeedSourcesNotificationProto other)
    {
      if (other == null)
        return;
      this.feedSourcesProto_.Add((IEnumerable<FeedSourceProto>) other.feedSourcesProto_);
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
          this.feedSourcesProto_.AddEntriesFrom(input, GetFeedSourcesNotificationProto._repeated_feedSourcesProto_codec);
      }
    }
  }
}
