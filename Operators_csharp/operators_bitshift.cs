using System;

class Operators_bitshift
{
	public static void Main()
	{
		Int32 A = 71;  /*01000111*/
		
		Int32 resultByteLeftShift =  A << 2;
		
		Console.WriteLine("The 2 - STEPS LEFT SHIFT of {0} IS {1}",A,resultByteLeftShift);
		
		Int32 resultByteRightShift =  A >> 2;
		
		Console.WriteLine("The 2 - STEPS RIGHT SHIFT of {0} IS {1}",A,resultByteRightShift);		
	}
}
