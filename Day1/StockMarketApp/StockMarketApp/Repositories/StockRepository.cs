using System.Collections.Generic;
using StockMarketApp.Models;

namespace StockMarketApp.Repositories
{
    public class StockRepository
    {
        public IList<Stock> GetAll()
        {
            return new List<Stock>
            {
                new Stock {Name = "Tata Motors", Price = 400, LastPrice = 230},
                new Stock {Name = "Yahoo Inc", Price = 123.0, LastPrice = 125.0},
                new Stock {Name = "Google", Price = 340, LastPrice = 400},
                new Stock {Name = "Delta", Price = 1400, LastPrice = 1000}
            };
        }
    }
}