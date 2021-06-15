using System;
using ActivTrades.ActivTrader.API;
using ActivWpf.Utils;
using ATPlatform.Model.Enums.Order;

namespace ActivWpf.Service
{
    class ProfitInfo
    {
        public string Symbol { get; }
        public OrderType OrderType { get; }
        public double Lots { get; }
        public double OpenPrice { get; }
        public double TakeProfit { get; }
        public double StopLoss { get; }
        public double Gain { get; }
        public double Loss { get; }
        public double ExchangeRate { get; }
        public double RatioRiskReward => Gain / -Loss;

        public ProfitInfo(
            string symbol,
            OrderType orderType,
            double lots, 
            double openPrice, 
            double takeProfit, 
            double stopLoss,
            double gain, 
            double loss,
            double exchangeRate)
        {
            Symbol = symbol;
            OrderType = orderType;
            Lots = lots;
            OpenPrice = openPrice;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            Gain = gain;
            Loss = loss;
            ExchangeRate = exchangeRate;
        }
    }

    class Calculator
    {
        private readonly IActivTraderAPI _api;

        public Calculator(IActivTraderAPI api)
        {
            _api = api;
        }

        public ProfitInfo EstimateProfit(string symbol, OrderType orderType, double lots, double openPrice, double takeProfit, double stopLoss)
        {
            double sign;
            switch (orderType)
            {
                case OrderType.Buy:
                case OrderType.BuyLimit:
                case OrderType.BuyStop:
                    sign = 1;
                    break;
                case OrderType.Sell:
                case OrderType.SellLimit:
                case OrderType.SellStop:
                case OrderType.Balance:
                    sign = -1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(orderType), orderType, null);
            }

            var symbolInfo = _api.GetSymbol(symbol);
            var exchangeRate = _api.GetExchangeRateService().GetRate(symbolInfo.BaseCurrencyIsoCode, symbolInfo.ProfitCurrencyIsoCode);

            return new ProfitInfo(
                symbol,
                orderType,
                lots,
                openPrice,
                takeProfit,
                stopLoss,
                (takeProfit - openPrice) * sign * symbolInfo.ContractSize * lots / exchangeRate.Ask, // TODO : manage ask/bid !
                (openPrice - stopLoss) * sign * symbolInfo.ContractSize * lots / exchangeRate.Ask,
                exchangeRate.Ask);
        }
    }
}
