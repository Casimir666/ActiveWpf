// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.Providers.ProtoMapperInitializer
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Filters;
using ATPlatform.Model.Proto.Contracts;
using ATPlatform.Model.Proto.EntityMappings;
using ATPlatform.Model.Proto.FiltersMappings;

namespace ATPlatform.Model.Proto.Providers
{
  internal static class ProtoMapperInitializer
  {
    public static void Initialize(ProtoMapperProvider protoProvider)
    {
      protoProvider.Register<CurrencyProto, Currency>((IProtoMapper<CurrencyProto, Currency>) new CurrencyMapping());
      protoProvider.Register<GetServerInfoNotificationProto, ServerInfo>((IProtoMapper<GetServerInfoNotificationProto, ServerInfo>) new ServerInfoMapping());
      protoProvider.Register<GetServerPublicInfoNotificationProto, ServerPublicInfo>((IProtoMapper<GetServerPublicInfoNotificationProto, ServerPublicInfo>) new ServerPublicInfoMapping());
      protoProvider.Register<ProtocolVersionProto, ProtocolVersion>((IProtoMapper<ProtocolVersionProto, ProtocolVersion>) new ProtocolVersionMapping());
      protoProvider.Register<AccountProto, Account>((IProtoMapper<AccountProto, Account>) new AccountMapping());
      protoProvider.Register<AccountBalanceOperationProto, AccountBalanceOperation>((IProtoMapper<AccountBalanceOperationProto, AccountBalanceOperation>) new AccountBalanceOperationMapping());
      protoProvider.Register<AccountTradeSummaryProto, AccountTradeSummary>((IProtoMapper<AccountTradeSummaryProto, AccountTradeSummary>) new AccountTradeSummaryMapping());
      protoProvider.Register<AccountEquityProto, AccountEquity>((IProtoMapper<AccountEquityProto, AccountEquity>) new AccountEquityMapping());
      protoProvider.Register<ClientSessionProto, ClientSession>((IProtoMapper<ClientSessionProto, ClientSession>) new ClientSessionMapping());
      protoProvider.Register<OrderProto, Order>((IProtoMapper<OrderProto, Order>) new OrderMapping());
      protoProvider.Register<SymbolProto, Symbol>((IProtoMapper<SymbolProto, Symbol>) new SymbolMapping());
      protoProvider.Register<SymbolTradingSessionsProto, SymbolTradingSessions>((IProtoMapper<SymbolTradingSessionsProto, SymbolTradingSessions>) new SymbolTradingSessionsMapping());
      protoProvider.Register<TradingSessionProto, TradingSession>((IProtoMapper<TradingSessionProto, TradingSession>) new TradingSessionMapping());
      protoProvider.Register<OrderRequestProto, OrderRequest>((IProtoMapper<OrderRequestProto, OrderRequest>) new OrderRequestMapping());
      protoProvider.Register<TickProto, Tick>((IProtoMapper<TickProto, Tick>) new TickMapping());
      protoProvider.Register<HistoryQuoteProto, Bar>((IProtoMapper<HistoryQuoteProto, Bar>) new BarMapping());
      protoProvider.Register<ClientMessageForAccountProto, ClientMessage>((IProtoMapper<ClientMessageForAccountProto, ClientMessage>) new ClientMessageMapping());
      protoProvider.Register<ClientMessageForAccountNotificationProto, ClientMessage>((IProtoMapper<ClientMessageForAccountNotificationProto, ClientMessage>) new ClientMessageNotificationMapping());
      protoProvider.Register<MarketDataEventNotificationProto, MarketDataEvent>((IProtoMapper<MarketDataEventNotificationProto, MarketDataEvent>) new MarketDataEventNotificationMapping());
      protoProvider.Register<MarketDataEventSettingsProto, MarketDataEventSettings>((IProtoMapper<MarketDataEventSettingsProto, MarketDataEventSettings>) new MarketDataEventSettingsMapping());
      protoProvider.Register<MarketDataEventTranslationProto, MarketDataEventTranslation>((IProtoMapper<MarketDataEventTranslationProto, MarketDataEventTranslation>) new MarketDataEventTranslationMapping());
      protoProvider.Register<MarketDataEventTagProto, MarketDataEventTag>((IProtoMapper<MarketDataEventTagProto, MarketDataEventTag>) new MarketDataEventTagMapping());
      protoProvider.Register<GetAccountBalanceOperationsFilterProto, GetAccountBalanceOperationsFilter>((IProtoMapper<GetAccountBalanceOperationsFilterProto, GetAccountBalanceOperationsFilter>) new GetAccountBalanceOperationsFilterMapping());
      protoProvider.Register<GetAccountsFilterProto, GetAccountsFilter>((IProtoMapper<GetAccountsFilterProto, GetAccountsFilter>) new GetAccountsFilterMapping());
      protoProvider.Register<GetClientSessionFilterProto, GetClientSessionFilter>((IProtoMapper<GetClientSessionFilterProto, GetClientSessionFilter>) new GetClientSessionFilterMapping());
      protoProvider.Register<GetOrdersFilterProto, GetOrdersFilter>((IProtoMapper<GetOrdersFilterProto, GetOrdersFilter>) new GetOrdersFilterMapping());
      protoProvider.Register<SymbolGroupProto, SymbolGroup>((IProtoMapper<SymbolGroupProto, SymbolGroup>) new SymbolGroupMapping());
      protoProvider.Register<CommissionGroupProto, CommissionGroup>((IProtoMapper<CommissionGroupProto, CommissionGroup>) new CommissionGroupMapping());
      protoProvider.Register<MarkupSettingsProto, MarkupSettings>((IProtoMapper<MarkupSettingsProto, MarkupSettings>) new MarkupSettingsMapping());
      protoProvider.Register<MarkupSettingsSetProto, MarkupSettingsSet>((IProtoMapper<MarkupSettingsSetProto, MarkupSettingsSet>) new MarkupSettingsSetMapping());
      protoProvider.Register<TradeSettingsProto, TradeSettings>((IProtoMapper<TradeSettingsProto, TradeSettings>) new TradeSettingsMapping());
      protoProvider.Register<TradeSettingsSetProto, TradeSettingsSet>((IProtoMapper<TradeSettingsSetProto, TradeSettingsSet>) new TradeSettingsSetMapping());
      protoProvider.Register<SymbolTagsProto, SymbolTags>((IProtoMapper<SymbolTagsProto, SymbolTags>) new SymbolTagsMapping());
    }
  }
}
