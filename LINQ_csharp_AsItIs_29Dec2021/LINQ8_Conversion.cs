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
			    var scoreRecords = new[] 
								{ 
									new {Name = "Alice", Score = 50},
									new {Name = "Bob"  , Score = 40},
									new {Name = "Cathy", Score = 45}
								};
				
				//This sample uses ToDictionary to immediately evaluate a sequence and a related key expression into a dictionary.
				var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);
 				Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
		}
	}
}