// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarkupSettings
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;

namespace ATPlatform.Model.Entities
{
  public class MarkupSettings : 
    ISymbolOrGroupRelated,
    ICloneable<MarkupSettings>,
    IUpdatable<MarkupSettings>,
    IEquatable<MarkupSettings>,
    IIdentify<string>
  {
    public int? SymbolGroupId { get; set; }

    public string SymbolId { get; set; }

    public int AskMarkup { get; set; }

    public int BidMarkup { get; set; }

    public double ConversionRateMarkup { get; set; }

    public int? TagId { get; set; }

    public void Update(MarkupSettings settings)
    {
      this.SymbolGroupId = settings.SymbolGroupId;
      this.SymbolId = settings.SymbolId;
      this.AskMarkup = settings.AskMarkup;
      this.BidMarkup = settings.BidMarkup;
      this.TagId = settings.TagId;
      this.ConversionRateMarkup = settings.ConversionRateMarkup;
    }

    public MarkupSettings Clone()
    {
      MarkupSettings markupSettings = new MarkupSettings();
      markupSettings.Update(this);
      return markupSettings;
    }

    public bool Equals(MarkupSettings other)
    {
      int? symbolGroupId1 = this.SymbolGroupId;
      int? symbolGroupId2 = other.SymbolGroupId;
      if (symbolGroupId1.GetValueOrDefault() == symbolGroupId2.GetValueOrDefault() & symbolGroupId1.HasValue == symbolGroupId2.HasValue && this.SymbolId == other.SymbolId && (this.AskMarkup == other.AskMarkup && this.BidMarkup == other.BidMarkup))
      {
        int? tagId1 = this.TagId;
        int? tagId2 = other.TagId;
        if (tagId1.GetValueOrDefault() == tagId2.GetValueOrDefault() & tagId1.HasValue == tagId2.HasValue)
          return this.ConversionRateMarkup == other.ConversionRateMarkup;
      }
      return false;
    }

    public string GetKey()
    {
      int? symbolGroupId = this.SymbolGroupId;
      ref int? local = ref symbolGroupId;
      string str = local.HasValue ? local.GetValueOrDefault().ToString() : (string) null;
      if (str != null)
        return str;
      return !string.IsNullOrEmpty(this.SymbolId) ? this.SymbolId : (string) null;
    }
  }
}
