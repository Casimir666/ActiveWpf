// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Tick
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Feed;
using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using System;

namespace ATPlatform.Model.Entities
{
  public class Tick : ICloneable<Tick>, IUpdatable<Tick>, Contracts.IEquatable<Tick>, ITick
  {
    public string SymbolId { get; set; }

    public int Digits { get; set; }

    public double Bid { get; set; }

    public double Ask { get; set; }

    public DateTime TimeStamp { get; set; }

    public Tick Clone()
    {
      Tick tick = new Tick();
      tick.Update(this);
      return tick;
    }

    public bool Equals(Tick other) => this.SymbolId == other.SymbolId && this.Digits == other.Digits && (DoubleComparer.AreEqual(this.Bid, other.Bid) && DoubleComparer.AreEqual(this.Ask, other.Ask)) && this.TimeStamp == other.TimeStamp;

    public void Update(Tick other)
    {
      this.SymbolId = other.SymbolId;
      this.Digits = other.Digits;
      this.Bid = other.Bid;
      this.Ask = other.Ask;
      this.TimeStamp = other.TimeStamp;
    }

    public override string ToString() => string.Format("{0}:{1};{2}:{3};{4}:{5};{6}:{7}:{8}:{9:MMddyyyyHHmmssfff}", (object) "SymbolId", (object) this.SymbolId, (object) "Digits", (object) this.Digits, (object) "Bid", (object) this.Bid, (object) "Ask", (object) this.Ask, (object) "TimeStamp", (object) this.TimeStamp);
  }
}
