// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetServerPublicInfoRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetServerPublicInfoRequestProto : 
    IMessage<GetServerPublicInfoRequestProto>,
    IMessage,
    IEquatable<GetServerPublicInfoRequestProto>,
    IDeepCloneable<GetServerPublicInfoRequestProto>
  {
    private static readonly MessageParser<GetServerPublicInfoRequestProto> _parser = new MessageParser<GetServerPublicInfoRequestProto>((Func<GetServerPublicInfoRequestProto>) (() => new GetServerPublicInfoRequestProto()));
    private UnknownFieldSet _unknownFields;

    [DebuggerNonUserCode]
    public static MessageParser<GetServerPublicInfoRequestProto> Parser => GetServerPublicInfoRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[9];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetServerPublicInfoRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetServerPublicInfoRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetServerPublicInfoRequestProto(GetServerPublicInfoRequestProto other)
      : this()
    {
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetServerPublicInfoRequestProto Clone() => new GetServerPublicInfoRequestProto(this);

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetServerPublicInfoRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetServerPublicInfoRequestProto other)
    {
      if (other == null)
        return false;
      return other == this || object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetServerPublicInfoRequestProto other)
    {
      if (other == null)
        return;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      while (input.ReadTag() != 0U)
        this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
    }
  }
}
