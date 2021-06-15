// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Connect.LightstreamerConnectionSettings
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System.Collections.Generic;

namespace ActivTrades.ActivTrader.Lightstreamer.Connect
{
  internal class LightstreamerConnectionSettings
  {
    internal string ServerHost { get; set; }

    internal string User { get; set; }

    internal string UserKey { get; set; }

    internal string AdapterSet { get; set; }

    internal string Adapter { get; set; }

    internal string Prefix { get; set; }

    internal string NotifyPrefix { get; set; }

    internal string NotifiClientMessagesPerfix { get; set; }

    internal HashSet<int> NotifiClientMessagesCategories { get; set; }

    internal string PreferredLanguage { get; set; }

    internal string NotifiMarketDataEventsPerfix { get; set; }

    internal string[] Fields { get; set; }

    internal int RequestedMaxFrequency { get; set; }

    internal int MaxBandwidth { get; set; }

    internal bool isFormatBinary { get; set; }

    internal string Alias => this.AdapterSet + "." + this.Adapter + "." + this.User;
  }
}
