using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not
            samples.Linq25(); // This sample uses TakeWhile to return elements starting from the beginning of the array 
                                // until a number is hit that is less than its position in the array

        }

        class LinqSamples
        {
            
            [Category("Partitioning Operators")]
            [Description("This sample uses TakeWhile to return elements starting from the " +
                        "beginning of the array until a number is hit that is less than its position " +
                        "in the array.")]
            public void Linq25()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

                Console.WriteLine("First numbers not less than their position:");
                foreach (var n in firstSmallNumbers)
                {
                    Console.WriteLine(n);
                }
            }

        }
    }
}
