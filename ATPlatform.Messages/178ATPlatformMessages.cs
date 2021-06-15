// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AdministratorsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class AdministratorsNotificationProto : 
    IMessage<AdministratorsNotificationProto>,
    IMessage,
    IEquatable<AdministratorsNotificationProto>,
    IDeepCloneable<AdministratorsNotificationProto>
  {
    private static readonly MessageParser<AdministratorsNotificationProto> _parser = new MessageParser<AdministratorsNotificationProto>((Func<AdministratorsNotificationProto>) (() => new AdministratorsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AdministratorFieldNumber = 1;
    private AdministratorProto administrator_;

    [DebuggerNonUserCode]
    public static MessageParser<AdministratorsNotificationProto> Parser => AdministratorsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[175];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AdministratorsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AdministratorsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AdministratorsNotificationProto(AdministratorsNotificationProto other)
      : this()
    {
      this.administrator_ = other.administrator_ != null ? other.administrator_.Clone() : (AdministratorProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AdministratorsNotificationProto Clone() => new AdministratorsNotificationProto(this);

    [DebuggerNonUserCode]
    public AdministratorProto Administrator
    {
      get => this.administrator_;
      set => this.administrator_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AdministratorsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AdministratorsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Administrator, (object) other.Administrator) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.administrator_ != null)
        num ^= this.Administrator.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.administrator_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Administrator);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.administrator_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Administrator);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AdministratorsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.administrator_ != null)
      {
        if (this.administrator_ == null)
          this.Administrator = new AdministratorProto();
        this.Administrator.MergeFrom(other.Administrator);
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
          if (this.administrator_ == null)
            this.Administrator = new AdministratorProto();
          input.ReadMessage((IMessage) this.Administrator);
        }
      }
    }
  }
}
