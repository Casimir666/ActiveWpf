// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ATServerConfigurationNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ATServerConfigurationNotificationProto : 
    IMessage<ATServerConfigurationNotificationProto>,
    IMessage,
    IEquatable<ATServerConfigurationNotificationProto>,
    IDeepCloneable<ATServerConfigurationNotificationProto>
  {
    private static readonly MessageParser<ATServerConfigurationNotificationProto> _parser = new MessageParser<ATServerConfigurationNotificationProto>((Func<ATServerConfigurationNotificationProto>) (() => new ATServerConfigurationNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AtserverConfigurationProtoFieldNumber = 1;
    private ATServerConfigurationProto atserverConfigurationProto_;
    public const int PrimaryFeedSourceFieldNumber = 2;
    private FeedSourceProto primaryFeedSource_;

    [DebuggerNonUserCode]
    public static MessageParser<ATServerConfigurationNotificationProto> Parser => ATServerConfigurationNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[214];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ATServerConfigurationNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ATServerConfigurationNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationNotificationProto(ATServerConfigurationNotificationProto other)
      : this()
    {
      this.atserverConfigurationProto_ = other.atserverConfigurationProto_ != null ? other.atserverConfigurationProto_.Clone() : (ATServerConfigurationProto) null;
      this.primaryFeedSource_ = other.primaryFeedSource_ != null ? other.primaryFeedSource_.Clone() : (FeedSourceProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ATServerConfigurationNotificationProto Clone() => new ATServerConfigurationNotificationProto(this);

    [DebuggerNonUserCode]
    public ATServerConfigurationProto AtserverConfigurationProto
    {
      get => this.atserverConfigurationProto_;
      set => this.atserverConfigurationProto_ = value;
    }

    [DebuggerNonUserCode]
    public FeedSourceProto PrimaryFeedSource
    {
      get => this.primaryFeedSource_;
      set => this.primaryFeedSource_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ATServerConfigurationNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ATServerConfigurationNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.AtserverConfigurationProto, (object) other.AtserverConfigurationProto) && object.Equals((object) this.PrimaryFeedSource, (object) other.PrimaryFeedSource) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.atserverConfigurationProto_ != null)
        num ^= this.AtserverConfigurationProto.GetHashCode();
      if (this.primaryFeedSource_ != null)
        num ^= this.PrimaryFeedSource.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.atserverConfigurationProto_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.AtserverConfigurationProto);
      }
      if (this.primaryFeedSource_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.PrimaryFeedSource);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.atserverConfigurationProto_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AtserverConfigurationProto);
      if (this.primaryFeedSource_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.PrimaryFeedSource);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ATServerConfigurationNotificationProto other)
    {
      if (other == null)
        return;
      if (other.atserverConfigurationProto_ != null)
      {
        if (this.atserverConfigurationProto_ == null)
          this.AtserverConfigurationProto = new ATServerConfigurationProto();
        this.AtserverConfigurationProto.MergeFrom(other.AtserverConfigurationProto);
      }
      if (other.primaryFeedSource_ != null)
      {
        if (this.primaryFeedSource_ == null)
          this.PrimaryFeedSource = new FeedSourceProto();
        this.PrimaryFeedSource.MergeFrom(other.PrimaryFeedSource);
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
            if (this.atserverConfigurationProto_ == null)
              this.AtserverConfigurationProto = new ATServerConfigurationProto();
            input.ReadMessage((IMessage) this.AtserverConfigurationProto);
            continue;
          case 18:
            if (this.primaryFeedSource_ == null)
              this.PrimaryFeedSource = new FeedSourceProto();
            input.ReadMessage((IMessage) this.PrimaryFeedSource);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
