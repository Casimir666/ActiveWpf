// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgeLiquidityProviderRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class HedgeLiquidityProviderRequestProto : 
    IMessage<HedgeLiquidityProviderRequestProto>,
    IMessage,
    IEquatable<HedgeLiquidityProviderRequestProto>,
    IDeepCloneable<HedgeLiquidityProviderRequestProto>
  {
    private static readonly MessageParser<HedgeLiquidityProviderRequestProto> _parser = new MessageParser<HedgeLiquidityProviderRequestProto>((Func<HedgeLiquidityProviderRequestProto>) (() => new HedgeLiquidityProviderRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int HedgeLiquidityProviderFieldNumber = 1;
    private HedgeLiquidityProviderProto hedgeLiquidityProvider_;

    [DebuggerNonUserCode]
    public static MessageParser<HedgeLiquidityProviderRequestProto> Parser => HedgeLiquidityProviderRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[191];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HedgeLiquidityProviderRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public HedgeLiquidityProviderRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public HedgeLiquidityProviderRequestProto(HedgeLiquidityProviderRequestProto other)
      : this()
    {
      this.hedgeLiquidityProvider_ = other.hedgeLiquidityProvider_ != null ? other.hedgeLiquidityProvider_.Clone() : (HedgeLiquidityProviderProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HedgeLiquidityProviderRequestProto Clone() => new HedgeLiquidityProviderRequestProto(this);

    [DebuggerNonUserCode]
    public HedgeLiquidityProviderProto HedgeLiquidityProvider
    {
      get => this.hedgeLiquidityProvider_;
      set => this.hedgeLiquidityProvider_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HedgeLiquidityProviderRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(HedgeLiquidityProviderRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.HedgeLiquidityProvider, (object) other.HedgeLiquidityProvider) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.hedgeLiquidityProvider_ != null)
        num ^= this.HedgeLiquidityProvider.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.hedgeLiquidityProvider_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.HedgeLiquidityProvider);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.hedgeLiquidityProvider_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.HedgeLiquidityProvider);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HedgeLiquidityProviderRequestProto other)
    {
      if (other == null)
        return;
      if (other.hedgeLiquidityProvider_ != null)
      {
        if (this.hedgeLiquidityProvider_ == null)
          this.HedgeLiquidityProvider = new HedgeLiquidityProviderProto();
        this.HedgeLiquidityProvider.MergeFrom(other.HedgeLiquidityProvider);
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
          if (this.hedgeLiquidityProvider_ == null)
            this.HedgeLiquidityProvider = new HedgeLiquidityProviderProto();
          input.ReadMessage((IMessage) this.HedgeLiquidityProvider);
        }
      }
    }
  }
}
