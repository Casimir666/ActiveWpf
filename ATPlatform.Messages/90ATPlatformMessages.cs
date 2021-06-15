// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarkupSettingsSetNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class MarkupSettingsSetNotificationProto : 
    IMessage<MarkupSettingsSetNotificationProto>,
    IMessage,
    IEquatable<MarkupSettingsSetNotificationProto>,
    IDeepCloneable<MarkupSettingsSetNotificationProto>
  {
    private static readonly MessageParser<MarkupSettingsSetNotificationProto> _parser = new MessageParser<MarkupSettingsSetNotificationProto>((Func<MarkupSettingsSetNotificationProto>) (() => new MarkupSettingsSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarkupSettingsSetFieldNumber = 1;
    private MarkupSettingsSetProto markupSettingsSet_;

    [DebuggerNonUserCode]
    public static MessageParser<MarkupSettingsSetNotificationProto> Parser => MarkupSettingsSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[79];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarkupSettingsSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public MarkupSettingsSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public MarkupSettingsSetNotificationProto(MarkupSettingsSetNotificationProto other)
      : this()
    {
      this.markupSettingsSet_ = other.markupSettingsSet_ != null ? other.markupSettingsSet_.Clone() : (MarkupSettingsSetProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarkupSettingsSetNotificationProto Clone() => new MarkupSettingsSetNotificationProto(this);

    [DebuggerNonUserCode]
    public MarkupSettingsSetProto MarkupSettingsSet
    {
      get => this.markupSettingsSet_;
      set => this.markupSettingsSet_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarkupSettingsSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(MarkupSettingsSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.MarkupSettingsSet, (object) other.MarkupSettingsSet) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.markupSettingsSet_ != null)
        num ^= this.MarkupSettingsSet.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.markupSettingsSet_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.MarkupSettingsSet);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.markupSettingsSet_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.MarkupSettingsSet);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarkupSettingsSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.markupSettingsSet_ != null)
      {
        if (this.markupSettingsSet_ == null)
          this.MarkupSettingsSet = new MarkupSettingsSetProto();
        this.MarkupSettingsSet.MergeFrom(other.MarkupSettingsSet);
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
          if (this.markupSettingsSet_ == null)
            this.MarkupSettingsSet = new MarkupSettingsSetProto();
          input.ReadMessage((IMessage) this.MarkupSettingsSet);
        }
      }
    }
  }
}
