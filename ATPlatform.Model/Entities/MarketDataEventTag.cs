// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarketDataEventTag
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Defaults;
using ATPlatform.Model.Contracts;
using System.Text;

namespace ATPlatform.Model.Entities
{
  public class MarketDataEventTag : 
    IModel<MarketDataEventTag, int>,
    ICloneable<MarketDataEventTag>,
    IUpdatable<MarketDataEventTag>,
    IEquatable<MarketDataEventTag>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public int MarketDataEventId { get; set; }

    public TagType Tag { get; set; }

    public string Value { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3}", (object) "Id", (object) this.Id, (object) "MarketDataEventId", (object) this.MarketDataEventId));
      stringBuilder.AppendFormat(string.Format("{0}:{1} ", (object) "Tag", (object) this.Tag));
      stringBuilder.AppendFormat("Value:" + this.Value);
      return stringBuilder.ToString();
    }

    public void Update(MarketDataEventTag tag)
    {
      this.Id = tag.Id;
      this.MarketDataEventId = tag.MarketDataEventId;
      this.Tag = tag.Tag;
      this.Value = tag.Value;
    }

    public MarketDataEventTag Clone()
    {
      MarketDataEventTag marketDataEventTag = new MarketDataEventTag();
      marketDataEventTag.Update(this);
      return marketDataEventTag;
    }

    public bool Equals(MarketDataEventTag other) => this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && this.Tag == other.Tag && this.Value == other.Value;

    public int GetKey() => this.Id;
  }
}
