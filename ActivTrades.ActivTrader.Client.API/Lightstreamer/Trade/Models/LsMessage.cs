// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.Models.LsMessage
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.IDL;
using Newtonsoft.Json;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade.Models
{
  public class LsMessage
  {
    public string Body { get; set; }

    public string Base64Body { get; set; }

    [JsonIgnore]
    public MessageTypeProto Type => (MessageTypeProto) this.TypeId;

    public int LsRequestId { get; set; }

    public int TypeId { get; set; }

    public int CategoryId { get; set; }
  }
}
