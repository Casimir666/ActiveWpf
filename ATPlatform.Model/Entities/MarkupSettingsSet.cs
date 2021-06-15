// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarkupSettingsSet
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Collections.Generic;

namespace ATPlatform.Model.Entities
{
  public class MarkupSettingsSet : 
    IModel<MarkupSettingsSet, int>,
    ICloneable<MarkupSettingsSet>,
    IUpdatable<MarkupSettingsSet>,
    IEquatable<MarkupSettingsSet>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsTemplate { get; set; }

    public IList<ATPlatform.Model.Entities.MarkupSettings> MarkupSettings { get; set; }

    public MarkupSettingsSet Clone()
    {
      MarkupSettingsSet markupSettingsSet = new MarkupSettingsSet();
      markupSettingsSet.Update(this);
      return markupSettingsSet;
    }

    public bool Equals(MarkupSettingsSet other) => this.Id == other.Id && this.Name == other.Name && this.IsTemplate == other.IsTemplate && this.MarkupSettings.AreEqual<ATPlatform.Model.Entities.MarkupSettings>((IEnumerable<ATPlatform.Model.Entities.MarkupSettings>) other.MarkupSettings);

    public int GetKey() => this.Id;

    public void Update(MarkupSettingsSet set)
    {
      this.Id = set.Id;
      this.Name = set.Name;
      this.IsTemplate = set.IsTemplate;
      this.MarkupSettings = set.MarkupSettings;
    }
  }
}
