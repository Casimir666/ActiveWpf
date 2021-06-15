// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.LastIdTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum LastIdTypeProto
  {
    [OriginalName("UNDEFINED")] Undefined,
    [OriginalName("SYMBOL_GROUP")] SymbolGroup,
    [OriginalName("ORDER")] Order,
    [OriginalName("ACCOUNT")] Account,
    [OriginalName("ORDER_EXECUTION")] OrderExecution,
    [OriginalName("BALANCE_OPERATION")] BalanceOperation,
    [OriginalName("TRADE_SETTINGS_SET")] TradeSettingsSet,
    [OriginalName("TRADE_MARKUPS_SET")] TradeMarkupsSet,
    [OriginalName("MESSAGE_SEQUENCE")] MessageSequence,
    [OriginalName("COMMISSION_GROUP")] CommissionGroup,
    [OriginalName("COMMISSION_SET")] CommissionSet,
    [OriginalName("ADMINISTRATOR")] Administrator,
    [OriginalName("ROLE")] Role,
    [OriginalName("DYNAMIC_LEVERAGE_SETTINGS")] DynamicLeverageSettings,
    [OriginalName("HEDGE_SETTINGS_SETS")] HedgeSettingsSets,
    [OriginalName("FEED_SOURCE")] FeedSource,
    [OriginalName("ACCOUNT_TRADES_SUMMARY")] AccountTradesSummary,
    [OriginalName("HEDGE_LIQUIDITY_PROVIDER")] HedgeLiquidityProvider,
    [OriginalName("TENANT")] Tenant,
    [OriginalName("SMART_BRIDGE_SETTINGS_SET")] SmartBridgeSettingsSet,
    [OriginalName("TAG")] Tag,
    [OriginalName("TAG_CATEGORY")] TagCategory,
  }
}
