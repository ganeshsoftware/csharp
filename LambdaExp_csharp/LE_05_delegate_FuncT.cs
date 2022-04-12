using System;
using System.Linq;


class Program
{
	public static void Main(string[] args)
	{
		// Func<T1,TResult>

		Func<int, int> square = (x) => x * x;
		Console.WriteLine(square(5));



		Func<int,double,int,double> sample = (a,b,c) =>  ((a+b)*(a-b))*c + c;
		Console.WriteLine(sample(5,2.75,2));	
		
		//36.875
		
	}

}






