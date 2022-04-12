using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Linq.AggregateOperators
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2 };
            
            //To get the lowest number in an array.
            int minNum = numbers.Min();    
 
            Console.WriteLine("The minimum number is {0}.", minNum);
        }
    }
}