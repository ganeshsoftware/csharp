using System;
using System.Linq;
using System.ComponentModel;

namespace Linq.RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
           
		       /* This sample  uses the where clause to find all elements  of an array with a value less than 5 */
                
				int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var lowNums =
                    from num in numbers
                    where num < 5
                    select num;

                Console.WriteLine("Numbers < 5:");
                foreach (var x in lowNums)
                {
                    Console.WriteLine(x);
                }
        }
    }
}
