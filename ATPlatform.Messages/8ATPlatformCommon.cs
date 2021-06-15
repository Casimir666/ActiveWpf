// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ServiceStatusRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ServiceStatusRequestProto : 
    IMessage<ServiceStatusRequestProto>,
    IMessage,
    IEquatable<ServiceStatusRequestProto>,
    IDeepCloneable<ServiceStatusRequestProto>
  {
    private static readonly MessageParser<ServiceStatusRequestProto> _parser = new MessageParser<ServiceStatusRequestProto>((Func<ServiceStatusRequestProto>) (() => new ServiceStatusRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int ServiceIdFieldNumber = 1;
    private string serviceId_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<ServiceStatusRequestProto> Parser => ServiceStatusRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[7];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ServiceStatusRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ServiceStatusRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ServiceStatusRequestProto(ServiceStatusRequestProto other)
      : this()
    {
      this.serviceId_ = other.serviceId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ServiceStatusRequestProto Clone() => new ServiceStatusRequestProto(this);

    [DebuggerNonUserCode]
    public string ServiceId
    {
      get => this.serviceId_;
      set => this.serviceId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ServiceStatusRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ServiceStatusRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.ServiceId != other.ServiceId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ServiceId.Length != 0)
        num ^= this.ServiceId.GetHashCode();
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
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ServiceStatusRequestProto other)
    {
      if (other == null)
        return;
      if (other.ServiceId.Length != 0)
        this.ServiceId = other.ServiceId;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.ServiceId = input.ReadString();
      }
    }
  }
}
