﻿// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Authentication.Models.Account
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System;

namespace ActivTrades.ActivTrader.Authentication.Models
{
  public class Account
  {
    public int AccountId { get; set; }

    public Decimal Balance { get; set; }

    public bool IsDemoAccount { get; set; }

    public int Platform { get; set; }

    public int Status { get; set; }

    public string Name { get; set; }
  }
}
