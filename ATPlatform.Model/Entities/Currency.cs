// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Currency
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.ExchangeRates;
using ATPlatform.Model.Contracts;

namespace ATPlatform.Model.Entities
{
  public class Currency : 
    IModel<Currency, string>,
    ICloneable<Currency>,
    IUpdatable<Currency>,
    IEquatable<Currency>,
    IIdentify<string>,
    IModel,
    ICurrency
  {
    public bool IsPrime { get; set; }

    public string IsoCode { get; set; }

    public Currency Clone()
    {
      Currency currency = new Currency();
      currency.Update(this);
      return currency;
    }

    public void Update(Currency other)
    {
      this.IsoCode = other.IsoCode;
      this.IsPrime = other.IsPrime;
    }

    public bool Equals(Currency other) => this.IsPrime == other.IsPrime && this.IsoCode == other.IsoCode;

    public string GetKey() => this.IsoCode;

    public override string ToString() => this.IsoCode + (this.IsPrime ? "*" : string.Empty);
  }
}
