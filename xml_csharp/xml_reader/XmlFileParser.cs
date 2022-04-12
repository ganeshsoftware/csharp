using System;
using System.Data;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace Ganesh
{
	public class Product
	{
		public Int32 Id {get; set;}
		public string Name {get; set;}
		public double Price {get; set;}
		
		public override string ToString()
		{
			return this.Id + " " + this.Name + " " + this.Price; 			
		}
	}
	
	public class XmlFileParser
	{
		public List<Product> GetTheCollections()
		{
			XmlDataDocument xmldoc = new XmlDataDocument();
			XmlNodeList xmlnode;
					
			FileStream fs = new FileStream("product.xml",FileMode.Open,FileAccess.Read);
			
			// XmlDataDocument has a method called load which will takein a filestream.
			xmldoc.Load(fs);
			xmlnode = xmldoc.GetElementsByTagName("Product");
			
			Product prd;
			List<Product> myProducts = new List<Product>();
			
			
			for(Int32 i=0; i<= xmlnode.Count -1; i++)
			{
				xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
				prd = new Product();
				prd.Id = Convert.ToInt32(xmlnode[i].ChildNodes.Item(0).InnerText.Trim());
				prd.Name = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
				prd.Price = Convert.ToDouble(xmlnode[i].ChildNodes.Item(2).InnerText.Trim());
				myProducts.Add(prd);
				prd = null;
			};
			
			return myProducts;
		}
	}
	
	public class Test
	{
		public static void Main()
		{
			XmlFileParser xfp = new XmlFileParser();
			
			xfp.GetTheCollections();
			
			foreach(Product prdt in xfp.GetTheCollections())
			{
				Console.WriteLine(prdt.ToString());			
			}
		}
	}
}


