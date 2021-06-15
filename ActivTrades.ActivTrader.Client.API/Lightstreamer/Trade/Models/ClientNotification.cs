// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.Models.ClientNotification
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using Google.Protobuf;
using System;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade.Models
{
  public class ClientNotification : ClientMessage
  {
    public int RequestId { get; set; }

    public int CategoryId { get; set; }

    public override string ToString()
    {
      object[] objArray = new object[8]
      {
        (object) "RequestId",
        (object) this.RequestId,
        (object) Environment.NewLine,
        (object) "Type",
        (object) this.Type,
        null,
        null,
        null
      };
      string str;
      if (this.CategoryId <= 0)
        str = string.Empty;
      else
        str = string.Format("{0}{1}:{2}{3}", (object) Environment.NewLine, (object) "CategoryId", (object) this.CategoryId, (object) Environment.NewLine);
      objArray[5] = (object) str;
      objArray[6] = (object) "Message";
      objArray[7] = (object) JsonFormatter.Default.Format(this.Message);
      return string.Format("{0}:{1},{2}{3}:{4},{5}{6}:{7}", objArray);
    }
  }
}
