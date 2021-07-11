using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Binance.Net;

namespace BinanceApi
{
    public class BinanceData
    {
        private static readonly BinanceSocketClient Client = new BinanceSocketClient();

        public static Dictionary<string, double> Cryptos = new Dictionary<string, double>();
        
        public static void Subscribe(string symbol)
        {
            decimal lastPrice = -1;

            Client.FuturesUsdt.SubscribeToBookTickerUpdatesAsync(symbol, data =>
            {
                var price = (data.Data.BestAskPrice + data.Data.BestBidPrice) / 2;

                // for each item in db
                // if above
                // if price > signal: alert
                // remove from db
                
                

            });
        }
    }
}