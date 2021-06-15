// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientMessagesForAccountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetClientMessagesForAccountRequestProto : 
    IMessage<GetClientMessagesForAccountRequestProto>,
    IMessage,
    IEquatable<GetClientMessagesForAccountRequestProto>,
    IDeepCloneable<GetClientMessagesForAccountRequestProto>
  {
    private static readonly MessageParser<GetClientMessagesForAccountRequestProto> _parser = new MessageParser<GetClientMessagesForAccountRequestProto>((Func<GetClientMessagesForAccountRequestProto>) (() => new GetClientMessagesForAccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int LanguageFieldNumber = 3;
    private string language_ = "";
    public const int UnreadOnlyFieldNumber = 4;
    private bool unreadOnly_;
    public const int FromDateFieldNumber = 5;
    private long fromDate_;
    public const int ToDateFieldNumber = 6;
    private long toDate_;
    public const int SkipFieldNumber = 10;
    private int skip_;
    public const int TakeFieldNumber = 11;
    private int take_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClientMessagesForAccountRequestProto> Parser => GetClientMessagesForAccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[234];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientMessagesForAccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountRequestProto(GetClientMessagesForAccountRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.language_ = other.language_;
      this.unreadOnly_ = other.unreadOnly_;
      this.fromDate_ = other.fromDate_;
      this.toDate_ = other.toDate_;
      this.skip_ = other.skip_;
      this.take_ = other.take_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientMessagesForAccountRequestProto Clone() => new GetClientMessagesForAccountRequestProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string PlatformId
    {
      get => this.platformId_;
      set => this.platformId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Language
    {
      get => this.language_;
      set => this.language_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public bool UnreadOnly
    {
      get => this.unreadOnly_;
      set => this.unreadOnly_ = value;
    }

    [DebuggerNonUserCode]
    public long FromDate
    {
      get => this.fromDate_;
      set => this.fromDate_ = value;
    }

    [DebuggerNonUserCode]
    public long ToDate
    {
      get => this.toDate_;
      set => this.toDate_ = value;
    }

    [DebuggerNonUserCode]
    public int Skip
    {
      get => this.skip_;
      set => this.skip_ = value;
    }

    [DebuggerNonUserCode]
    public int Take
    {
      get => this.take_;
      set => this.take_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientMessagesForAccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientMessagesForAccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && (!(this.Language != other.Language) && this.UnreadOnly == other.UnreadOnly) && (this.FromDate == other.FromDate && this.ToDate == other.ToDate && (this.Skip == other.Skip && this.Take == other.Take)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.PlatformId.Length != 0)
        num1 ^= this.PlatformId.GetHashCode();
      if (this.Language.Length != 0)
        num1 ^= this.Language.GetHashCode();
      if (this.UnreadOnly)
        num1 ^= this.UnreadOnly.GetHashCode();
      long num4;
      if (this.FromDate != 0L)
      {
        int num3 = num1;
        num4 = this.FromDate;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ToDate != 0L)
      {
        int num3 = num1;
        num4 = this.ToDate;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Skip != 0)
      {
        int num3 = num1;
        num2 = this.Skip;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Take != 0)
      {
        int num3 = num1;
        num2 = this.Take;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.PlatformId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.PlatformId);
      }
      if (this.Language.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Language);
      }
      if (this.UnreadOnly)
      {
        output.WriteRawTag((byte) 32);
        output.WriteBool(this.UnreadOnly);
      }
      if (this.FromDate != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.FromDate);
      }
      if (this.ToDate != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.ToDate);
      }
      if (this.Skip != 0)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt32(this.Skip);
      }
      if (this.Take != 0)
      {
        output.WriteRawTag((byte) 88);
        output.WriteInt32(this.Take);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.PlatformId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      if (this.Language.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Language);
      if (this.UnreadOnly)
        num += 2;
      if (this.FromDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.FromDate);
      if (this.ToDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.ToDate);
      if (this.Skip != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Skip);
      if (this.Take != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Take);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientMessagesForAccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.Language.Length != 0)
        this.Language = other.Language;
      if (other.UnreadOnly)
        this.UnreadOnly = other.UnreadOnly;
      if (other.FromDate != 0L)
        this.FromDate = other.FromDate;
      if (other.ToDate != 0L)
        this.ToDate = other.ToDate;
      if (other.Skip != 0)
        this.Skip = other.Skip;
      if (other.Take != 0)
        this.Take = other.Take;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 18:
            this.PlatformId = input.ReadString();
            continue;
          case 26:
            this.Language = input.ReadString();
            continue;
          case 32:
            this.UnreadOnly = input.ReadBool();
            continue;
          case 40:
            this.FromDate = input.ReadInt64();
            continue;
          case 48:
            this.ToDate = input.ReadInt64();
            continue;
          case 80:
            this.Skip = input.ReadInt32();
            continue;
          case 88:
            this.Take = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
