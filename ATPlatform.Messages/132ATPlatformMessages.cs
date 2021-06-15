// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientSessionNotificationtProto
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
  public sealed class GetClientSessionNotificationtProto : 
    IMessage<GetClientSessionNotificationtProto>,
    IMessage,
    IEquatable<GetClientSessionNotificationtProto>,
    IDeepCloneable<GetClientSessionNotificationtProto>
  {
    private static readonly MessageParser<GetClientSessionNotificationtProto> _parser = new MessageParser<GetClientSessionNotificationtProto>((Func<GetClientSessionNotificationtProto>) (() => new GetClientSessionNotificationtProto()));
    private UnknownFieldSet _unknownFields;
    public const int ClientSessionsFieldNumber = 1;
    private static readonly FieldCodec<ClientSessionProto> _repeated_clientSessions_codec = FieldCodec.ForMessage<ClientSessionProto>(10U, ClientSessionProto.Parser);
    private readonly RepeatedField<ClientSessionProto> clientSessions_ = new RepeatedField<ClientSessionProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetClientSessionNotificationtProto> Parser => GetClientSessionNotificationtProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[125];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientSessionNotificationtProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientSessionNotificationtProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientSessionNotificationtProto(GetClientSessionNotificationtProto other)
      : this()
    {
      this.clientSessions_ = other.clientSessions_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientSessionNotificationtProto Clone() => new GetClientSessionNotificationtProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<ClientSessionProto> ClientSessions => this.clientSessions_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientSessionNotificationtProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientSessionNotificationtProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.clientSessions_.Equals(other.clientSessions_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.clientSessions_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.clientSessions_.WriteTo(output, GetClientSessionNotificationtProto._repeated_clientSessions_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.clientSessions_.CalculateSize(GetClientSessionNotificationtProto._repeated_clientSessions_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientSessionNotificationtProto other)
    {
      if (other == null)
        return;
      this.clientSessions_.Add((IEnumerable<ClientSessionProto>) other.clientSessions_);
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
          this.clientSessions_.AddEntriesFrom(input, GetClientSessionNotificationtProto._repeated_clientSessions_codec);
      }
    }
  }
}
