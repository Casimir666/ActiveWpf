// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientMessagesNotificationProto
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
  public sealed class GetClientMessagesNotificationProto : 
    IMessage<GetClientMessagesNotificationProto>,
    IMessage,
    IEquatable<GetClientMessagesNotificationProto>,
    IDeepCloneable<GetClientMessagesNotificationProto>
  {
    private static readonly MessageParser<GetClientMessagesNotificationProto> _parser = new MessageParser<GetClientMessagesNotificationProto>((Func<GetClientMessagesNotificationProto>) (() => new GetClientMessagesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ClientMessagesFieldNumber = 1;
    private static readonly FieldCodec<ClientMessageProto> _repeated_clientMessages_codec = FieldCodec.ForMessage<ClientMessageProto>(10U, ClientMessageProto.Parser);
    private readonly RepeatedField<ClientMessageProto> clientMessages_ = new RepeatedField<ClientMessageProto>();
    public const int TagsFieldNumber = 2;
    private static readonly FieldCodec<ClientMessageTagProto> _repeated_tags_codec = FieldCodec.ForMessage<ClientMessageTagProto>(18U, ClientMessageTagProto.Parser);
    private readonly RepeatedField<ClientMessageTagProto> tags_ = new RepeatedField<ClientMessageTagProto>();
    public const int AccountsFieldNumber = 3;
    private static readonly FieldCodec<ClientMessageAccountProto> _repeated_accounts_codec = FieldCodec.ForMessage<ClientMessageAccountProto>(26U, ClientMessageAccountProto.Parser);
    private readonly RepeatedField<ClientMessageAccountProto> accounts_ = new RepeatedField<ClientMessageAccountProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetClientMessagesNotificationProto> Parser => GetClientMessagesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[232];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientMessagesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientMessagesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientMessagesNotificationProto(GetClientMessagesNotificationProto other)
      : this()
    {
      this.clientMessages_ = other.clientMessages_.Clone();
      this.tags_ = other.tags_.Clone();
      this.accounts_ = other.accounts_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientMessagesNotificationProto Clone() => new GetClientMessagesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageProto> ClientMessages => this.clientMessages_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageTagProto> Tags => this.tags_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageAccountProto> Accounts => this.accounts_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientMessagesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientMessagesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.clientMessages_.Equals(other.clientMessages_) && this.tags_.Equals(other.tags_) && this.accounts_.Equals(other.accounts_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.clientMessages_.GetHashCode() ^ this.tags_.GetHashCode() ^ this.accounts_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.clientMessages_.WriteTo(output, GetClientMessagesNotificationProto._repeated_clientMessages_codec);
      this.tags_.WriteTo(output, GetClientMessagesNotificationProto._repeated_tags_codec);
      this.accounts_.WriteTo(output, GetClientMessagesNotificationProto._repeated_accounts_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.clientMessages_.CalculateSize(GetClientMessagesNotificationProto._repeated_clientMessages_codec) + this.tags_.CalculateSize(GetClientMessagesNotificationProto._repeated_tags_codec) + this.accounts_.CalculateSize(GetClientMessagesNotificationProto._repeated_accounts_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientMessagesNotificationProto other)
    {
      if (other == null)
        return;
      this.clientMessages_.Add((IEnumerable<ClientMessageProto>) other.clientMessages_);
      this.tags_.Add((IEnumerable<ClientMessageTagProto>) other.tags_);
      this.accounts_.Add((IEnumerable<ClientMessageAccountProto>) other.accounts_);
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
          case 10:
            this.clientMessages_.AddEntriesFrom(input, GetClientMessagesNotificationProto._repeated_clientMessages_codec);
            continue;
          case 18:
            this.tags_.AddEntriesFrom(input, GetClientMessagesNotificationProto._repeated_tags_codec);
            continue;
          case 26:
            this.accounts_.AddEntriesFrom(input, GetClientMessagesNotificationProto._repeated_accounts_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
