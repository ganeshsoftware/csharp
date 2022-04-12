using System;



class TypeCasting
{
	public static void Main()
	{
		Int32 c = 32453;
		Int64 d = (Int64)c;
		
		Console.WriteLine(d);
		
		Int64 a = 2147483648;
		
		Int32 b = (Int32)a;
		Console.WriteLine(b);		
		
	
	}
}