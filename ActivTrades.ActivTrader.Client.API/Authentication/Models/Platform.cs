// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Authentication.Models.Platform
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System.ComponentModel;

namespace ActivTrades.ActivTrader.Authentication.Models
{
  internal enum Platform
  {
    [Description("MetaTrader 4 Standard")] MT4S = 5,
    [Description("MetaTrader 4 Classic(Interbank)")] MT4I = 6,
    [Description("MetaTrader 4 Demo")] MT4D = 9,
    [Description("UNKNOWN")] UNKNOWN = 10, // 0x0000000A
    [Description("MetaTrader 4 Pro")] MT4P = 12, // 0x0000000C
    [Description("MetaTrader 4 Classic 2")] MT4C2 = 16, // 0x00000010
    [Description("MetaTrader 4 Classic 3")] MT4C3 = 18, // 0x00000012
    [Description("ActivTrader Live")] AT = 19, // 0x00000013
    [Description("ActivTrader Demo")] ATD = 20, // 0x00000014
    [Description("ActivTrader BH")] ATDBH = 21, // 0x00000015
    [Description("ActivTrader")] ActivTrader = 200, // 0x000000C8
    [Description("ActivTrader VAtanasov")] VAtanasov = 201, // 0x000000C9
    [Description("ActivTrader ZKostov")] ZKostov = 202, // 0x000000CA
    [Description("ActivTrader HBojkov")] HBojkov = 203, // 0x000000CB
    [Description("ActivTrader NGamzakov")] NGamzakov = 204, // 0x000000CC
    [Description("ActivTrader EGrigorov")] EGrigorov = 205, // 0x000000CD
    [Description("ActivTrader IShabarkov")] IShabarkov = 206, // 0x000000CE
    [Description("ActivTrader KDaskalov")] KDaskalov = 207, // 0x000000CF
    [Description("ActivTrader DevServer")] DevServer = 208, // 0x000000D0
    [Description("ActivTrader RMehanov")] RMehanov = 209, // 0x000000D1
    [Description("ActivTrader DRachev")] DRachev = 210, // 0x000000D2
    [Description("ActivTrader SDimitrov")] SDimitrov = 211, // 0x000000D3
    [Description("ActivTrader TestServer")] TestServer = 212, // 0x000000D4
    [Description("ActivTrader VSurdolova")] VSurdolova = 213, // 0x000000D5
    [Description("ActivTrader VAtanasov Automation")] VAtanasov_Automation = 301, // 0x0000012D
    [Description("ActivTrader ZKostov Automation")] ZKostov_Automation = 302, // 0x0000012E
    [Description("ActivTrader HBojkov Automation")] HBojkov_Automation = 303, // 0x0000012F
    [Description("ActivTrader NGamzakov Automation")] NGamzakov_Automation = 304, // 0x00000130
    [Description("ActivTrader EGrigorov Automation")] EGrigorov_Automation = 305, // 0x00000131
    [Description("ActivTrader IShabarkov Automation")] IShabarkov_Automation = 306, // 0x00000132
    [Description("ActivTrader KDaskalov Automation")] KDaskalov_Automation = 307, // 0x00000133
    [Description("ActivTrader DevServer Automation")] DevServer_Automation = 308, // 0x00000134
    [Description("ActivTrader RMehanov Automation")] RMehanov_Automation = 309, // 0x00000135
    [Description("ActivTrader DRachev Automation")] DRachev_Automation = 310, // 0x00000136
    [Description("ActivTrader SDimitrov Automation")] SDimitrov_Automation = 311, // 0x00000137
    [Description("ActivTrader VSurdolova Automation")] VSurdolova_Automation = 312, // 0x00000138
  }
}
