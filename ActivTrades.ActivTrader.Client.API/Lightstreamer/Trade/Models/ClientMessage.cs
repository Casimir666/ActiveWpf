// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.Models.ClientMessage
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.IDL;
using Google.Protobuf;
using System;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade.Models
{
  public class ClientMessage
  {
    public MessageTypeProto Type { get; set; }

    public IMessage Message { get; set; }

    public override string ToString() => string.Format("{0}:{1},{2}{3}:{4}", (object) "Type", (object) this.Type, (object) Environment.NewLine, (object) "Message", (object) JsonFormatter.Default.Format(this.Message));
  }
}
