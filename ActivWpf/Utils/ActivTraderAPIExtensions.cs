using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using ActivTrades.ActivTrader.API;
using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.API.Trade;
using ATPlatform.Common.ExchangeRates;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using ATPlatform.Model.Proto;
using Google.Protobuf;

namespace ActivWpf.Utils
{
    static class ActivTraderAPIExtensions
    {
        public static Task PartialCloseMarketOrderAsync(this IActivTraderAPI api, OrderRequest orderRequest)
        {
            var tradeClient = GetTradeClient(api);
            return tradeClient.SendOrderRequestAsync<Order>(MessageTypeProto.PartialCloseOrderRequest, orderRequest.ProtoFromModel());
        }

        public static SymbolTradingData GetSymbolTradingData(this IActivTraderAPI api, string symbol)
        {
            var tradeClient = GetTradeClient(api);
            var symbolTradingData = tradeClient.GetPrivateField<TradeClient, ConcurrentDictionary<string, SymbolTradingData>>("_symbolTradingData");

            if (!symbolTradingData.ContainsKey(symbol))
                throw new ArgumentException("Symbol " + symbol + " not found.");

            return symbolTradingData[symbol];
        }

        public static IExchangeRateService GetExchangeRateService(this IActivTraderAPI api)
        {
            var tradeClient = GetTradeClient(api);
            return tradeClient.GetPrivateField<TradeClient, ExchangeRateService>("_exchangeRateService");
        }

        public static bool IsSellOrder(this OrderType orderType)
        {
            switch (orderType)
            {
                case OrderType.Buy:
                case OrderType.BuyLimit:
                case OrderType.BuyStop:
                    return false;
                case OrderType.Sell:
                case OrderType.SellLimit:
                case OrderType.SellStop:
                    return true;
                default:
                    throw new ArgumentOutOfRangeException(nameof(orderType), orderType, null);
            }
        }

        private static TradeClient GetTradeClient(IActivTraderAPI api) =>
            api.GetPrivateField<ActivTraderAPI, TradeClient>("_tradeChannel");

        private static Task<T> SendOrderRequestAsync<T>(this TradeClient tradeClient, MessageTypeProto type, IMessage request)
            => tradeClient.InvokePrivateAsync<T>("SendOrderRequestAsync", type, request);
    }
}
