// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Filters.GetAccountsFilter
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using System;

namespace ATPlatform.Model.Filters
{
  public class GetAccountsFilter
  {
    public int AccountId { get; set; }

    public string CustomerEmail { get; set; }

    public DateTime? FromRegistrationDate { get; set; }

    public DateTime? ToRegistrationDate { get; set; }

    public bool IncludeClosed { get; set; }
  }
}
