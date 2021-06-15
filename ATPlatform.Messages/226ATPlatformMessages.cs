// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageRequestProto
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
  public sealed class ClientMessageRequestProto : 
    IMessage<ClientMessageRequestProto>,
    IMessage,
    IEquatable<ClientMessageRequestProto>,
    IDeepCloneable<ClientMessageRequestProto>
  {
    private static readonly MessageParser<ClientMessageRequestProto> _parser = new MessageParser<ClientMessageRequestProto>((Func<ClientMessageRequestProto>) (() => new ClientMessageRequestProto()));
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

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageRequestProto> Parser => ClientMessageRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[227];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageRequestProto(ClientMessageRequestProto other)
      : this()
    {
      this.clientMessage_ = other.clientMessage_ != null ? other.clientMessage_.Clone() : (ClientMessageProto) null;
      this.translations_ = other.translations_.Clone();
      this.tags_ = other.tags_.Clone();
      this.accounts_ = other.accounts_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageRequestProto Clone() => new ClientMessageRequestProto(this);

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
    public override bool Equals(object other) => this.Equals(other as ClientMessageRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.ClientMessage, (object) other.ClientMessage) && this.Translations.Equals(other.Translations) && (this.tags_.Equals(other.tags_) && this.accounts_.Equals(other.accounts_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.clientMessage_ != null)
        num1 ^= this.ClientMessage.GetHashCode();
      int num2 = num1 ^ this.Translations.GetHashCode() ^ this.tags_.GetHashCode() ^ this.accounts_.GetHashCode();
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
      this.translations_.WriteTo(output, ClientMessageRequestProto._map_translations_codec);
      this.tags_.WriteTo(output, ClientMessageRequestProto._repeated_tags_codec);
      this.accounts_.WriteTo(output, ClientMessageRequestProto._repeated_accounts_codec);
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
      int num2 = num1 + this.translations_.CalculateSize(ClientMessageRequestProto._map_translations_codec) + this.tags_.CalculateSize(ClientMessageRequestProto._repeated_tags_codec) + this.accounts_.CalculateSize(ClientMessageRequestProto._repeated_accounts_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageRequestProto other)
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
            this.translations_.AddEntriesFrom(input, ClientMessageRequestProto._map_translations_codec);
            continue;
          case 26:
            this.tags_.AddEntriesFrom(input, ClientMessageRequestProto._repeated_tags_codec);
            continue;
          case 34:
            this.accounts_.AddEntriesFrom(input, ClientMessageRequestProto._repeated_accounts_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
