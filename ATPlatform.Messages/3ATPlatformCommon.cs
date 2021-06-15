// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HelloProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class HelloProto : 
    IMessage<HelloProto>,
    IMessage,
    IEquatable<HelloProto>,
    IDeepCloneable<HelloProto>
  {
    private static readonly MessageParser<HelloProto> _parser = new MessageParser<HelloProto>((Func<HelloProto>) (() => new HelloProto()));
    private UnknownFieldSet _unknownFields;
    public const int AuthenticationTokenFieldNumber = 1;
    private ByteString authenticationToken_ = ByteString.Empty;
    public const int ClientPublicKeyFieldNumber = 2;
    private ByteString clientPublicKey_ = ByteString.Empty;
    public const int ProtocolVersionFieldNumber = 3;
    private ProtocolVersionProto protocolVersion_;

    [DebuggerNonUserCode]
    public static MessageParser<HelloProto> Parser => HelloProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[2];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HelloProto.Descriptor;

    [DebuggerNonUserCode]
    public HelloProto()
    {
    }

    [DebuggerNonUserCode]
    public HelloProto(HelloProto other)
      : this()
    {
      this.authenticationToken_ = other.authenticationToken_;
      this.clientPublicKey_ = other.clientPublicKey_;
      this.protocolVersion_ = other.protocolVersion_ != null ? other.protocolVersion_.Clone() : (ProtocolVersionProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HelloProto Clone() => new HelloProto(this);

    [DebuggerNonUserCode]
    public ByteString AuthenticationToken
    {
      get => this.authenticationToken_;
      set => this.authenticationToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ByteString ClientPublicKey
    {
      get => this.clientPublicKey_;
      set => this.clientPublicKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto ProtocolVersion
    {
      get => this.protocolVersion_;
      set => this.protocolVersion_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HelloProto);

    [DebuggerNonUserCode]
    public bool Equals(HelloProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.AuthenticationToken != other.AuthenticationToken) && !(this.ClientPublicKey != other.ClientPublicKey) && object.Equals((object) this.ProtocolVersion, (object) other.ProtocolVersion) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AuthenticationToken.Length != 0)
        num ^= this.AuthenticationToken.GetHashCode();
      if (this.ClientPublicKey.Length != 0)
        num ^= this.ClientPublicKey.GetHashCode();
      if (this.protocolVersion_ != null)
        num ^= this.ProtocolVersion.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AuthenticationToken.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteBytes(this.AuthenticationToken);
      }
      if (this.ClientPublicKey.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteBytes(this.ClientPublicKey);
      }
      if (this.protocolVersion_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.ProtocolVersion);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AuthenticationToken.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.AuthenticationToken);
      if (this.ClientPublicKey.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.ClientPublicKey);
      if (this.protocolVersion_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ProtocolVersion);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HelloProto other)
    {
      if (other == null)
        return;
      if (other.AuthenticationToken.Length != 0)
        this.AuthenticationToken = other.AuthenticationToken;
      if (other.ClientPublicKey.Length != 0)
        this.ClientPublicKey = other.ClientPublicKey;
      if (other.protocolVersion_ != null)
      {
        if (this.protocolVersion_ == null)
          this.ProtocolVersion = new ProtocolVersionProto();
        this.ProtocolVersion.MergeFrom(other.ProtocolVersion);
      }
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
            this.AuthenticationToken = input.ReadBytes();
            continue;
          case 18:
            this.ClientPublicKey = input.ReadBytes();
            continue;
          case 26:
            if (this.protocolVersion_ == null)
              this.ProtocolVersion = new ProtocolVersionProto();
            input.ReadMessage((IMessage) this.ProtocolVersion);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
