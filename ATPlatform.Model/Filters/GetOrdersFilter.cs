// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Filters.GetOrdersFilter
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Enums.Order;
using System;
using System.Collections.Generic;

namespace ATPlatform.Model.Filters
{
  public class GetOrdersFilter
  {
    public DateTime? CloseStartDate { get; set; }

    public DateTime? CloseEndDate { get; set; }

    public DateTime? OpenStartDate { get; set; }

    public DateTime? OpenEndDate { get; set; }

    public double MinLots { get; set; }

    public double MaxLots { get; set; }

    public List<OrderState> OrderStates { get; set; } = new List<OrderState>();

    public List<string> Symbols { get; set; } = new List<string>();

    public List<int> AccountIds { get; set; } = new List<int>();
  }
}
