//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization_Deserialization
{
	[Serializable]                 //System.Runtime.Serialization;
    public class Stock
    {
        public Int32 StockId { get; set; }
        public string StockName { get; set; }
        public double StockSellingPrice { get; set; }
        public double StockBuyingPrice { get; set; }

        
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
					
			//Create a Stock object to be serialized.
			Stock tcs = new Stock(108, "Tata Consultancy services!", 6543.90, 5462.89);
			
			
			/*************************************************************************************   
			 The 'SERIALIZATION PART' and the 'DE-SERIALIZATION PART' are mutually exclusive.
			 Either do serialization or de serialization. Not both at the same time. 
			 Comment the other one when one is active			 
 			**************************************************************************************/

            /*
     		
			//SERIALIZATION PART
			
			// Serialization of Stock Object
			//System.IO;
			FileStream shejalstream = new FileStream("e:\\mimsys.txt", FileMode.Create);
			
			//System.Runtime.Serialization.Formatters.Binary
			BinaryFormatter shejalformatter = new BinaryFormatter();
			
			shejalformatter.Serialize(shejalstream,tcs);
			
			
			//mandatory.
			shejalstream.Close();
            shejalformatter = null;
			*/
			
			
			
			
			
			
			
			// DE - SERIALIZATION PART
			FileStream dilipstream = new FileStream("e:\\mimsys.txt", FileMode.Open);
			
			BinaryFormatter sasiformatter = new BinaryFormatter();
			Stock mystock = (Stock)sasiformatter.Deserialize(dilipstream);          
            System.Console.WriteLine(mystock.DisplayStock());
			
				
			Console.Read();	

			}
			catch (InvalidCastException ex)
			{
				System.Console.WriteLine(ex.ToString());				
			}
			catch (FileNotFoundException ex)
			{
				System.Console.WriteLine("NO FILE!!!!");				
			}

      }
    }
}



