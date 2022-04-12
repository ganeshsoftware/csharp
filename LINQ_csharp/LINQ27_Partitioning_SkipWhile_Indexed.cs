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
           samples.Linq27(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
                                // element less than its position
        }

        class LinqSamples
        {
            
            [Category("Partitioning Operators")]
            [Description("This sample uses SkipWhile to get the elements of the array " +
                        "starting from the first element less than its position.")]
            public void Linq27()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

                Console.WriteLine("All elements starting from first element less than its position:");
                foreach (var n in laterNumbers)
                {
                    Console.WriteLine(n);
                }
            }

        }
    }
}
