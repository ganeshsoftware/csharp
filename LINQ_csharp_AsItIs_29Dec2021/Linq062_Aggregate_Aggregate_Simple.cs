using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

//Aggregate - Simple
//This sample uses Aggregate to create a running product on the array that calculates the total product of all elements.
namespace Linq.AggregateOperators
{
    class Program
    {
        static void Main(string[] args)
        {
			double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
 
			double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
		 
			Console.WriteLine("Total product of all numbers: {0}", product);
        }       
    }
}
