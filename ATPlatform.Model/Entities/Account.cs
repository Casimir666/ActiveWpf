// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Account
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums;
using System;

namespace ATPlatform.Model.Entities
{
  public class Account : 
    IModel<Account, int>,
    ICloneable<Account>,
    IUpdatable<Account>,
    Contracts.IEquatable<Account>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public int? ParentAgentId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string CountryIsoCode { get; set; }

    public string Comment { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsClosed { get; set; }

    public bool IsVirtual { get; set; }

    public bool IsProfessional { get; set; }

    public bool IsStopLossGuaranteed { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string CurrencyIsoCode { get; set; }

    public bool IsTradeEnabled { get; set; }

    public bool IsSwapsChargeEnabled { get; set; }

    public int LeverageMultiplier { get; set; }

    public int MarginCallLevel { get; set; }

    public int StopOutLevel { get; set; }

    public double Balance { get; set; }

    public double Margin { get; set; }

    public double Equity { get; set; }

    public DateTime? LastTradeDate { get; set; }

    public int MaxNumberOrders { get; set; }

    public bool IsAPIConnectionAllowed { get; set; }

    public string TradeSettingsSet { get; set; }

    public string HedgeSettingsSet { get; set; }

    public string MarkupSettingsSet { get; set; }

    public string CommissionSettingsSet { get; set; }

    public string DynamicLeverageSettings { get; set; }

    public int DynamicLeverageThresholdCoefficient { get; set; }

    public AccountMode AccountMode { get; set; } = AccountMode.Hedging;

    public int TenantId { get; set; }

    public DateTime? ClosedDate { get; set; }

    public int GetKey() => this.Id;

    public Account Clone()
    {
      Account account = new Account();
      account.Update(this);
      return account;
    }

    public void Update(Account other)
    {
      this.Id = other.Id;
      this.ParentAgentId = other.ParentAgentId;
      this.Name = other.Name;
      this.Email = other.Email;
      this.CountryIsoCode = other.CountryIsoCode;
      this.Comment = other.Comment;
      this.IsEnabled = other.IsEnabled;
      this.IsClosed = other.IsClosed;
      this.IsVirtual = other.IsVirtual;
      this.IsProfessional = other.IsProfessional;
      this.IsStopLossGuaranteed = other.IsStopLossGuaranteed;
      this.RegistrationDate = other.RegistrationDate;
      this.DeletedDate = other.DeletedDate;
      this.CurrencyIsoCode = other.CurrencyIsoCode;
      this.IsTradeEnabled = other.IsTradeEnabled;
      this.IsSwapsChargeEnabled = other.IsSwapsChargeEnabled;
      this.LeverageMultiplier = other.LeverageMultiplier;
      this.MarginCallLevel = other.MarginCallLevel;
      this.StopOutLevel = other.StopOutLevel;
      this.Balance = other.Balance;
      this.Margin = other.Margin;
      this.Equity = other.Equity;
      this.LastTradeDate = other.LastTradeDate;
      this.MaxNumberOrders = other.MaxNumberOrders;
      this.IsAPIConnectionAllowed = other.IsAPIConnectionAllowed;
      this.TradeSettingsSet = other.TradeSettingsSet;
      this.HedgeSettingsSet = other.HedgeSettingsSet;
      this.MarkupSettingsSet = other.MarkupSettingsSet;
      this.CommissionSettingsSet = other.CommissionSettingsSet;
      this.DynamicLeverageSettings = other.DynamicLeverageSettings;
      this.DynamicLeverageThresholdCoefficient = other.DynamicLeverageThresholdCoefficient;
      this.AccountMode = other.AccountMode;
      this.TenantId = other.TenantId;
      this.ClosedDate = other.ClosedDate;
    }

    public bool Equals(Account other)
    {
      if (this.Id == other.Id)
      {
        int? parentAgentId1 = this.ParentAgentId;
        int? parentAgentId2 = other.ParentAgentId;
        if (parentAgentId1.GetValueOrDefault() == parentAgentId2.GetValueOrDefault() & parentAgentId1.HasValue == parentAgentId2.HasValue && this.Name == other.Name && (this.Email == other.Email && this.CountryIsoCode == other.CountryIsoCode) && (this.Comment == other.Comment && this.IsEnabled == other.IsEnabled && (this.IsClosed == other.IsClosed && this.IsVirtual == other.IsVirtual)) && (this.IsProfessional == other.IsProfessional && this.IsStopLossGuaranteed == other.IsStopLossGuaranteed))
        {
          DateTime? nullable1 = this.RegistrationDate;
          DateTime? registrationDate = other.RegistrationDate;
          if ((nullable1.HasValue == registrationDate.HasValue ? (nullable1.HasValue ? (nullable1.GetValueOrDefault() == registrationDate.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0)
          {
            DateTime? nullable2 = this.DeletedDate;
            nullable1 = other.DeletedDate;
            if ((nullable2.HasValue == nullable1.HasValue ? (nullable2.HasValue ? (nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && this.CurrencyIsoCode == other.CurrencyIsoCode && (this.IsTradeEnabled == other.IsTradeEnabled && this.IsSwapsChargeEnabled == other.IsSwapsChargeEnabled) && (this.LeverageMultiplier == other.LeverageMultiplier && this.MarginCallLevel == other.MarginCallLevel && (this.StopOutLevel == other.StopOutLevel && DoubleComparer.AreEqual(this.Balance, other.Balance))) && (DoubleComparer.AreEqual(this.Margin, other.Margin) && DoubleComparer.AreEqual(this.Equity, other.Equity)))
            {
              nullable1 = this.LastTradeDate;
              nullable2 = other.LastTradeDate;
              if ((nullable1.HasValue == nullable2.HasValue ? (nullable1.HasValue ? (nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && this.TradeSettingsSet == other.TradeSettingsSet && (this.HedgeSettingsSet == other.HedgeSettingsSet && this.MarkupSettingsSet == other.MarkupSettingsSet) && (this.CommissionSettingsSet == other.CommissionSettingsSet && this.DynamicLeverageSettings == other.DynamicLeverageSettings && (this.DynamicLeverageThresholdCoefficient == other.DynamicLeverageThresholdCoefficient && this.AccountMode == other.AccountMode)) && (this.TenantId == other.TenantId && this.MaxNumberOrders == other.MaxNumberOrders && this.IsAPIConnectionAllowed == other.IsAPIConnectionAllowed))
              {
                nullable2 = this.ClosedDate;
                nullable1 = other.ClosedDate;
                if (nullable2.HasValue != nullable1.HasValue)
                  return false;
                return !nullable2.HasValue || nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault();
              }
            }
          }
        }
      }
      return false;
    }
  }
}
