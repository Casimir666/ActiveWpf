// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgeSettingsSetNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class HedgeSettingsSetNotificationProto : 
    IMessage<HedgeSettingsSetNotificationProto>,
    IMessage,
    IEquatable<HedgeSettingsSetNotificationProto>,
    IDeepCloneable<HedgeSettingsSetNotificationProto>
  {
    private static readonly MessageParser<HedgeSettingsSetNotificationProto> _parser = new MessageParser<HedgeSettingsSetNotificationProto>((Func<HedgeSettingsSetNotificationProto>) (() => new HedgeSettingsSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int HedgeSettingsSetFieldNumber = 1;
    private HedgeSettingsSetProto hedgeSettingsSet_;

    [DebuggerNonUserCode]
    public static MessageParser<HedgeSettingsSetNotificationProto> Parser => HedgeSettingsSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[198];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HedgeSettingsSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public HedgeSettingsSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public HedgeSettingsSetNotificationProto(HedgeSettingsSetNotificationProto other)
      : this()
    {
      this.hedgeSettingsSet_ = other.hedgeSettingsSet_ != null ? other.hedgeSettingsSet_.Clone() : (HedgeSettingsSetProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HedgeSettingsSetNotificationProto Clone() => new HedgeSettingsSetNotificationProto(this);

    [DebuggerNonUserCode]
    public HedgeSettingsSetProto HedgeSettingsSet
    {
      get => this.hedgeSettingsSet_;
      set => this.hedgeSettingsSet_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HedgeSettingsSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(HedgeSettingsSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.HedgeSettingsSet, (object) other.HedgeSettingsSet) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.hedgeSettingsSet_ != null)
        num ^= this.HedgeSettingsSet.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.hedgeSettingsSet_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.HedgeSettingsSet);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.hedgeSettingsSet_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.HedgeSettingsSet);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HedgeSettingsSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.hedgeSettingsSet_ != null)
      {
        if (this.hedgeSettingsSet_ == null)
          this.HedgeSettingsSet = new HedgeSettingsSetProto();
        this.HedgeSettingsSet.MergeFrom(other.HedgeSettingsSet);
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
          if (this.hedgeSettingsSet_ == null)
            this.HedgeSettingsSet = new HedgeSettingsSetProto();
          input.ReadMessage((IMessage) this.HedgeSettingsSet);
        }
      }
    }
  }
}
