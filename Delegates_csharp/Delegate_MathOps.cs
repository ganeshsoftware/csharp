using System;

public delegate double MathOps(double x);

public static class MathOperations
{
	public static double Square(double a)
	{
		return a * a;
	}
	

	public static double Cube(double a)
	{
		return a * a * a;
	}

	public static double Add(double a, double b)
	{
		return a + b;
	}
	
	public static double Cube1(decimal x)
	{
		return Convert.ToDouble(x * x * x);
	}
	
	
	public static double Cube1(double x)
	{
		return x * x * x;
	}
	
	public static double Someops(double a)
	{
		return a + a;
	}	
}


class Program
{
	public static void Main()
	{

			double result = MathOperations.Square(2.5);
			
			MathOps squareops = new MathOps(MathOperations.Square);
		
			
			MathOps cubeops = new MathOps(MathOperations.Cube);
			MathOps addops = new MathOps(MathOperations.Someops);
			MathOps cube1ops = new MathOps(MathOperations.Cube1);
			
			
			
			squareops_result = squareops(3.738);
			cubeops_result = cubeops(2.5);
			addops_result = addops(8.5839)
			cube1ops_result = cube1ops(9.5373);
			
				
			
			Console.WriteLine("Square of {0} is {1}",3.738,squareops_result);
			Console.WriteLine("Cube of 2.5 is {0}",cubeops_result);
			Console.WriteLine("Addops of of 8.5839 is {0}",addops_result);
			Console.WriteLine("Cubeops1 of of 8.5839 is {0}",cube1ops_result);
			
			
			Console.WriteLine(result);
			
			Console.ReadLine();
	}
}