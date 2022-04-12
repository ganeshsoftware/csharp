using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

//Average - Projection
//This sample uses Average to get the average length of the words in the array.
namespace Linq.AggregateOperators
{
    class Program
    {		
        static void Main(string[] args)
        {
			string[] words = { "cherry", "apple", "blueberry" };
			
			//Length = 6+5+9 = 20/3 = 6.666666666666667
			
			double averageLength = words.Average(w => w.Length);
		 
			Console.WriteLine("The average word length is {0} characters.", averageLength);  
        }		
    }
}
