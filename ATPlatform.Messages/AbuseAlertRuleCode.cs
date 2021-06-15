// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertRuleCode
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL.AbuseAlert
{
  public enum AbuseAlertRuleCode
  {
    [OriginalName("UNDEFINED_RULE")] UndefinedRule,
    [OriginalName("CLIENT_SESSIONS_FROM_SAME_IP")] ClientSessionsFromSameIp,
    [OriginalName("DISABLED_ACCOUNT")] DisabledAccount,
    [OriginalName("MARGIN_EXPOSURE")] MarginExposure,
    [OriginalName("SCALPER_ORDERS")] ScalperOrders,
    [OriginalName("EQUITY_INCREASE_IN_A_DAY")] EquityIncreaseInADay,
    [OriginalName("OPPOSITE_ORDERS")] OppositeOrders,
    [OriginalName("ALL_IN_BEHAVIOUR")] AllInBehaviour,
    [OriginalName("FREQUENT_ORDER_TRADES")] FrequentOrderTrades,
    [OriginalName("BLACKLISTED_IPS")] BlacklistedIps,
  }
}
