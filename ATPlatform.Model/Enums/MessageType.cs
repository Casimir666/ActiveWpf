// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Enums.MessageType
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

namespace ATPlatform.Model.Enums
{
  public enum MessageType
  {
    NotSet,
    CreateClientSession,
    GetClientSessions,
    CreateAccount,
    UpdateAccount,
    DeleteAccount,
    CloseAccount,
    ReOpenAccount,
    GetAccounts,
    GetAccountBalanceOperation,
    UpdateAccountBalanceOperaion,
    UpsertAccountTradeSummary,
    UpsertAccountEquity,
    UpsertAccountEquityPrevDay,
    CloseOrder,
    CancelOrder,
    OpenOrder,
    UpdateOrder,
    DeleteOrder,
    ActivateOrder,
    GetOrders,
    CreateSymbol,
    UpdateSymbol,
    DeleteSymbol,
    GetSymbols,
    CreateSymbolGroup,
    UpdateSymbolGroup,
    DeleteSymbolGroup,
    GetSymbolsGroups,
    CreateCommissionsGroup,
    DeleteCommissionsGroup,
    GetCommissionsGroups,
    CreateTradeSettingsSet,
    UpdateTradeSettingsSet,
    DeleteTradeSettingsSet,
    GetTradeSettingsSets,
    CreateMarkupSettingsSet,
    UpdateMarkupSettingsSet,
    DeleteMarkupSettingsSet,
    GetMarkupSettingsSets,
    Tick,
    CreateClientMessage,
    UpdateClientMessage,
    DeleteClientMessage,
    GetClientMessage,
    GetClientMessages,
  }
}
