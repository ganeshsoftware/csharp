using System;



class Operators_incrementdecrement
{
	public static void Main()
	{
		double a = 10.345;
		double b = 7.7839;
		
		double resadd, ressub, resmul, resdiv, resmod;
		
		resadd = a+b;
		ressub = a-b;
		resmul = a*b;
		resdiv = a/b;
		resmod = a%b;
		
		Console.WriteLine("The sum of {0} and {1} is {2}",a,b,resadd);
		Console.WriteLine("The difference of {0} and {1} is {2}",a,b,ressub);
		Console.WriteLine("The product of {0} and {1} is {2}",a,b,resmul);
		Console.WriteLine("The quotient of {0} and {1} is {2}",a,b,resdiv);
		Console.WriteLine("The modulus of {0} and {1} is {2}",a,b,resmod);
	}
}