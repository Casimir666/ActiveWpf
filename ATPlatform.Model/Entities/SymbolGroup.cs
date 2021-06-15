// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.SymbolGroup
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;

namespace ATPlatform.Model.Entities
{
  public class SymbolGroup : 
    IModel<SymbolGroup, int>,
    ICloneable<SymbolGroup>,
    IUpdatable<SymbolGroup>,
    IEquatable<SymbolGroup>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int ParentId { get; set; }

    public string ColorHex { get; set; }

    public int Rank { get; set; }

    public bool IsVirtual { get; set; }

    public void Update(SymbolGroup group)
    {
      this.Id = group.Id;
      this.ColorHex = group.ColorHex;
      this.Name = group.Name;
      this.ParentId = group.ParentId;
      this.Rank = group.Rank;
      this.IsVirtual = group.IsVirtual;
    }

    public SymbolGroup Clone()
    {
      SymbolGroup symbolGroup = new SymbolGroup();
      symbolGroup.Update(this);
      return symbolGroup;
    }

    public bool Equals(SymbolGroup other) => this.Id == other.Id && this.ColorHex == other.ColorHex && (this.Name == other.Name && this.ParentId == other.ParentId) && this.Rank == other.Rank && this.IsVirtual == other.IsVirtual;

    public int GetKey() => this.Id;
  }
}
