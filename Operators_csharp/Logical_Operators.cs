using System;


class LogicalOperators
{
	public static void Main()
	{
		Console.WriteLine("***** Logical AND *******");
		Console.WriteLine(0&0);
		Console.WriteLine(0&1);
		Console.WriteLine(1&0);
		Console.WriteLine(1&1);
		Console.WriteLine(51&45);		
			
		
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		
		Console.WriteLine("***** Logical OR *******");
		Console.WriteLine("***** | - pipe operator  *******");
		Console.WriteLine(0|0);
		Console.WriteLine(0|1);
		Console.WriteLine(1|0);
		Console.WriteLine(1|1);

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();

		
		Console.WriteLine("***** Exclusive OR *******");
		Console.WriteLine(0^0);
		Console.WriteLine(0^1);
		Console.WriteLine(1^0);
		Console.WriteLine(1^1);
		
		
		
		
		
		Console.ReadLine();
	}

}