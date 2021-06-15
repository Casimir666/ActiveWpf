// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertStatefulAlertProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertStatefulAlertProto : 
    IMessage<AbuseAlertStatefulAlertProto>,
    IMessage,
    IEquatable<AbuseAlertStatefulAlertProto>,
    IDeepCloneable<AbuseAlertStatefulAlertProto>
  {
    private static readonly MessageParser<AbuseAlertStatefulAlertProto> _parser = new MessageParser<AbuseAlertStatefulAlertProto>((Func<AbuseAlertStatefulAlertProto>) (() => new AbuseAlertStatefulAlertProto()));
    private UnknownFieldSet _unknownFields;
    public const int AlertDataFieldNumber = 1;
    private AbuseAlertStatelessAlertDataProto alertData_;
    public const int AlertStateFieldNumber = 2;
    private AbuseAlertStateDataProto alertState_;

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertStatefulAlertProto> Parser => AbuseAlertStatefulAlertProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[2];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertStatefulAlertProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertStatefulAlertProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertStatefulAlertProto(AbuseAlertStatefulAlertProto other)
      : this()
    {
      this.alertData_ = other.alertData_ != null ? other.alertData_.Clone() : (AbuseAlertStatelessAlertDataProto) null;
      this.alertState_ = other.alertState_ != null ? other.alertState_.Clone() : (AbuseAlertStateDataProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertStatefulAlertProto Clone() => new AbuseAlertStatefulAlertProto(this);

    [DebuggerNonUserCode]
    public AbuseAlertStatelessAlertDataProto AlertData
    {
      get => this.alertData_;
      set => this.alertData_ = value;
    }

    [DebuggerNonUserCode]
    public AbuseAlertStateDataProto AlertState
    {
      get => this.alertState_;
      set => this.alertState_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertStatefulAlertProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertStatefulAlertProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.AlertData, (object) other.AlertData) && object.Equals((object) this.AlertState, (object) other.AlertState) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.alertData_ != null)
        num ^= this.AlertData.GetHashCode();
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
      if (this.alertData_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.AlertData);
      }
      if (this.alertState_ != null)
      {
        output.WriteRawTag((byte) 18);
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
      if (this.alertData_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AlertData);
      if (this.alertState_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AlertState);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertStatefulAlertProto other)
    {
      if (other == null)
        return;
      if (other.alertData_ != null)
      {
        if (this.alertData_ == null)
          this.AlertData = new AbuseAlertStatelessAlertDataProto();
        this.AlertData.MergeFrom(other.AlertData);
      }
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
        switch (num)
        {
          case 10:
            if (this.alertData_ == null)
              this.AlertData = new AbuseAlertStatelessAlertDataProto();
            input.ReadMessage((IMessage) this.AlertData);
            continue;
          case 18:
            if (this.alertState_ == null)
              this.AlertState = new AbuseAlertStateDataProto();
            input.ReadMessage((IMessage) this.AlertState);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
