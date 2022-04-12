/******************************************************************
Definition:
Concurrent dictionary is a "Thread safe dictionary".
*******************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;

public class Stock
{
	public string Symbol{get; set;}
	public decimal Price {get; set;}
}



public class StockScenario
{
	List<Stock> stocks;
	ConcurrentDictionary<string, Stock> _stocksconcdic;
	Dictionary<string, Stock> _stocksdic;
	
	
	// List copied to a "ConcurrentDictionary"
	public void ConcDictImpl()
	{
		
		if (stocks != null)
		{
			stocks = null;
		}
				
		stocks = new List<Stock>()
		{
			new Stock{Symbol="Microsoft", Price= 12.23M},
			new Stock{Symbol="Google", Price= 10.23M},
			new Stock{Symbol="Apple", Price= 11.23M}
		};
		
		_stocksconcdic = new ConcurrentDictionary<string, Stock>();
		
		stocks.ForEach(stock => _stocksconcdic.TryAdd(stock.Symbol,stock));
		
		foreach(var curstock in _stocksconcdic)
		{
			Console.WriteLine(((Stock)curstock.Value).Symbol);
		}
	}


	// List copied to a "Dictionary"
	public void DictImpl()
	{
		
		if (stocks != null)
		{
			stocks = null;
		}
		
		stocks = new List<Stock>()
		{
			new Stock{Symbol="Microsoft", Price= 12.23M},
			new Stock{Symbol="Google", Price= 10.23M},
			new Stock{Symbol="Apple", Price= 11.23M}
		};

		_stocksdic = new Dictionary<string, Stock>();
		stocks.ForEach(stock => _stocksdic.Add(stock.Symbol,stock));
	
		foreach(var curstock in _stocksdic)
		{
			Console.WriteLine(((Stock)curstock.Value).Symbol);
		}
	}
	
	// An arbitrary method that will be used to pre empt. 
	public void Method1()
	{
		for(Int32 counter = 0; counter<=100; counter++)
		{
			Console.WriteLine("We have reached the {0} count",counter);			
		}
	}
}


public static class TestOps
{
	public static void Main()	
	{
		StockScenario mystockscenario = new StockScenario();
				
		Thread thread1 = new Thread(new ThreadStart(mystockscenario.Method1));
		Thread thread2 = new Thread(new ThreadStart(mystockscenario.DictImpl));
		
		Thread thread3 = new Thread(new ThreadStart(mystockscenario.ConcDictImpl));
		
		thread1.Start();
		thread3.Start();
	}
}