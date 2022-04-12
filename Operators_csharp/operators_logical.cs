using System;

class Operators_Logical
{
	public static void Main()
	{
		Int32 A = 65; /* 1000001 */
		Int32 B = 70; /* 1000110 */
		Int32 C = 250; /*          */
		
		
		// AND & Operator. 
		Int32 resAND = A&B;  /* logical AND */
		
		bool result = (!(2<3));
		Console.WriteLine(result);
			
	
		
		
		
		// OR | Operator. 
		Int32 resOR = A|B;
		
		
		// NOT ~ Operator. 
		Int32 resNOT = ~A;
		Int32 resNOT1 = ~B;
		Int32 resNOT2 = ~C;
		
		
		// EX-OR ^ Operator. 
		Int32 resEXOR = A^B;
		
		// Bit Shift A 
		//Int32 resABitShiftRight = A>>
		
		Console.WriteLine("The AND of {0} and {1} is {2}",A,B,resAND);
			
		Console.WriteLine("The OR of {0} and {1} is {2}",A,B,resOR);
		Console.WriteLine("The NOT of {0} is {1}",A,resNOT);
		Console.WriteLine("The NOT of {0} is {1}",B,resNOT1);
		Console.WriteLine("The NOT of {0} is {1}",C,resNOT2);
		Console.WriteLine("The EXOR of {0} and {1} is {2}",A,B,resEXOR);
		//Console.WriteLine("The RIGHT BITSHIFT of {0} is {1}",A,resABitShiftRight);
	}
}