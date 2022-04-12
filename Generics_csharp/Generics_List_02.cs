using System;
using System.Collections.Generic;

public class Stock
{
	public Int32 StockID {get; set;}
	public string StockName {get; set;}
	public double StockSellingPrice {get; set;}
	public double StockBuyingPrice {get; set;}
	
	public Stock(Int32 Id, string name, double SP, double BP)
	{
		StockID = Id;
		StockName = name;
		StockSellingPrice= SP;
		StockBuyingPrice = BP;
	}
	
	
	public Stock()
	{
		
	}
	
	public override string ToString()
	{
		return "StockID: " + StockID + Environment.NewLine + "StockName: " + StockName + Environment.NewLine + "Stock Selling Price: " +  StockSellingPrice  + Environment.NewLine  + "Stock Buying Price: " + StockBuyingPrice;
	}
	
}


public class Security:Stock
{
	public string SecurityName {get; set;}
	public double SecurityDeposit {get; set;}
			
	public Security(Int32 Id, string name, double SP, double BP)
	{
		StockID = Id;
		StockName = name;
		StockSellingPrice= SP;
		StockBuyingPrice = BP;
	}
	
	public Security(Int32 Id, string name, double SP, double BP,string secname, double amount)
	{
		StockID = Id;
		StockName = name;
		StockSellingPrice= SP;
		StockBuyingPrice = BP;
		SecurityName = 	secname;
		SecurityDeposit = amount;
	}


			
	public override string ToString()
	{
		return "SecurityName: " + SecurityName + Environment.NewLine + "SecurityDeposit: " + SecurityDeposit.ToString();
	}
}


class GenricTest
{
	public static void Main()
	{
		
		//List<T> (T = Stock)
		List<Stock> myStocks = new List<Stock>();	
		
		Stock ibm = new Stock(1,"IBM",100.00,110.00);
		Stock wipro = new Stock(2,"WIPRO",110.00,100.00);
		Security kotak = new Security(1120,"Kotak",1200.78,1786.90);
		
		
		myStocks.Add(ibm);
		myStocks.Add(wipro);
		myStocks.Add((Stock)kotak);
		

		foreach(Stock stk in myStocks)
		{
			Console.WriteLine("------------------------------------------------------------------------------------");			
			Console.WriteLine(stk.ToString());
			Console.WriteLine("------------------------------------------------------------------------------------");			
		}
	}
}


