// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.AccountBalanceOperation
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums;
using System;

namespace ATPlatform.Model.Entities
{
  public class AccountBalanceOperation : 
    IModel<AccountBalanceOperation, long>,
    ICloneable<AccountBalanceOperation>,
    IUpdatable<AccountBalanceOperation>,
    Contracts.IEquatable<AccountBalanceOperation>,
    IIdentify<long>,
    IModel
  {
    public long Id { get; set; }

    public int AccountId { get; set; }

    public double Amount { get; set; }

    public BalanceChangeType BalanceChangeType { get; set; }

    public DateTime Timestamp { get; set; }

    public string Comment { get; set; }

    public long? InverseOperationId { get; set; }

    public long? ExternalOperationId { get; set; }

    public AccountBalanceOperation Clone()
    {
      AccountBalanceOperation balanceOperation = new AccountBalanceOperation();
      balanceOperation.Update(this);
      return balanceOperation;
    }

    public bool Equals(AccountBalanceOperation other)
    {
      if (this.Id == other.Id && this.AccountId == other.AccountId && (DoubleComparer.AreEqual(this.Amount, other.Amount) && this.BalanceChangeType == other.BalanceChangeType) && (this.Timestamp == other.Timestamp && this.Comment == other.Comment))
      {
        long? inverseOperationId1 = this.InverseOperationId;
        long? inverseOperationId2 = other.InverseOperationId;
        if (inverseOperationId1.GetValueOrDefault() == inverseOperationId2.GetValueOrDefault() & inverseOperationId1.HasValue == inverseOperationId2.HasValue)
        {
          long? externalOperationId1 = this.ExternalOperationId;
          long? externalOperationId2 = other.ExternalOperationId;
          return externalOperationId1.GetValueOrDefault() == externalOperationId2.GetValueOrDefault() & externalOperationId1.HasValue == externalOperationId2.HasValue;
        }
      }
      return false;
    }

    public long GetKey() => this.Id;

    public void Update(AccountBalanceOperation other)
    {
      this.Id = other.Id;
      this.AccountId = other.AccountId;
      this.Amount = other.Amount;
      this.BalanceChangeType = other.BalanceChangeType;
      this.Timestamp = other.Timestamp;
      this.Comment = other.Comment;
      this.InverseOperationId = other.InverseOperationId;
      this.ExternalOperationId = other.ExternalOperationId;
    }
  }
}
