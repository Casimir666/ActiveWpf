// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.AccountTradeSummary
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using System;

namespace ATPlatform.Model.Entities
{
  public class AccountTradeSummary : 
    IModel<AccountTradeSummary, int>,
    ICloneable<AccountTradeSummary>,
    IUpdatable<AccountTradeSummary>,
    Contracts.IEquatable<AccountTradeSummary>,
    IIdentify<int>,
    IModel
  {
    public double Margin { get; set; }

    public double Balance { get; set; }

    public double Equity { get; set; }

    public int AccountId { get; set; }

    public DateTime Timestamp { get; set; }

    public double MarginLevel => this.Margin <= 0.0 ? 0.0 : this.Equity / this.Margin * 100.0;

    public AccountTradeSummary Clone()
    {
      AccountTradeSummary accountTradeSummary = new AccountTradeSummary();
      accountTradeSummary.Update(this);
      return accountTradeSummary;
    }

    public bool Equals(AccountTradeSummary other) => this.AccountId == other.AccountId && DoubleComparer.AreEqual(this.Margin, other.Margin) && (DoubleComparer.AreEqual(this.Balance, other.Balance) && DoubleComparer.AreEqual(this.Equity, other.Equity)) && this.Timestamp == other.Timestamp;

    public int GetKey() => this.AccountId;

    public void Update(AccountTradeSummary other)
    {
      this.AccountId = other.AccountId;
      this.Margin = other.Margin;
      this.Balance = other.Balance;
      this.Equity = other.Equity;
      this.Timestamp = other.Timestamp;
    }
  }
}
