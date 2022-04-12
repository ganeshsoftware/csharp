using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

              samples.Linq20(); // This sample uses Take to get only the first 3 elements of the array

        }

        class LinqSamples
        {
         
            [Category("Partitioning Operators")]
            [Description("This sample uses Take to get only the first 3 elements of " +
                         "the array.")]
            public void Linq20()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var first3Numbers = numbers.Take(3);

                Console.WriteLine("First 3 numbers:");
                foreach (var n in first3Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
