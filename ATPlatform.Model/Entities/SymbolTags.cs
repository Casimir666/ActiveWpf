// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.SymbolTags
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Collections.Generic;

namespace ATPlatform.Model.Entities
{
  public class SymbolTags : 
    IModel<SymbolTags, string>,
    ICloneable<SymbolTags>,
    IUpdatable<SymbolTags>,
    IEquatable<SymbolTags>,
    IIdentify<string>,
    IModel
  {
    public SymbolTags() => this.TagIds = new List<int>();

    public string SymbolId { get; set; }

    public List<int> TagIds { get; set; }

    public SymbolTags Clone()
    {
      SymbolTags symbolTags = new SymbolTags();
      symbolTags.Update(this);
      return symbolTags;
    }

    public bool Equals(SymbolTags other)
    {
      bool flag = this.SymbolId == other.SymbolId;
      if (flag && this.TagIds.Count == other.TagIds.Count)
      {
        int index = 0;
        foreach (int tagId in this.TagIds)
        {
          if (tagId != other.TagIds[index])
            return false;
          ++index;
        }
      }
      return flag;
    }

    public string GetKey() => this.SymbolId;

    public void Update(SymbolTags other)
    {
      this.SymbolId = other.SymbolId;
      this.TagIds.Clear();
      this.TagIds.AddRange((IEnumerable<int>) other.TagIds);
    }
  }
}
