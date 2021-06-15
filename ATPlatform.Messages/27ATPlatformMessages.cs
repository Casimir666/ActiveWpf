// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.InactiveOrderRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class InactiveOrderRequestProto : 
    IMessage<InactiveOrderRequestProto>,
    IMessage,
    IEquatable<InactiveOrderRequestProto>,
    IDeepCloneable<InactiveOrderRequestProto>
  {
    private static readonly MessageParser<InactiveOrderRequestProto> _parser = new MessageParser<InactiveOrderRequestProto>((Func<InactiveOrderRequestProto>) (() => new InactiveOrderRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int OrderRequestFieldNumber = 1;
    private OrderProto orderRequest_;
    public const int OriginalOrderFieldNumber = 2;
    private OrderProto originalOrder_;

    [DebuggerNonUserCode]
    public static MessageParser<InactiveOrderRequestProto> Parser => InactiveOrderRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[8];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => InactiveOrderRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public InactiveOrderRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public InactiveOrderRequestProto(InactiveOrderRequestProto other)
      : this()
    {
      this.orderRequest_ = other.orderRequest_ != null ? other.orderRequest_.Clone() : (OrderProto) null;
      this.originalOrder_ = other.originalOrder_ != null ? other.originalOrder_.Clone() : (OrderProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public InactiveOrderRequestProto Clone() => new InactiveOrderRequestProto(this);

    [DebuggerNonUserCode]
    public OrderProto OrderRequest
    {
      get => this.orderRequest_;
      set => this.orderRequest_ = value;
    }

    [DebuggerNonUserCode]
    public OrderProto OriginalOrder
    {
      get => this.originalOrder_;
      set => this.originalOrder_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as InactiveOrderRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(InactiveOrderRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.OrderRequest, (object) other.OrderRequest) && object.Equals((object) this.OriginalOrder, (object) other.OriginalOrder) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.orderRequest_ != null)
        num ^= this.OrderRequest.GetHashCode();
      if (this.originalOrder_ != null)
        num ^= this.OriginalOrder.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.orderRequest_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.OrderRequest);
      }
      if (this.originalOrder_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.OriginalOrder);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.orderRequest_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.OrderRequest);
      if (this.originalOrder_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.OriginalOrder);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(InactiveOrderRequestProto other)
    {
      if (other == null)
        return;
      if (other.orderRequest_ != null)
      {
        if (this.orderRequest_ == null)
          this.OrderRequest = new OrderProto();
        this.OrderRequest.MergeFrom(other.OrderRequest);
      }
      if (other.originalOrder_ != null)
      {
        if (this.originalOrder_ == null)
          this.OriginalOrder = new OrderProto();
        this.OriginalOrder.MergeFrom(other.OriginalOrder);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 10:
            if (this.orderRequest_ == null)
              this.OrderRequest = new OrderProto();
            input.ReadMessage((IMessage) this.OrderRequest);
            continue;
          case 18:
            if (this.originalOrder_ == null)
              this.OriginalOrder = new OrderProto();
            input.ReadMessage((IMessage) this.OriginalOrder);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
