// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.NewTickNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class NewTickNotificationProto : 
    IMessage<NewTickNotificationProto>,
    IMessage,
    IEquatable<NewTickNotificationProto>,
    IDeepCloneable<NewTickNotificationProto>
  {
    private static readonly MessageParser<NewTickNotificationProto> _parser = new MessageParser<NewTickNotificationProto>((Func<NewTickNotificationProto>) (() => new NewTickNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TickFieldNumber = 1;
    private TickProto tick_;

    [DebuggerNonUserCode]
    public static MessageParser<NewTickNotificationProto> Parser => NewTickNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[146];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => NewTickNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public NewTickNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public NewTickNotificationProto(NewTickNotificationProto other)
      : this()
    {
      this.tick_ = other.tick_ != null ? other.tick_.Clone() : (TickProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public NewTickNotificationProto Clone() => new NewTickNotificationProto(this);

    [DebuggerNonUserCode]
    public TickProto Tick
    {
      get => this.tick_;
      set => this.tick_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as NewTickNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(NewTickNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Tick, (object) other.Tick) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.tick_ != null)
        num ^= this.Tick.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.tick_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Tick);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.tick_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Tick);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(NewTickNotificationProto other)
    {
      if (other == null)
        return;
      if (other.tick_ != null)
      {
        if (this.tick_ == null)
          this.Tick = new TickProto();
        this.Tick.MergeFrom(other.Tick);
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
          if (this.tick_ == null)
            this.Tick = new TickProto();
          input.ReadMessage((IMessage) this.Tick);
        }
      }
    }
  }
}
