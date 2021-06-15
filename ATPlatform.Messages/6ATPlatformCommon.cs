// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ErrorNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ErrorNotificationProto : 
    IMessage<ErrorNotificationProto>,
    IMessage,
    IEquatable<ErrorNotificationProto>,
    IDeepCloneable<ErrorNotificationProto>
  {
    private static readonly MessageParser<ErrorNotificationProto> _parser = new MessageParser<ErrorNotificationProto>((Func<ErrorNotificationProto>) (() => new ErrorNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ErrorCodeFieldNumber = 1;
    private ErrorCodeProto errorCode_;

    [DebuggerNonUserCode]
    public static MessageParser<ErrorNotificationProto> Parser => ErrorNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[5];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ErrorNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ErrorNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ErrorNotificationProto(ErrorNotificationProto other)
      : this()
    {
      this.errorCode_ = other.errorCode_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ErrorNotificationProto Clone() => new ErrorNotificationProto(this);

    [DebuggerNonUserCode]
    public ErrorCodeProto ErrorCode
    {
      get => this.errorCode_;
      set => this.errorCode_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ErrorNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ErrorNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.ErrorCode == other.ErrorCode && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ErrorCode != ErrorCodeProto.Success)
        num ^= this.ErrorCode.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ErrorCode != ErrorCodeProto.Success)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.ErrorCode);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ErrorCode != ErrorCodeProto.Success)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.ErrorCode);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ErrorNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ErrorCode != ErrorCodeProto.Success)
        this.ErrorCode = other.ErrorCode;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 8U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.ErrorCode = (ErrorCodeProto) input.ReadEnum();
      }
    }
  }
}
