using System;
using System.Linq;
using System.Collections.Generic;


public class Customer
{
	public Int32 CustId {get; set;}
	public string CustName {get; set;}
	public string CustCity {get; set;}

	public Customer(Int32 CustId,string CustName,string CustCity)
	{
		this.CustId = CustId;	
		this.CustName = CustName;
		this.CustCity = CustCity;
	}
	
	public Customer()
	{
			
	}
}


public class LinqDemo
{
	
        private static List<Customer> customers = new List<Customer>()
		{
        	new Customer(1,"Ganesh N","Bengaluru"),
			new Customer(2,"Ramesh","Chennai"),
			new Customer(3,"Janakiram","Delhi"),
			new Customer(4,"Dwarakanath","Bengaluru"),
        	new Customer(5,"Jayashree","Bengaluru"),
			new Customer(6,"Rick Allen","New york"),
			new Customer(7,"Bruce Payne","Berlin"),
			new Customer(8,"Chris Sabaian","New Hampshire")
        };

		
		public static void Main()
		{
				
			
			
			
			
			
			// Lambda expression.
			IEnumerable<Customer> customers = LinqDemo.customers.Where(ty => ty.CustName == "Gan");
			
			// query syntax
			IEnumerable<Customer> queryLondonCustomers = from cust in customers
										where cust.CustCity == "New"
										select cust;

			
			// Execution.
			foreach(Customer mycust in queryLondonCustomers)
			{
				Console.WriteLine(mycust.CustId + "  " + mycust.CustName + " " + mycust.CustCity);
			}	

	}
}