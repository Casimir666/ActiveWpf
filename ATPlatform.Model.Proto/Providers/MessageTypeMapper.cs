﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.Providers.MessageTypeMapper
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Enums;
using System.Collections.Generic;

namespace ATPlatform.Model.Proto.Providers
{
  public static class MessageTypeMapper
  {
    private static readonly Dictionary<MessageTypeProto, MessageType> _mapping = new Dictionary<MessageTypeProto, MessageType>()
    {
      {
        MessageTypeProto.CreateClientSessionForAccountNotification,
        MessageType.CreateClientSession
      },
      {
        MessageTypeProto.EndClientSessionForAccountNotification,
        MessageType.CreateClientSession
      },
      {
        MessageTypeProto.GetAccountClientSessionsNotification,
        MessageType.GetClientSessions
      },
      {
        MessageTypeProto.CreateAccountNotification,
        MessageType.CreateAccount
      },
      {
        MessageTypeProto.UpdateAccountNotification,
        MessageType.UpdateAccount
      },
      {
        MessageTypeProto.DeleteAccountNotification,
        MessageType.DeleteAccount
      },
      {
        MessageTypeProto.CloseAccountNotification,
        MessageType.CloseAccount
      },
      {
        MessageTypeProto.ReOpenAccountNotification,
        MessageType.ReOpenAccount
      },
      {
        MessageTypeProto.GetAccountsNotification,
        MessageType.GetAccounts
      },
      {
        MessageTypeProto.GetAccountBalanceOperationNotification,
        MessageType.GetAccountBalanceOperation
      },
      {
        MessageTypeProto.UpdateAccountBalanceNotification,
        MessageType.UpdateAccountBalanceOperaion
      },
      {
        MessageTypeProto.AccountTradeConditionsInitializedNotification,
        MessageType.UpsertAccountTradeSummary
      },
      {
        MessageTypeProto.AccountTradeConditionsUpdatedNotification,
        MessageType.UpsertAccountTradeSummary
      },
      {
        MessageTypeProto.UpdateAccountEquitiesNotification,
        MessageType.UpsertAccountEquity
      },
      {
        MessageTypeProto.CloseOrderNotification,
        MessageType.CloseOrder
      },
      {
        MessageTypeProto.CancelOrderNotification,
        MessageType.CancelOrder
      },
      {
        MessageTypeProto.OpenOrderNotification,
        MessageType.OpenOrder
      },
      {
        MessageTypeProto.UpdateOrderNotification,
        MessageType.UpdateOrder
      },
      {
        MessageTypeProto.DeleteOrderNotification,
        MessageType.DeleteOrder
      },
      {
        MessageTypeProto.ActivateOrderNotification,
        MessageType.ActivateOrder
      },
      {
        MessageTypeProto.GetOrdersFilteredNotification,
        MessageType.GetOrders
      },
      {
        MessageTypeProto.CreateSymbolNotification,
        MessageType.CreateSymbol
      },
      {
        MessageTypeProto.UpdateSymbolNotification,
        MessageType.UpdateSymbol
      },
      {
        MessageTypeProto.DeleteSymbolNotification,
        MessageType.DeleteSymbol
      },
      {
        MessageTypeProto.GetSymbolsNotification,
        MessageType.GetSymbols
      },
      {
        MessageTypeProto.CreateSymbolGroupNotification,
        MessageType.CreateSymbolGroup
      },
      {
        MessageTypeProto.UpdateSymbolGroupNotification,
        MessageType.UpdateSymbolGroup
      },
      {
        MessageTypeProto.DeleteSymbolGroupNotification,
        MessageType.DeleteSymbolGroup
      },
      {
        MessageTypeProto.GetSymbolGroupsNotification,
        MessageType.GetSymbolsGroups
      },
      {
        MessageTypeProto.CreateCommissionsGroupNotification,
        MessageType.CreateCommissionsGroup
      },
      {
        MessageTypeProto.DeleteCommissionsGroupNotification,
        MessageType.DeleteCommissionsGroup
      },
      {
        MessageTypeProto.GetCommissionGroupsNotification,
        MessageType.GetCommissionsGroups
      },
      {
        MessageTypeProto.CreateTradeSettingsSetNotification,
        MessageType.CreateTradeSettingsSet
      },
      {
        MessageTypeProto.UpdateTradeSettingsSetNotification,
        MessageType.UpdateTradeSettingsSet
      },
      {
        MessageTypeProto.DeleteTradeSettingsSetNotification,
        MessageType.DeleteTradeSettingsSet
      },
      {
        MessageTypeProto.GetTradeSettingsSetsNotification,
        MessageType.GetTradeSettingsSets
      },
      {
        MessageTypeProto.CreateMarkupSettingsSetNotification,
        MessageType.CreateMarkupSettingsSet
      },
      {
        MessageTypeProto.UpdateMarkupSettingsSetNotification,
        MessageType.UpdateMarkupSettingsSet
      },
      {
        MessageTypeProto.DeleteMarkupSettingsSetNotification,
        MessageType.DeleteMarkupSettingsSet
      },
      {
        MessageTypeProto.GetMarkupSettingsSetsNotification,
        MessageType.GetMarkupSettingsSets
      },
      {
        MessageTypeProto.NewTickNotification,
        MessageType.Tick
      }
    };

    public static MessageType GetMessageType(MessageTypeProto? messageTypeProto) => !messageTypeProto.HasValue || !MessageTypeMapper._mapping.ContainsKey(messageTypeProto.Value) ? MessageType.NotSet : MessageTypeMapper._mapping[messageTypeProto.Value];
  }
}