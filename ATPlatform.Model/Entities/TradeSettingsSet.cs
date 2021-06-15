// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.TradeSettingsSet
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Collections.Generic;

namespace ATPlatform.Model.Entities
{
  public class TradeSettingsSet : 
    IModel<TradeSettingsSet, int>,
    ICloneable<TradeSettingsSet>,
    IUpdatable<TradeSettingsSet>,
    IEquatable<TradeSettingsSet>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsTemplate { get; set; }

    public IList<ATPlatform.Model.Entities.TradeSettings> TradeSettings { get; set; }

    public TradeSettingsSet Clone()
    {
      TradeSettingsSet tradeSettingsSet = new TradeSettingsSet();
      tradeSettingsSet.Update(this);
      return tradeSettingsSet;
    }

    public bool Equals(TradeSettingsSet other) => this.Id == other.Id && this.Name == other.Name && this.IsTemplate == other.IsTemplate && this.TradeSettings.AreEqual<ATPlatform.Model.Entities.TradeSettings>((IEnumerable<ATPlatform.Model.Entities.TradeSettings>) other.TradeSettings);

    public int GetKey() => this.Id;

    public void Update(TradeSettingsSet set)
    {
      this.Id = set.Id;
      this.Name = set.Name;
      this.IsTemplate = set.IsTemplate;
      this.TradeSettings = set.TradeSettings;
    }
  }
}
