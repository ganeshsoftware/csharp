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
            samples.Linq26(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
                                // element divisible by 3
        }

        class LinqSamples
        {
            
            [Category("Partitioning Operators")]
            [Description("This sample uses SkipWhile to get the elements of the array " +
                        "starting from the first element divisible by 3.")]
            public void Linq26()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                // In the lambda expression, 'n' is the input parameter that identifies each
                // element in the collection in succession. It is is inferred to be
                // of type int because numbers is an int array.
                var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

                Console.WriteLine("All elements starting from first element divisible by 3:");
                foreach (var n in allButFirst3Numbers)
                {
                    Console.WriteLine(n);
                }
            }

        }
    }
}
