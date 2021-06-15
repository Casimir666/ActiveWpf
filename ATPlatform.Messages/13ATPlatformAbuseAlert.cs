// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.GetAbuseAlertRulesSettingsRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class GetAbuseAlertRulesSettingsRequestProto : 
    IMessage<GetAbuseAlertRulesSettingsRequestProto>,
    IMessage,
    IEquatable<GetAbuseAlertRulesSettingsRequestProto>,
    IDeepCloneable<GetAbuseAlertRulesSettingsRequestProto>
  {
    private static readonly MessageParser<GetAbuseAlertRulesSettingsRequestProto> _parser = new MessageParser<GetAbuseAlertRulesSettingsRequestProto>((Func<GetAbuseAlertRulesSettingsRequestProto>) (() => new GetAbuseAlertRulesSettingsRequestProto()));
    private UnknownFieldSet _unknownFields;

    [DebuggerNonUserCode]
    public static MessageParser<GetAbuseAlertRulesSettingsRequestProto> Parser => GetAbuseAlertRulesSettingsRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[12];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAbuseAlertRulesSettingsRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsRequestProto(GetAbuseAlertRulesSettingsRequestProto other)
      : this()
    {
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAbuseAlertRulesSettingsRequestProto Clone() => new GetAbuseAlertRulesSettingsRequestProto(this);

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAbuseAlertRulesSettingsRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAbuseAlertRulesSettingsRequestProto other)
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
    public void MergeFrom(GetAbuseAlertRulesSettingsRequestProto other)
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
