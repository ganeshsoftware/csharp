using System;
using System.Collections.Generic;

namespace Ganesh.Utils.Collections
{
	class DecendingComparer<TKey>: IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return y.CompareTo(x);
		}
	}
		
	
	class SortedListBasic
	{
		public static void Main()
		{

			//Creating a SortedList of string keys, string values using collection-initializer syntax
			SortedList<string,string> cities = new SortedList<string,string>(new DecendingComparer<string>())
            {
              {"Chennai", "India"},
			  {"London", "Britain"},
              {"Paris", "France"},
              {"Amsterdam", "Netherlands"}
			};
			
			/*
			var descendingComparer = Comparer<string>.Create((x, y) => y.CompareTo(x));
        	SortedList<string, string> descSortedList = new SortedList<string, string>(descendingComparer);
			*/
			
		
			
			cities.Add("Tanjore", "India");
			cities.Add("Bengaluru", "India");
			cities.Add("New Delhi", "India");
			cities.Add("Mumbai", "India");
			cities.Add("Kolkatta", "India");
			
			Console.WriteLine("---Initial key-values--");
			Console.WriteLine("-------------------------------");
			foreach(KeyValuePair<string, string> kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );
			
			Console.WriteLine("Count = {0}",cities.Count);
			

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("---Key values post removal of items. --");
			Console.WriteLine("-------------------------------");
			foreach(KeyValuePair<string, string> kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value);
			
			Console.WriteLine("Count = {0}",cities.Count);				
		}
	}	
}