// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageProto : 
    IMessage<ClientMessageProto>,
    IMessage,
    IEquatable<ClientMessageProto>,
    IDeepCloneable<ClientMessageProto>
  {
    private static readonly MessageParser<ClientMessageProto> _parser = new MessageParser<ClientMessageProto>((Func<ClientMessageProto>) (() => new ClientMessageProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int ImportanceFieldNumber = 3;
    private ClientMessageImportanceProto importance_;
    public const int CategoryFieldNumber = 4;
    private ClientMessageCategoryProto category_;
    public const int StateFieldNumber = 5;
    private ClientMessageStateProto state_;
    public const int SubjectFieldNumber = 6;
    private string subject_ = "";
    public const int BodyFieldNumber = 7;
    private string body_ = "";
    public const int TimestampFieldNumber = 8;
    private long timestamp_;
    public const int InitiatorIdFieldNumber = 9;
    private string initiatorId_ = "";
    public const int OneTimeOnlyNotificationFieldNumber = 10;
    private bool oneTimeOnlyNotification_;
    public const int SendTimestampFieldNumber = 11;
    private long sendTimestamp_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageProto> Parser => ClientMessageProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[226];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageProto(ClientMessageProto other)
      : this()
    {
      this.id_ = other.id_;
      this.platformId_ = other.platformId_;
      this.importance_ = other.importance_;
      this.category_ = other.category_;
      this.state_ = other.state_;
      this.subject_ = other.subject_;
      this.body_ = other.body_;
      this.timestamp_ = other.timestamp_;
      this.initiatorId_ = other.initiatorId_;
      this.oneTimeOnlyNotification_ = other.oneTimeOnlyNotification_;
      this.sendTimestamp_ = other.sendTimestamp_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageProto Clone() => new ClientMessageProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string PlatformId
    {
      get => this.platformId_;
      set => this.platformId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ClientMessageImportanceProto Importance
    {
      get => this.importance_;
      set => this.importance_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageCategoryProto Category
    {
      get => this.category_;
      set => this.category_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public string Subject
    {
      get => this.subject_;
      set => this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Body
    {
      get => this.body_;
      set => this.body_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string InitiatorId
    {
      get => this.initiatorId_;
      set => this.initiatorId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public bool OneTimeOnlyNotification
    {
      get => this.oneTimeOnlyNotification_;
      set => this.oneTimeOnlyNotification_ = value;
    }

    [DebuggerNonUserCode]
    public long SendTimestamp
    {
      get => this.sendTimestamp_;
      set => this.sendTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.PlatformId != other.PlatformId) && (this.Importance == other.Importance && this.Category == other.Category) && (this.State == other.State && !(this.Subject != other.Subject) && (!(this.Body != other.Body) && this.Timestamp == other.Timestamp)) && (!(this.InitiatorId != other.InitiatorId) && this.OneTimeOnlyNotification == other.OneTimeOnlyNotification && this.SendTimestamp == other.SendTimestamp) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Id != 0)
        num1 ^= this.Id.GetHashCode();
      if (this.PlatformId.Length != 0)
        num1 ^= this.PlatformId.GetHashCode();
      if (this.Importance != ClientMessageImportanceProto.UndefinedClientMessageImportance)
        num1 ^= this.Importance.GetHashCode();
      if (this.Category != ClientMessageCategoryProto.UndefinedClientMessageCategory)
        num1 ^= this.Category.GetHashCode();
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
        num1 ^= this.State.GetHashCode();
      if (this.Subject.Length != 0)
        num1 ^= this.Subject.GetHashCode();
      if (this.Body.Length != 0)
        num1 ^= this.Body.GetHashCode();
      long num2;
      if (this.Timestamp != 0L)
      {
        int num3 = num1;
        num2 = this.Timestamp;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.InitiatorId.Length != 0)
        num1 ^= this.InitiatorId.GetHashCode();
      if (this.OneTimeOnlyNotification)
        num1 ^= this.OneTimeOnlyNotification.GetHashCode();
      if (this.SendTimestamp != 0L)
      {
        int num3 = num1;
        num2 = this.SendTimestamp;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.PlatformId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.PlatformId);
      }
      if (this.Importance != ClientMessageImportanceProto.UndefinedClientMessageImportance)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.Importance);
      }
      if (this.Category != ClientMessageCategoryProto.UndefinedClientMessageCategory)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.Category);
      }
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
      {
        output.WriteRawTag((byte) 40);
        output.WriteEnum((int) this.State);
      }
      if (this.Subject.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Subject);
      }
      if (this.Body.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.Body);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt64(this.Timestamp);
      }
      if (this.InitiatorId.Length != 0)
      {
        output.WriteRawTag((byte) 74);
        output.WriteString(this.InitiatorId);
      }
      if (this.OneTimeOnlyNotification)
      {
        output.WriteRawTag((byte) 80);
        output.WriteBool(this.OneTimeOnlyNotification);
      }
      if (this.SendTimestamp != 0L)
      {
        output.WriteRawTag((byte) 88);
        output.WriteInt64(this.SendTimestamp);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.PlatformId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      if (this.Importance != ClientMessageImportanceProto.UndefinedClientMessageImportance)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Importance);
      if (this.Category != ClientMessageCategoryProto.UndefinedClientMessageCategory)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Category);
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.Subject.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Subject);
      if (this.Body.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Body);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.InitiatorId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.InitiatorId);
      if (this.OneTimeOnlyNotification)
        num += 2;
      if (this.SendTimestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.SendTimestamp);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.Importance != ClientMessageImportanceProto.UndefinedClientMessageImportance)
        this.Importance = other.Importance;
      if (other.Category != ClientMessageCategoryProto.UndefinedClientMessageCategory)
        this.Category = other.Category;
      if (other.State != ClientMessageStateProto.UndefinedClientMessageState)
        this.State = other.State;
      if (other.Subject.Length != 0)
        this.Subject = other.Subject;
      if (other.Body.Length != 0)
        this.Body = other.Body;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.InitiatorId.Length != 0)
        this.InitiatorId = other.InitiatorId;
      if (other.OneTimeOnlyNotification)
        this.OneTimeOnlyNotification = other.OneTimeOnlyNotification;
      if (other.SendTimestamp != 0L)
        this.SendTimestamp = other.SendTimestamp;
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
            this.Id = input.ReadInt32();
            continue;
          case 18:
            this.PlatformId = input.ReadString();
            continue;
          case 24:
            this.Importance = (ClientMessageImportanceProto) input.ReadEnum();
            continue;
          case 32:
            this.Category = (ClientMessageCategoryProto) input.ReadEnum();
            continue;
          case 40:
            this.State = (ClientMessageStateProto) input.ReadEnum();
            continue;
          case 50:
            this.Subject = input.ReadString();
            continue;
          case 58:
            this.Body = input.ReadString();
            continue;
          case 64:
            this.Timestamp = input.ReadInt64();
            continue;
          case 74:
            this.InitiatorId = input.ReadString();
            continue;
          case 80:
            this.OneTimeOnlyNotification = input.ReadBool();
            continue;
          case 88:
            this.SendTimestamp = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
