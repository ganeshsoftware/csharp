using System;


class Test
{
	public static void Main()
	{
		try
		{
		Int32 k = 100;
		Int32 m = 0;
	
		Int32 result = k/m;
		Console.WriteLine(result);
		}
		catch (Exception)
		{
			Console.WriteLine("index is out of range!");			
		}
	}
}