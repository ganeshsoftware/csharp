using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Linq.ConversionOperators
{
	class Program
	{
	
		public static void Main()
		{
		    double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
 
			var sortedDoubles =
			from d in doubles
			orderby d descending
			select d;
			
			// ToArray to immediately evaluate a sequence into an array.
			var doublesArray = sortedDoubles.ToArray();
 
			Console.WriteLine("Every other double from highest to lowest:");
			for (int d = 0; d < doublesArray.Length; d += 1)
			{
				Console.WriteLine(doublesArray[d]);
			}
		}
	}
}
