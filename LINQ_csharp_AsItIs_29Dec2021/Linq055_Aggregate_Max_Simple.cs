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
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            
            //To get the highest number in an array.
            int maxNum = numbers.Max();
 
            Console.WriteLine("The maximum number is {0}.", maxNum);
        }
    }
}