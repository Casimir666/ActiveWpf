// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientMessagesFilterProto
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
  public sealed class GetClientMessagesFilterProto : 
    IMessage<GetClientMessagesFilterProto>,
    IMessage,
    IEquatable<GetClientMessagesFilterProto>,
    IDeepCloneable<GetClientMessagesFilterProto>
  {
    private static readonly MessageParser<GetClientMessagesFilterProto> _parser = new MessageParser<GetClientMessagesFilterProto>((Func<GetClientMessagesFilterProto>) (() => new GetClientMessagesFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int PreferredLanguageFieldNumber = 1;
    private string preferredLanguage_ = "";
    public const int FromDateFieldNumber = 2;
    private long fromDate_;
    public const int ToDateFieldNumber = 3;
    private long toDate_;
    public const int ImportanceFieldNumber = 4;
    private static readonly FieldCodec<ClientMessageImportanceProto> _repeated_importance_codec = FieldCodec.ForEnum<ClientMessageImportanceProto>(34U, (Func<ClientMessageImportanceProto, int>) (x => (int) x), (Func<int, ClientMessageImportanceProto>) (x => (ClientMessageImportanceProto) x));
    private readonly RepeatedField<ClientMessageImportanceProto> importance_ = new RepeatedField<ClientMessageImportanceProto>();
    public const int CategoriesFieldNumber = 5;
    private static readonly FieldCodec<ClientMessageCategoryProto> _repeated_categories_codec = FieldCodec.ForEnum<ClientMessageCategoryProto>(42U, (Func<ClientMessageCategoryProto, int>) (x => (int) x), (Func<int, ClientMessageCategoryProto>) (x => (ClientMessageCategoryProto) x));
    private readonly RepeatedField<ClientMessageCategoryProto> categories_ = new RepeatedField<ClientMessageCategoryProto>();
    public const int StatesFieldNumber = 6;
    private static readonly FieldCodec<ClientMessageStateProto> _repeated_states_codec = FieldCodec.ForEnum<ClientMessageStateProto>(50U, (Func<ClientMessageStateProto, int>) (x => (int) x), (Func<int, ClientMessageStateProto>) (x => (ClientMessageStateProto) x));
    private readonly RepeatedField<ClientMessageStateProto> states_ = new RepeatedField<ClientMessageStateProto>();
    public const int PlatformsFieldNumber = 7;
    private static readonly FieldCodec<string> _repeated_platforms_codec = FieldCodec.ForString(58U);
    private readonly RepeatedField<string> platforms_ = new RepeatedField<string>();
    public const int AccountsFieldNumber = 8;
    private static readonly FieldCodec<int> _repeated_accounts_codec = FieldCodec.ForInt32(66U);
    private readonly RepeatedField<int> accounts_ = new RepeatedField<int>();
    public const int TextFieldNumber = 9;
    private string text_ = "";
    public const int InitiatorsFieldNumber = 10;
    private static readonly FieldCodec<string> _repeated_initiators_codec = FieldCodec.ForString(82U);
    private readonly RepeatedField<string> initiators_ = new RepeatedField<string>();

    [DebuggerNonUserCode]
    public static MessageParser<GetClientMessagesFilterProto> Parser => GetClientMessagesFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[230];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientMessagesFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientMessagesFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientMessagesFilterProto(GetClientMessagesFilterProto other)
      : this()
    {
      this.preferredLanguage_ = other.preferredLanguage_;
      this.fromDate_ = other.fromDate_;
      this.toDate_ = other.toDate_;
      this.importance_ = other.importance_.Clone();
      this.categories_ = other.categories_.Clone();
      this.states_ = other.states_.Clone();
      this.platforms_ = other.platforms_.Clone();
      this.accounts_ = other.accounts_.Clone();
      this.text_ = other.text_;
      this.initiators_ = other.initiators_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientMessagesFilterProto Clone() => new GetClientMessagesFilterProto(this);

    [DebuggerNonUserCode]
    public string PreferredLanguage
    {
      get => this.preferredLanguage_;
      set => this.preferredLanguage_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
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
    public RepeatedField<ClientMessageImportanceProto> Importance => this.importance_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageCategoryProto> Categories => this.categories_;

    [DebuggerNonUserCode]
    public RepeatedField<ClientMessageStateProto> States => this.states_;

    [DebuggerNonUserCode]
    public RepeatedField<string> Platforms => this.platforms_;

    [DebuggerNonUserCode]
    public RepeatedField<int> Accounts => this.accounts_;

    [DebuggerNonUserCode]
    public string Text
    {
      get => this.text_;
      set => this.text_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> Initiators => this.initiators_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientMessagesFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientMessagesFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.PreferredLanguage != other.PreferredLanguage) && this.FromDate == other.FromDate && (this.ToDate == other.ToDate && this.importance_.Equals(other.importance_)) && (this.categories_.Equals(other.categories_) && this.states_.Equals(other.states_) && (this.platforms_.Equals(other.platforms_) && this.accounts_.Equals(other.accounts_))) && (!(this.Text != other.Text) && this.initiators_.Equals(other.initiators_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.PreferredLanguage.Length != 0)
        num1 ^= this.PreferredLanguage.GetHashCode();
      if (this.FromDate != 0L)
        num1 ^= this.FromDate.GetHashCode();
      if (this.ToDate != 0L)
        num1 ^= this.ToDate.GetHashCode();
      int num2 = num1 ^ this.importance_.GetHashCode() ^ this.categories_.GetHashCode() ^ this.states_.GetHashCode() ^ this.platforms_.GetHashCode() ^ this.accounts_.GetHashCode();
      if (this.Text.Length != 0)
        num2 ^= this.Text.GetHashCode();
      int num3 = num2 ^ this.initiators_.GetHashCode();
      if (this._unknownFields != null)
        num3 ^= this._unknownFields.GetHashCode();
      return num3;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.PreferredLanguage.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.PreferredLanguage);
      }
      if (this.FromDate != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.FromDate);
      }
      if (this.ToDate != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.ToDate);
      }
      this.importance_.WriteTo(output, GetClientMessagesFilterProto._repeated_importance_codec);
      this.categories_.WriteTo(output, GetClientMessagesFilterProto._repeated_categories_codec);
      this.states_.WriteTo(output, GetClientMessagesFilterProto._repeated_states_codec);
      this.platforms_.WriteTo(output, GetClientMessagesFilterProto._repeated_platforms_codec);
      this.accounts_.WriteTo(output, GetClientMessagesFilterProto._repeated_accounts_codec);
      if (this.Text.Length != 0)
      {
        output.WriteRawTag((byte) 74);
        output.WriteString(this.Text);
      }
      this.initiators_.WriteTo(output, GetClientMessagesFilterProto._repeated_initiators_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.PreferredLanguage.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.PreferredLanguage);
      if (this.FromDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.FromDate);
      if (this.ToDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.ToDate);
      int num2 = num1 + this.importance_.CalculateSize(GetClientMessagesFilterProto._repeated_importance_codec) + this.categories_.CalculateSize(GetClientMessagesFilterProto._repeated_categories_codec) + this.states_.CalculateSize(GetClientMessagesFilterProto._repeated_states_codec) + this.platforms_.CalculateSize(GetClientMessagesFilterProto._repeated_platforms_codec) + this.accounts_.CalculateSize(GetClientMessagesFilterProto._repeated_accounts_codec);
      if (this.Text.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.Text);
      int num3 = num2 + this.initiators_.CalculateSize(GetClientMessagesFilterProto._repeated_initiators_codec);
      if (this._unknownFields != null)
        num3 += this._unknownFields.CalculateSize();
      return num3;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientMessagesFilterProto other)
    {
      if (other == null)
        return;
      if (other.PreferredLanguage.Length != 0)
        this.PreferredLanguage = other.PreferredLanguage;
      if (other.FromDate != 0L)
        this.FromDate = other.FromDate;
      if (other.ToDate != 0L)
        this.ToDate = other.ToDate;
      this.importance_.Add((IEnumerable<ClientMessageImportanceProto>) other.importance_);
      this.categories_.Add((IEnumerable<ClientMessageCategoryProto>) other.categories_);
      this.states_.Add((IEnumerable<ClientMessageStateProto>) other.states_);
      this.platforms_.Add((IEnumerable<string>) other.platforms_);
      this.accounts_.Add((IEnumerable<int>) other.accounts_);
      if (other.Text.Length != 0)
        this.Text = other.Text;
      this.initiators_.Add((IEnumerable<string>) other.initiators_);
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
            this.PreferredLanguage = input.ReadString();
            continue;
          case 16:
            this.FromDate = input.ReadInt64();
            continue;
          case 24:
            this.ToDate = input.ReadInt64();
            continue;
          case 32:
          case 34:
            this.importance_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_importance_codec);
            continue;
          case 40:
          case 42:
            this.categories_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_categories_codec);
            continue;
          case 48:
          case 50:
            this.states_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_states_codec);
            continue;
          case 58:
            this.platforms_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_platforms_codec);
            continue;
          case 64:
          case 66:
            this.accounts_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_accounts_codec);
            continue;
          case 74:
            this.Text = input.ReadString();
            continue;
          case 82:
            this.initiators_.AddEntriesFrom(input, GetClientMessagesFilterProto._repeated_initiators_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
