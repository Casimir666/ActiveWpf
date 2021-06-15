// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientMessagesForAccountNotificationProto
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
  public sealed class GetClientMessagesForAccountNotificationProto : 
    IMessage<GetClientMessagesForAccountNotificationProto>,
    IMessage,
    IEquatable<GetClientMessagesForAccountNotificationProto>,
    IDeepCloneable<GetClientMessagesForAccountNotificationProto>
  {
    private static readonly MessageParser<GetClientMessagesForAccountNotificationProto> _parser = new MessageParser<GetClientMessagesForAccountNotificationProto>((Func<GetClientMessagesForAccountNotificationProto>) (() => new GetClientMessagesForAccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int ClientMessagesForAccountFieldNumber = 3;
    private static readonly FieldCodec<ClientMessageForAccountProto> _repeated_clientMessagesForAccount_codec = FieldCodec.ForMessage<ClientMessageForAccountProto>(26U, ClientMessageForAccountProto.Parser);
    private readonly RepeatedField<ClientMessageForAccountProto> clientMessagesForAccount_ = new RepeatedField<ClientMessageForAccountProto>();
    public const int ClientMessagesCountFieldNumber = 4;
    private int clientMessagesCount_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClientMessagesForAccountNotificationProto> Parser => GetClientMessagesForAccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[237];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientMessagesForAccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountNotificationProto(
      GetClientMessagesForAccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.clientMessagesForAccount_ = other.clientMessagesForAccount_.Clone();
      this.clientMessagesCount_ = other.clientMessagesCount_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountNotificationProto Clone() => new GetClientMessagesForAccountNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string PlatformId
    {
      get => this.platformId_;
      set => this.platformId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageForAccountProto> ClientMessagesForAccount => this.clientMessagesForAccount_;

    [DebuggerNonUserCode]
    public int ClientMessagesCount
    {
      get => this.clientMessagesCount_;
      set => this.clientMessagesCount_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientMessagesForAccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientMessagesForAccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && (this.clientMessagesForAccount_.Equals(other.clientMessagesForAccount_) && this.ClientMessagesCount == other.ClientMessagesCount) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.PlatformId.Length != 0)
        num1 ^= this.PlatformId.GetHashCode();
      int num4 = num1 ^ this.clientMessagesForAccount_.GetHashCode();
      if (this.ClientMessagesCount != 0)
      {
        int num3 = num4;
        num2 = this.ClientMessagesCount;
        int hashCode = num2.GetHashCode();
        num4 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
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
      if (this.PlatformId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.PlatformId);
      }
      this.clientMessagesForAccount_.WriteTo(output, GetClientMessagesForAccountNotificationProto._repeated_clientMessagesForAccount_codec);
      if (this.ClientMessagesCount != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.ClientMessagesCount);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.AccountId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.PlatformId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      int num2 = num1 + this.clientMessagesForAccount_.CalculateSize(GetClientMessagesForAccountNotificationProto._repeated_clientMessagesForAccount_codec);
      if (this.ClientMessagesCount != 0)
        num2 += 1 + CodedOutputStream.ComputeInt32Size(this.ClientMessagesCount);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientMessagesForAccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      this.clientMessagesForAccount_.Add((IEnumerable<ClientMessageForAccountProto>) other.clientMessagesForAccount_);
      if (other.ClientMessagesCount != 0)
        this.ClientMessagesCount = other.ClientMessagesCount;
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
          case 18:
            this.PlatformId = input.ReadString();
            continue;
          case 26:
            this.clientMessagesForAccount_.AddEntriesFrom(input, GetClientMessagesForAccountNotificationProto._repeated_clientMessagesForAccount_codec);
            continue;
          case 32:
            this.ClientMessagesCount = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
