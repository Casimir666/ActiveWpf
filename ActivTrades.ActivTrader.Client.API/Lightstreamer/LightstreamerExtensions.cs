// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.LightstreamerExtensions
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.Common.Utils.Logging;
using ATPlatform.IDL;
using ATPlatform.Messages;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Lightstreamer
{
  public static class LightstreamerExtensions
  {
    private const OrderTypeProto pendingOrders = OrderTypeProto.BuyLimit | OrderTypeProto.SellLimit | OrderTypeProto.SellStop;
    private const OrderTypeProto marketOrders = OrderTypeProto.Buy | OrderTypeProto.Sell;
    private static readonly List<TaskStatus> activeStatuses = new List<TaskStatus>()
    {
      TaskStatus.Created,
      TaskStatus.Running,
      TaskStatus.WaitingForActivation,
      TaskStatus.WaitingForChildrenToComplete,
      TaskStatus.WaitingToRun
    };

    public static bool TryCastToProto<TProto>(
      this ClientNotification clientNotification,
      out TProto proto)
      where TProto : IMessage
    {
      int num = clientNotification.Message is TProto ? 1 : 0;
      if (num != 0)
      {
        proto = (TProto) clientNotification.Message;
        return num != 0;
      }
      proto = default (TProto);
      return num != 0;
    }

    public static string ToJson(this LsMessage lsMessage) => JsonConvert.SerializeObject((object) lsMessage, Formatting.None, new JsonSerializerSettings()
    {
      NullValueHandling = NullValueHandling.Ignore
    });

    public static T FromJson<T>(this LsMessage lsMessage) where T : IMessage, new() => JsonParser.Default.Parse<T>(lsMessage.Body);

    public static ClientNotification ParseNotification(this LsMessage lsMessage)
    {
      IMessage message = (IMessage) null;
      if (!string.IsNullOrEmpty(lsMessage.Body))
      {
        MessageDescriptor descriptor;
        if (!MessagesDescriptors.TryGetValueForAccount(lsMessage.Type, out descriptor))
          return (ClientNotification) null;
        message = ApplicationSettings.IsBinaryFromatNotifications ? descriptor.Parser.ParseFrom(Convert.FromBase64String(lsMessage.Body)) : descriptor.Parser.ParseJson(lsMessage.Body);
      }
      ClientNotification clientNotification = new ClientNotification();
      clientNotification.Type = lsMessage.Type;
      clientNotification.Message = message;
      clientNotification.RequestId = lsMessage.LsRequestId;
      clientNotification.CategoryId = lsMessage.CategoryId;
      return clientNotification;
    }

    public static void CancelAllTasks<T>(
      this ConcurrentDictionary<int, TaskCompletionSource<T>> map,
      ILogger logger)
    {
      foreach (int key in (IEnumerable<int>) map.Keys)
      {
        try
        {
          TaskCompletionSource<T> completionSource;
          if (map.TryRemove(key, out completionSource))
          {
            if (completionSource.Task.IsWaitingOrRunning<T>() && completionSource.TrySetCanceled())
              logger?.DebugFormat("Task {0} cancelled", (object) key);
            else
              logger?.WarnFormat("Unable to cancel task {0}", (object) key);
          }
          else
            logger?.ErrorFormat("Unable to remove task {0}", (object) key);
        }
        catch (Exception ex)
        {
          logger?.Error((object) ex);
        }
      }
    }

    public static void CancelAllTasks<T>(
      this ConcurrentDictionary<int, Tuple<TaskCompletionSource<T>, CancellationTokenSource>> map,
      ILogger logger)
    {
      foreach (int key in (IEnumerable<int>) map.Keys)
      {
        try
        {
          Tuple<TaskCompletionSource<T>, CancellationTokenSource> tuple;
          if (map.TryRemove(key, out tuple))
          {
            if (tuple.Item1.Task.IsWaitingOrRunning<T>() && tuple.Item1.TrySetCanceled())
              logger?.DebugFormat("Task {0} cancelled", (object) key);
            else
              logger?.WarnFormat("Unable to cancel task {0}", (object) key);
          }
          else
            logger?.ErrorFormat("Unable to remove task {0}", (object) key);
        }
        catch (Exception ex)
        {
          logger?.Error((object) ex);
        }
      }
    }

    public static void CancelAllTasks<T>(
      this ConcurrentDictionary<int, Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>>> map,
      ILogger logger)
    {
      foreach (int key in (IEnumerable<int>) map.Keys)
      {
        try
        {
          Tuple<ClientNotifications, TaskCompletionSource<ClientNotifications>> tuple;
          if (map.TryRemove(key, out tuple))
          {
            if (tuple.Item2.Task.IsWaitingOrRunning<ClientNotifications>() && tuple.Item2.TrySetCanceled())
              logger?.DebugFormat("Task {0} cancelled", (object) key);
            else
              logger?.WarnFormat("Unable to cancel task {0}", (object) key);
          }
          else
            logger?.ErrorFormat("Unable to remove task {0}", (object) key);
        }
        catch (Exception ex)
        {
          logger?.Error((object) ex);
        }
      }
    }

    public static bool IsWaitingOrRunning<TResult>(this Task<TResult> task) => LightstreamerExtensions.activeStatuses.Contains(task.Status);

    public static bool IsPosition(this OrderRequestProto order) => (uint) (order.Type & (OrderTypeProto.Buy | OrderTypeProto.Sell)) > 0U;

    public static bool IsPending(this OrderRequestProto order) => (uint) (order.Type & (OrderTypeProto.BuyLimit | OrderTypeProto.SellLimit | OrderTypeProto.SellStop)) > 0U;

    public static bool IsTrailingStop(this OrderRequestProto order) => order.TrailingStopTier1 > 0.0;

    public static string ToBase64(this IMessage protoMessage) => Convert.ToBase64String(protoMessage.ToByteArray());

    public static LsMessage ToLsMessage(this ClientRequest clientRequest, int requestId)
    {
      LsMessage lsMessage = new LsMessage()
      {
        LsRequestId = requestId,
        TypeId = (int) clientRequest.Type
      };
      if (clientRequest.Message != null)
      {
        if (ApplicationSettings.IsBinaryFromatNotifications)
          lsMessage.Base64Body = clientRequest.Message.ToBase64();
        else
          lsMessage.Body = JsonFormatter.Default.Format(clientRequest.Message);
      }
      return lsMessage;
    }
  }
}
