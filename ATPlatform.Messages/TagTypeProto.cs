// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TagTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum TagTypeProto
  {
    [OriginalName("unknown_tag_type")] UnknownTagType,
    [OriginalName("account_tag_type")] AccountTagType,
    [OriginalName("country_tag_type")] CountryTagType,
    [OriginalName("currency_tag_type")] CurrencyTagType,
    [OriginalName("leverage_tag_type")] LeverageTagType,
    [OriginalName("symbol_tag_type")] SymbolTagType,
    [OriginalName("trade_settings_tag_type")] TradeSettingsTagType,
    [OriginalName("markup_settings_tag_type")] MarkupSettingsTagType,
    [OriginalName("commission_settings_tag_type")] CommissionSettingsTagType,
  }
}
