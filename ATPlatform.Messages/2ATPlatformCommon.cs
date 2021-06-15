// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ServerPublicKeyNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ServerPublicKeyNotificationProto : 
    IMessage<ServerPublicKeyNotificationProto>,
    IMessage,
    IEquatable<ServerPublicKeyNotificationProto>,
    IDeepCloneable<ServerPublicKeyNotificationProto>
  {
    private static readonly MessageParser<ServerPublicKeyNotificationProto> _parser = new MessageParser<ServerPublicKeyNotificationProto>((Func<ServerPublicKeyNotificationProto>) (() => new ServerPublicKeyNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ServerPublicKeyFieldNumber = 1;
    private ByteString serverPublicKey_ = ByteString.Empty;

    [DebuggerNonUserCode]
    public static MessageParser<ServerPublicKeyNotificationProto> Parser => ServerPublicKeyNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[1];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ServerPublicKeyNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ServerPublicKeyNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ServerPublicKeyNotificationProto(ServerPublicKeyNotificationProto other)
      : this()
    {
      this.serverPublicKey_ = other.serverPublicKey_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ServerPublicKeyNotificationProto Clone() => new ServerPublicKeyNotificationProto(this);

    [DebuggerNonUserCode]
    public ByteString ServerPublicKey
    {
      get => this.serverPublicKey_;
      set => this.serverPublicKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ServerPublicKeyNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ServerPublicKeyNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.ServerPublicKey != other.ServerPublicKey) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ServerPublicKey.Length != 0)
        num ^= this.ServerPublicKey.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ServerPublicKey.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteBytes(this.ServerPublicKey);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ServerPublicKey.Length != 0)
        num += 1 + CodedOutputStream.ComputeBytesSize(this.ServerPublicKey);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ServerPublicKeyNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ServerPublicKey.Length != 0)
        this.ServerPublicKey = other.ServerPublicKey;
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
          this.ServerPublicKey = input.ReadBytes();
      }
    }
  }
}
