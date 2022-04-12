using System;
using Ganesh.Operations.Utils;

class OperationsUsage
{
	public static void Main()
	{
		Operations ops = new Operations();
		
		Console.WriteLine("Please enter the number for which for you want the Square and Cube!");
		Int32 inputnumber = Convert.ToInt32(Console.ReadLine());
		
		double square  = ops.Square(inputnumber);
		double cube  =  ops.Cube(inputnumber);

		Console.WriteLine("The Square of {0} and {1}",inputnumber,square);
		Console.WriteLine("The Cube of {0} and {1}",inputnumber,cube);
	}

}
