using System;
using System.Linq;
using System.Collections.Generic;

namespace Mimsys.Lambda
{
	class Program
	{
		public static void Main()
		{
			System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
			Console.WriteLine(e);
		}
		
	}

}