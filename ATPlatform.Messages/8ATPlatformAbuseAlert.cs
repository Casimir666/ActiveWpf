// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertNewStatefulAlertNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertNewStatefulAlertNotificationProto : 
    IMessage<AbuseAlertNewStatefulAlertNotificationProto>,
    IMessage,
    IEquatable<AbuseAlertNewStatefulAlertNotificationProto>,
    IDeepCloneable<AbuseAlertNewStatefulAlertNotificationProto>
  {
    private static readonly MessageParser<AbuseAlertNewStatefulAlertNotificationProto> _parser = new MessageParser<AbuseAlertNewStatefulAlertNotificationProto>((Func<AbuseAlertNewStatefulAlertNotificationProto>) (() => new AbuseAlertNewStatefulAlertNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AlertFieldNumber = 1;
    private AbuseAlertStatefulAlertProto alert_;

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertNewStatefulAlertNotificationProto> Parser => AbuseAlertNewStatefulAlertNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[7];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertNewStatefulAlertNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertNewStatefulAlertNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertNewStatefulAlertNotificationProto(
      AbuseAlertNewStatefulAlertNotificationProto other)
      : this()
    {
      this.alert_ = other.alert_ != null ? other.alert_.Clone() : (AbuseAlertStatefulAlertProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertNewStatefulAlertNotificationProto Clone() => new AbuseAlertNewStatefulAlertNotificationProto(this);

    [DebuggerNonUserCode]
    public AbuseAlertStatefulAlertProto Alert
    {
      get => this.alert_;
      set => this.alert_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertNewStatefulAlertNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertNewStatefulAlertNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Alert, (object) other.Alert) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.alert_ != null)
        num ^= this.Alert.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.alert_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Alert);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.alert_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Alert);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertNewStatefulAlertNotificationProto other)
    {
      if (other == null)
        return;
      if (other.alert_ != null)
      {
        if (this.alert_ == null)
          this.Alert = new AbuseAlertStatefulAlertProto();
        this.Alert.MergeFrom(other.Alert);
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
          if (this.alert_ == null)
            this.Alert = new AbuseAlertStatefulAlertProto();
          input.ReadMessage((IMessage) this.Alert);
        }
      }
    }
  }
}
