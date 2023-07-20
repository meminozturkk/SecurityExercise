using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityExercise.Models
{
	public class StockRepository
	{
		private static StockRepository instance;
		private List<Stock> stocks;

		private StockRepository()
		{
			stocks = new List<Stock>();
		}
		public static StockRepository GetStockRepository()
		{
			if (instance == null)
			{
				instance = new StockRepository();
			}
			return instance;
		}
		public void AddNewStock(Stock stock)
		{
			stocks.Add(stock);
		}
		public IEnumerable<Stock> GetAllStocks()
		{
			return stocks;
		}
		public Stock GetStockByStockCode(string stockCode)
		{
			return stocks.Single(stock => stock.Code == stockCode);
		}
		public void UpdateStock(Stock stockToUpdate)
		{
			Stock stock=  GetStockByStockCode(stockToUpdate.Code);

			if (stock != null)
			{
				stock.Description = stockToUpdate.Description;
				stock.Price = stockToUpdate.Price;
				stock.Quantity = stockToUpdate.Quantity;
				
			}
		}
		public void DeleteStock(Stock stockToDelete)
		{
			Stock stock = GetStockByStockCode(stockToDelete.Code);
			if (stock != null)
				stocks.Remove(stock);

		}

	}
}