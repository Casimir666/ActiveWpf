﻿// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.MarketData.IMarketDataChannel
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Connection;
using System;

namespace ActivTrades.ActivTrader.API.MarketData
{
  public interface IMarketDataChannel : IAPIChannel, IDisposable
  {
    event EventHandler<MarketDataUpdateEventArgs> MarketDataUpdate;
  }
}
