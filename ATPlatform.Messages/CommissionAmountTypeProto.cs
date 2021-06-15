// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CommissionAmountTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum CommissionAmountTypeProto
  {
    [OriginalName("UNDEFINED_COMMISSION_AMOUNT_TYPE")] UndefinedCommissionAmountType = 0,
    [OriginalName("COMMISSION_POINTS")] CommissionPoints = 1,
    [OriginalName("COMMISSION_TICKS")] CommissionTicks = 2,
    [OriginalName("COMMISSION_PERCENTAGE")] CommissionPercentage = 4,
    [OriginalName("COMMISSION_MONEY_BASE_CURRENCY")] CommissionMoneyBaseCurrency = 8,
    [OriginalName("COMMISSION_MONEY_PROFIT_CURRENCY")] CommissionMoneyProfitCurrency = 16, // 0x00000010
    [OriginalName("COMMISSION_MONEY_DEPOSIT_CURRENCY")] CommissionMoneyDepositCurrency = 32, // 0x00000020
    [OriginalName("COMMISSION_MONEY_SPECIFIED_CURRENCY")] CommissionMoneySpecifiedCurrency = 64, // 0x00000040
    [OriginalName("COMMISSION_TARGET_SPREAD_PERCENTAGE")] CommissionTargetSpreadPercentage = 128, // 0x00000080
  }
}
