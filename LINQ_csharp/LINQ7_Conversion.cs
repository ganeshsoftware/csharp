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
			string[] words = { "cherry", "apple", "blueberry" };

			// ToList() to immediately evaluate a sequence into a List<T>.
			var sortedWords =
				from w in words
				orderby w
				select w;
			var wordList = sortedWords.ToList();

			Console.WriteLine("The sorted word list:");
			foreach (var w in wordList)
			{
				Console.WriteLine(w);
			}
		}
	}
}