// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ATServerConfigurationRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ATServerConfigurationRequestProto : 
    IMessage<ATServerConfigurationRequestProto>,
    IMessage,
    IEquatable<ATServerConfigurationRequestProto>,
    IDeepCloneable<ATServerConfigurationRequestProto>
  {
    private static readonly MessageParser<ATServerConfigurationRequestProto> _parser = new MessageParser<ATServerConfigurationRequestProto>((Func<ATServerConfigurationRequestProto>) (() => new ATServerConfigurationRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AtserverConfigurationProtoFieldNumber = 1;
    private ATServerConfigurationProto atserverConfigurationProto_;

    [DebuggerNonUserCode]
    public static MessageParser<ATServerConfigurationRequestProto> Parser => ATServerConfigurationRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[213];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ATServerConfigurationRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ATServerConfigurationRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationRequestProto(ATServerConfigurationRequestProto other)
      : this()
    {
      this.atserverConfigurationProto_ = other.atserverConfigurationProto_ != null ? other.atserverConfigurationProto_.Clone() : (ATServerConfigurationProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationRequestProto Clone() => new ATServerConfigurationRequestProto(this);

    [DebuggerNonUserCode]
    public ATServerConfigurationProto AtserverConfigurationProto
    {
      get => this.atserverConfigurationProto_;
      set => this.atserverConfigurationProto_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ATServerConfigurationRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ATServerConfigurationRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.AtserverConfigurationProto, (object) other.AtserverConfigurationProto) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.atserverConfigurationProto_ != null)
        num ^= this.AtserverConfigurationProto.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.atserverConfigurationProto_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.AtserverConfigurationProto);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.atserverConfigurationProto_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AtserverConfigurationProto);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ATServerConfigurationRequestProto other)
    {
      if (other == null)
        return;
      if (other.atserverConfigurationProto_ != null)
      {
        if (this.atserverConfigurationProto_ == null)
          this.AtserverConfigurationProto = new ATServerConfigurationProto();
        this.AtserverConfigurationProto.MergeFrom(other.AtserverConfigurationProto);
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
          if (this.atserverConfigurationProto_ == null)
            this.AtserverConfigurationProto = new ATServerConfigurationProto();
          input.ReadMessage((IMessage) this.AtserverConfigurationProto);
        }
      }
    }
  }
}
