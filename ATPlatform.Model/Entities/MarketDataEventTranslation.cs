// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarketDataEventTranslation
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Text;

namespace ATPlatform.Model.Entities
{
  public class MarketDataEventTranslation : 
    IModel<MarketDataEventTranslation, int>,
    ICloneable<MarketDataEventTranslation>,
    IUpdatable<MarketDataEventTranslation>,
    IEquatable<MarketDataEventTranslation>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public int MarketDataEventId { get; set; }

    public string Language { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3} {4}:{5}", (object) "Id", (object) this.Id, (object) "MarketDataEventId", (object) this.MarketDataEventId, (object) "Language", (object) this.Language));
      stringBuilder.AppendFormat("Subject:" + this.Subject + " Body:" + this.Body);
      return stringBuilder.ToString();
    }

    public void Update(MarketDataEventTranslation translation)
    {
      this.Id = translation.Id;
      this.MarketDataEventId = translation.MarketDataEventId;
      this.Language = translation.Language;
      this.Subject = translation.Subject;
      this.Body = translation.Body;
    }

    public MarketDataEventTranslation Clone()
    {
      MarketDataEventTranslation eventTranslation = new MarketDataEventTranslation();
      eventTranslation.Update(this);
      return eventTranslation;
    }

    public bool Equals(MarketDataEventTranslation other) => this.Id == other.Id && this.MarketDataEventId == other.MarketDataEventId && (this.Language == other.Language && this.Subject == other.Subject) && this.Body == other.Body;

    public int GetKey() => this.Id;
  }
}
