// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertUpdateAlertStateRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertUpdateAlertStateRequestProto : 
    IMessage<AbuseAlertUpdateAlertStateRequestProto>,
    IMessage,
    IEquatable<AbuseAlertUpdateAlertStateRequestProto>,
    IDeepCloneable<AbuseAlertUpdateAlertStateRequestProto>
  {
    private static readonly MessageParser<AbuseAlertUpdateAlertStateRequestProto> _parser = new MessageParser<AbuseAlertUpdateAlertStateRequestProto>((Func<AbuseAlertUpdateAlertStateRequestProto>) (() => new AbuseAlertUpdateAlertStateRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AlertStateFieldNumber = 1;
    private AbuseAlertStateDataProto alertState_;

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertUpdateAlertStateRequestProto> Parser => AbuseAlertUpdateAlertStateRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[8];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertUpdateAlertStateRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertUpdateAlertStateRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertUpdateAlertStateRequestProto(AbuseAlertUpdateAlertStateRequestProto other)
      : this()
    {
      this.alertState_ = other.alertState_ != null ? other.alertState_.Clone() : (AbuseAlertStateDataProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertUpdateAlertStateRequestProto Clone() => new AbuseAlertUpdateAlertStateRequestProto(this);

    [DebuggerNonUserCode]
    public AbuseAlertStateDataProto AlertState
    {
      get => this.alertState_;
      set => this.alertState_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertUpdateAlertStateRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertUpdateAlertStateRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.AlertState, (object) other.AlertState) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.alertState_ != null)
        num ^= this.AlertState.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.alertState_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.AlertState);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.alertState_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AlertState);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertUpdateAlertStateRequestProto other)
    {
      if (other == null)
        return;
      if (other.alertState_ != null)
      {
        if (this.alertState_ == null)
          this.AlertState = new AbuseAlertStateDataProto();
        this.AlertState.MergeFrom(other.AlertState);
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
          if (this.alertState_ == null)
            this.AlertState = new AbuseAlertStateDataProto();
          input.ReadMessage((IMessage) this.AlertState);
        }
      }
    }
  }
}
