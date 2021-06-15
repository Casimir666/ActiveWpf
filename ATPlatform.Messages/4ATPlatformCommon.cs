// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.WelcomeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class WelcomeProto : 
    IMessage<WelcomeProto>,
    IMessage,
    IEquatable<WelcomeProto>,
    IDeepCloneable<WelcomeProto>
  {
    private static readonly MessageParser<WelcomeProto> _parser = new MessageParser<WelcomeProto>((Func<WelcomeProto>) (() => new WelcomeProto()));
    private UnknownFieldSet _unknownFields;
    public const int ServerAuthenticationTokenFieldNumber = 1;
    private ByteString serverAuthenticationToken_ = ByteString.Empty;
    public const int ServerTradingSecretKeyFieldNumber = 2;
    private ByteString serverTradingSecretKey_ = ByteString.Empty;
    public const int ServerNotificationSecretKeyFieldNumber = 3;
    private ByteString serverNotificationSecretKey_ = ByteString.Empty;
    public const int ProtocolVersionFieldNumber = 4;
    private ProtocolVersionProto protocolVersion_;

    [DebuggerNonUserCode]
    public static MessageParser<WelcomeProto> Parser => WelcomeProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[3];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => WelcomeProto.Descriptor;

    [DebuggerNonUserCode]
    public WelcomeProto()
    {
    }

    [DebuggerNonUserCode]
    public WelcomeProto(WelcomeProto other)
      : this()
    {
      this.serverAuthenticationToken_ = other.serverAuthenticationToken_;
      this.serverTradingSecretKey_ = other.serverTradingSecretKey_;
      this.serverNotificationSecretKey_ = other.serverNotificationSecretKey_;
      this.protocolVersion_ = other.protocolVersion_ != null ? other.protocolVersion_.Clone() : (ProtocolVersionProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public WelcomeProto Clone() => new WelcomeProto(this);

    [DebuggerNonUserCode]
    public ByteString ServerAuthenticationToken
    {
      get => this.serverAuthenticationToken_;
      set => this.serverAuthenticationToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ByteString ServerTradingSecretKey
    {
      get => this.serverTradingSecretKey_;
      set => this.serverTradingSecretKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ByteString ServerNotificationSecretKey
    {
      get => this.serverNotificationSecretKey_;
      set => this.serverNotificationSecretKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto ProtocolVersion
    {
      get => this.protocolVersion_;
      set => this.protocolVersion_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as WelcomeProto);

    [DebuggerNonUserCode]
    public bool Equals(WelcomeProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.ServerAuthenticationToken != other.ServerAuthenticationToken) && !(this.ServerTradingSecretKey != other.ServerTradingSecretKey) && (!(this.ServerNotificationSecretKey != other.ServerNotificationSecretKey) && object.Equals((object) this.ProtocolVersion, (object) other.ProtocolVersion)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ServerAuthenticationToken.Length != 0)
        num ^= this.ServerAuthenticationToken.GetHashCode();
      if (this.ServerTradingSecretKey.Length != 0)
        num ^= this.ServerTradingSecretKey.GetHashCode();
      if (this.ServerNotificationSecretKey.Length != 0)
        num ^= this.ServerNotificationSecretKey.GetHashCode();
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
      if (this.ServerAuthenticationToken.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteBytes(this.ServerAuthenticationToken);
      }
      if (this.ServerTradingSecretKey.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteBytes(this.ServerTradingSecretKey);
      }
      if (this.ServerNotificationSecretKey.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteBytes(this.ServerNotificationSecretKey);
      }
      if (this.protocolVersion_ != null)
      {
        output.WriteRawTag((byte) 34);
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
      if (this.ServerAuthenticationToken.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.ServerAuthenticationToken);
      if (this.ServerTradingSecretKey.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.ServerTradingSecretKey);
      if (this.ServerNotificationSecretKey.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.ServerNotificationSecretKey);
      if (this.protocolVersion_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ProtocolVersion);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(WelcomeProto other)
    {
      if (other == null)
        return;
      if (other.ServerAuthenticationToken.Length != 0)
        this.ServerAuthenticationToken = other.ServerAuthenticationToken;
      if (other.ServerTradingSecretKey.Length != 0)
        this.ServerTradingSecretKey = other.ServerTradingSecretKey;
      if (other.ServerNotificationSecretKey.Length != 0)
        this.ServerNotificationSecretKey = other.ServerNotificationSecretKey;
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
            this.ServerAuthenticationToken = input.ReadBytes();
            continue;
          case 18:
            this.ServerTradingSecretKey = input.ReadBytes();
            continue;
          case 26:
            this.ServerNotificationSecretKey = input.ReadBytes();
            continue;
          case 34:
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
