using System;
using System.Linq;
using System.Collections.Generic;

namespace Mimsys.Lambda
{
	class Program
	{
		public static void Main()
		{
			Func<string> message = () =>  PrintHardCodedMessage();
			Console.WriteLine(message);
			
		}
		
		public static string PrintHardCodedMessage()
		{
			return "Good Morning Doctor! How are you !";
			
		}
		
	}
}





