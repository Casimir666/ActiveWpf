// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageNotificationProto
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
  public sealed class ClientMessageNotificationProto : 
    IMessage<ClientMessageNotificationProto>,
    IMessage,
    IEquatable<ClientMessageNotificationProto>,
    IDeepCloneable<ClientMessageNotificationProto>
  {
    private static readonly MessageParser<ClientMessageNotificationProto> _parser = new MessageParser<ClientMessageNotificationProto>((Func<ClientMessageNotificationProto>) (() => new ClientMessageNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ClientMessageFieldNumber = 1;
    private ClientMessageProto clientMessage_;
    public const int TranslationsFieldNumber = 2;
    private static readonly MapField<string, ClientMessageTranslationProto>.Codec _map_translations_codec = new MapField<string, ClientMessageTranslationProto>.Codec(FieldCodec.ForString(10U), FieldCodec.ForMessage<ClientMessageTranslationProto>(18U, ClientMessageTranslationProto.Parser), 18U);
    private readonly MapField<string, ClientMessageTranslationProto> translations_ = new MapField<string, ClientMessageTranslationProto>();
    public const int TagsFieldNumber = 3;
    private static readonly FieldCodec<ClientMessageTagProto> _repeated_tags_codec = FieldCodec.ForMessage<ClientMessageTagProto>(26U, ClientMessageTagProto.Parser);
    private readonly RepeatedField<ClientMessageTagProto> tags_ = new RepeatedField<ClientMessageTagProto>();
    public const int AccountsFieldNumber = 4;
    private static readonly FieldCodec<ClientMessageAccountProto> _repeated_accounts_codec = FieldCodec.ForMessage<ClientMessageAccountProto>(34U, ClientMessageAccountProto.Parser);
    private readonly RepeatedField<ClientMessageAccountProto> accounts_ = new RepeatedField<ClientMessageAccountProto>();
    public const int StateHistoryFieldNumber = 5;
    private static readonly FieldCodec<ClientMessageStateHistoryProto> _repeated_stateHistory_codec = FieldCodec.ForMessage<ClientMessageStateHistoryProto>(42U, ClientMessageStateHistoryProto.Parser);
    private readonly RepeatedField<ClientMessageStateHistoryProto> stateHistory_ = new RepeatedField<ClientMessageStateHistoryProto>();

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageNotificationProto> Parser => ClientMessageNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[228];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageNotificationProto(ClientMessageNotificationProto other)
      : this()
    {
      this.clientMessage_ = other.clientMessage_ != null ? other.clientMessage_.Clone() : (ClientMessageProto) null;
      this.translations_ = other.translations_.Clone();
      this.tags_ = other.tags_.Clone();
      this.accounts_ = other.accounts_.Clone();
      this.stateHistory_ = other.stateHistory_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageNotificationProto Clone() => new ClientMessageNotificationProto(this);

    [DebuggerNonUserCode]
    public ClientMessageProto ClientMessage
    {
      get => this.clientMessage_;
      set => this.clientMessage_ = value;
    }

    [DebuggerNonUserCode]
    public MapField<string, ClientMessageTranslationProto> Translations => this.translations_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageTagProto> Tags => this.tags_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageAccountProto> Accounts => this.accounts_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageStateHistoryProto> StateHistory => this.stateHistory_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.ClientMessage, (object) other.ClientMessage) && this.Translations.Equals(other.Translations) && (this.tags_.Equals(other.tags_) && this.accounts_.Equals(other.accounts_)) && this.stateHistory_.Equals(other.stateHistory_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.clientMessage_ != null)
        num1 ^= this.ClientMessage.GetHashCode();
      int num2 = num1 ^ this.Translations.GetHashCode() ^ this.tags_.GetHashCode() ^ this.accounts_.GetHashCode() ^ this.stateHistory_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.clientMessage_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.ClientMessage);
      }
      this.translations_.WriteTo(output, ClientMessageNotificationProto._map_translations_codec);
      this.tags_.WriteTo(output, ClientMessageNotificationProto._repeated_tags_codec);
      this.accounts_.WriteTo(output, ClientMessageNotificationProto._repeated_accounts_codec);
      this.stateHistory_.WriteTo(output, ClientMessageNotificationProto._repeated_stateHistory_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.clientMessage_ != null)
        num1 += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ClientMessage);
      int num2 = num1 + this.translations_.CalculateSize(ClientMessageNotificationProto._map_translations_codec) + this.tags_.CalculateSize(ClientMessageNotificationProto._repeated_tags_codec) + this.accounts_.CalculateSize(ClientMessageNotificationProto._repeated_accounts_codec) + this.stateHistory_.CalculateSize(ClientMessageNotificationProto._repeated_stateHistory_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageNotificationProto other)
    {
      if (other == null)
        return;
      if (other.clientMessage_ != null)
      {
        if (this.clientMessage_ == null)
          this.ClientMessage = new ClientMessageProto();
        this.ClientMessage.MergeFrom(other.ClientMessage);
      }
      this.translations_.Add((IDictionary<string, ClientMessageTranslationProto>) other.translations_);
      this.tags_.Add((IEnumerable<ClientMessageTagProto>) other.tags_);
      this.accounts_.Add((IEnumerable<ClientMessageAccountProto>) other.accounts_);
      this.stateHistory_.Add((IEnumerable<ClientMessageStateHistoryProto>) other.stateHistory_);
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
            if (this.clientMessage_ == null)
              this.ClientMessage = new ClientMessageProto();
            input.ReadMessage((IMessage) this.ClientMessage);
            continue;
          case 18:
            this.translations_.AddEntriesFrom(input, ClientMessageNotificationProto._map_translations_codec);
            continue;
          case 26:
            this.tags_.AddEntriesFrom(input, ClientMessageNotificationProto._repeated_tags_codec);
            continue;
          case 34:
            this.accounts_.AddEntriesFrom(input, ClientMessageNotificationProto._repeated_accounts_codec);
            continue;
          case 42:
            this.stateHistory_.AddEntriesFrom(input, ClientMessageNotificationProto._repeated_stateHistory_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
