using System;

class TestPyramid
{       

	public static void Main()
	{
		Console.WriteLine("Enter the number of rows you want to get printed!"); 
		Int32 rows = Int32.Parse(Console.ReadLine());
		
		string str="1";
		Console.WriteLine(str);
		str=str +"0";
		Console.WriteLine(str);
		
		for(Int32 counter=0;counter<=rows-2;counter++)
		{
						
			if (str.EndsWith("0"))
			{
				str = str + "1";
			}
			else
			{
				str = str + "0";
			}
			Console.WriteLine(str);						 
		}
	}
}