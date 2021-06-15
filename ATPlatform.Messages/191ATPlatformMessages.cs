// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetHedgeLiquidityProviderNotificationProto
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
  public sealed class GetHedgeLiquidityProviderNotificationProto : 
    IMessage<GetHedgeLiquidityProviderNotificationProto>,
    IMessage,
    IEquatable<GetHedgeLiquidityProviderNotificationProto>,
    IDeepCloneable<GetHedgeLiquidityProviderNotificationProto>
  {
    private static readonly MessageParser<GetHedgeLiquidityProviderNotificationProto> _parser = new MessageParser<GetHedgeLiquidityProviderNotificationProto>((Func<GetHedgeLiquidityProviderNotificationProto>) (() => new GetHedgeLiquidityProviderNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ProvidersFieldNumber = 1;
    private static readonly FieldCodec<HedgeLiquidityProviderProto> _repeated_providers_codec = FieldCodec.ForMessage<HedgeLiquidityProviderProto>(10U, HedgeLiquidityProviderProto.Parser);
    private readonly RepeatedField<HedgeLiquidityProviderProto> providers_ = new RepeatedField<HedgeLiquidityProviderProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetHedgeLiquidityProviderNotificationProto> Parser => GetHedgeLiquidityProviderNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[189];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetHedgeLiquidityProviderNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetHedgeLiquidityProviderNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetHedgeLiquidityProviderNotificationProto(
      GetHedgeLiquidityProviderNotificationProto other)
      : this()
    {
      this.providers_ = other.providers_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetHedgeLiquidityProviderNotificationProto Clone() => new GetHedgeLiquidityProviderNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<HedgeLiquidityProviderProto> Providers => this.providers_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetHedgeLiquidityProviderNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetHedgeLiquidityProviderNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.providers_.Equals(other.providers_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.providers_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.providers_.WriteTo(output, GetHedgeLiquidityProviderNotificationProto._repeated_providers_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.providers_.CalculateSize(GetHedgeLiquidityProviderNotificationProto._repeated_providers_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetHedgeLiquidityProviderNotificationProto other)
    {
      if (other == null)
        return;
      this.providers_.Add((IEnumerable<HedgeLiquidityProviderProto>) other.providers_);
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
          this.providers_.AddEntriesFrom(input, GetHedgeLiquidityProviderNotificationProto._repeated_providers_codec);
      }
    }
  }
}
