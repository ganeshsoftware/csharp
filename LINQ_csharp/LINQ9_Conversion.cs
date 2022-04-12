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
			object[] numbers = { null, 1.2, "two", 3, "four", 5, "six", 7.2 };

            // This sample uses OfType to return only the elements of the array that are of type double.
			var doubles = numbers.OfType<double>();

			Console.WriteLine("Numbers stored as doubles:");
			foreach (var d in doubles)
			{
				Console.WriteLine(d);
			}
		}
	}
}