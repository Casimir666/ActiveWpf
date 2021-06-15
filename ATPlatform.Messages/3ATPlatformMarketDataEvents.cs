// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventTranslationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class MarketDataEventTranslationProto : 
    IMessage<MarketDataEventTranslationProto>,
    IMessage,
    IEquatable<MarketDataEventTranslationProto>,
    IDeepCloneable<MarketDataEventTranslationProto>
  {
    private static readonly MessageParser<MarketDataEventTranslationProto> _parser = new MessageParser<MarketDataEventTranslationProto>((Func<MarketDataEventTranslationProto>) (() => new MarketDataEventTranslationProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MarketDataEventIdFieldNumber = 2;
    private int marketDataEventId_;
    public const int LanguageFieldNumber = 3;
    private string language_ = "";
    public const int SubjectFieldNumber = 4;
    private string subject_ = "";
    public const int BodyFieldNumber = 5;
    private string body_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventTranslationProto> Parser => MarketDataEventTranslationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[2];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventTranslationProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventTranslationProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventTranslationProto(MarketDataEventTranslationProto other)
      : this()
    {
      this.id_ = other.id_;
      this.marketDataEventId_ = other.marketDataEventId_;
      this.language_ = other.language_;
      this.subject_ = other.subject_;
      this.body_ = other.body_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventTranslationProto Clone() => new MarketDataEventTranslationProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public int MarketDataEventId
    {
      get => this.marketDataEventId_;
      set => this.marketDataEventId_ = value;
    }

    [DebuggerNonUserCode]
    public string Language
    {
      get => this.language_;
      set => this.language_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Subject
    {
      get => this.subject_;
      set => this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Body
    {
      get => this.body_;
      set => this.body_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventTranslationProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventTranslationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (!(this.Language != other.Language) && !(this.Subject != other.Subject)) && !(this.Body != other.Body) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MarketDataEventId != 0)
      {
        int num3 = num1;
        num2 = this.MarketDataEventId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Language.Length != 0)
        num1 ^= this.Language.GetHashCode();
      if (this.Subject.Length != 0)
        num1 ^= this.Subject.GetHashCode();
      if (this.Body.Length != 0)
        num1 ^= this.Body.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.MarketDataEventId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.MarketDataEventId);
      }
      if (this.Language.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Language);
      }
      if (this.Subject.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Subject);
      }
      if (this.Body.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Body);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.MarketDataEventId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MarketDataEventId);
      if (this.Language.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Language);
      if (this.Subject.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Subject);
      if (this.Body.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Body);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventTranslationProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MarketDataEventId != 0)
        this.MarketDataEventId = other.MarketDataEventId;
      if (other.Language.Length != 0)
        this.Language = other.Language;
      if (other.Subject.Length != 0)
        this.Subject = other.Subject;
      if (other.Body.Length != 0)
        this.Body = other.Body;
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
          case 8:
            this.Id = input.ReadInt32();
            continue;
          case 16:
            this.MarketDataEventId = input.ReadInt32();
            continue;
          case 26:
            this.Language = input.ReadString();
            continue;
          case 34:
            this.Subject = input.ReadString();
            continue;
          case 42:
            this.Body = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
