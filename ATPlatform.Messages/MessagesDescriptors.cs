// Decompiled with JetBrains decompiler
// Type: ATPlatform.Messages.MessagesDescriptors
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using ATPlatform.IDL;
using ATPlatform.IDL.AbuseAlert;
using ATPlatform.IDL.HedgingBridge;
using ATPlatform.IDL.MarketDataEvents;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Messages
{
  public static class MessagesDescriptors
  {
    private static readonly Dictionary<MessageTypeProto, MessageDescriptor> _messagesDescriptors = new Dictionary<MessageTypeProto, MessageDescriptor>();
    private static readonly Dictionary<MessageTypeProto, MessageDescriptor> _messagesForAccountDescriptors;

    static MessagesDescriptors()
    {
      MessagesDescriptors.InitMessageDescriptorsByMessageType();
      MessagesDescriptors.FillCommon();
      MessagesDescriptors.FillToDBProxy();
      MessagesDescriptors.FillFromDBProxy();
      MessagesDescriptors.FillToATServer();
      MessagesDescriptors.FillFromATServer();
      MessagesDescriptors.FillToAbuseAlert();
      MessagesDescriptors.FillFromAbuseAlert();
      MessagesDescriptors.FillHedgingBridge();
      MessagesDescriptors.SupportedMessageTypes = new HashSet<MessageTypeProto>((IEnumerable<MessageTypeProto>) MessagesDescriptors._messagesDescriptors.Keys);
      MessagesDescriptors._messagesForAccountDescriptors = MessagesDescriptors._messagesDescriptors.ToDictionary<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageTypeProto, MessageDescriptor>((Func<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageTypeProto>) (k => k.Key), (Func<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageDescriptor>) (v => v.Value));
      MessagesDescriptors.OverwriteForAccountDescriptors();
    }

    public static HashSet<MessageTypeProto> SupportedMessageTypes { get; }

    public static Dictionary<MessageTypeProto, MessageDescriptor> SupportedMessagesDescriptors => MessagesDescriptors._messagesDescriptors.ToDictionary<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageTypeProto, MessageDescriptor>((Func<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageTypeProto>) (k => k.Key), (Func<KeyValuePair<MessageTypeProto, MessageDescriptor>, MessageDescriptor>) (v => v.Value));

    public static void OverwriteForAccountDescriptors()
    {
      MessagesDescriptors._messagesForAccountDescriptors[MessageTypeProto.UpdateClientMessageNotification] = ClientMessageForAccountNotificationProto.Descriptor;
      MessagesDescriptors._messagesForAccountDescriptors[MessageTypeProto.DeleteClientMessageNotification] = ClientMessageForAccountNotificationProto.Descriptor;
    }

    private static void FillHedgingBridge()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BridgeOrderRequest, BridgeOrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BridgeOrderNotification, BridgeOrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BridgeMarginCheckRequest, BridgeMarginCheckRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BridgeMarginCheckNotification, BridgeMarginCheckNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Level2PriceRequest, Level2PriceRequest.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Level2PriceNotification, Level2PriceNotification.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Level2MarginCheckRequest, Level2MarginCheckRequest.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Level2MarginCheckNotification, Level2MarginCheckNotification.Descriptor);
    }

    public static bool TryGetValue(MessageTypeProto messageType, out MessageDescriptor descriptor) => MessagesDescriptors._messagesDescriptors.TryGetValue(messageType, out descriptor);

    public static MessageParser GetParserOrDefault(MessageTypeProto messageType)
    {
      MessageDescriptor messageDescriptor;
      return MessagesDescriptors._messagesDescriptors.TryGetValue(messageType, out messageDescriptor) ? messageDescriptor.Parser : (MessageParser) null;
    }

    public static bool TryGetValueForAccount(
      MessageTypeProto messageType,
      out MessageDescriptor descriptor)
    {
      return MessagesDescriptors._messagesForAccountDescriptors.TryGetValue(messageType, out descriptor);
    }

    public static MessageParser GetParserOrDefaultForAccount(
      MessageTypeProto messageType)
    {
      MessageDescriptor messageDescriptor;
      return MessagesDescriptors._messagesForAccountDescriptors.TryGetValue(messageType, out messageDescriptor) ? messageDescriptor.Parser : (MessageParser) null;
    }

    private static void FillCommon()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ErrorNotification, ErrorNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.KeepAlive, KeepAliveProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ReloadTradeSettingsForAccountNotification, (MessageDescriptor) null);
    }

    private static void FillToDBProxy()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCountRequest, GetCountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCurrenciesRequest, GetCurrencyRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountsRequest, GetAccountsFilteredRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountClientSessionsRequest, GetClientSessionRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOrdersFilteredRequest, GetOrdersFilteredRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountsWithTradeSummaryPrevdayRequest, GetAccountsTradeSummaryPrevDayRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsTagsRequest, GetSymbolsTagsRequestProto.Descriptor);
    }

    private static void FillFromDBProxy()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCountNotification, GetCountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCurrenciesNotification, GetCurrencyNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountsNotification, GetAccountsFilteredNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountClientSessionsNotification, GetClientSessionNotificationtProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOrdersFilteredNotification, GetOrdersFilteredNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsRequest, GetSymbolsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsNotification, GetSymbolsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountBalanceOperationNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastPricesNotification, GetLastPricesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastTicksNotification, GetLastTicksNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHistoryQuotesNotification, GetHistoryQuotesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountDetailsForAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolTradingSessionsForAccountNotification, GetSymbolTradingSessionsForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClosedOrdersForAccountNotification, GetClosedOrdersForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOpenedOrdersForAccountNotification, GetOpenedOrdersForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountsWithTradeSummaryPrevdayNotification, AccountsTradeSummaryPrevDayNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsTagsNotification, GetSymbolsTagsNotificationProto.Descriptor);
    }

    private static void FillToATServer() => MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ExecuteEndOfDayOperationsRequest, EndOfDayOperationsRequestProto.Descriptor);

    private static void FillFromATServer()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetServerInfoNotification, GetServerInfoNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetServerPublicInfoNotification, GetServerPublicInfoNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAtserverConfigurationNotification, ATServerConfigurationNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ServiceStatusNotification, ServiceStatusNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ReOpenAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloseAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAccountBalanceNotification, UpdateAccountBalanceNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AccountTradeConditionsUpdatedNotification, AccountTradeConditionsUpdatedNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AccountTradeConditionsInitializedNotification, AccountTradeConditionsUpdatedNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAccountEquitiesNotification, AccountEquitiesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloseOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CancelOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.OpenOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ActivateOrderNotification, OrderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSymbolNotification, SymbolNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolNotification, SymbolNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSymbolNotification, SymbolNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSymbolGroupNotification, SymbolGroupNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolGroupNotification, SymbolGroupNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSymbolGroupNotification, SymbolGroupNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTagCategoryNotification, TagCategoryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTagCategoryNotification, TagCategoryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTagCategoryNotification, TagCategoryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTagNotification, TagNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTagNotification, TagNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTagNotification, TagNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateClientSessionForAccountNotification, ClientSessionNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.EndClientSessionForAccountNotification, ClientSessionNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.NewTickNotification, NewTickNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ExposureChangeNotification, ExposureNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateMarkupSettingsSetNotification, MarkupSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTradeSettingsSetNotification, TradeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.MarginRequirementCheckNotification, MarginRequirementCheckNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BarsEditCompleteNotification, BarsEditCompleteProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ExecuteEndOfDayOperationsNotification, EndOfDayOperationsNotificationProto.Descriptor);
    }

    private static void FillToAbuseAlert()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAbuseAlertStatefulAlertsRequest, GetAbuseAlertStatefulAlertsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAbuseAlertRuleSettingsRequest, GetAbuseAlertRulesSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AbuseAlertUpdateRuleSettingRequest, AbuseAlertUpdateRuleSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AbuseAlertUpdateAlertStateRequest, AbuseAlertUpdateAlertStateRequestProto.Descriptor);
    }

    private static void FillFromAbuseAlert()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AbuseAlertUpdateRuleSettingNotification, AbuseAlertUpdateRuleSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AbuseAlertUpdateAlertStateNotification, AbuseAlertUpdateAlertStateNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AbuseAlertNewStatefulAlertNotification, AbuseAlertNewStatefulAlertNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAbuseAlertRuleSettingsNotification, GetAbuseAlertRulesSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAbuseAlertStatefulAlertsNotification, GetAbuseAlertStatefulAlertsNotificationProto.Descriptor);
    }

    private static void InitMessageDescriptorsByMessageType()
    {
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetServerInfoRequest, GetServerInfoRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetServerPublicInfoRequest, GetServerPublicInfoRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ServiceStatusRequest, ServiceStatusRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.OpenOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ActivateOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.PartialCloseOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloseOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CancelOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloseHedgedOrdersRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.NetOrdersRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminOpenOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminActivateOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminPartialCloseOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminCloseOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminCancelOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminUpdateOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminDeleteOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminUpdateClosedOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminReOpenOrderRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminNetOrdersRequest, OrderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.MarginRequirementCheckRequest, MarginRequirementCheckRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAccountBalanceRequest, UpdateAccountBalanceRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AdminDeleteAccountBalanceOperationRequest, UpdateAccountBalanceRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOpenedOrdersForAccountRequest, GetOpenedOrdersForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClosedOrdersForAccountRequest, GetClosedOrdersForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountDetailsForAccountRequest, GetAccountDetailsForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateClientSessionForAccountRequest, ClientSessionRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.EndClientSessionForAccountRequest, ClientSessionRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolTradingSessionsForAccountRequest, GetSymbolTradingSessionsForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsByTradeSetRequest, GetSymbolsByTradeSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsByTradeSetNotification, GetSymbolsByTradeSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetRequest, GetSymbolsMarkupSettingsByMarkupSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsMarkupSettingsByMarkupSetNotification, GetSymbolsMarkupSettingsByMarkupSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsHedgeSettingsByHedgeSetRequest, GetSymbolsHedgeSettingsByHedgeSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsHedgeSettingsByHedgeSetNotification, GetSymbolsHedgeSettingsByHedgeSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastIdRequest, GetLastIdRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastIdNotification, GetLastIdNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOpenedOrdersRequest, GetOpenedOrdersRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOpenedOrdersNotification, GetOpenedOrdersNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOrderExecutionsRequest, GetOrderExecutionsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetOrderExecutionsNotification, GetOrderExecutionsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetExposureRequest, GetExposureRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetExposureNotification, ExposureNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountBalanceOperationRequest, GetAccountBalanceOperationRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountBalanceOperationsFilteredRequest, GetAccountBalanceOperationsFilteredRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountBalanceOperationsFilteredNotification, GetAccountBalanceOperationsFilteredNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHistoryQuotesRequest, GetHistoryQuotesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastPricesRequest, GetLastPricesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLastTicksRequest, GetLastTicksRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetBarsRequest, BarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetBarsNotification, BarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloneBarsRequest, CloneBarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloneBarsNotification, BarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.FixBarsRequest, BarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.FixBarsNotification, BarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Update1MinBarsRequest, Update1MinBarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.Update1MinBarsNotification, BarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AddOffset1MinBarsRequest, AddOffset1MinBarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AddOffset1MinBarsNotification, BarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.BarsEditCompleteRequest, BarsEditCompleteProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.NewTickRequest, NewTickRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.InsertCurrentQuotesNotification, CurrentQuotesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTrailingStopsNotification, TrailingStopsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTicksRequest, TicksRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTicksNotification, TicksNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ImportDailyBarsRequest, UpdateBarsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ImportDailyBarsNotification, UpdateBarsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolGroupsRequest, GetSymbolGroupsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolGroupsNotification, GetSymbolGroupsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSymbolGroupRequest, SymbolGroupRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolGroupRequest, SymbolGroupRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSymbolGroupRequest, SymbolGroupRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTagCategoriesRequest, GetTagCategoriesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTagCategoriesNotification, GetTagCategoriesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTagsRequest, GetTagsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTagsNotification, GetTagsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTagCategoryRequest, TagCategoryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTagCategoryRequest, TagCategoryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTagCategoryRequest, TagCategoryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTagRequest, TagRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTagRequest, TagRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTagRequest, TagRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCommissionGroupsRequest, GetCommissionGroupsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCommissionGroupsNotification, GetCommissionGroupsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateCommissionsGroupRequest, CommissionGroupsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateCommissionsGroupNotification, CommissionGroupsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteCommissionsGroupRequest, CommissionGroupsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteCommissionsGroupNotification, CommissionGroupsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSymbolRequest, SymbolRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolRequest, SymbolRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSymbolRequest, SymbolRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolRequest, SymbolProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolNotification, GetSymbolNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsTradingSessionsRequest, GetSymbolTradingSessionsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsTradingSessionsNotification, GetSymbolsTradingSessionsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsMarginTiersRequest, GetSymbolMarginTiersRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolsMarginTiersNotification, GetSymbolsMarginTiersNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolSpreadsRequest, GetAverageSymbolSpreadRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSymbolSpreadsNotification, GetAverageSymbolSpreadNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolSpreadsRequest, UpdateAverageSymbolSpreadRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSymbolSpreadsNotification, (MessageDescriptor) null);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CloseAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ReOpenAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AnonymizeAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.AnonymizeAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateClosedAccountRequest, AccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateClosedAccountNotification, AccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountStatementRequest, AccountStatementRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAccountStatementNotification, AccountStatementNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.RedoAccountStatementRequest, AccountStatementRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.RedoAccountStatementNotification, AccountStatementNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTradeSettingsSetsRequest, GetTradeSettingsSetsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTradeSettingsSetsNotification, GetTradeSettingsSetsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTradeSettingsSetRequest, TradeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTradeSettingsSetNotification, TradeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTradeSettingsSetRequest, TradeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTradeSettingsSetRequest, TradeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTradeSettingsSetNotification, TradeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarkupSettingsSetsRequest, GetMarkupSettingsSetsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarkupSettingsSetsNotification, GetMarkupSettingsSetsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateMarkupSettingsSetRequest, MarkupSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateMarkupSettingsSetNotification, MarkupSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateMarkupSettingsSetRequest, MarkupSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteMarkupSettingsSetRequest, MarkupSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteMarkupSettingsSetNotification, MarkupSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCommissionSettingsSetRequest, GetCommissionSettingsSetsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCommissionSettingsSetNotification, GetCommissionSettingsSetsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateCommissionSettingsSetRequest, CommissionSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateCommissionSettingsSetNotification, CommissionSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateCommissionSettingsSetRequest, CommissionSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateCommissionSettingsSetNotification, CommissionSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteCommissionSettingsSetRequest, CommissionSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteCommissionSettingsSetNotification, CommissionSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetDynamicLeverageSettingsRequest, GetDynamicLeverageSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetDynamicLeverageSettingsNotification, GetDynamicLeverageSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateDynamicLeverageSettingsRequest, DynamicLeverageSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateDynamicLeverageSettingsNotification, DynamicLeverageSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateDynamicLeverageSettingsRequest, DynamicLeverageSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateDynamicLeverageSettingsNotification, DynamicLeverageSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteDynamicLeverageSettingsRequest, DynamicLeverageSettingsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteDynamicLeverageSettingsNotification, DynamicLeverageSettingsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLeveragesRequest, GetLeverageRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetLeveragesNotification, GetLeverageNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCountriesRequest, GetCountryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetCountriesNotification, GetCountryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAdministratorsRequest, GetAdministratorsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAdministratorsNotification, GetAdministratorsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateAdministratorRequest, AdministratorsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateAdministratorNotification, AdministratorsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAdministratorRequest, AdministratorsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAdministratorNotification, AdministratorsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteAdministratorRequest, AdministratorsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteAdministratorNotification, AdministratorsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetRolesRequest, GetRolesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetRolesNotification, GetRolesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateRoleRequest, RolesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateRoleNotification, RolesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateRoleRequest, RolesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateRoleNotification, RolesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteRoleRequest, RolesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteRoleNotification, RolesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetJournalEntryRequest, GetJournalEntryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetJournalEntryNotification, GetJournalEntryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAtserverConfigurationRequest, GetATServerConfigurationRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetAtserverConfigurationNotification, GetATServerConfigurationNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateAtserverConfigurationRequest, ATServerConfigurationRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetFeedSourcesRequest, GetFeedSourcesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetFeedSourcesNotification, GetFeedSourcesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateFeedSourceRequest, FeedSourceRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateFeedSourceNotification, FeedSourceNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateFeedSourceRequest, FeedSourceRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateFeedSourceNotification, FeedSourceNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteFeedSourceRequest, FeedSourceRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteFeedSourceNotification, FeedSourceNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHedgeSettingsSetsRequest, GetHedgeSettingsSetsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHedgeSettingsSetsNotification, GetHedgeSettingsSetsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateHedgeSettingsSetRequest, HedgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateHedgeSettingsSetNotification, HedgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateHedgeSettingsSetRequest, HedgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateHedgeSettingsSetNotification, HedgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteHedgeSettingsSetRequest, HedgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteHedgeSettingsSetNotification, HedgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHedgeLiquidityProvidersRequest, (MessageDescriptor) null);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetHedgeLiquidityProvidersNotification, GetHedgeLiquidityProviderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateHedgeLiquidityProviderRequest, HedgeLiquidityProviderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateHedgeLiquidityProviderNotification, HedgeLiquidityProviderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateHedgeLiquidityProviderRequest, HedgeLiquidityProviderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateHedgeLiquidityProviderNotification, HedgeLiquidityProviderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteHedgeLiquidityProviderRequest, HedgeLiquidityProviderRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteHedgeLiquidityProviderNotification, HedgeLiquidityProviderNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSmartBridgeSettingsSetsRequest, GetSmartBridgeSettingsSetsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetSmartBridgeSettingsSetsNotification, GetSmartBridgeSettingsSetsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSmartBridgeSettingsSetRequest, SmartBridgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateSmartBridgeSettingsSetNotification, SmartBridgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSmartBridgeSettingsSetRequest, SmartBridgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateSmartBridgeSettingsSetNotification, SmartBridgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSmartBridgeSettingsSetRequest, SmartBridgeSettingsSetRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteSmartBridgeSettingsSetNotification, SmartBridgeSettingsSetNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTenantsRequest, GetTenantsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetTenantsNotification, GetTenantsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTenantRequest, TenantRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateTenantNotification, TenantNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTenantRequest, TenantRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateTenantNotification, TenantNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTenantRequest, TenantRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteTenantNotification, TenantNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesRequest, GetClientMessagesRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesNotification, GetClientMessagesNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessageRequest, ClientMessageRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessageNotification, ClientMessageNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateClientMessageRequest, ClientMessageRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateClientMessageNotification, ClientMessageNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateClientMessageRequest, ClientMessageRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateClientMessageNotification, ClientMessageNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteClientMessageRequest, ClientMessageRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteClientMessageNotification, ClientMessageNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesForAccountRequest, GetClientMessagesForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesForAccountNotification, GetClientMessagesForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesCountForAccountRequest, GetClientMessagesForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesCountForAccountNotification, GetClientMessagesForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesFilteredForAccountRequest, GetClientMessagesFilteredForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesFilteredForAccountNotification, GetClientMessagesForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesFilteredCountForAccountRequest, GetClientMessagesFilteredForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetClientMessagesFilteredCountForAccountNotification, GetClientMessagesForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ClientMessageReadForAccountRequest, ClientMessageReadForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ClientMessageReadForAccountNotification, ClientMessageReadForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ClientMessagesReadForAccountRequest, ClientMessagesReadForAccountRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.ClientMessagesReadForAccountNotification, ClientMessagesReadForAccountNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventsRequest, GetMarketDataEventsRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventsNotification, GetMarketDataEventsNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventRequest, MarketDataEventRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventNotification, MarketDataEventNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateMarketDataEventRequest, MarketDataEventRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.CreateMarketDataEventNotification, MarketDataEventNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateMarketDataEventRequest, MarketDataEventRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.UpdateMarketDataEventNotification, MarketDataEventNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteMarketDataEventRequest, MarketDataEventRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.DeleteMarketDataEventNotification, MarketDataEventNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventHistoryRequest, GetMarketDataEventHistoryRequestProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.GetMarketDataEventHistoryNotification, GetMarketDataEventHistoryNotificationProto.Descriptor);
      MessagesDescriptors._messagesDescriptors.Add(MessageTypeProto.MarketDataEventNotification, MarketDataEventNotificationProto.Descriptor);
    }
  }
}
