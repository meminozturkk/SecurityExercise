using SecurityExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Security.Application;

namespace SecurityExercise.Controllers
{
    public class StockController : Controller
    {
        private StockRepository RepositoryInstance => StockRepository.GetStockRepository();
		// GET: Stock
		public ActionResult Index(string filterName)
        {
			var stocks = RepositoryInstance.GetAllStocks();
			ViewBag.FilterName = string.IsNullOrWhiteSpace(filterName) ? "None" : filterName;
			return View(stocks);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Stock stock)
        {
            if (ModelState.IsValid)
            {
                RepositoryInstance.AddNewStock(stock);
                return View(stock);
            }

            return View(stock);
        }

        public ActionResult Edit(string stockCode) 
        {
            var stockData = RepositoryInstance.GetStockByStockCode(stockCode);
            
            return View(stockData);
        }

        [HttpPost]
        public ActionResult Edit(Stock stock) 
        {
            RepositoryInstance.UpdateStock(stock);
            
            return View(stock);
        }
        [HttpPost]
        public ActionResult Delete(string stockcode)
        {
            var stockData = RepositoryInstance.GetStockByStockCode(stockcode);

            RepositoryInstance.DeleteStock(stockData);

            return View("Index",RepositoryInstance.GetAllStocks());
        }
        
        public ActionResult Detail(string stockCode)
        {
            var stockToShow = RepositoryInstance.GetStockByStockCode(stockCode);

            return View(stockToShow);

		}



    }
}