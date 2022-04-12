using System;
using System.Collections.Generic;

namespace Ganesh.Utils.Collections
{
	class SortedListBasic
	{
		public static void Main()
		{
			//SortedList of int keys, string values 
			SortedList<int, string> numberNames = new SortedList<int, string>();

			numberNames.Add(10, "Ten");
			numberNames.Add(5, "Five");
			numberNames.Add(3, "Three");
			numberNames.Add(1, "One");
			numberNames.Add(2, "Two");
			numberNames.Add(4, null);

			
			//Creating a SortedList of string keys, string values 
			//using collection-initializer syntax
			SortedList<string,string> cities = new SortedList<string,string>()
            {
              {"Chennai", "India"},
			  {"London", "Britain"},
              {"Paris", "France"},
              {"Amsterdam", "Netherlands"}
            };
			
			Console.WriteLine("---Initial key-values--");

			foreach(KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );

			numberNames.Add(6, "Six");
			
			// Uncomment and see this... you will get duplicate key errors.
			
			//numberNames.Add(2, "Two");
			//numberNames.Add(4, "Four");


			Console.WriteLine("---After adding new key-values--");

			foreach(var kvp in numberNames)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );
	
			
			Console.WriteLine("---Initial key-values--");
			
			foreach(KeyValuePair<string, string> kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );
				
			cities.Add("Tanjore", "India");
			cities.Add("Bengaluru", "India");
			cities.Add("New Delhi", "India");
			cities.Add("Mumbai", "India");
			cities.Add("Kolkatta", "India");

			Console.WriteLine("--- After adding new key-values--");
			
			foreach(KeyValuePair<string, string> kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );			
			
		}
	}	
}