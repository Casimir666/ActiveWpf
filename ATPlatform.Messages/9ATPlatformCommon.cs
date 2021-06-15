// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ServiceStatusNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ServiceStatusNotificationProto : 
    IMessage<ServiceStatusNotificationProto>,
    IMessage,
    IEquatable<ServiceStatusNotificationProto>,
    IDeepCloneable<ServiceStatusNotificationProto>
  {
    private static readonly MessageParser<ServiceStatusNotificationProto> _parser = new MessageParser<ServiceStatusNotificationProto>((Func<ServiceStatusNotificationProto>) (() => new ServiceStatusNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ServiceIdFieldNumber = 1;
    private string serviceId_ = "";
    public const int ServiceStatusFieldNumber = 2;
    private ServiceStatusProto serviceStatus_;

    [DebuggerNonUserCode]
    public static MessageParser<ServiceStatusNotificationProto> Parser => ServiceStatusNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[8];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ServiceStatusNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ServiceStatusNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ServiceStatusNotificationProto(ServiceStatusNotificationProto other)
      : this()
    {
      this.serviceId_ = other.serviceId_;
      this.serviceStatus_ = other.serviceStatus_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ServiceStatusNotificationProto Clone() => new ServiceStatusNotificationProto(this);

    [DebuggerNonUserCode]
    public string ServiceId
    {
      get => this.serviceId_;
      set => this.serviceId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public ServiceStatusProto ServiceStatus
    {
      get => this.serviceStatus_;
      set => this.serviceStatus_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ServiceStatusNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ServiceStatusNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.ServiceId != other.ServiceId) && this.ServiceStatus == other.ServiceStatus && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ServiceId.Length != 0)
        num ^= this.ServiceId.GetHashCode();
      if (this.ServiceStatus != ServiceStatusProto.UnknownServiceStatus)
        num ^= this.ServiceStatus.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ServiceId.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.ServiceId);
      }
      if (this.ServiceStatus != ServiceStatusProto.UnknownServiceStatus)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.ServiceStatus);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ServiceId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.ServiceId);
      if (this.ServiceStatus != ServiceStatusProto.UnknownServiceStatus)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.ServiceStatus);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ServiceStatusNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ServiceId.Length != 0)
        this.ServiceId = other.ServiceId;
      if (other.ServiceStatus != ServiceStatusProto.UnknownServiceStatus)
        this.ServiceStatus = other.ServiceStatus;
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
            this.ServiceId = input.ReadString();
            continue;
          case 16:
            this.ServiceStatus = (ServiceStatusProto) input.ReadEnum();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
