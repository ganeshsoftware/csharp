using System;
using System.Linq;
// using System.Collections.ObjectModel.ObservableCollection;

class Program
{
	public static void Main()
	{
		
			//1 - Lambda expression with empty arguments.
			Action line = () => Console.WriteLine("Line Break");
			line();
			
			
			//2 - Func<T1,TResult> Lambda expression which calcuates a cube. 
			Func<double, double> cube = x => x * x * x;
			Console.WriteLine("The cube of {0} is {1}",3,cube(3));
			
			
			//3 -Func<T1,T2, TResult>  where TResult is a bool.
			Func<int, int, bool> testForEquality = (x, y) => x == y;
			Console.WriteLine("{0} is equal to {1} is {2}",5,6,testForEquality(5,6));
			
			
			//4 -Func<T1,T2, TResult>  where TResult is a bool. EXPLICIT mention of TYPES in the PARAMETERS.
			Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
			Console.WriteLine("Sentence '{0}' being longer than {1} is {2}","This is a beautiful planet!",40,isTooLong(40,"This is a beautiful planet!"));
			
			//5 - Expression Tree extraction and display.
			System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
			Console.WriteLine(e);
			
			
			
	}
}