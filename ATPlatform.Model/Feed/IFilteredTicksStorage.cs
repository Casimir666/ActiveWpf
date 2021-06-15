// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Feed.IFilteredTicksStorage
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Entities;
using System;
using System.Collections.Generic;

namespace ATPlatform.Model.Feed
{
  public interface IFilteredTicksStorage
  {
    bool IsEmpty { get; }

    Symbol Symbol { get; }

    List<Tick> GetAllOrderedByTimestampAndReset();

    DateTime? Timestamp { get; }

    Tick Open { get; }

    Tick Close { get; }

    Tick MinBid { get; }

    Tick MaxBid { get; }

    Tick MinAsk { get; }

    Tick MaxAsk { get; }

    void Reset();

    void Update(Tick newTick);
  }
}
