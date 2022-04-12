using System;


namespace Ganesh.SDLC
{
	
	public class Stock
	{
		public Int32 Id {get; set;}
		public string Name {get; set;}

		public double SellingPrice {get; set;}
		public double BuyPrice {get; set;}

		public double DayHigh {get; set;}
		public double DayLow {get; set;}



		public override string ToString()
		{
			return  this.Id + " " + this.Name + " " + this.SellingPrice + " " + this.BuyPrice+ " " + this.DayHigh + " " + this.DayLow;		
		}
	

		/*
		public override System.Type GetType()
		{
			return "Stock";			
		}
		*/

		public override bool Equals(object obj)
		{
			if (this.GetType() != obj.GetType())
			{
				return false;				
			}
			else
			{
				Stock s3 =  new Stock();
				s3 = (Stock)obj;
				if ((this.DayHigh == s3.DayHigh)&&(this.DayLow == s3.DayLow)&&(this.SellingPrice == s3.SellingPrice)&&(this.BuyPrice == s3.BuyPrice))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
				
		}
	
	
		public override Int32 GetHashCode()
		{
			
			Random rnd = new Random();
			return rnd.Next(1,1000);
			
			
		}
	

		
		public Stock()
		{
			
		}
		
		public Stock(Int32 Id, string Named, double bp, double sp, double high, double low)
		{
			this.Id = Id;
			this.Name = Named;
			this.SellingPrice= sp;
			this.BuyPrice= bp;
			this.DayHigh= high;
			this.DayLow= low;
		}
	}


	public class TestStock
	{
		public static void Main()
		{
			Stock s1 = new Stock(108,"IBM",11.35,11.43,11.50,10.34);
			Console.WriteLine(s1.ToString());
			Console.WriteLine(s1.GetType());
			Console.WriteLine(s1.GetHashCode());
			
			Stock s2 = new Stock(109,"Microsoft",11.35,11.43,11.50,10.34);
			
			Console.WriteLine(s2.Equals(s1));
			
			
		}

/*
s1.Equals(object obj) - m
s1.GetType()
s1.GetHashCode()
s1.ToString() - m

s1.Finalize()
*/	
	}
}


