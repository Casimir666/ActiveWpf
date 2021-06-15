// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLeverageNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetLeverageNotificationProto : 
    IMessage<GetLeverageNotificationProto>,
    IMessage,
    IEquatable<GetLeverageNotificationProto>,
    IDeepCloneable<GetLeverageNotificationProto>
  {
    private static readonly MessageParser<GetLeverageNotificationProto> _parser = new MessageParser<GetLeverageNotificationProto>((Func<GetLeverageNotificationProto>) (() => new GetLeverageNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int LeveragesFieldNumber = 1;
    private static readonly FieldCodec<LeverageProto> _repeated_leverages_codec = FieldCodec.ForMessage<LeverageProto>(10U, LeverageProto.Parser);
    private readonly RepeatedField<LeverageProto> leverages_ = new RepeatedField<LeverageProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetLeverageNotificationProto> Parser => GetLeverageNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[129];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLeverageNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLeverageNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLeverageNotificationProto(GetLeverageNotificationProto other)
      : this()
    {
      this.leverages_ = other.leverages_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLeverageNotificationProto Clone() => new GetLeverageNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<LeverageProto> Leverages => this.leverages_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLeverageNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLeverageNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.leverages_.Equals(other.leverages_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.leverages_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.leverages_.WriteTo(output, GetLeverageNotificationProto._repeated_leverages_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.leverages_.CalculateSize(GetLeverageNotificationProto._repeated_leverages_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLeverageNotificationProto other)
    {
      if (other == null)
        return;
      this.leverages_.Add((IEnumerable<LeverageProto>) other.leverages_);
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
          this.leverages_.AddEntriesFrom(input, GetLeverageNotificationProto._repeated_leverages_codec);
      }
    }
  }
}
