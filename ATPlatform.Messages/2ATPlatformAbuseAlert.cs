// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertStateDataProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertStateDataProto : 
    IMessage<AbuseAlertStateDataProto>,
    IMessage,
    IEquatable<AbuseAlertStateDataProto>,
    IDeepCloneable<AbuseAlertStateDataProto>
  {
    private static readonly MessageParser<AbuseAlertStateDataProto> _parser = new MessageParser<AbuseAlertStateDataProto>((Func<AbuseAlertStateDataProto>) (() => new AbuseAlertStateDataProto()));
    private UnknownFieldSet _unknownFields;
    public const int AlertIdFieldNumber = 1;
    private int alertId_;
    public const int StateFieldNumber = 2;
    private AbuseAlertStateType state_;
    public const int AssignedToFieldNumber = 3;
    private int assignedTo_;
    public const int LastActionDateFieldNumber = 4;
    private long lastActionDate_;
    public const int CommentFieldNumber = 5;
    private string comment_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertStateDataProto> Parser => AbuseAlertStateDataProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[1];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertStateDataProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertStateDataProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertStateDataProto(AbuseAlertStateDataProto other)
      : this()
    {
      this.alertId_ = other.alertId_;
      this.state_ = other.state_;
      this.assignedTo_ = other.assignedTo_;
      this.lastActionDate_ = other.lastActionDate_;
      this.comment_ = other.comment_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertStateDataProto Clone() => new AbuseAlertStateDataProto(this);

    [DebuggerNonUserCode]
    public int AlertId
    {
      get => this.alertId_;
      set => this.alertId_ = value;
    }

    [DebuggerNonUserCode]
    public AbuseAlertStateType State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public int AssignedTo
    {
      get => this.assignedTo_;
      set => this.assignedTo_ = value;
    }

    [DebuggerNonUserCode]
    public long LastActionDate
    {
      get => this.lastActionDate_;
      set => this.lastActionDate_ = value;
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertStateDataProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertStateDataProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AlertId == other.AlertId && this.State == other.State && (this.AssignedTo == other.AssignedTo && this.LastActionDate == other.LastActionDate) && !(this.Comment != other.Comment) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AlertId != 0)
      {
        int num3 = num1;
        num2 = this.AlertId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.State != AbuseAlertStateType.UndefinedState)
        num1 ^= this.State.GetHashCode();
      if (this.AssignedTo != 0)
      {
        int num3 = num1;
        num2 = this.AssignedTo;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.LastActionDate != 0L)
        num1 ^= this.LastActionDate.GetHashCode();
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AlertId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AlertId);
      }
      if (this.State != AbuseAlertStateType.UndefinedState)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.State);
      }
      if (this.AssignedTo != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.AssignedTo);
      }
      if (this.LastActionDate != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.LastActionDate);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Comment);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AlertId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AlertId);
      if (this.State != AbuseAlertStateType.UndefinedState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.AssignedTo != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AssignedTo);
      if (this.LastActionDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.LastActionDate);
      if (this.Comment.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertStateDataProto other)
    {
      if (other == null)
        return;
      if (other.AlertId != 0)
        this.AlertId = other.AlertId;
      if (other.State != AbuseAlertStateType.UndefinedState)
        this.State = other.State;
      if (other.AssignedTo != 0)
        this.AssignedTo = other.AssignedTo;
      if (other.LastActionDate != 0L)
        this.LastActionDate = other.LastActionDate;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
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
            this.AlertId = input.ReadInt32();
            continue;
          case 16:
            this.State = (AbuseAlertStateType) input.ReadEnum();
            continue;
          case 24:
            this.AssignedTo = input.ReadInt32();
            continue;
          case 32:
            this.LastActionDate = input.ReadInt64();
            continue;
          case 42:
            this.Comment = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
