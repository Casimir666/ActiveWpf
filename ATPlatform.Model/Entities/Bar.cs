// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Bar
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System;

namespace ATPlatform.Model.Entities
{
  public class Bar : ICloneable<Bar>, IUpdatable<Bar>, Contracts.IEquatable<Bar>
  {
    public int MinPrice { get; set; }

    public int MaxPrice { get; set; }

    public int StartPrice { get; set; }

    public int EndPrice { get; set; }

    public long CountTicks { get; set; }

    public DateTime Time { get; set; }

    public int EndAskPrice { get; set; }

    public long Timestamp { get; set; }

    public Bar Clone()
    {
      Bar bar = new Bar();
      bar.Update(this);
      return bar;
    }

    public bool Equals(Bar other) => this.Timestamp == other.Timestamp && this.Time == other.Time && (this.CountTicks == other.CountTicks && this.StartPrice == other.StartPrice) && (this.EndPrice == other.EndPrice && this.EndAskPrice == other.EndAskPrice && this.MinPrice == other.MinPrice) && this.MaxPrice == other.MaxPrice;

    public void Update(Bar other)
    {
      this.Time = other.Time;
      this.Timestamp = other.Timestamp;
      this.CountTicks = other.CountTicks;
      this.StartPrice = other.StartPrice;
      this.EndPrice = other.EndPrice;
      this.EndAskPrice = other.EndAskPrice;
      this.MinPrice = other.MinPrice;
      this.MaxPrice = other.MaxPrice;
    }
  }
}
