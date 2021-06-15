// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Feed.LastTicksFilteredStorage
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ATPlatform.Model.Feed
{
  public class LastTicksFilteredStorage : IFilteredTicksStorage
  {
    public static readonly Tick EmptyTick = new Tick();
    private readonly List<Tick> _ticks;

    public LastTicksFilteredStorage(Symbol symbol)
    {
      this.Symbol = symbol;
      this.Reset();
      this._ticks = new List<Tick>()
      {
        this.Open,
        this.MinBid,
        this.MaxBid,
        this.MinAsk,
        this.MaxAsk,
        this.Close
      };
    }

    public bool IsEmpty { get; private set; }

    public Symbol Symbol { get; }

    public List<Tick> GetAllOrderedByTimestampAndReset()
    {
      if (this.IsEmpty)
        return new List<Tick>();
      List<Tick> list = this._ticks.Distinct<Tick>((IEqualityComparer<Tick>) new LastTicksFilteredStorage.TickComparer()).OrderBy<Tick, DateTime>((Func<Tick, DateTime>) (t => t.TimeStamp)).Select<Tick, Tick>((Func<Tick, Tick>) (t => t.Clone())).ToList<Tick>();
      this.Reset();
      return list;
    }

    public DateTime? Timestamp { get; private set; }

    public Tick Open { get; } = new Tick();

    public Tick Close { get; } = new Tick();

    public Tick MinBid { get; } = new Tick();

    public Tick MaxBid { get; } = new Tick();

    public Tick MinAsk { get; } = new Tick();

    public Tick MaxAsk { get; } = new Tick();

    public void Reset()
    {
      this.Timestamp = new DateTime?();
      this.Open.Update(LastTicksFilteredStorage.EmptyTick);
      this.Close.Update(LastTicksFilteredStorage.EmptyTick);
      this.MinBid.Update(LastTicksFilteredStorage.EmptyTick);
      this.MaxBid.Update(LastTicksFilteredStorage.EmptyTick);
      this.MinAsk.Update(LastTicksFilteredStorage.EmptyTick);
      this.MaxAsk.Update(LastTicksFilteredStorage.EmptyTick);
      this.IsEmpty = true;
    }

    public void Update(Tick newTick)
    {
      if (this.IsEmpty)
      {
        this.Open.Update(newTick);
        this.Close.Update(this.Open);
        this.MinBid.Update(this.Open);
        this.MaxBid.Update(this.Open);
        this.MinAsk.Update(this.Open);
        this.MaxAsk.Update(this.Open);
        this.Timestamp = new DateTime?(newTick.TimeStamp);
        this.IsEmpty = false;
      }
      else
      {
        this.Close.Update(newTick);
        if (newTick.Bid < this.MinBid.Bid)
          this.MinBid.Update(newTick);
        if (newTick.Bid > this.MaxBid.Bid)
          this.MaxBid.Update(newTick);
        if (newTick.Ask < this.MinAsk.Ask)
          this.MinAsk.Update(newTick);
        if (newTick.Ask <= this.MaxAsk.Ask)
          return;
        this.MaxAsk.Update(newTick);
      }
    }

    internal class TickComparer : IEqualityComparer<Tick>
    {
      public bool Equals(Tick x, Tick y) => x != null && x.Ask.ToString((IFormatProvider) CultureInfo.InvariantCulture) == y.Ask.ToString((IFormatProvider) CultureInfo.InvariantCulture) && x.Bid.ToString((IFormatProvider) CultureInfo.InvariantCulture) == y.Bid.ToString((IFormatProvider) CultureInfo.InvariantCulture) && x.SymbolId == y.SymbolId;

      public int GetHashCode(Tick obj) => string.Format("{0}{1}{2}", (object) obj.Ask, (object) obj.Bid, (object) obj.SymbolId).GetHashCode();
    }
  }
}
