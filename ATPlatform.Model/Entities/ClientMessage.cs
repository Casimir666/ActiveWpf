// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.ClientMessage
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums.ClientMessage;
using System;
using System.Text;

namespace ATPlatform.Model.Entities
{
  public class ClientMessage : 
    IModel<ATPlatform.Model.Entities.ClientMessage, int>,
    ICloneable<ATPlatform.Model.Entities.ClientMessage>,
    IUpdatable<ATPlatform.Model.Entities.ClientMessage>,
    Contracts.IEquatable<ATPlatform.Model.Entities.ClientMessage>,
    IIdentify<int>,
    IModel
  {
    public int Id { get; set; }

    public string PlatformId { get; set; }

    public int AccountId { get; set; }

    public ClientMessageImportance Importance { get; set; }

    public ClientMessageCategory Category { get; set; }

    public ClientMessageState State { get; set; }

    public ClientMessageAccountState AccountState { get; set; }

    public DateTime Timestamp { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3} {4}:{5} {6}:{7} {8}:{9} {10}:{11}", (object) "Id", (object) this.Id, (object) "AccountId", (object) this.AccountId, (object) "PlatformId", (object) this.PlatformId, (object) "Importance", (object) this.Importance, (object) "Category", (object) this.Category, (object) "State", (object) this.State));
      stringBuilder.AppendFormat(string.Format("{0}:{1} {2}:{3}", (object) "Timestamp", (object) this.Timestamp, (object) "AccountState", (object) this.AccountState));
      stringBuilder.AppendFormat("Subject:" + this.Subject + " Body:" + this.Body);
      return stringBuilder.ToString();
    }

    public void Update(ATPlatform.Model.Entities.ClientMessage clientMessage)
    {
      this.Id = clientMessage.Id;
      this.AccountId = clientMessage.AccountId;
      this.PlatformId = clientMessage.PlatformId;
      this.Importance = clientMessage.Importance;
      this.Category = clientMessage.Category;
      this.State = clientMessage.State;
      this.AccountState = clientMessage.AccountState;
      this.Timestamp = clientMessage.Timestamp;
      this.Subject = clientMessage.Subject;
      this.Body = clientMessage.Body;
    }

    public ATPlatform.Model.Entities.ClientMessage Clone()
    {
      ATPlatform.Model.Entities.ClientMessage clientMessage = new ATPlatform.Model.Entities.ClientMessage();
      clientMessage.Update(this);
      return clientMessage;
    }

    public bool Equals(ATPlatform.Model.Entities.ClientMessage other) => this.Id == other.Id && this.AccountId == other.AccountId && (this.PlatformId == other.PlatformId && this.Importance == other.Importance) && (this.Category == other.Category && this.State == other.State && (this.AccountState == other.AccountState && this.Timestamp == other.Timestamp)) && this.Subject == other.Subject && this.Body == other.Body;

    public int GetKey() => this.Id;
  }
}
