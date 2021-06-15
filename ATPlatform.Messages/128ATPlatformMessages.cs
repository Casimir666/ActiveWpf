﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientSessionRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientSessionRequestProto : 
    IMessage<ClientSessionRequestProto>,
    IMessage,
    IEquatable<ClientSessionRequestProto>,
    IDeepCloneable<ClientSessionRequestProto>
  {
    private static readonly MessageParser<ClientSessionRequestProto> _parser = new MessageParser<ClientSessionRequestProto>((Func<ClientSessionRequestProto>) (() => new ClientSessionRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int ClientSessionFieldNumber = 1;
    private ClientSessionProto clientSession_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientSessionRequestProto> Parser => ClientSessionRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[121];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientSessionRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientSessionRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientSessionRequestProto(ClientSessionRequestProto other)
      : this()
    {
      this.clientSession_ = other.clientSession_ != null ? other.clientSession_.Clone() : (ClientSessionProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientSessionRequestProto Clone() => new ClientSessionRequestProto(this);

    [DebuggerNonUserCode]
    public ClientSessionProto ClientSession
    {
      get => this.clientSession_;
      set => this.clientSession_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientSessionRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientSessionRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.ClientSession, (object) other.ClientSession) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.clientSession_ != null)
        num ^= this.ClientSession.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.clientSession_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.ClientSession);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.clientSession_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ClientSession);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientSessionRequestProto other)
    {
      if (other == null)
        return;
      if (other.clientSession_ != null)
      {
        if (this.clientSession_ == null)
          this.ClientSession = new ClientSessionProto();
        this.ClientSession.MergeFrom(other.ClientSession);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.clientSession_ == null)
            this.ClientSession = new ClientSessionProto();
          input.ReadMessage((IMessage) this.ClientSession);
        }
      }
    }
  }
}
