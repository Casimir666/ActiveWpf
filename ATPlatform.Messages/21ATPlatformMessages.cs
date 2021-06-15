// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.EndOfDayOperationsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class EndOfDayOperationsNotificationProto : 
    IMessage<EndOfDayOperationsNotificationProto>,
    IMessage,
    IEquatable<EndOfDayOperationsNotificationProto>,
    IDeepCloneable<EndOfDayOperationsNotificationProto>
  {
    private static readonly MessageParser<EndOfDayOperationsNotificationProto> _parser = new MessageParser<EndOfDayOperationsNotificationProto>((Func<EndOfDayOperationsNotificationProto>) (() => new EndOfDayOperationsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TimestampFieldNumber = 1;
    private long timestamp_;
    public const int ApplySwapsFieldNumber = 2;
    private bool applySwaps_;
    public const int GenerateStatementsFieldNumber = 3;
    private bool generateStatements_;

    [DebuggerNonUserCode]
    public static MessageParser<EndOfDayOperationsNotificationProto> Parser => EndOfDayOperationsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[2];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => EndOfDayOperationsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public EndOfDayOperationsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public EndOfDayOperationsNotificationProto(EndOfDayOperationsNotificationProto other)
      : this()
    {
      this.timestamp_ = other.timestamp_;
      this.applySwaps_ = other.applySwaps_;
      this.generateStatements_ = other.generateStatements_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public EndOfDayOperationsNotificationProto Clone() => new EndOfDayOperationsNotificationProto(this);

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public bool ApplySwaps
    {
      get => this.applySwaps_;
      set => this.applySwaps_ = value;
    }

    [DebuggerNonUserCode]
    public bool GenerateStatements
    {
      get => this.generateStatements_;
      set => this.generateStatements_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as EndOfDayOperationsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(EndOfDayOperationsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Timestamp == other.Timestamp && this.ApplySwaps == other.ApplySwaps && this.GenerateStatements == other.GenerateStatements && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      bool flag;
      if (this.ApplySwaps)
      {
        int num2 = num1;
        flag = this.ApplySwaps;
        int hashCode = flag.GetHashCode();
        num1 = num2 ^ hashCode;
      }
      if (this.GenerateStatements)
      {
        int num2 = num1;
        flag = this.GenerateStatements;
        int hashCode = flag.GetHashCode();
        num1 = num2 ^ hashCode;
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
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.Timestamp);
      }
      if (this.ApplySwaps)
      {
        output.WriteRawTag((byte) 16);
        output.WriteBool(this.ApplySwaps);
      }
      if (this.GenerateStatements)
      {
        output.WriteRawTag((byte) 24);
        output.WriteBool(this.GenerateStatements);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.ApplySwaps)
        num += 2;
      if (this.GenerateStatements)
        num += 2;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(EndOfDayOperationsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.ApplySwaps)
        this.ApplySwaps = other.ApplySwaps;
      if (other.GenerateStatements)
        this.GenerateStatements = other.GenerateStatements;
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
            this.Timestamp = input.ReadInt64();
            continue;
          case 16:
            this.ApplySwaps = input.ReadBool();
            continue;
          case 24:
            this.GenerateStatements = input.ReadBool();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
