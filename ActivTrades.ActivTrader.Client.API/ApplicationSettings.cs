// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.ApplicationSettings
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace ActivTrades.ActivTrader
{
  public class ApplicationSettings
  {
    private static string _wpLogin;
    private static string _wpLogout;
    private static string _wpAntForg;
    private static string _wpSwitchAccount;
    private static string _feedAdapterSet;
    private static string _feedPrefix;
    private static string[] _fieldsMarketData;
    private static string _tradeAdapterSet;
    private static string _tradePrefix;
    private static string _tradeNotifyPrefix;
    private static string _clientMessagesNotifyPrefix;
    private static string _marketDataEventsNotifyPrefix;
    private static HashSet<int> _clientMessagesNotifyCategories;
    private static string _preferredLanguage;
    private static string[] _fieldsTrading;
    private static int _feedTimestampDelimiter;
    private static TimeSpan _requestTimeout;
    private static TimeSpan _configurationDataRequestTimeout;
    private static TimeSpan _connectTimeout;
    private static TimeSpan _apiConnectTimeout;
    private static TimeSpan _nextCheckMinTimeout;
    private static TimeSpan _apiConnectRetryInterval;
    private static int _nextCheckTimeoutIntervalBasedOnTimeoutPercentage;
    public static HashSet<int> ClientMessagesNotifyCategories;

    public static string LsTradingMode => "RAW";

    public static string LsFeedMode => "MERGE";

    public static string LsSessionKilledCode => "31";

    public static string WpHost => ConfigurationManager.AppSettings[nameof (WpHost)];

    public static string WpLogin => ApplicationSettings._wpLogin ?? (ApplicationSettings._wpLogin = ConfigurationManager.AppSettings[nameof (WpLogin)] ?? "Account/LoginApi");

    public static string ClientType => "ClientApi";

    public static string WpLogout => ApplicationSettings._wpLogout ?? (ApplicationSettings._wpLogout = ConfigurationManager.AppSettings[nameof (WpLogout)] ?? "Account/Logout");

    public static string WpAntForg => ApplicationSettings._wpAntForg ?? (ApplicationSettings._wpAntForg = ConfigurationManager.AppSettings[nameof (WpAntForg)] ?? "Account/GetForgeryTokenExt");

    public static string WpSwitchAccount => ApplicationSettings._wpSwitchAccount ?? (ApplicationSettings._wpSwitchAccount = ConfigurationManager.AppSettings[nameof (WpSwitchAccount)] ?? "Platform/SwitchAccountMobile");

    public static string RedisCacheEndpoit => ConfigurationManager.AppSettings[nameof (RedisCacheEndpoit)];

    public static string FeedAdapterSet => ApplicationSettings._feedAdapterSet ?? (ApplicationSettings._feedAdapterSet = ConfigurationManager.AppSettings[nameof (FeedAdapterSet)] ?? "ATMarketData");

    public static string FeedAdapter => ConfigurationManager.AppSettings[nameof (FeedAdapter)];

    public static string FeedPrefix => ApplicationSettings._feedPrefix ?? (ApplicationSettings._feedPrefix = ConfigurationManager.AppSettings[nameof (FeedPrefix)] ?? "MDF_");

    public static string[] FieldsMarketData
    {
      get
      {
        string[] fieldsMarketData = ApplicationSettings._fieldsMarketData;
        if (fieldsMarketData != null)
          return fieldsMarketData;
        string[] strArray;
        if (ConfigurationManager.AppSettings["FeedFields"] != null)
          strArray = ConfigurationManager.AppSettings["FeedFields"].Split(new string[1]
          {
            ","
          }, StringSplitOptions.RemoveEmptyEntries);
        else
          strArray = new string[5]
          {
            "ask",
            "bid",
            "symbolID",
            "digits",
            "timestamp"
          };
        ApplicationSettings._fieldsMarketData = strArray;
        return strArray;
      }
    }

    public static int FeedTimestampDelimiter => ApplicationSettings._feedTimestampDelimiter != 0 ? ApplicationSettings._feedTimestampDelimiter : (ApplicationSettings._feedTimestampDelimiter = ConfigurationManager.AppSettings[nameof (FeedTimestampDelimiter)] == null ? 1000 : int.Parse(ConfigurationManager.AppSettings[nameof (FeedTimestampDelimiter)]));

    public static string TradeAdapterSet => ApplicationSettings._tradeAdapterSet ?? (ApplicationSettings._tradeAdapterSet = ConfigurationManager.AppSettings[nameof (TradeAdapterSet)] ?? "ATTrading");

    public static string TradeAdapter => ConfigurationManager.AppSettings[nameof (TradeAdapter)];

    public static string TradePrefix => ApplicationSettings._tradePrefix ?? (ApplicationSettings._tradePrefix = ConfigurationManager.AppSettings[nameof (TradePrefix)] ?? "TR_");

    public static string TradeNotifyPrefix => ApplicationSettings._tradeNotifyPrefix ?? (ApplicationSettings._tradeNotifyPrefix = ConfigurationManager.AppSettings[nameof (TradeNotifyPrefix)] ?? "NTF_TR_");

    public static string ClientMessagesNotifyPrefix => ApplicationSettings._clientMessagesNotifyPrefix ?? (ApplicationSettings._clientMessagesNotifyPrefix = ConfigurationManager.AppSettings[nameof (ClientMessagesNotifyPrefix)] ?? "NTF_CM_");

    public static string PreferredLanguage => ApplicationSettings._preferredLanguage ?? (ApplicationSettings._preferredLanguage = ConfigurationManager.AppSettings[nameof (PreferredLanguage)] ?? "en");

    public static string[] FieldsTrading
    {
      get
      {
        string[] fieldsTrading = ApplicationSettings._fieldsTrading;
        if (fieldsTrading != null)
          return fieldsTrading;
        string[] strArray;
        if (ConfigurationManager.AppSettings["TradeFields"] != null)
          strArray = ConfigurationManager.AppSettings["TradeFields"].Split(new string[1]
          {
            ","
          }, StringSplitOptions.RemoveEmptyEntries);
        else
          strArray = new string[3]
          {
            "LsRequestId",
            "TypeId",
            "Base64Body"
          };
        ApplicationSettings._fieldsTrading = strArray;
        return strArray;
      }
    }

    public static string MarketDataEventsNotifyPrefix => ApplicationSettings._marketDataEventsNotifyPrefix ?? (ApplicationSettings._marketDataEventsNotifyPrefix = ConfigurationManager.AppSettings[nameof (MarketDataEventsNotifyPrefix)] ?? "NTF_ME_");

    public static TimeSpan RequestTimeout => ApplicationSettings._requestTimeout.Ticks != 0L ? ApplicationSettings._requestTimeout : (ApplicationSettings._requestTimeout = ConfigurationManager.AppSettings[nameof (RequestTimeout)] == null ? TimeSpan.FromMilliseconds(10000.0) : TimeSpan.FromMilliseconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (RequestTimeout)])));

    public static TimeSpan ConfigurationDataRequestTimeout => ApplicationSettings._configurationDataRequestTimeout.Ticks != 0L ? ApplicationSettings._configurationDataRequestTimeout : (ApplicationSettings._configurationDataRequestTimeout = ConfigurationManager.AppSettings[nameof (ConfigurationDataRequestTimeout)] == null ? TimeSpan.FromSeconds(20.0) : TimeSpan.FromSeconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (ConfigurationDataRequestTimeout)])));

    public static TimeSpan ApiConnectRetryInterval => ApplicationSettings._apiConnectRetryInterval.Ticks != 0L ? ApplicationSettings._apiConnectRetryInterval : (ApplicationSettings._apiConnectRetryInterval = ApplicationSettings.SetTimeSpanSecondsByRange(10, 3, int.MaxValue, nameof (ApiConnectRetryInterval)));

    public static TimeSpan ConnectTimeout => ApplicationSettings._connectTimeout.Ticks != 0L ? ApplicationSettings._connectTimeout : (ApplicationSettings._connectTimeout = ConfigurationManager.AppSettings[nameof (ConnectTimeout)] == null ? TimeSpan.FromMilliseconds(5000.0) : TimeSpan.FromMilliseconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (ConnectTimeout)])));

    public static TimeSpan ApiConnectTimeout => ApplicationSettings._apiConnectTimeout.Ticks != 0L ? ApplicationSettings._apiConnectTimeout : (ApplicationSettings._apiConnectTimeout = ConfigurationManager.AppSettings[nameof (ApiConnectTimeout)] == null ? TimeSpan.FromMilliseconds(30000.0) : TimeSpan.FromMilliseconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (ApiConnectTimeout)])));

    public static TimeSpan ConfigurationSungleRequestTimeout => TimeSpan.FromMilliseconds(ApplicationSettings.ConfigurationDataRequestTimeout.TotalMilliseconds / 5.0);

    public static int ReconnectionMaxAttempts => 3;

    public static TimeSpan NextCheckMinTimeout => ApplicationSettings._nextCheckMinTimeout.Ticks != 0L ? ApplicationSettings._nextCheckMinTimeout : (ApplicationSettings._nextCheckMinTimeout = ConfigurationManager.AppSettings[nameof (NextCheckMinTimeout)] == null ? TimeSpan.FromMilliseconds(25.0) : TimeSpan.FromMilliseconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (NextCheckMinTimeout)])));

    public static int NextCheckTimeoutIntervalBasedOnTimeoutPercentage => ApplicationSettings._nextCheckTimeoutIntervalBasedOnTimeoutPercentage != 0 ? ApplicationSettings._nextCheckTimeoutIntervalBasedOnTimeoutPercentage : (ApplicationSettings._nextCheckTimeoutIntervalBasedOnTimeoutPercentage = ConfigurationManager.AppSettings[nameof (NextCheckTimeoutIntervalBasedOnTimeoutPercentage)] == null ? 5 : int.Parse(ConfigurationManager.AppSettings[nameof (NextCheckTimeoutIntervalBasedOnTimeoutPercentage)]));

    public static TimeSpan LightstreamerReconnectInterval => TimeSpan.FromMilliseconds(1000.0);

    public static int ServiceStatusCheckMaxAttempts => ConfigurationManager.AppSettings[nameof (ServiceStatusCheckMaxAttempts)] != null ? int.Parse(ConfigurationManager.AppSettings[nameof (ServiceStatusCheckMaxAttempts)]) : 40;

    public static TimeSpan ServiceStatusCheckInterval => ConfigurationManager.AppSettings[nameof (ServiceStatusCheckInterval)] != null ? TimeSpan.FromMilliseconds((double) int.Parse(ConfigurationManager.AppSettings[nameof (ServiceStatusCheckInterval)])) : TimeSpan.FromMilliseconds(500.0);

    public static int SubscriptionMaxAttempts => 20;

    public static TimeSpan SubscriptionAttemptsInterval => TimeSpan.FromMilliseconds(1000.0);

    public static IEnumerable<string> IPAddresses => ((IEnumerable<IPAddress>) Dns.GetHostEntry(Dns.GetHostName()).AddressList).Where<IPAddress>((Func<IPAddress, bool>) (ip => ip.AddressFamily == AddressFamily.InterNetwork)).Select<IPAddress, string>((Func<IPAddress, string>) (ip => ip.ToString()));

    public static bool IsBinaryFromatNotifications => ApplicationSettings.FieldsTrading[2].StartsWith("Base64");

    public static string ProAPITradeSettingsSetFlag => "pro_API";

    private static TimeSpan SetTimeSpanSecondsByRange(
      int defaultValue,
      int minValue,
      int maxValue,
      string applicationSettingsValue)
    {
      if (minValue > maxValue || defaultValue < minValue || defaultValue > maxValue)
        throw new ArgumentException(string.Format("Invalid argument combination. {0}:{1}, {2}:{3} and {4}:{5}.", (object) nameof (defaultValue), (object) defaultValue, (object) nameof (minValue), (object) minValue, (object) nameof (maxValue), (object) maxValue));
      int result = defaultValue;
      if (ConfigurationManager.AppSettings[applicationSettingsValue] != null && int.TryParse(ConfigurationManager.AppSettings[applicationSettingsValue], out result) && (result < minValue || result > maxValue))
        result = defaultValue;
      return TimeSpan.FromSeconds((double) result);
    }

    static ApplicationSettings()
    {
      HashSet<int> intSet1 = ApplicationSettings._clientMessagesNotifyCategories;
      if (intSet1 == null)
      {
        HashSet<int> intSet2;
        if (ConfigurationManager.AppSettings[nameof (ClientMessagesNotifyCategories)] != null)
          intSet2 = new HashSet<int>((IEnumerable<int>) ((IEnumerable<string>) ConfigurationManager.AppSettings[nameof (ClientMessagesNotifyCategories)].Split(new string[1]
          {
            ","
          }, StringSplitOptions.RemoveEmptyEntries)).Select<string, int>((Func<string, int>) (c => int.Parse(c))).ToList<int>());
        else
          intSet2 = new HashSet<int>((IEnumerable<int>) new int[3]
          {
            1,
            2,
            3
          });
        ApplicationSettings._clientMessagesNotifyCategories = intSet2;
        intSet1 = intSet2;
      }
      ApplicationSettings.ClientMessagesNotifyCategories = intSet1;
    }
  }
}
