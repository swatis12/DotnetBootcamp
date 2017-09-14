using Microsoft.AspNetCore.Mvc;
using StockMarketApp.Repositories;

namespace StockMarketApp.Controllers
{
    public class StockController : Controller
    {
        private readonly StockRepository _stockRepository;

        public StockController(StockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public ActionResult GetAllStocks()
        {
            var stocks = _stockRepository.GetAll();
            return View("Stock", stocks);
        }
    }
}