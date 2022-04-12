using System;
using System.Text;

class Test
{
	public static void Main()
	{
		string str ="";
		
		StringOps ops = new StringOps();
		
		
		for(Int32 i=5; i>=1; i--)
		{
				str = str + i;
				Console.WriteLine(ops.ReverseTheString(str) + str);
		}
		
		str ="";
			
		for(Int32 i=1; i<=5; i++)
		{
				str = str + i;
				Console.WriteLine(str);
		}
				
	}
}

class StringOps
{
    StringBuilder sb = new StringBuilder();
	public string ReverseTheString(string strsrc)
	{
		for(Int32 counter = 0 ; counter<=strsrc.Length - 1; counter++)
		{
			sb.Append(strsrc[(strsrc.Length - counter - 1)]);
		}
		return sb.ToString();
	}
}
		
		
		
		
		
		