using System;

class fortest
{
	public static void Main()
	{
		
		for(Int32 i=1;i<=10;i=i+2)
		{
			// Action body. 
			Console.WriteLine("{0}- {1} - {2} - {3}",i,i,i,i);			
		}

		
	
		for(Int32 i=10;i>=1;i--)
		{
			Console.WriteLine("{0}",i);			
			
		}
		Console.ReadLine();
		
	}
	
}