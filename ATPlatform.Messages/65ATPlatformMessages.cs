// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class AccountProto : 
    IMessage<AccountProto>,
    IMessage,
    IEquatable<AccountProto>,
    IDeepCloneable<AccountProto>
  {
    private static readonly MessageParser<AccountProto> _parser = new MessageParser<AccountProto>((Func<AccountProto>) (() => new AccountProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int IsEnabledFieldNumber = 2;
    private bool isEnabled_;
    public const int IsTradeEnabledFieldNumber = 3;
    private bool isTradeEnabled_;
    public const int RegistrationDateFieldNumber = 4;
    private long registrationDate_;
    public const int DeletedDateFieldNumber = 5;
    private long deletedDate_;
    public const int EnableChargeOfSwapsFieldNumber = 6;
    private bool enableChargeOfSwaps_;
    public const int MarginCallLevelFieldNumber = 7;
    private int marginCallLevel_;
    public const int StopOutLevelFieldNumber = 8;
    private int stopOutLevel_;
    public const int ParentAgentIdFieldNumber = 9;
    private int parentAgentId_;
    public const int LeverageMultiplierFieldNumber = 10;
    private int leverageMultiplier_;
    public const int CurrencyIsoCodeFieldNumber = 11;
    private string currencyIsoCode_ = "";
    public const int CustomerEmailFieldNumber = 12;
    private string customerEmail_ = "";
    public const int CustomerNameFieldNumber = 13;
    private string customerName_ = "";
    public const int HedgeSettingsSetFieldNumber = 14;
    private string hedgeSettingsSet_ = "";
    public const int BalanceFieldNumber = 15;
    private double balance_;
    public const int MarginFieldNumber = 16;
    private double margin_;
    public const int TradeSettingsSetFieldNumber = 17;
    private string tradeSettingsSet_ = "";
    public const int MarkupSettingsSetFieldNumber = 18;
    private string markupSettingsSet_ = "";
    public const int CountryIsoCodeFieldNumber = 19;
    private string countryIsoCode_ = "";
    public const int CommentFieldNumber = 20;
    private string comment_ = "";
    public const int IsVirtualFieldNumber = 21;
    private bool isVirtual_;
    public const int IsClosedFieldNumber = 22;
    private bool isClosed_;
    public const int IsProfessionalFieldNumber = 23;
    private bool isProfessional_;
    public const int IsStopLossGuaranteedFieldNumber = 24;
    private bool isStopLossGuaranteed_;
    public const int CommissionSettingsSetFieldNumber = 25;
    private string commissionSettingsSet_ = "";
    public const int DynamicLeverageSettingsFieldNumber = 26;
    private string dynamicLeverageSettings_ = "";
    public const int DynamicLeverageThresholdCoefFieldNumber = 27;
    private int dynamicLeverageThresholdCoef_;
    public const int EquityFieldNumber = 28;
    private double equity_;
    public const int LastTradeDateFieldNumber = 29;
    private long lastTradeDate_;
    public const int AccountModeFieldNumber = 30;
    private AccountModeProto accountMode_;
    public const int TenantIdFieldNumber = 31;
    private int tenantId_;
    public const int MaxNumberOfOrdersFieldNumber = 32;
    private int maxNumberOfOrders_;
    public const int IsApiConnectionEnabledFieldNumber = 33;
    private bool isApiConnectionEnabled_;
    public const int ClosedDateFieldNumber = 34;
    private long closedDate_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountProto> Parser => AccountProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[48];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountProto(AccountProto other)
      : this()
    {
      this.id_ = other.id_;
      this.isEnabled_ = other.isEnabled_;
      this.isTradeEnabled_ = other.isTradeEnabled_;
      this.registrationDate_ = other.registrationDate_;
      this.deletedDate_ = other.deletedDate_;
      this.enableChargeOfSwaps_ = other.enableChargeOfSwaps_;
      this.marginCallLevel_ = other.marginCallLevel_;
      this.stopOutLevel_ = other.stopOutLevel_;
      this.parentAgentId_ = other.parentAgentId_;
      this.leverageMultiplier_ = other.leverageMultiplier_;
      this.currencyIsoCode_ = other.currencyIsoCode_;
      this.customerEmail_ = other.customerEmail_;
      this.customerName_ = other.customerName_;
      this.hedgeSettingsSet_ = other.hedgeSettingsSet_;
      this.balance_ = other.balance_;
      this.margin_ = other.margin_;
      this.tradeSettingsSet_ = other.tradeSettingsSet_;
      this.markupSettingsSet_ = other.markupSettingsSet_;
      this.countryIsoCode_ = other.countryIsoCode_;
      this.comment_ = other.comment_;
      this.isVirtual_ = other.isVirtual_;
      this.isClosed_ = other.isClosed_;
      this.isProfessional_ = other.isProfessional_;
      this.isStopLossGuaranteed_ = other.isStopLossGuaranteed_;
      this.commissionSettingsSet_ = other.commissionSettingsSet_;
      this.dynamicLeverageSettings_ = other.dynamicLeverageSettings_;
      this.dynamicLeverageThresholdCoef_ = other.dynamicLeverageThresholdCoef_;
      this.equity_ = other.equity_;
      this.lastTradeDate_ = other.lastTradeDate_;
      this.accountMode_ = other.accountMode_;
      this.tenantId_ = other.tenantId_;
      this.maxNumberOfOrders_ = other.maxNumberOfOrders_;
      this.isApiConnectionEnabled_ = other.isApiConnectionEnabled_;
      this.closedDate_ = other.closedDate_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountProto Clone() => new AccountProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsEnabled
    {
      get => this.isEnabled_;
      set => this.isEnabled_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsTradeEnabled
    {
      get => this.isTradeEnabled_;
      set => this.isTradeEnabled_ = value;
    }

    [DebuggerNonUserCode]
    public long RegistrationDate
    {
      get => this.registrationDate_;
      set => this.registrationDate_ = value;
    }

    [DebuggerNonUserCode]
    public long DeletedDate
    {
      get => this.deletedDate_;
      set => this.deletedDate_ = value;
    }

    [DebuggerNonUserCode]
    public bool EnableChargeOfSwaps
    {
      get => this.enableChargeOfSwaps_;
      set => this.enableChargeOfSwaps_ = value;
    }

    [DebuggerNonUserCode]
    public int MarginCallLevel
    {
      get => this.marginCallLevel_;
      set => this.marginCallLevel_ = value;
    }

    [DebuggerNonUserCode]
    public int StopOutLevel
    {
      get => this.stopOutLevel_;
      set => this.stopOutLevel_ = value;
    }

    [DebuggerNonUserCode]
    public int ParentAgentId
    {
      get => this.parentAgentId_;
      set => this.parentAgentId_ = value;
    }

    [DebuggerNonUserCode]
    public int LeverageMultiplier
    {
      get => this.leverageMultiplier_;
      set => this.leverageMultiplier_ = value;
    }

    [DebuggerNonUserCode]
    public string CurrencyIsoCode
    {
      get => this.currencyIsoCode_;
      set => this.currencyIsoCode_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string CustomerEmail
    {
      get => this.customerEmail_;
      set => this.customerEmail_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string CustomerName
    {
      get => this.customerName_;
      set => this.customerName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string HedgeSettingsSet
    {
      get => this.hedgeSettingsSet_;
      set => this.hedgeSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double Balance
    {
      get => this.balance_;
      set => this.balance_ = value;
    }

    [DebuggerNonUserCode]
    public double Margin
    {
      get => this.margin_;
      set => this.margin_ = value;
    }

    [DebuggerNonUserCode]
    public string TradeSettingsSet
    {
      get => this.tradeSettingsSet_;
      set => this.tradeSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string MarkupSettingsSet
    {
      get => this.markupSettingsSet_;
      set => this.markupSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string CountryIsoCode
    {
      get => this.countryIsoCode_;
      set => this.countryIsoCode_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public bool IsVirtual
    {
      get => this.isVirtual_;
      set => this.isVirtual_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsClosed
    {
      get => this.isClosed_;
      set => this.isClosed_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsProfessional
    {
      get => this.isProfessional_;
      set => this.isProfessional_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsStopLossGuaranteed
    {
      get => this.isStopLossGuaranteed_;
      set => this.isStopLossGuaranteed_ = value;
    }

    [DebuggerNonUserCode]
    public string CommissionSettingsSet
    {
      get => this.commissionSettingsSet_;
      set => this.commissionSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string DynamicLeverageSettings
    {
      get => this.dynamicLeverageSettings_;
      set => this.dynamicLeverageSettings_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int DynamicLeverageThresholdCoef
    {
      get => this.dynamicLeverageThresholdCoef_;
      set => this.dynamicLeverageThresholdCoef_ = value;
    }

    [DebuggerNonUserCode]
    public double Equity
    {
      get => this.equity_;
      set => this.equity_ = value;
    }

    [DebuggerNonUserCode]
    public long LastTradeDate
    {
      get => this.lastTradeDate_;
      set => this.lastTradeDate_ = value;
    }

    [DebuggerNonUserCode]
    public AccountModeProto AccountMode
    {
      get => this.accountMode_;
      set => this.accountMode_ = value;
    }

    [DebuggerNonUserCode]
    public int TenantId
    {
      get => this.tenantId_;
      set => this.tenantId_ = value;
    }

    [DebuggerNonUserCode]
    public int MaxNumberOfOrders
    {
      get => this.maxNumberOfOrders_;
      set => this.maxNumberOfOrders_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsApiConnectionEnabled
    {
      get => this.isApiConnectionEnabled_;
      set => this.isApiConnectionEnabled_ = value;
    }

    [DebuggerNonUserCode]
    public long ClosedDate
    {
      get => this.closedDate_;
      set => this.closedDate_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.IsEnabled == other.IsEnabled && (this.IsTradeEnabled == other.IsTradeEnabled && this.RegistrationDate == other.RegistrationDate) && (this.DeletedDate == other.DeletedDate && this.EnableChargeOfSwaps == other.EnableChargeOfSwaps && (this.MarginCallLevel == other.MarginCallLevel && this.StopOutLevel == other.StopOutLevel)) && (this.ParentAgentId == other.ParentAgentId && this.LeverageMultiplier == other.LeverageMultiplier && (!(this.CurrencyIsoCode != other.CurrencyIsoCode) && !(this.CustomerEmail != other.CustomerEmail)) && (!(this.CustomerName != other.CustomerName) && !(this.HedgeSettingsSet != other.HedgeSettingsSet) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Balance, other.Balance) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Margin, other.Margin)))) && (!(this.TradeSettingsSet != other.TradeSettingsSet) && !(this.MarkupSettingsSet != other.MarkupSettingsSet) && (!(this.CountryIsoCode != other.CountryIsoCode) && !(this.Comment != other.Comment)) && (this.IsVirtual == other.IsVirtual && this.IsClosed == other.IsClosed && (this.IsProfessional == other.IsProfessional && this.IsStopLossGuaranteed == other.IsStopLossGuaranteed)) && (!(this.CommissionSettingsSet != other.CommissionSettingsSet) && !(this.DynamicLeverageSettings != other.DynamicLeverageSettings) && (this.DynamicLeverageThresholdCoef == other.DynamicLeverageThresholdCoef && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Equity, other.Equity)) && (this.LastTradeDate == other.LastTradeDate && this.AccountMode == other.AccountMode && (this.TenantId == other.TenantId && this.MaxNumberOfOrders == other.MaxNumberOfOrders)))) && (this.IsApiConnectionEnabled == other.IsApiConnectionEnabled && this.ClosedDate == other.ClosedDate) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      bool flag;
      if (this.IsEnabled)
      {
        int num3 = num1;
        flag = this.IsEnabled;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsTradeEnabled)
      {
        int num3 = num1;
        flag = this.IsTradeEnabled;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      long num4;
      if (this.RegistrationDate != 0L)
      {
        int num3 = num1;
        num4 = this.RegistrationDate;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.DeletedDate != 0L)
      {
        int num3 = num1;
        num4 = this.DeletedDate;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.EnableChargeOfSwaps)
      {
        int num3 = num1;
        flag = this.EnableChargeOfSwaps;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MarginCallLevel != 0)
      {
        int num3 = num1;
        num2 = this.MarginCallLevel;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.StopOutLevel != 0)
      {
        int num3 = num1;
        num2 = this.StopOutLevel;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ParentAgentId != 0)
      {
        int num3 = num1;
        num2 = this.ParentAgentId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.LeverageMultiplier != 0)
      {
        int num3 = num1;
        num2 = this.LeverageMultiplier;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CurrencyIsoCode.Length != 0)
        num1 ^= this.CurrencyIsoCode.GetHashCode();
      if (this.CustomerEmail.Length != 0)
        num1 ^= this.CustomerEmail.GetHashCode();
      if (this.CustomerName.Length != 0)
        num1 ^= this.CustomerName.GetHashCode();
      if (this.HedgeSettingsSet.Length != 0)
        num1 ^= this.HedgeSettingsSet.GetHashCode();
      if (this.Balance != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Balance);
      if (this.Margin != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Margin);
      if (this.TradeSettingsSet.Length != 0)
        num1 ^= this.TradeSettingsSet.GetHashCode();
      if (this.MarkupSettingsSet.Length != 0)
        num1 ^= this.MarkupSettingsSet.GetHashCode();
      if (this.CountryIsoCode.Length != 0)
        num1 ^= this.CountryIsoCode.GetHashCode();
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      if (this.IsVirtual)
      {
        int num3 = num1;
        flag = this.IsVirtual;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsClosed)
      {
        int num3 = num1;
        flag = this.IsClosed;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsProfessional)
      {
        int num3 = num1;
        flag = this.IsProfessional;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsStopLossGuaranteed)
      {
        int num3 = num1;
        flag = this.IsStopLossGuaranteed;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.CommissionSettingsSet.Length != 0)
        num1 ^= this.CommissionSettingsSet.GetHashCode();
      if (this.DynamicLeverageSettings.Length != 0)
        num1 ^= this.DynamicLeverageSettings.GetHashCode();
      if (this.DynamicLeverageThresholdCoef != 0)
      {
        int num3 = num1;
        num2 = this.DynamicLeverageThresholdCoef;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Equity != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Equity);
      if (this.LastTradeDate != 0L)
      {
        int num3 = num1;
        num4 = this.LastTradeDate;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.AccountMode != AccountModeProto.UnknowAccountTradingType)
        num1 ^= this.AccountMode.GetHashCode();
      if (this.TenantId != 0)
      {
        int num3 = num1;
        num2 = this.TenantId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MaxNumberOfOrders != 0)
      {
        int num3 = num1;
        num2 = this.MaxNumberOfOrders;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsApiConnectionEnabled)
      {
        int num3 = num1;
        flag = this.IsApiConnectionEnabled;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ClosedDate != 0L)
      {
        int num3 = num1;
        num4 = this.ClosedDate;
        int hashCode = num4.GetHashCode();
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
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.IsEnabled)
      {
        output.WriteRawTag((byte) 16);
        output.WriteBool(this.IsEnabled);
      }
      if (this.IsTradeEnabled)
      {
        output.WriteRawTag((byte) 24);
        output.WriteBool(this.IsTradeEnabled);
      }
      if (this.RegistrationDate != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.RegistrationDate);
      }
      if (this.DeletedDate != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.DeletedDate);
      }
      if (this.EnableChargeOfSwaps)
      {
        output.WriteRawTag((byte) 48);
        output.WriteBool(this.EnableChargeOfSwaps);
      }
      if (this.MarginCallLevel != 0)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt32(this.MarginCallLevel);
      }
      if (this.StopOutLevel != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.StopOutLevel);
      }
      if (this.ParentAgentId != 0)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt32(this.ParentAgentId);
      }
      if (this.LeverageMultiplier != 0)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt32(this.LeverageMultiplier);
      }
      if (this.CurrencyIsoCode.Length != 0)
      {
        output.WriteRawTag((byte) 90);
        output.WriteString(this.CurrencyIsoCode);
      }
      if (this.CustomerEmail.Length != 0)
      {
        output.WriteRawTag((byte) 98);
        output.WriteString(this.CustomerEmail);
      }
      if (this.CustomerName.Length != 0)
      {
        output.WriteRawTag((byte) 106);
        output.WriteString(this.CustomerName);
      }
      if (this.HedgeSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 114);
        output.WriteString(this.HedgeSettingsSet);
      }
      if (this.Balance != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.Balance);
      }
      if (this.Margin != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 1);
        output.WriteDouble(this.Margin);
      }
      if (this.TradeSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 138, (byte) 1);
        output.WriteString(this.TradeSettingsSet);
      }
      if (this.MarkupSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 146, (byte) 1);
        output.WriteString(this.MarkupSettingsSet);
      }
      if (this.CountryIsoCode.Length != 0)
      {
        output.WriteRawTag((byte) 154, (byte) 1);
        output.WriteString(this.CountryIsoCode);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 162, (byte) 1);
        output.WriteString(this.Comment);
      }
      if (this.IsVirtual)
      {
        output.WriteRawTag((byte) 168, (byte) 1);
        output.WriteBool(this.IsVirtual);
      }
      if (this.IsClosed)
      {
        output.WriteRawTag((byte) 176, (byte) 1);
        output.WriteBool(this.IsClosed);
      }
      if (this.IsProfessional)
      {
        output.WriteRawTag((byte) 184, (byte) 1);
        output.WriteBool(this.IsProfessional);
      }
      if (this.IsStopLossGuaranteed)
      {
        output.WriteRawTag((byte) 192, (byte) 1);
        output.WriteBool(this.IsStopLossGuaranteed);
      }
      if (this.CommissionSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 202, (byte) 1);
        output.WriteString(this.CommissionSettingsSet);
      }
      if (this.DynamicLeverageSettings.Length != 0)
      {
        output.WriteRawTag((byte) 210, (byte) 1);
        output.WriteString(this.DynamicLeverageSettings);
      }
      if (this.DynamicLeverageThresholdCoef != 0)
      {
        output.WriteRawTag((byte) 216, (byte) 1);
        output.WriteInt32(this.DynamicLeverageThresholdCoef);
      }
      if (this.Equity != 0.0)
      {
        output.WriteRawTag((byte) 225, (byte) 1);
        output.WriteDouble(this.Equity);
      }
      if (this.LastTradeDate != 0L)
      {
        output.WriteRawTag((byte) 232, (byte) 1);
        output.WriteInt64(this.LastTradeDate);
      }
      if (this.AccountMode != AccountModeProto.UnknowAccountTradingType)
      {
        output.WriteRawTag((byte) 240, (byte) 1);
        output.WriteEnum((int) this.AccountMode);
      }
      if (this.TenantId != 0)
      {
        output.WriteRawTag((byte) 248, (byte) 1);
        output.WriteInt32(this.TenantId);
      }
      if (this.MaxNumberOfOrders != 0)
      {
        output.WriteRawTag((byte) 128, (byte) 2);
        output.WriteInt32(this.MaxNumberOfOrders);
      }
      if (this.IsApiConnectionEnabled)
      {
        output.WriteRawTag((byte) 136, (byte) 2);
        output.WriteBool(this.IsApiConnectionEnabled);
      }
      if (this.ClosedDate != 0L)
      {
        output.WriteRawTag((byte) 144, (byte) 2);
        output.WriteInt64(this.ClosedDate);
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
      if (this.IsEnabled)
        num += 2;
      if (this.IsTradeEnabled)
        num += 2;
      if (this.RegistrationDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RegistrationDate);
      if (this.DeletedDate != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DeletedDate);
      if (this.EnableChargeOfSwaps)
        num += 2;
      if (this.MarginCallLevel != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MarginCallLevel);
      if (this.StopOutLevel != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.StopOutLevel);
      if (this.ParentAgentId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.ParentAgentId);
      if (this.LeverageMultiplier != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.LeverageMultiplier);
      if (this.CurrencyIsoCode.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.CurrencyIsoCode);
      if (this.CustomerEmail.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.CustomerEmail);
      if (this.CustomerName.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.CustomerName);
      if (this.HedgeSettingsSet.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.HedgeSettingsSet);
      if (this.Balance != 0.0)
        num += 9;
      if (this.Margin != 0.0)
        num += 10;
      if (this.TradeSettingsSet.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.TradeSettingsSet);
      if (this.MarkupSettingsSet.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.MarkupSettingsSet);
      if (this.CountryIsoCode.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.CountryIsoCode);
      if (this.Comment.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.IsVirtual)
        num += 3;
      if (this.IsClosed)
        num += 3;
      if (this.IsProfessional)
        num += 3;
      if (this.IsStopLossGuaranteed)
        num += 3;
      if (this.CommissionSettingsSet.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.CommissionSettingsSet);
      if (this.DynamicLeverageSettings.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.DynamicLeverageSettings);
      if (this.DynamicLeverageThresholdCoef != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.DynamicLeverageThresholdCoef);
      if (this.Equity != 0.0)
        num += 10;
      if (this.LastTradeDate != 0L)
        num += 2 + CodedOutputStream.ComputeInt64Size(this.LastTradeDate);
      if (this.AccountMode != AccountModeProto.UnknowAccountTradingType)
        num += 2 + CodedOutputStream.ComputeEnumSize((int) this.AccountMode);
      if (this.TenantId != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.TenantId);
      if (this.MaxNumberOfOrders != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxNumberOfOrders);
      if (this.IsApiConnectionEnabled)
        num += 3;
      if (this.ClosedDate != 0L)
        num += 2 + CodedOutputStream.ComputeInt64Size(this.ClosedDate);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.IsEnabled)
        this.IsEnabled = other.IsEnabled;
      if (other.IsTradeEnabled)
        this.IsTradeEnabled = other.IsTradeEnabled;
      if (other.RegistrationDate != 0L)
        this.RegistrationDate = other.RegistrationDate;
      if (other.DeletedDate != 0L)
        this.DeletedDate = other.DeletedDate;
      if (other.EnableChargeOfSwaps)
        this.EnableChargeOfSwaps = other.EnableChargeOfSwaps;
      if (other.MarginCallLevel != 0)
        this.MarginCallLevel = other.MarginCallLevel;
      if (other.StopOutLevel != 0)
        this.StopOutLevel = other.StopOutLevel;
      if (other.ParentAgentId != 0)
        this.ParentAgentId = other.ParentAgentId;
      if (other.LeverageMultiplier != 0)
        this.LeverageMultiplier = other.LeverageMultiplier;
      if (other.CurrencyIsoCode.Length != 0)
        this.CurrencyIsoCode = other.CurrencyIsoCode;
      if (other.CustomerEmail.Length != 0)
        this.CustomerEmail = other.CustomerEmail;
      if (other.CustomerName.Length != 0)
        this.CustomerName = other.CustomerName;
      if (other.HedgeSettingsSet.Length != 0)
        this.HedgeSettingsSet = other.HedgeSettingsSet;
      if (other.Balance != 0.0)
        this.Balance = other.Balance;
      if (other.Margin != 0.0)
        this.Margin = other.Margin;
      if (other.TradeSettingsSet.Length != 0)
        this.TradeSettingsSet = other.TradeSettingsSet;
      if (other.MarkupSettingsSet.Length != 0)
        this.MarkupSettingsSet = other.MarkupSettingsSet;
      if (other.CountryIsoCode.Length != 0)
        this.CountryIsoCode = other.CountryIsoCode;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.IsVirtual)
        this.IsVirtual = other.IsVirtual;
      if (other.IsClosed)
        this.IsClosed = other.IsClosed;
      if (other.IsProfessional)
        this.IsProfessional = other.IsProfessional;
      if (other.IsStopLossGuaranteed)
        this.IsStopLossGuaranteed = other.IsStopLossGuaranteed;
      if (other.CommissionSettingsSet.Length != 0)
        this.CommissionSettingsSet = other.CommissionSettingsSet;
      if (other.DynamicLeverageSettings.Length != 0)
        this.DynamicLeverageSettings = other.DynamicLeverageSettings;
      if (other.DynamicLeverageThresholdCoef != 0)
        this.DynamicLeverageThresholdCoef = other.DynamicLeverageThresholdCoef;
      if (other.Equity != 0.0)
        this.Equity = other.Equity;
      if (other.LastTradeDate != 0L)
        this.LastTradeDate = other.LastTradeDate;
      if (other.AccountMode != AccountModeProto.UnknowAccountTradingType)
        this.AccountMode = other.AccountMode;
      if (other.TenantId != 0)
        this.TenantId = other.TenantId;
      if (other.MaxNumberOfOrders != 0)
        this.MaxNumberOfOrders = other.MaxNumberOfOrders;
      if (other.IsApiConnectionEnabled)
        this.IsApiConnectionEnabled = other.IsApiConnectionEnabled;
      if (other.ClosedDate != 0L)
        this.ClosedDate = other.ClosedDate;
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
            this.IsEnabled = input.ReadBool();
            continue;
          case 24:
            this.IsTradeEnabled = input.ReadBool();
            continue;
          case 32:
            this.RegistrationDate = input.ReadInt64();
            continue;
          case 40:
            this.DeletedDate = input.ReadInt64();
            continue;
          case 48:
            this.EnableChargeOfSwaps = input.ReadBool();
            continue;
          case 56:
            this.MarginCallLevel = input.ReadInt32();
            continue;
          case 64:
            this.StopOutLevel = input.ReadInt32();
            continue;
          case 72:
            this.ParentAgentId = input.ReadInt32();
            continue;
          case 80:
            this.LeverageMultiplier = input.ReadInt32();
            continue;
          case 90:
            this.CurrencyIsoCode = input.ReadString();
            continue;
          case 98:
            this.CustomerEmail = input.ReadString();
            continue;
          case 106:
            this.CustomerName = input.ReadString();
            continue;
          case 114:
            this.HedgeSettingsSet = input.ReadString();
            continue;
          case 121:
            this.Balance = input.ReadDouble();
            continue;
          case 129:
            this.Margin = input.ReadDouble();
            continue;
          case 138:
            this.TradeSettingsSet = input.ReadString();
            continue;
          case 146:
            this.MarkupSettingsSet = input.ReadString();
            continue;
          case 154:
            this.CountryIsoCode = input.ReadString();
            continue;
          case 162:
            this.Comment = input.ReadString();
            continue;
          case 168:
            this.IsVirtual = input.ReadBool();
            continue;
          case 176:
            this.IsClosed = input.ReadBool();
            continue;
          case 184:
            this.IsProfessional = input.ReadBool();
            continue;
          case 192:
            this.IsStopLossGuaranteed = input.ReadBool();
            continue;
          case 202:
            this.CommissionSettingsSet = input.ReadString();
            continue;
          case 210:
            this.DynamicLeverageSettings = input.ReadString();
            continue;
          case 216:
            this.DynamicLeverageThresholdCoef = input.ReadInt32();
            continue;
          case 225:
            this.Equity = input.ReadDouble();
            continue;
          case 232:
            this.LastTradeDate = input.ReadInt64();
            continue;
          case 240:
            this.AccountMode = (AccountModeProto) input.ReadEnum();
            continue;
          case 248:
            this.TenantId = input.ReadInt32();
            continue;
          case 256:
            this.MaxNumberOfOrders = input.ReadInt32();
            continue;
          case 264:
            this.IsApiConnectionEnabled = input.ReadBool();
            continue;
          case 272:
            this.ClosedDate = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
