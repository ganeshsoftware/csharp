using System;

public class Stringtest
{

	public static void Main()
	{
	
		string str1 = "krishna";
		string str2;
		str2 = str1;
		
		Console.WriteLine("Str1 value is {0}",str1);
		Console.WriteLine("Str2 value is {0}",str2);
		
		str1 = "Radha";
		str2 = str1;
		Console.WriteLine("Str1 value is {0}",str1);
		Console.WriteLine("Str2 value is {0}",str2);
	}

}