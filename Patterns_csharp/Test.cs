using System;
using System.Collections.Generic;



public class Product
{
	public Int32 Iden{get; set;}
	public string Name{get; set;}
	public double Price{get; set;}
	public DateTime Mfg{get; set;}
	public string ImageURL {get; set;}
	public string Description {get; set;}
	
	public Product()
	{
	
	}
	
	public Product(Int32 Iden,string Name,double Price,DateTime Mfg,string ImageURL,string Description)
	{
		this.Iden = Iden;
		this.Name = Name;
		this.Price = Price;
		this.Mfg = Mfg;
		this.ImageURL = ImageURL;
		this.Description = Description;
	}
		
	
}


class Test
{

	public static void Main()
	{
		 List <Product> products = new  List <Product>()
		 {
		  new Product(001, "Laddu", 400.00, DateTime.Now,"image1","Laddus are good for health."),
		  new Product(002, "Boondi", 300.00, DateTime.Now,"image2","Boondis are so yummy.")
		 };
		 
		 foreach(Product p in products)
		 {
			Console.WriteLine(p.Iden);
			Console.WriteLine(p.Name);
			Console.WriteLine(p.Price);
			Console.WriteLine(p.Mfg);
			Console.WriteLine(p.ImageURL);
			Console.WriteLine(p.Description);
		 }
		 
		 
	
	
	
	
	}



}