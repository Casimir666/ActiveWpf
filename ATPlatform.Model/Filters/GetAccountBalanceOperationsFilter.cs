// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Filters.GetAccountBalanceOperationsFilter
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Enums;
using System;
using System.Collections.Generic;

namespace ATPlatform.Model.Filters
{
  public class GetAccountBalanceOperationsFilter
  {
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public List<BalanceChangeType> Types { get; set; } = new List<BalanceChangeType>();

    public List<int> AccountIds { get; set; } = new List<int>();

    public List<long> BalanceIds { get; set; } = new List<long>();

    public string Comment { get; set; }
  }
}
