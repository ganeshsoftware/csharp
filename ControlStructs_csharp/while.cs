using System;

class switch_control
{
	public static void Main()
	{
		Int32 counter = 10;
		
		while(counter>=1)
		{
			Console.WriteLine("{0}",counter);
			counter = counter - 1;
			//--counter;
		}
		
		do
		{
			Console.WriteLine("{0}",counter);
			counter++;
			
		}while(counter<10);
		
		Console.ReadLine();
		
	}
	
}