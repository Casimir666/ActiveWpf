// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.LightstreamerUtilities
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ATPlatform.Common.Utils.Logging;
using Lightstreamer.DotNet.Client;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ActivTrades.ActivTrader.Lightstreamer
{
  public static class LightstreamerUtilities
  {
    private static readonly string protocolVersionHeaderKey = "protocol-version";
    private static readonly string clientApiMarketDataAllowedSymbolGroupsHeaderKey = "capi-md-sgroups";
    private static readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private static readonly Encoding encoding = Encoding.GetEncoding("ISO-8859-1");

    public static string CurrentProtocolVersion => string.Format("{0}.{1}.{2}", (object) 3, (object) 20, (object) 1);

    public static bool TryConnect(
      CancellationToken cancellationToken,
      string lsHost,
      string accountId,
      string token,
      string adapter,
      string adapterSet,
      int lsReconnectionMaxAttempts,
      TimeSpan lsReconnectInterval,
      IConnectionListener connectionlistener,
      out LSClient lsClient)
    {
      lsClient = new LSClient();
      string adapterId = LightstreamerUtilities.GetAdapterId(adapterSet, adapter);
      ConnectionInfo connectionInfo = new ConnectionInfo()
      {
        Adapter = adapterSet,
        Password = string.Empty,
        User = token,
        PushServerUrl = lsHost,
        ContentLength = 0,
        HttpExtraHeaders = (IDictionary<string, string>) new ConcurrentDictionary<string, string>((IEnumerable<KeyValuePair<string, string>>) new List<KeyValuePair<string, string>>()
        {
          new KeyValuePair<string, string>(LightstreamerUtilities.protocolVersionHeaderKey, LightstreamerUtilities.CurrentProtocolVersion)
        })
      };
      bool flag = false;
      int num = 0;
      LightstreamerUtilities._logger.InfoFormat("{0} {1} connecting", (object) adapterId, (object) accountId);
      while (!flag && !cancellationToken.IsCancellationRequested)
      {
        if (num > lsReconnectionMaxAttempts)
        {
          LightstreamerUtilities._logger.WarnFormat(flag ? "{0} {1} connected" : "{0} {1} connection failed", (object) adapterId, (object) accountId);
          break;
        }
        try
        {
          lsClient.OpenConnection(connectionInfo, connectionlistener);
          flag = true;
          break;
        }
        catch (Exception ex)
        {
          LightstreamerUtilities._logger.Error((object) ("Lightstreamer connect failed for " + accountId + ". " + Environment.NewLine + " Connection info: " + LightstreamerUtilities.PrintConnectionInfo(connectionInfo)), ex);
        }
        if (!flag)
          Thread.Sleep(lsReconnectInterval);
        ++num;
      }
      return flag;
    }

    public static IEnumerable<SubscribedTableKey> Subscribe(
      bool isTrading,
      LSClient lsClient,
      IEnumerable<string> itemsToSubscribe,
      string prefix,
      string adapter,
      IEnumerable<string> fields,
      string subscriptionMode,
      int lsSubscriptionAttempts,
      TimeSpan lsSubscriptionAttemptsInterval,
      IHandyTableListener notificationListener,
      string suffix = "")
    {
      List<SubscribedTableKey> subscribedTableKeyList = new List<SubscribedTableKey>();
      bool flag = false;
      int num = 0;
      string group = string.Join(" ", itemsToSubscribe.Select<string, string>((Func<string, string>) (s =>
      {
        if (!isTrading)
          return prefix + s + suffix;
        return adapter + "." + prefix + s + suffix;
      })).ToArray<string>());
      while (!flag)
      {
        if (num > lsSubscriptionAttempts)
          throw new ApplicationException(string.Format("Subscription for {0} fialed. Number of maximum attemps reached {1}.", (object) group, (object) num));
        try
        {
          LightstreamerUtilities._logger.DebugFormat("subscr begin for {0}", (object) group);
          SubscribedTableKey subscribedTableKey = lsClient.SubscribeTable(new SimpleTableInfo(group, subscriptionMode, string.Join(" ", fields), false)
          {
            DataAdapter = adapter
          }, notificationListener, false);
          subscribedTableKeyList.Add(subscribedTableKey);
          LightstreamerUtilities._logger.Debug((object) ("subscr done for " + group));
          break;
        }
        catch (Exception ex)
        {
          LightstreamerUtilities._logger.Error((object) ("Error on subscribe. Items:" + group), ex);
        }
        if (!flag)
        {
          Thread.Sleep(lsSubscriptionAttemptsInterval);
          ++num;
        }
      }
      return (IEnumerable<SubscribedTableKey>) subscribedTableKeyList;
    }

    public static void Unsubscribe(
      LSClient lsClient,
      IEnumerable<SubscribedTableKey> keys,
      int lsSubscriptionAttempts,
      TimeSpan lsSubscriptionAttemptsInterval)
    {
      if (!(keys is SubscribedTableKey[] subscribedTableKeyArray))
        subscribedTableKeyArray = keys.ToArray<SubscribedTableKey>();
      SubscribedTableKey[] tableKeys = subscribedTableKeyArray;
      string str = string.Join<SubscribedTableKey>(";", ((IEnumerable<SubscribedTableKey>) tableKeys).Select<SubscribedTableKey, SubscribedTableKey>((Func<SubscribedTableKey, SubscribedTableKey>) (s => s)));
      bool flag = false;
      int num = 0;
      while (!flag)
      {
        if (lsSubscriptionAttempts > num)
        {
          try
          {
            LightstreamerUtilities._logger.Info((object) "sunubscr begin for stringToSubscribe");
            lsClient.UnsubscribeTables(tableKeys);
            LightstreamerUtilities._logger.InfoFormat("unsubscr done for {0}", (object) str);
            flag = true;
            break;
          }
          catch (Exception ex)
          {
            LightstreamerUtilities._logger.Error((object) ("Error on unsubscribe. Items:" + str), ex);
          }
          if (!flag)
          {
            Thread.Sleep(lsSubscriptionAttemptsInterval);
            ++num;
          }
        }
        else
          break;
      }
      if (!flag)
        throw new ApplicationException(string.Format("Unsubscription for {0} fialed. Number of maximum attemps reached {1}.", (object) str, (object) num));
    }

    public static void KillSession(string lsHost, string sessionId)
    {
      Uri address = new Uri(lsHost + "lightstreamer/control.txt");
      using (WebClient webClient = new WebClient())
        webClient.UploadStringAsync(address, "POST", "LS_session=" + sessionId + "&LS_op=destroy&LS_cause_code=10");
    }

    public static string GetAdapterId(string adapterSet, string adapter) => adapterSet + "." + adapter;

    public static HashSet<int> GetClientApiMarketDataAllowedSymbolGroups(string lsHost)
    {
      HashSet<int> intSet = new HashSet<int>();
      using (WebClient webClient = new WebClient())
      {
        webClient.DownloadString(lsHost);
        string str1 = webClient.ResponseHeaders.Get(LightstreamerUtilities.clientApiMarketDataAllowedSymbolGroupsHeaderKey);
        if (str1 != null)
        {
          string[] strArray = str1.Split(new string[1]
          {
            ","
          }, StringSplitOptions.RemoveEmptyEntries);
          foreach (string str2 in strArray)
          {
            int result;
            if (int.TryParse(str2.Trim(), out result))
              intSet.Add(result);
          }
          if (strArray.Length != intSet.Count)
            throw new InvalidCastException("Unable to cast value " + str1 + " to symbol groups ids.");
        }
      }
      return intSet;
    }

    public static void ValidateConnectionStatus(bool expectingToBeConnected, bool isConnected)
    {
      if (!expectingToBeConnected & isConnected)
        throw new InvalidOperationException("Lightstreamer client already connected");
      if (expectingToBeConnected && !isConnected)
        throw new InvalidOperationException("Lightstreamer client is not connected.");
    }

    public static int GetInt32(string strByteArray)
    {
      byte[] bytes = LightstreamerUtilities.encoding.GetBytes(strByteArray);
      if (!BitConverter.IsLittleEndian)
        Array.Reverse((Array) bytes);
      return BitConverter.ToInt32(bytes, 0);
    }

    public static long GetInt64(string strByteArray)
    {
      byte[] bytes = LightstreamerUtilities.encoding.GetBytes(strByteArray);
      if (!BitConverter.IsLittleEndian)
        Array.Reverse((Array) bytes);
      return BitConverter.ToInt64(bytes, 0);
    }

    public static byte GetByte(string strByteArray)
    {
      byte[] bytes = LightstreamerUtilities.encoding.GetBytes(strByteArray);
      if (!BitConverter.IsLittleEndian)
        Array.Reverse((Array) bytes);
      return bytes[0];
    }

    public static void ConfigureLightstreamerClientDefaultSettings()
    {
      ServicePointManager.DefaultConnectionLimit = 1000;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      AppDomain.CurrentDomain.SetData("lightstreamer.client.defaultConnectTimeout", (object) 30000);
      AppDomain.CurrentDomain.SetData("lightstreamer.client.defaultReadTimeout", (object) 30000);
    }

    private static string PrintConnectionInfo(ConnectionInfo connectionInfo) => "Host: " + connectionInfo.PushServerUrl + ", " + Environment.NewLine + " User: " + connectionInfo.User + ", " + Environment.NewLine;
  }
}
