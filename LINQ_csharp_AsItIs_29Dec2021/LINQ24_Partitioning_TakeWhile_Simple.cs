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

            samples.Linq24(); // This sample uses Skip to get all but the first four elements of the array

        }

        class LinqSamples
        {
            
            [Category("Partitioning Operators")]
            [Description("This sample uses TakeWhile to return elements starting from the " +
                         "beginning of the array until a number is read whose value is not less than 6.")]
            public void Linq24()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

                Console.WriteLine("First numbers less than 6:");
                foreach (var num in firstNumbersLessThan6)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
