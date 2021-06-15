// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ExchangeRates.ExchangeRateService
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using ATPlatform.Common.Feed;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Common.ExchangeRates
{
  public class ExchangeRateService : IExchangeRateService
  {
    private const string UsdCurrencyIsoCode = "USD";
    private IDictionary<string, int> indexMap;
    private List<int> primeCurrencyIndices;
    private int intermediateCurrencyIndex;
    private ExchangeRate[,] rates;

    public void Initialize(IEnumerable<ICurrency> currencies)
    {
      IList<ICurrency> list = (IList<ICurrency>) currencies.OrderBy<ICurrency, bool>((Func<ICurrency, bool>) (c => c.IsPrime)).ToList<ICurrency>();
      this.ProcessOrderedCurrencies(list);
      this.InitializeRates(list.Count<ICurrency>());
      this.intermediateCurrencyIndex = this.indexMap["USD"];
    }

    public void UpdateExchangeRate(IExchangeRateSymbol symbol, ITick tick)
    {
      if (!symbol.AffectsExchangeRates)
        return;
      int index1 = this.indexMap[symbol.BaseCurrencyIsoCode];
      int index2 = this.indexMap[symbol.ProfitCurrencyIsoCode];
      if (this.primeCurrencyIndices.Contains(index2))
      {
        ExchangeRate exchangeRate = new ExchangeRate(tick.Bid, tick.Ask);
        this.rates[index1, index2] = exchangeRate;
      }
      if (!this.primeCurrencyIndices.Contains(index1))
        return;
      ExchangeRate exchangeRate1 = new ExchangeRate(1.0 / tick.Ask, 1.0 / tick.Bid);
      this.rates[index2, index1] = exchangeRate1;
    }

    public ExchangeRate GetRate(string fromCurrencyIsoCode, string toCurrencyIsoCode)
    {
      int index1 = this.indexMap[fromCurrencyIsoCode];
      int index2 = this.indexMap[toCurrencyIsoCode];
      ExchangeRate rate1 = this.rates[index1, index2];
      if (rate1.Bid > 0.0)
        return rate1;
      ExchangeRate rate2 = this.rates[index1, this.intermediateCurrencyIndex];
      ExchangeRate rate3 = this.rates[this.intermediateCurrencyIndex, index2];
      return new ExchangeRate(rate2.Bid * rate3.Bid, rate2.Ask * rate3.Ask);
    }

    private void InitializeRates(int currenciesCount)
    {
      this.rates = new ExchangeRate[currenciesCount - 1 + 1, this.primeCurrencyIndices.Max() + 1];
      foreach (int primeCurrencyIndex in this.primeCurrencyIndices)
        this.rates[primeCurrencyIndex, primeCurrencyIndex] = new ExchangeRate(1.0, 1.0);
    }

    private void ProcessOrderedCurrencies(IList<ICurrency> orderedCurrencies)
    {
      this.indexMap = (IDictionary<string, int>) new Dictionary<string, int>();
      this.primeCurrencyIndices = new List<int>();
      int num = 0;
      foreach (ICurrency orderedCurrency in (IEnumerable<ICurrency>) orderedCurrencies)
      {
        this.indexMap.Add(orderedCurrency.IsoCode, num);
        if (orderedCurrency.IsPrime)
          this.primeCurrencyIndices.Add(num);
        ++num;
      }
      if (this.primeCurrencyIndices.Count <= 0)
        throw new InvalidOperationException("No prime currencies found.");
    }
  }
}
