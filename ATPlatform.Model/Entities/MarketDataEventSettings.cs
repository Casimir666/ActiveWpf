// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarketDataEventSettings
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Text;

namespace ATPlatform.Model.Entities
{
  public class MarketDataEventSettings : 
    IModel<MarketDataEventSettings, int>,
    ICloneable<MarketDataEventSettings>,
    IUpdatable<MarketDataEventSettings>,
    IEquatable<MarketDataEventSettings>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Type { get; set; }

    public string Key { get; set; }

    public string Value { get; set; }

    public string Description { get; set; }

    public int MarketDataEventId { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3} {4}:{5} {6}:{7}", (object) "Id", (object) this.Id, (object) "Type", (object) this.Type, (object) "Key", (object) this.Key, (object) "Value", (object) this.Value));
      return stringBuilder.ToString();
    }

    public void Update(MarketDataEventSettings settings)
    {
      this.Id = settings.Id;
      this.MarketDataEventId = settings.MarketDataEventId;
      this.Type = settings.Type;
      this.Key = settings.Key;
      this.Value = settings.Value;
      this.Description = settings.Description;
    }

    public MarketDataEventSettings Clone()
    {
      MarketDataEventSettings dataEventSettings = new MarketDataEventSettings();
      dataEventSettings.Update(this);
      return dataEventSettings;
    }

    public bool Equals(MarketDataEventSettings other) => this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (this.Type == other.Type && this.Key == other.Key) && this.Value == other.Value && this.Description == other.Description;

    public int GetKey() => this.Id;
  }
}
