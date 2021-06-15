// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.PriceFormatting
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System.Collections.Generic;

namespace ATPlatform.Common.Utils
{
  public class PriceFormatting
  {
    private static readonly IDictionary<byte, string> cachedFormats = (IDictionary<byte, string>) new Dictionary<byte, string>();

    public static string GetOrderPricesFormat(byte digits)
    {
      string str;
      if (!PriceFormatting.cachedFormats.TryGetValue(digits, out str))
      {
        str = PriceFormatting.BuildOrderPriceFormat(digits);
        PriceFormatting.cachedFormats.Add(digits, str);
      }
      return str;
    }

    private static string BuildOrderPriceFormat(byte digits)
    {
      string str = "0.";
      for (int index = 0; index < (int) digits; ++index)
        str += "0";
      return str + "###";
    }
  }
}
