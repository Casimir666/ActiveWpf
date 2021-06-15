// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Authentication.Models.Responsedata
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System.Collections.Generic;

namespace ActivTrades.ActivTrader.Authentication.Models
{
  internal class Responsedata
  {
    public string Key { get; set; }

    public string LsMarketDataHost { get; set; }

    public string LsMarketDataAdapterSet { get; set; }

    public string LsMarketDataAdapter { get; set; }

    public string LsTradingHost { get; set; }

    public string LsTradingAdapterSet { get; set; }

    public string LsTradingAdapter { get; set; }

    public List<TradingAccount> TradingAccounts { get; set; }

    public User User { get; set; }
  }
}
