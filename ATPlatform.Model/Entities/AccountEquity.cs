// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.AccountEquity
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using System;

namespace ATPlatform.Model.Entities
{
  public class AccountEquity : 
    IModel<AccountEquity, int>,
    ICloneable<AccountEquity>,
    IUpdatable<AccountEquity>,
    Contracts.IEquatable<AccountEquity>,
    IIdentify<int>,
    IModel
  {
    public AccountEquity() => this.Timestamp = DateTime.Now.Date;

    public int AccountId { get; set; }

    public double Equity { get; set; }

    public DateTime Timestamp { get; set; }

    public AccountEquity Clone()
    {
      AccountEquity accountEquity = new AccountEquity();
      accountEquity.Update(this);
      return accountEquity;
    }

    public bool Equals(AccountEquity other) => this.AccountId == other.AccountId && this.Timestamp == other.Timestamp && DoubleComparer.AreEqual(this.Equity, other.Equity);

    public int GetKey() => this.AccountId;

    public void Update(AccountEquity other)
    {
      this.AccountId = other.AccountId;
      this.Equity = other.Equity;
      this.Timestamp = other.Timestamp;
    }
  }
}
