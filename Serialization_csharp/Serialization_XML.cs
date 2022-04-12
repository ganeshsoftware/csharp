using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Xml;
using System.Xml.Serialization;

namespace Serialization_Deserialization
{	
	[Serializable]   //System.Runtime.Serialization;
    public class Stock
    {
        public Int32 StockId { get; set; }
        public string StockName { get; set; }
        public double StockSellingPrice { get; set; }
        public double StockBuyingPrice { get; set; }

		public Stock()
		{
						
		}
        
		public Stock(Int32 id, string name, double sellprice, double buyprice)
        {
            this.StockId = id;
            this.StockName = name;
            this.StockBuyingPrice = buyprice;
            this.StockSellingPrice = sellprice;
        }
        public string DisplayStock()
        {
            return StockId + "  |  " + StockName + "  |  " + StockBuyingPrice + "  |  " + StockSellingPrice;
        }
    }
 	
	class Program
    {
		static void Main(string[] args)
        {
			try
			{
				
				// XML - SERIALIZATION PART			
				//Create a Stock object to be serialized.
				Stock tcs = new Stock(108, "Tata Consultancy services!", 6543.90, 5462.89);


				XmlSerializer xmlserializer	= new XmlSerializer(typeof(Stock));

				
				FileStream strwriter = new FileStream("e:\\mimsys.xml", FileMode.Create);
				xmlserializer.Serialize(strwriter,tcs);
				strwriter.Close();
				xmlserializer = null;
				
				
	
                Stock mystock = new Stock();
			    FileStream strwriter = new FileStream("e:\\shejal.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Stock));
			    mystock = (Stock)serializer.Deserialize(strwriter); 
                strwriter.Close();				
                Console.WriteLine(mystock.DisplayStock());
				
			}
			catch (InvalidCastException ex)
			{
				Console.WriteLine(ex.ToString());				
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine(ex.ToString());				
			}
			
        }
    }
}
/*
Serialization_XML.cs
Displaying Serialization_XML.cs.
*/