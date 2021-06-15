// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientSessionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientSessionProto : 
    IMessage<ClientSessionProto>,
    IMessage,
    IEquatable<ClientSessionProto>,
    IDeepCloneable<ClientSessionProto>
  {
    private static readonly MessageParser<ClientSessionProto> _parser = new MessageParser<ClientSessionProto>((Func<ClientSessionProto>) (() => new ClientSessionProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int SessionIdHashFieldNumber = 2;
    private int sessionIdHash_;
    public const int ClientAppTypeFieldNumber = 3;
    private ClientAppTypeProto clientAppType_;
    public const int IpAddressFieldNumber = 4;
    private string ipAddress_ = "";
    public const int ProtocolVersionFieldNumber = 5;
    private ProtocolVersionProto protocolVersion_;
    public const int AuthenticationTokenFieldNumber = 6;
    private ByteString authenticationToken_ = ByteString.Empty;
    public const int TimestampFieldNumber = 7;
    private long timestamp_;
    public const int SessionActionTypeFieldNumber = 8;
    private SessionActionTypeProto sessionActionType_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientSessionProto> Parser => ClientSessionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[120];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientSessionProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientSessionProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientSessionProto(ClientSessionProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.sessionIdHash_ = other.sessionIdHash_;
      this.clientAppType_ = other.clientAppType_;
      this.ipAddress_ = other.ipAddress_;
      this.protocolVersion_ = other.protocolVersion_ != null ? other.protocolVersion_.Clone() : (ProtocolVersionProto) null;
      this.authenticationToken_ = other.authenticationToken_;
      this.timestamp_ = other.timestamp_;
      this.sessionActionType_ = other.sessionActionType_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientSessionProto Clone() => new ClientSessionProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public int SessionIdHash
    {
      get => this.sessionIdHash_;
      set => this.sessionIdHash_ = value;
    }

    [DebuggerNonUserCode]
    public ClientAppTypeProto ClientAppType
    {
      get => this.clientAppType_;
      set => this.clientAppType_ = value;
    }

    [DebuggerNonUserCode]
    public string IpAddress
    {
      get => this.ipAddress_;
      set => this.ipAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto ProtocolVersion
    {
      get => this.protocolVersion_;
      set => this.protocolVersion_ = value;
    }

    [DebuggerNonUserCode]
    public ByteString AuthenticationToken
    {
      get => this.authenticationToken_;
      set => this.authenticationToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public SessionActionTypeProto SessionActionType
    {
      get => this.sessionActionType_;
      set => this.sessionActionType_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientSessionProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientSessionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.SessionIdHash == other.SessionIdHash && (this.ClientAppType == other.ClientAppType && !(this.IpAddress != other.IpAddress)) && (object.Equals((object) this.ProtocolVersion, (object) other.ProtocolVersion) && !(this.AuthenticationToken != other.AuthenticationToken) && (this.Timestamp == other.Timestamp && this.SessionActionType == other.SessionActionType)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SessionIdHash != 0)
      {
        int num3 = num1;
        num2 = this.SessionIdHash;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ClientAppType != ClientAppTypeProto.UnknownClientApp)
        num1 ^= this.ClientAppType.GetHashCode();
      if (this.IpAddress.Length != 0)
        num1 ^= this.IpAddress.GetHashCode();
      if (this.protocolVersion_ != null)
        num1 ^= this.ProtocolVersion.GetHashCode();
      if (this.AuthenticationToken.Length != 0)
        num1 ^= this.AuthenticationToken.GetHashCode();
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this.SessionActionType != SessionActionTypeProto.UnknownSessionActionType)
        num1 ^= this.SessionActionType.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.SessionIdHash != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.SessionIdHash);
      }
      if (this.ClientAppType != ClientAppTypeProto.UnknownClientApp)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.ClientAppType);
      }
      if (this.IpAddress.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.IpAddress);
      }
      if (this.protocolVersion_ != null)
      {
        output.WriteRawTag((byte) 42);
        output.WriteMessage((IMessage) this.ProtocolVersion);
      }
      if (this.AuthenticationToken.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteBytes(this.AuthenticationToken);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt64(this.Timestamp);
      }
      if (this.SessionActionType != SessionActionTypeProto.UnknownSessionActionType)
      {
        output.WriteRawTag((byte) 64);
        output.WriteEnum((int) this.SessionActionType);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.SessionIdHash != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SessionIdHash);
      if (this.ClientAppType != ClientAppTypeProto.UnknownClientApp)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.ClientAppType);
      if (this.IpAddress.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.IpAddress);
      if (this.protocolVersion_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ProtocolVersion);
      if (this.AuthenticationToken.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.AuthenticationToken);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.SessionActionType != SessionActionTypeProto.UnknownSessionActionType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.SessionActionType);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientSessionProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.SessionIdHash != 0)
        this.SessionIdHash = other.SessionIdHash;
      if (other.ClientAppType != ClientAppTypeProto.UnknownClientApp)
        this.ClientAppType = other.ClientAppType;
      if (other.IpAddress.Length != 0)
        this.IpAddress = other.IpAddress;
      if (other.protocolVersion_ != null)
      {
        if (this.protocolVersion_ == null)
          this.ProtocolVersion = new ProtocolVersionProto();
        this.ProtocolVersion.MergeFrom(other.ProtocolVersion);
      }
      if (other.AuthenticationToken.Length != 0)
        this.AuthenticationToken = other.AuthenticationToken;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.SessionActionType != SessionActionTypeProto.UnknownSessionActionType)
        this.SessionActionType = other.SessionActionType;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 16:
            this.SessionIdHash = input.ReadInt32();
            continue;
          case 24:
            this.ClientAppType = (ClientAppTypeProto) input.ReadEnum();
            continue;
          case 34:
            this.IpAddress = input.ReadString();
            continue;
          case 42:
            if (this.protocolVersion_ == null)
              this.ProtocolVersion = new ProtocolVersionProto();
            input.ReadMessage((IMessage) this.ProtocolVersion);
            continue;
          case 50:
            this.AuthenticationToken = input.ReadBytes();
            continue;
          case 56:
            this.Timestamp = input.ReadInt64();
            continue;
          case 64:
            this.SessionActionType = (SessionActionTypeProto) input.ReadEnum();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
