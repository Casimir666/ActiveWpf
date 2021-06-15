// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.CommissionGroup
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;

namespace ATPlatform.Model.Entities
{
  public class CommissionGroup : 
    IModel<CommissionGroup, int>,
    ICloneable<CommissionGroup>,
    IUpdatable<CommissionGroup>,
    IEquatable<CommissionGroup>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public void Update(CommissionGroup group)
    {
      this.Id = group.Id;
      this.Name = group.Name;
    }

    public CommissionGroup Clone()
    {
      CommissionGroup commissionGroup = new CommissionGroup();
      commissionGroup.Update(this);
      return commissionGroup;
    }

    public bool Equals(CommissionGroup other) => this.Id == other.Id && this.Name == other.Name;

    public int GetKey() => this.Id;
  }
}
