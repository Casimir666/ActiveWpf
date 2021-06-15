// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsMarkupSettingsByMarkupSetRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetSymbolsMarkupSettingsByMarkupSetRequestProto : 
    IMessage<GetSymbolsMarkupSettingsByMarkupSetRequestProto>,
    IMessage,
    IEquatable<GetSymbolsMarkupSettingsByMarkupSetRequestProto>,
    IDeepCloneable<GetSymbolsMarkupSettingsByMarkupSetRequestProto>
  {
    private static readonly MessageParser<GetSymbolsMarkupSettingsByMarkupSetRequestProto> _parser = new MessageParser<GetSymbolsMarkupSettingsByMarkupSetRequestProto>((Func<GetSymbolsMarkupSettingsByMarkupSetRequestProto>) (() => new GetSymbolsMarkupSettingsByMarkupSetRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarkupSetNameFieldNumber = 1;
    private string markupSetName_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsMarkupSettingsByMarkupSetRequestProto> Parser => GetSymbolsMarkupSettingsByMarkupSetRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[112];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsMarkupSettingsByMarkupSetRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetRequestProto(
      GetSymbolsMarkupSettingsByMarkupSetRequestProto other)
      : this()
    {
      this.markupSetName_ = other.markupSetName_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetRequestProto Clone() => new GetSymbolsMarkupSettingsByMarkupSetRequestProto(this);

    [DebuggerNonUserCode]
    public string MarkupSetName
    {
      get => this.markupSetName_;
      set => this.markupSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsMarkupSettingsByMarkupSetRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetSymbolsMarkupSettingsByMarkupSetRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.MarkupSetName != other.MarkupSetName) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.MarkupSetName.Length != 0)
        num ^= this.MarkupSetName.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.MarkupSetName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.MarkupSetName);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.MarkupSetName.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.MarkupSetName);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetSymbolsMarkupSettingsByMarkupSetRequestProto other)
    {
      if (other == null)
        return;
      if (other.MarkupSetName.Length != 0)
        this.MarkupSetName = other.MarkupSetName;
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
          this.MarkupSetName = input.ReadString();
      }
    }
  }
}
