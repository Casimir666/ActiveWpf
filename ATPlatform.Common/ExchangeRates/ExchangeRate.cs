// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ExchangeRates.ExchangeRate
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

namespace ATPlatform.Common.ExchangeRates
{
  public struct ExchangeRate
  {
    public ExchangeRate(double bid, double ask)
    {
      this.Bid = bid;
      this.Ask = ask;
    }

    public double Bid { get; set; }

    public double Ask { get; set; }

    public override string ToString() => string.Format("<->[Bid:{0} Ask:{1}]", (object) this.Bid, (object) this.Ask);
  }
}
