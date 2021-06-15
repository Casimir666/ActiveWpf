// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountStatementProto
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
  public sealed class AccountStatementProto : 
    IMessage<AccountStatementProto>,
    IMessage,
    IEquatable<AccountStatementProto>,
    IDeepCloneable<AccountStatementProto>
  {
    private static readonly MessageParser<AccountStatementProto> _parser = new MessageParser<AccountStatementProto>((Func<AccountStatementProto>) (() => new AccountStatementProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int CustomerNameFieldNumber = 2;
    private string customerName_ = "";
    public const int StatementTimeFieldNumber = 3;
    private long statementTime_;
    public const int DepositWithdrawFieldNumber = 4;
    private double depositWithdraw_;
    public const int CreditFacilityFieldNumber = 5;
    private double creditFacility_;
    public const int CloseTradeProfitLossFieldNumber = 6;
    private double closeTradeProfitLoss_;
    public const int FloatingProfitLossFieldNumber = 7;
    private double floatingProfitLoss_;
    public const int PreviousLedgerBalanceFieldNumber = 8;
    private double previousLedgerBalance_;
    public const int TotalCreditFacilityFieldNumber = 9;
    private double totalCreditFacility_;
    public const int DepositsAdditionsFieldNumber = 10;
    private double depositsAdditions_;
    public const int EquityFieldNumber = 11;
    private double equity_;
    public const int WithdrawalsDeductionsFieldNumber = 12;
    private double withdrawalsDeductions_;
    public const int MarginRequirementFieldNumber = 13;
    private double marginRequirement_;
    public const int FeeChargesTaxesFieldNumber = 14;
    private double feeChargesTaxes_;
    public const int AvailableMarginFieldNumber = 15;
    private double availableMargin_;
    public const int BalanceFieldNumber = 16;
    private double balance_;
    public const int ClosedTransactionsFieldNumber = 17;
    private static readonly FieldCodec<AccountStatementTransactionProto> _repeated_closedTransactions_codec = FieldCodec.ForMessage<AccountStatementTransactionProto>(138U, AccountStatementTransactionProto.Parser);
    private readonly RepeatedField<AccountStatementTransactionProto> closedTransactions_ = new RepeatedField<AccountStatementTransactionProto>();
    public const int OpenTradesFieldNumber = 18;
    private static readonly FieldCodec<AccountStatementTransactionProto> _repeated_openTrades_codec = FieldCodec.ForMessage<AccountStatementTransactionProto>(146U, AccountStatementTransactionProto.Parser);
    private readonly RepeatedField<AccountStatementTransactionProto> openTrades_ = new RepeatedField<AccountStatementTransactionProto>();
    public const int WorkingOrdersFieldNumber = 19;
    private static readonly FieldCodec<AccountStatementTransactionProto> _repeated_workingOrders_codec = FieldCodec.ForMessage<AccountStatementTransactionProto>(154U, AccountStatementTransactionProto.Parser);
    private readonly RepeatedField<AccountStatementTransactionProto> workingOrders_ = new RepeatedField<AccountStatementTransactionProto>();
    public const int BalanceOperationsFieldNumber = 20;
    private static readonly FieldCodec<AccountStatementTransactionProto> _repeated_balanceOperations_codec = FieldCodec.ForMessage<AccountStatementTransactionProto>(162U, AccountStatementTransactionProto.Parser);
    private readonly RepeatedField<AccountStatementTransactionProto> balanceOperations_ = new RepeatedField<AccountStatementTransactionProto>();
    public const int AccountDepositCurrencyFieldNumber = 21;
    private string accountDepositCurrency_ = "";
    public const int StatementStartTimeFieldNumber = 22;
    private long statementStartTime_;
    public const int CanceledOrdersFieldNumber = 23;
    private static readonly FieldCodec<AccountStatementTransactionProto> _repeated_canceledOrders_codec = FieldCodec.ForMessage<AccountStatementTransactionProto>(186U, AccountStatementTransactionProto.Parser);
    private readonly RepeatedField<AccountStatementTransactionProto> canceledOrders_ = new RepeatedField<AccountStatementTransactionProto>();

    [DebuggerNonUserCode]
    public static MessageParser<AccountStatementProto> Parser => AccountStatementProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[140];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountStatementProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountStatementProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountStatementProto(AccountStatementProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.customerName_ = other.customerName_;
      this.statementTime_ = other.statementTime_;
      this.depositWithdraw_ = other.depositWithdraw_;
      this.creditFacility_ = other.creditFacility_;
      this.closeTradeProfitLoss_ = other.closeTradeProfitLoss_;
      this.floatingProfitLoss_ = other.floatingProfitLoss_;
      this.previousLedgerBalance_ = other.previousLedgerBalance_;
      this.totalCreditFacility_ = other.totalCreditFacility_;
      this.depositsAdditions_ = other.depositsAdditions_;
      this.equity_ = other.equity_;
      this.withdrawalsDeductions_ = other.withdrawalsDeductions_;
      this.marginRequirement_ = other.marginRequirement_;
      this.feeChargesTaxes_ = other.feeChargesTaxes_;
      this.availableMargin_ = other.availableMargin_;
      this.balance_ = other.balance_;
      this.closedTransactions_ = other.closedTransactions_.Clone();
      this.openTrades_ = other.openTrades_.Clone();
      this.workingOrders_ = other.workingOrders_.Clone();
      this.balanceOperations_ = other.balanceOperations_.Clone();
      this.accountDepositCurrency_ = other.accountDepositCurrency_;
      this.statementStartTime_ = other.statementStartTime_;
      this.canceledOrders_ = other.canceledOrders_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountStatementProto Clone() => new AccountStatementProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string CustomerName
    {
      get => this.customerName_;
      set => this.customerName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long StatementTime
    {
      get => this.statementTime_;
      set => this.statementTime_ = value;
    }

    [DebuggerNonUserCode]
    public double DepositWithdraw
    {
      get => this.depositWithdraw_;
      set => this.depositWithdraw_ = value;
    }

    [DebuggerNonUserCode]
    public double CreditFacility
    {
      get => this.creditFacility_;
      set => this.creditFacility_ = value;
    }

    [DebuggerNonUserCode]
    public double CloseTradeProfitLoss
    {
      get => this.closeTradeProfitLoss_;
      set => this.closeTradeProfitLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double FloatingProfitLoss
    {
      get => this.floatingProfitLoss_;
      set => this.floatingProfitLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double PreviousLedgerBalance
    {
      get => this.previousLedgerBalance_;
      set => this.previousLedgerBalance_ = value;
    }

    [DebuggerNonUserCode]
    public double TotalCreditFacility
    {
      get => this.totalCreditFacility_;
      set => this.totalCreditFacility_ = value;
    }

    [DebuggerNonUserCode]
    public double DepositsAdditions
    {
      get => this.depositsAdditions_;
      set => this.depositsAdditions_ = value;
    }

    [DebuggerNonUserCode]
    public double Equity
    {
      get => this.equity_;
      set => this.equity_ = value;
    }

    [DebuggerNonUserCode]
    public double WithdrawalsDeductions
    {
      get => this.withdrawalsDeductions_;
      set => this.withdrawalsDeductions_ = value;
    }

    [DebuggerNonUserCode]
    public double MarginRequirement
    {
      get => this.marginRequirement_;
      set => this.marginRequirement_ = value;
    }

    [DebuggerNonUserCode]
    public double FeeChargesTaxes
    {
      get => this.feeChargesTaxes_;
      set => this.feeChargesTaxes_ = value;
    }

    [DebuggerNonUserCode]
    public double AvailableMargin
    {
      get => this.availableMargin_;
      set => this.availableMargin_ = value;
    }

    [DebuggerNonUserCode]
    public double Balance
    {
      get => this.balance_;
      set => this.balance_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementTransactionProto> ClosedTransactions => this.closedTransactions_;

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementTransactionProto> OpenTrades => this.openTrades_;

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementTransactionProto> WorkingOrders => this.workingOrders_;

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementTransactionProto> BalanceOperations => this.balanceOperations_;

    [DebuggerNonUserCode]
    public string AccountDepositCurrency
    {
      get => this.accountDepositCurrency_;
      set => this.accountDepositCurrency_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long StatementStartTime
    {
      get => this.statementStartTime_;
      set => this.statementStartTime_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementTransactionProto> CanceledOrders => this.canceledOrders_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountStatementProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountStatementProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.CustomerName != other.CustomerName) && (this.StatementTime == other.StatementTime && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DepositWithdraw, other.DepositWithdraw)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CreditFacility, other.CreditFacility) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CloseTradeProfitLoss, other.CloseTradeProfitLoss) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.FloatingProfitLoss, other.FloatingProfitLoss) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PreviousLedgerBalance, other.PreviousLedgerBalance))) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalCreditFacility, other.TotalCreditFacility) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DepositsAdditions, other.DepositsAdditions) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Equity, other.Equity) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.WithdrawalsDeductions, other.WithdrawalsDeductions)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MarginRequirement, other.MarginRequirement) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.FeeChargesTaxes, other.FeeChargesTaxes) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AvailableMargin, other.AvailableMargin) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Balance, other.Balance)))) && (this.closedTransactions_.Equals(other.closedTransactions_) && this.openTrades_.Equals(other.openTrades_) && (this.workingOrders_.Equals(other.workingOrders_) && this.balanceOperations_.Equals(other.balanceOperations_)) && (!(this.AccountDepositCurrency != other.AccountDepositCurrency) && this.StatementStartTime == other.StatementStartTime && this.canceledOrders_.Equals(other.canceledOrders_))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      if (this.CustomerName.Length != 0)
        num1 ^= this.CustomerName.GetHashCode();
      long num2;
      if (this.StatementTime != 0L)
      {
        int num3 = num1;
        num2 = this.StatementTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.DepositWithdraw != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DepositWithdraw);
      if (this.CreditFacility != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CreditFacility);
      if (this.CloseTradeProfitLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CloseTradeProfitLoss);
      if (this.FloatingProfitLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.FloatingProfitLoss);
      if (this.PreviousLedgerBalance != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PreviousLedgerBalance);
      if (this.TotalCreditFacility != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalCreditFacility);
      if (this.DepositsAdditions != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DepositsAdditions);
      if (this.Equity != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Equity);
      if (this.WithdrawalsDeductions != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.WithdrawalsDeductions);
      if (this.MarginRequirement != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MarginRequirement);
      if (this.FeeChargesTaxes != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.FeeChargesTaxes);
      if (this.AvailableMargin != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AvailableMargin);
      if (this.Balance != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Balance);
      int num4 = num1 ^ this.closedTransactions_.GetHashCode() ^ this.openTrades_.GetHashCode() ^ this.workingOrders_.GetHashCode() ^ this.balanceOperations_.GetHashCode();
      if (this.AccountDepositCurrency.Length != 0)
        num4 ^= this.AccountDepositCurrency.GetHashCode();
      if (this.StatementStartTime != 0L)
      {
        int num3 = num4;
        num2 = this.StatementStartTime;
        int hashCode = num2.GetHashCode();
        num4 = num3 ^ hashCode;
      }
      int num5 = num4 ^ this.canceledOrders_.GetHashCode();
      if (this._unknownFields != null)
        num5 ^= this._unknownFields.GetHashCode();
      return num5;
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
      if (this.CustomerName.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.CustomerName);
      }
      if (this.StatementTime != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.StatementTime);
      }
      if (this.DepositWithdraw != 0.0)
      {
        output.WriteRawTag((byte) 33);
        output.WriteDouble(this.DepositWithdraw);
      }
      if (this.CreditFacility != 0.0)
      {
        output.WriteRawTag((byte) 41);
        output.WriteDouble(this.CreditFacility);
      }
      if (this.CloseTradeProfitLoss != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.CloseTradeProfitLoss);
      }
      if (this.FloatingProfitLoss != 0.0)
      {
        output.WriteRawTag((byte) 57);
        output.WriteDouble(this.FloatingProfitLoss);
      }
      if (this.PreviousLedgerBalance != 0.0)
      {
        output.WriteRawTag((byte) 65);
        output.WriteDouble(this.PreviousLedgerBalance);
      }
      if (this.TotalCreditFacility != 0.0)
      {
        output.WriteRawTag((byte) 73);
        output.WriteDouble(this.TotalCreditFacility);
      }
      if (this.DepositsAdditions != 0.0)
      {
        output.WriteRawTag((byte) 81);
        output.WriteDouble(this.DepositsAdditions);
      }
      if (this.Equity != 0.0)
      {
        output.WriteRawTag((byte) 89);
        output.WriteDouble(this.Equity);
      }
      if (this.WithdrawalsDeductions != 0.0)
      {
        output.WriteRawTag((byte) 97);
        output.WriteDouble(this.WithdrawalsDeductions);
      }
      if (this.MarginRequirement != 0.0)
      {
        output.WriteRawTag((byte) 105);
        output.WriteDouble(this.MarginRequirement);
      }
      if (this.FeeChargesTaxes != 0.0)
      {
        output.WriteRawTag((byte) 113);
        output.WriteDouble(this.FeeChargesTaxes);
      }
      if (this.AvailableMargin != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.AvailableMargin);
      }
      if (this.Balance != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 1);
        output.WriteDouble(this.Balance);
      }
      this.closedTransactions_.WriteTo(output, AccountStatementProto._repeated_closedTransactions_codec);
      this.openTrades_.WriteTo(output, AccountStatementProto._repeated_openTrades_codec);
      this.workingOrders_.WriteTo(output, AccountStatementProto._repeated_workingOrders_codec);
      this.balanceOperations_.WriteTo(output, AccountStatementProto._repeated_balanceOperations_codec);
      if (this.AccountDepositCurrency.Length != 0)
      {
        output.WriteRawTag((byte) 170, (byte) 1);
        output.WriteString(this.AccountDepositCurrency);
      }
      if (this.StatementStartTime != 0L)
      {
        output.WriteRawTag((byte) 176, (byte) 1);
        output.WriteInt64(this.StatementStartTime);
      }
      this.canceledOrders_.WriteTo(output, AccountStatementProto._repeated_canceledOrders_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.AccountId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.CustomerName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.CustomerName);
      if (this.StatementTime != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.StatementTime);
      if (this.DepositWithdraw != 0.0)
        num1 += 9;
      if (this.CreditFacility != 0.0)
        num1 += 9;
      if (this.CloseTradeProfitLoss != 0.0)
        num1 += 9;
      if (this.FloatingProfitLoss != 0.0)
        num1 += 9;
      if (this.PreviousLedgerBalance != 0.0)
        num1 += 9;
      if (this.TotalCreditFacility != 0.0)
        num1 += 9;
      if (this.DepositsAdditions != 0.0)
        num1 += 9;
      if (this.Equity != 0.0)
        num1 += 9;
      if (this.WithdrawalsDeductions != 0.0)
        num1 += 9;
      if (this.MarginRequirement != 0.0)
        num1 += 9;
      if (this.FeeChargesTaxes != 0.0)
        num1 += 9;
      if (this.AvailableMargin != 0.0)
        num1 += 9;
      if (this.Balance != 0.0)
        num1 += 10;
      int num2 = num1 + this.closedTransactions_.CalculateSize(AccountStatementProto._repeated_closedTransactions_codec) + this.openTrades_.CalculateSize(AccountStatementProto._repeated_openTrades_codec) + this.workingOrders_.CalculateSize(AccountStatementProto._repeated_workingOrders_codec) + this.balanceOperations_.CalculateSize(AccountStatementProto._repeated_balanceOperations_codec);
      if (this.AccountDepositCurrency.Length != 0)
        num2 += 2 + CodedOutputStream.ComputeStringSize(this.AccountDepositCurrency);
      if (this.StatementStartTime != 0L)
        num2 += 2 + CodedOutputStream.ComputeInt64Size(this.StatementStartTime);
      int num3 = num2 + this.canceledOrders_.CalculateSize(AccountStatementProto._repeated_canceledOrders_codec);
      if (this._unknownFields != null)
        num3 += this._unknownFields.CalculateSize();
      return num3;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountStatementProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.CustomerName.Length != 0)
        this.CustomerName = other.CustomerName;
      if (other.StatementTime != 0L)
        this.StatementTime = other.StatementTime;
      if (other.DepositWithdraw != 0.0)
        this.DepositWithdraw = other.DepositWithdraw;
      if (other.CreditFacility != 0.0)
        this.CreditFacility = other.CreditFacility;
      if (other.CloseTradeProfitLoss != 0.0)
        this.CloseTradeProfitLoss = other.CloseTradeProfitLoss;
      if (other.FloatingProfitLoss != 0.0)
        this.FloatingProfitLoss = other.FloatingProfitLoss;
      if (other.PreviousLedgerBalance != 0.0)
        this.PreviousLedgerBalance = other.PreviousLedgerBalance;
      if (other.TotalCreditFacility != 0.0)
        this.TotalCreditFacility = other.TotalCreditFacility;
      if (other.DepositsAdditions != 0.0)
        this.DepositsAdditions = other.DepositsAdditions;
      if (other.Equity != 0.0)
        this.Equity = other.Equity;
      if (other.WithdrawalsDeductions != 0.0)
        this.WithdrawalsDeductions = other.WithdrawalsDeductions;
      if (other.MarginRequirement != 0.0)
        this.MarginRequirement = other.MarginRequirement;
      if (other.FeeChargesTaxes != 0.0)
        this.FeeChargesTaxes = other.FeeChargesTaxes;
      if (other.AvailableMargin != 0.0)
        this.AvailableMargin = other.AvailableMargin;
      if (other.Balance != 0.0)
        this.Balance = other.Balance;
      this.closedTransactions_.Add((IEnumerable<AccountStatementTransactionProto>) other.closedTransactions_);
      this.openTrades_.Add((IEnumerable<AccountStatementTransactionProto>) other.openTrades_);
      this.workingOrders_.Add((IEnumerable<AccountStatementTransactionProto>) other.workingOrders_);
      this.balanceOperations_.Add((IEnumerable<AccountStatementTransactionProto>) other.balanceOperations_);
      if (other.AccountDepositCurrency.Length != 0)
        this.AccountDepositCurrency = other.AccountDepositCurrency;
      if (other.StatementStartTime != 0L)
        this.StatementStartTime = other.StatementStartTime;
      this.canceledOrders_.Add((IEnumerable<AccountStatementTransactionProto>) other.canceledOrders_);
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
            this.CustomerName = input.ReadString();
            continue;
          case 24:
            this.StatementTime = input.ReadInt64();
            continue;
          case 33:
            this.DepositWithdraw = input.ReadDouble();
            continue;
          case 41:
            this.CreditFacility = input.ReadDouble();
            continue;
          case 49:
            this.CloseTradeProfitLoss = input.ReadDouble();
            continue;
          case 57:
            this.FloatingProfitLoss = input.ReadDouble();
            continue;
          case 65:
            this.PreviousLedgerBalance = input.ReadDouble();
            continue;
          case 73:
            this.TotalCreditFacility = input.ReadDouble();
            continue;
          case 81:
            this.DepositsAdditions = input.ReadDouble();
            continue;
          case 89:
            this.Equity = input.ReadDouble();
            continue;
          case 97:
            this.WithdrawalsDeductions = input.ReadDouble();
            continue;
          case 105:
            this.MarginRequirement = input.ReadDouble();
            continue;
          case 113:
            this.FeeChargesTaxes = input.ReadDouble();
            continue;
          case 121:
            this.AvailableMargin = input.ReadDouble();
            continue;
          case 129:
            this.Balance = input.ReadDouble();
            continue;
          case 138:
            this.closedTransactions_.AddEntriesFrom(input, AccountStatementProto._repeated_closedTransactions_codec);
            continue;
          case 146:
            this.openTrades_.AddEntriesFrom(input, AccountStatementProto._repeated_openTrades_codec);
            continue;
          case 154:
            this.workingOrders_.AddEntriesFrom(input, AccountStatementProto._repeated_workingOrders_codec);
            continue;
          case 162:
            this.balanceOperations_.AddEntriesFrom(input, AccountStatementProto._repeated_balanceOperations_codec);
            continue;
          case 170:
            this.AccountDepositCurrency = input.ReadString();
            continue;
          case 176:
            this.StatementStartTime = input.ReadInt64();
            continue;
          case 186:
            this.canceledOrders_.AddEntriesFrom(input, AccountStatementProto._repeated_canceledOrders_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
