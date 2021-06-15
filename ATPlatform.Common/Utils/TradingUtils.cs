// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.TradingUtils
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;

namespace ATPlatform.Common.Utils
{
  public static class TradingUtils
  {
    public static double CalculateOrderProfit(
      ProfitOrderArguments order,
      int symbolContractSize,
      int contractSizeDenominator,
      double conversionRateBid,
      double conversionRateAsk)
    {
      double num1 = (order.IsBuy ? 1.0 : -1.0) * (order.ClosePrice - order.OpenPrice);
      double num2 = num1 > 0.0 ? conversionRateBid : conversionRateAsk;
      if (contractSizeDenominator == 0)
        contractSizeDenominator = 1;
      return Math.Round(num1 * (double) symbolContractSize * order.Lots / (double) contractSizeDenominator * num2, 2, MidpointRounding.AwayFromZero);
    }
  }
}
