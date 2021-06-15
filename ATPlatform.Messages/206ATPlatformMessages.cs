// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.FeedSourceRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class FeedSourceRequestProto : 
    IMessage<FeedSourceRequestProto>,
    IMessage,
    IEquatable<FeedSourceRequestProto>,
    IDeepCloneable<FeedSourceRequestProto>
  {
    private static readonly MessageParser<FeedSourceRequestProto> _parser = new MessageParser<FeedSourceRequestProto>((Func<FeedSourceRequestProto>) (() => new FeedSourceRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int FeedSourceProtoFieldNumber = 1;
    private FeedSourceProto feedSourceProto_;

    [DebuggerNonUserCode]
    public static MessageParser<FeedSourceRequestProto> Parser => FeedSourceRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[206];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => FeedSourceRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public FeedSourceRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public FeedSourceRequestProto(FeedSourceRequestProto other)
      : this()
    {
      this.feedSourceProto_ = other.feedSourceProto_ != null ? other.feedSourceProto_.Clone() : (FeedSourceProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public FeedSourceRequestProto Clone() => new FeedSourceRequestProto(this);

    [DebuggerNonUserCode]
    public FeedSourceProto FeedSourceProto
    {
      get => this.feedSourceProto_;
      set => this.feedSourceProto_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as FeedSourceRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(FeedSourceRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.FeedSourceProto, (object) other.FeedSourceProto) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.feedSourceProto_ != null)
        num ^= this.FeedSourceProto.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.feedSourceProto_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.FeedSourceProto);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.feedSourceProto_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.FeedSourceProto);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(FeedSourceRequestProto other)
    {
      if (other == null)
        return;
      if (other.feedSourceProto_ != null)
      {
        if (this.feedSourceProto_ == null)
          this.FeedSourceProto = new FeedSourceProto();
        this.FeedSourceProto.MergeFrom(other.FeedSourceProto);
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
          if (this.feedSourceProto_ == null)
            this.FeedSourceProto = new FeedSourceProto();
          input.ReadMessage((IMessage) this.FeedSourceProto);
        }
      }
    }
  }
}
