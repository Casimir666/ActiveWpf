// Decompiled with JetBrains decompiler
// Type: ATPlatform.Messages.Helper
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using ATPlatform.IDL;
using System.Collections.Generic;

namespace ATPlatform.Messages
{
  public static class Helper
  {
    private static readonly Dictionary<int, AppIdentityProto> allAppIdentities = Helper.GetAllAppIdentities();

    public static AppIdentityProto GetAppIdentity(byte clientApplicationId) => Helper.allAppIdentities[(int) clientApplicationId];

    private static Dictionary<int, AppIdentityProto> GetAllAppIdentities()
    {
      Dictionary<int, AppIdentityProto> dictionary = new Dictionary<int, AppIdentityProto>((int) byte.MaxValue);
      for (byte clientId = 0; clientId < byte.MaxValue; ++clientId)
        dictionary[(int) clientId] = Helper.MapAppIdentity(clientId);
      return dictionary;
    }

    private static AppIdentityProto MapAppIdentity(byte clientId)
    {
      AppIdentityProto appIdentityProto = AppIdentityProto.UndefinedApp;
      if (clientId < (byte) 10)
        appIdentityProto = AppIdentityProto.AtServer;
      else if (clientId >= (byte) 100 && clientId <= byte.MaxValue)
        appIdentityProto = AppIdentityProto.AtAdmin;
      else if (clientId >= (byte) 10 && clientId < (byte) 20)
        appIdentityProto = AppIdentityProto.LightStreamer;
      else if (clientId >= (byte) 20 && clientId < (byte) 30)
        appIdentityProto = AppIdentityProto.SqlProxy;
      else if (clientId >= (byte) 30 && clientId < (byte) 40)
        appIdentityProto = AppIdentityProto.Journal;
      else if (clientId >= (byte) 40 && clientId < (byte) 49)
        appIdentityProto = AppIdentityProto.HedgingBridge;
      else if (clientId >= (byte) 49 && clientId < (byte) 50)
        appIdentityProto = AppIdentityProto.Level2PriceCalculator;
      else if (clientId >= (byte) 50 && clientId < (byte) 60)
        appIdentityProto = AppIdentityProto.Boats;
      else if (clientId >= (byte) 60 && clientId < (byte) 70)
        appIdentityProto = AppIdentityProto.ExternalServices;
      else if (clientId >= (byte) 70 && clientId < (byte) 74)
        appIdentityProto = AppIdentityProto.ClientMessages;
      else if (clientId >= (byte) 72 && clientId < (byte) 74)
        appIdentityProto = AppIdentityProto.MarketDataEvents;
      else if (clientId >= (byte) 74 && clientId < (byte) 80)
        appIdentityProto = AppIdentityProto.MarketDataEventsClients;
      else if (clientId >= (byte) 80 && clientId < (byte) 100)
        appIdentityProto = AppIdentityProto.ExpertAdvisors;
      return appIdentityProto;
    }
  }
}
