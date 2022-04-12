using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Linq.OrderingOperators
{
	class Program
	{
		public static void Main()
		{
			string[] words = { "cherry", "apple", "blueberry" };
			
			// orderby to sort a list of words alphabetically.
			var sortedWords =
			from w in words
			orderby w
			select w;
			
			Console.WriteLine("The sorted list of words:");
			foreach (var w in sortedWords)
			{
				Console.WriteLine(w);
			}
		}
	}

}