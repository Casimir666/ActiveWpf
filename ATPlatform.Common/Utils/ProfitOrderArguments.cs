﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.ProfitOrderArguments
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

namespace ATPlatform.Common.Utils
{
  public struct ProfitOrderArguments
  {
    public ProfitOrderArguments(bool isBuy, double openPrice, double closePrice, double lots)
    {
      this.IsBuy = isBuy;
      this.OpenPrice = openPrice;
      this.ClosePrice = closePrice;
      this.Lots = lots;
    }

    public bool IsBuy { get; }

    public double OpenPrice { get; }

    public double ClosePrice { get; }

    public double Lots { get; }
  }
}
