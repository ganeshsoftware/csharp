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

            samples.Linq22(); // This sample uses Skip to get all but the first four elements of the array

        }

        class LinqSamples
        {
            
            [Category("Partitioning Operators")]
            [Description("This sample uses Skip to get all but the first four elements of " +
                         "the array.")]
            public void Linq22()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var allButFirst4Numbers = numbers.Skip(4);

                Console.WriteLine("All but first 4 numbers:");
                foreach (var n in allButFirst4Numbers)
                {
                    Console.WriteLine(n);
                }
            }

        }
    }
}
