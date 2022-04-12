using System;
using System.Linq;
using System.Collections.Generic;

namespace Mimsys.Lambda
{
	class Program
	{
		public static void Main()
		{
			int[] numbers = { 2, 3, 4, 5 };
			var squaredNumbers = numbers.Select(x => x * x);
			Console.WriteLine(string.Join(" ", squaredNumbers));
		}
		
	}

}



