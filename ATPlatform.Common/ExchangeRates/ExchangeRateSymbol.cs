// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ExchangeRates.ExchangeRateSymbol
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

namespace ATPlatform.Common.ExchangeRates
{
  public class ExchangeRateSymbol : IExchangeRateSymbol
  {
    private const int ForexSymbolLength = 6;
    private readonly string symbolId;
    private readonly string baseCurrencyIsCode;
    private readonly string profitCurrencyIsoCode;
    private readonly bool affectsConversionRates;

    public ExchangeRateSymbol(
      string symbolId,
      string baseCurrencyIsCode,
      string profitCurrencyIsoCode)
    {
      this.symbolId = symbolId;
      this.baseCurrencyIsCode = baseCurrencyIsCode;
      this.profitCurrencyIsoCode = profitCurrencyIsoCode;
      this.affectsConversionRates = this.symbolId.Length == 6 && this.BaseCurrencyIsoCode != this.ProfitCurrencyIsoCode && this.BaseCurrencyIsoCode + this.ProfitCurrencyIsoCode == this.symbolId;
    }

    public string Id => this.symbolId;

    public string BaseCurrencyIsoCode => this.baseCurrencyIsCode;

    public string ProfitCurrencyIsoCode => this.profitCurrencyIsoCode;

    public bool AffectsExchangeRates => this.affectsConversionRates;
  }
}
