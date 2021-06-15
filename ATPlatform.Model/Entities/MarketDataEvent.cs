// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.MarketDataEvent
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums.MarketDataEvent;
using System;
using System.Text;

namespace ATPlatform.Model.Entities
{
  public class MarketDataEvent : 
    IModel<ATPlatform.Model.Entities.MarketDataEvent, int>,
    ICloneable<ATPlatform.Model.Entities.MarketDataEvent>,
    IUpdatable<ATPlatform.Model.Entities.MarketDataEvent>,
    Contracts.IEquatable<ATPlatform.Model.Entities.MarketDataEvent>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public MarketDataEventType Type { get; set; }

    public MarketDataEventState State { get; set; }

    public DateTime Timestamp { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public string Initiator { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3} {4}:{5} {6}:{7}", (object) "Id", (object) this.Id, (object) "Name", (object) this.Name, (object) "Type", (object) this.Type, (object) "State", (object) this.State));
      stringBuilder.AppendFormat(string.Format("{0}:{1} ", (object) "Timestamp", (object) this.Timestamp));
      stringBuilder.AppendFormat("Subject:" + this.Subject + " Body:" + this.Body + " Initiator:" + this.Initiator);
      return stringBuilder.ToString();
    }

    public void Update(ATPlatform.Model.Entities.MarketDataEvent marketDataEvent)
    {
      this.Id = marketDataEvent.Id;
      this.Initiator = marketDataEvent.Initiator;
      this.Name = marketDataEvent.Name;
      this.Type = marketDataEvent.Type;
      this.State = marketDataEvent.State;
      this.Timestamp = marketDataEvent.Timestamp;
      this.Subject = marketDataEvent.Subject;
      this.Body = marketDataEvent.Body;
    }

    public ATPlatform.Model.Entities.MarketDataEvent Clone()
    {
      ATPlatform.Model.Entities.MarketDataEvent marketDataEvent = new ATPlatform.Model.Entities.MarketDataEvent();
      marketDataEvent.Update(this);
      return marketDataEvent;
    }

    public bool Equals(ATPlatform.Model.Entities.MarketDataEvent other) => this.Id == other.Id && this.Initiator == other.Initiator && (this.Name == other.Name && this.Type == other.Type) && (this.State == other.State && this.Timestamp == other.Timestamp && this.Subject == other.Subject) && this.Body == other.Body;

    public int GetKey() => this.Id;
  }
}
