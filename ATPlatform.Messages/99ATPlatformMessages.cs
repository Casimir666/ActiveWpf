// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCountNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetCountNotificationProto : 
    IMessage<GetCountNotificationProto>,
    IMessage,
    IEquatable<GetCountNotificationProto>,
    IDeepCloneable<GetCountNotificationProto>
  {
    private static readonly MessageParser<GetCountNotificationProto> _parser = new MessageParser<GetCountNotificationProto>((Func<GetCountNotificationProto>) (() => new GetCountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int NumberElementsFieldNumber = 1;
    private int numberElements_;
    public const int CountNotificationFieldNumber = 2;
    private CountTypeProto countNotification_;

    [DebuggerNonUserCode]
    public static MessageParser<GetCountNotificationProto> Parser => GetCountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[91];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCountNotificationProto(GetCountNotificationProto other)
      : this()
    {
      this.numberElements_ = other.numberElements_;
      this.countNotification_ = other.countNotification_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCountNotificationProto Clone() => new GetCountNotificationProto(this);

    [DebuggerNonUserCode]
    public int NumberElements
    {
      get => this.numberElements_;
      set => this.numberElements_ = value;
    }

    [DebuggerNonUserCode]
    public CountTypeProto CountNotification
    {
      get => this.countNotification_;
      set => this.countNotification_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.NumberElements == other.NumberElements && this.CountNotification == other.CountNotification && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.NumberElements != 0)
        num ^= this.NumberElements.GetHashCode();
      if (this.CountNotification != CountTypeProto.UndefinedCountRequest)
        num ^= this.CountNotification.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.NumberElements != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.NumberElements);
      }
      if (this.CountNotification != CountTypeProto.UndefinedCountRequest)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.CountNotification);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.NumberElements != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberElements);
      if (this.CountNotification != CountTypeProto.UndefinedCountRequest)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.CountNotification);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.NumberElements != 0)
        this.NumberElements = other.NumberElements;
      if (other.CountNotification != CountTypeProto.UndefinedCountRequest)
        this.CountNotification = other.CountNotification;
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
            this.NumberElements = input.ReadInt32();
            continue;
          case 16:
            this.CountNotification = (CountTypeProto) input.ReadEnum();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
