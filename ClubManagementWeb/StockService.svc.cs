using System;
using System.Collections.Generic;

namespace ClubManagementWeb
{
    public class StockService : IStockService
    {
        private static readonly Dictionary<string, decimal> StockPrices = new Dictionary<string, decimal>
        {
            { "AAPL", 267.50m },
            { "MSFT", 424.75m },
            { "GOOGL", 348.25m },
            { "AMZN", 261.30m },
            { "TSLA", 378.10m }
        };

        public string GetStockPrice(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                return "Please enter a stock symbol.";
            }

            string normalizedSymbol = symbol.Trim().ToUpper();

            if (StockPrices.ContainsKey(normalizedSymbol))
            {
                return normalizedSymbol + " price: $" + StockPrices[normalizedSymbol].ToString("0.00");
            }

            return "Symbol not found. Try AAPL, MSFT, GOOGL, AMZN, or TSLA.";
        }
    }
}