// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.AccountMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class AccountMapping : IProtoMapper<AccountProto, Account>
  {
    public Account ModelFromProto(AccountProto proto) => new Account()
    {
      Id = proto.Id,
      ParentAgentId = ProtoNullableNumberConverter.GetFromProto(proto.ParentAgentId),
      Name = ProtoNullableStringConverter.GetFromProto(proto.CustomerName),
      Email = ProtoNullableStringConverter.GetFromProto(proto.CustomerEmail),
      CountryIsoCode = ProtoNullableStringConverter.GetFromProto(proto.CountryIsoCode),
      Comment = ProtoNullableStringConverter.GetFromProto(proto.Comment),
      IsEnabled = proto.IsEnabled,
      IsClosed = proto.IsClosed,
      IsVirtual = proto.IsVirtual,
      IsProfessional = proto.IsProfessional,
      IsStopLossGuaranteed = proto.IsStopLossGuaranteed,
      RegistrationDate = ProtoNullableDateTimeConverter.GetFromProto(proto.RegistrationDate),
      DeletedDate = ProtoNullableDateTimeConverter.GetFromProto(proto.DeletedDate),
      CurrencyIsoCode = ProtoNullableStringConverter.GetFromProto(proto.CurrencyIsoCode),
      IsTradeEnabled = proto.IsTradeEnabled,
      IsSwapsChargeEnabled = proto.EnableChargeOfSwaps,
      LeverageMultiplier = proto.LeverageMultiplier,
      MarginCallLevel = proto.MarginCallLevel,
      StopOutLevel = proto.StopOutLevel,
      Balance = proto.Balance,
      Margin = proto.Margin,
      Equity = proto.Equity,
      LastTradeDate = ProtoNullableDateTimeConverter.GetFromProto(proto.LastTradeDate),
      MaxNumberOrders = proto.MaxNumberOfOrders,
      IsAPIConnectionAllowed = proto.IsApiConnectionEnabled,
      TradeSettingsSet = ProtoNullableStringConverter.GetFromProto(proto.TradeSettingsSet),
      HedgeSettingsSet = ProtoNullableStringConverter.GetFromProto(proto.HedgeSettingsSet),
      MarkupSettingsSet = ProtoNullableStringConverter.GetFromProto(proto.MarkupSettingsSet),
      CommissionSettingsSet = ProtoNullableStringConverter.GetFromProto(proto.CommissionSettingsSet),
      DynamicLeverageSettings = ProtoNullableStringConverter.GetFromProto(proto.DynamicLeverageSettings),
      DynamicLeverageThresholdCoefficient = proto.DynamicLeverageThresholdCoef,
      AccountMode = (AccountMode) proto.AccountMode,
      TenantId = proto.TenantId,
      ClosedDate = ProtoNullableDateTimeConverter.GetFromProto(proto.ClosedDate)
    };

    public AccountProto ProtoFromModel(Account model) => new AccountProto()
    {
      Id = model.Id,
      ParentAgentId = ProtoNullableNumberConverter.GetFromModel(model.ParentAgentId),
      CustomerName = ProtoNullableStringConverter.GetFromModel(model.Name),
      CustomerEmail = ProtoNullableStringConverter.GetFromModel(model.Email),
      CountryIsoCode = ProtoNullableStringConverter.GetFromModel(model.CountryIsoCode),
      Comment = ProtoNullableStringConverter.GetFromModel(model.Comment),
      IsEnabled = model.IsEnabled,
      IsClosed = model.IsClosed,
      IsVirtual = model.IsVirtual,
      IsProfessional = model.IsProfessional,
      IsStopLossGuaranteed = model.IsStopLossGuaranteed,
      RegistrationDate = ProtoNullableDateTimeConverter.GetFromModel(model.RegistrationDate),
      DeletedDate = ProtoNullableDateTimeConverter.GetFromModel(model.DeletedDate),
      CurrencyIsoCode = ProtoNullableStringConverter.GetFromModel(model.CurrencyIsoCode),
      IsTradeEnabled = model.IsTradeEnabled,
      EnableChargeOfSwaps = model.IsSwapsChargeEnabled,
      LeverageMultiplier = model.LeverageMultiplier,
      MarginCallLevel = model.MarginCallLevel,
      StopOutLevel = model.StopOutLevel,
      Balance = model.Balance,
      Margin = model.Margin,
      Equity = model.Equity,
      LastTradeDate = ProtoNullableDateTimeConverter.GetFromModel(model.LastTradeDate),
      MaxNumberOfOrders = model.MaxNumberOrders,
      IsApiConnectionEnabled = model.IsAPIConnectionAllowed,
      TradeSettingsSet = ProtoNullableStringConverter.GetFromModel(model.TradeSettingsSet),
      HedgeSettingsSet = ProtoNullableStringConverter.GetFromModel(model.HedgeSettingsSet),
      MarkupSettingsSet = ProtoNullableStringConverter.GetFromModel(model.MarkupSettingsSet),
      CommissionSettingsSet = ProtoNullableStringConverter.GetFromModel(model.CommissionSettingsSet),
      DynamicLeverageSettings = ProtoNullableStringConverter.GetFromModel(model.DynamicLeverageSettings),
      DynamicLeverageThresholdCoef = model.DynamicLeverageThresholdCoefficient,
      TenantId = model.TenantId,
      AccountMode = (AccountModeProto) model.AccountMode,
      ClosedDate = ProtoNullableDateTimeConverter.GetFromModel(model.ClosedDate)
    };
  }
}
