using System;

class SwitchControl
{
	public static void Main()
	{
		Int32 counter = 10;
		
    	do
		{
			Console.WriteLine("{0}",counter);
			counter++;
			
		}while(counter<10);
		
		Console.ReadLine();
	}
}