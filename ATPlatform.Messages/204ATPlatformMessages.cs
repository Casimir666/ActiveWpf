// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SmartBridgeSettingsSetNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SmartBridgeSettingsSetNotificationProto : 
    IMessage<SmartBridgeSettingsSetNotificationProto>,
    IMessage,
    IEquatable<SmartBridgeSettingsSetNotificationProto>,
    IDeepCloneable<SmartBridgeSettingsSetNotificationProto>
  {
    private static readonly MessageParser<SmartBridgeSettingsSetNotificationProto> _parser = new MessageParser<SmartBridgeSettingsSetNotificationProto>((Func<SmartBridgeSettingsSetNotificationProto>) (() => new SmartBridgeSettingsSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SmartBridgeSettingsSetFieldNumber = 1;
    private SmartBridgeSettingsSetProto smartBridgeSettingsSet_;

    [DebuggerNonUserCode]
    public static MessageParser<SmartBridgeSettingsSetNotificationProto> Parser => SmartBridgeSettingsSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[204];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SmartBridgeSettingsSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public SmartBridgeSettingsSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public SmartBridgeSettingsSetNotificationProto(SmartBridgeSettingsSetNotificationProto other)
      : this()
    {
      this.smartBridgeSettingsSet_ = other.smartBridgeSettingsSet_ != null ? other.smartBridgeSettingsSet_.Clone() : (SmartBridgeSettingsSetProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SmartBridgeSettingsSetNotificationProto Clone() => new SmartBridgeSettingsSetNotificationProto(this);

    [DebuggerNonUserCode]
    public SmartBridgeSettingsSetProto SmartBridgeSettingsSet
    {
      get => this.smartBridgeSettingsSet_;
      set => this.smartBridgeSettingsSet_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SmartBridgeSettingsSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(SmartBridgeSettingsSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.SmartBridgeSettingsSet, (object) other.SmartBridgeSettingsSet) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.smartBridgeSettingsSet_ != null)
        num ^= this.SmartBridgeSettingsSet.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.smartBridgeSettingsSet_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.SmartBridgeSettingsSet);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.smartBridgeSettingsSet_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.SmartBridgeSettingsSet);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SmartBridgeSettingsSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.smartBridgeSettingsSet_ != null)
      {
        if (this.smartBridgeSettingsSet_ == null)
          this.SmartBridgeSettingsSet = new SmartBridgeSettingsSetProto();
        this.SmartBridgeSettingsSet.MergeFrom(other.SmartBridgeSettingsSet);
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
          if (this.smartBridgeSettingsSet_ == null)
            this.SmartBridgeSettingsSet = new SmartBridgeSettingsSetProto();
          input.ReadMessage((IMessage) this.SmartBridgeSettingsSet);
        }
      }
    }
  }
}
