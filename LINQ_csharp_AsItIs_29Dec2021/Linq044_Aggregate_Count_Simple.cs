using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Linq.AggregateOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq73(); // This sample uses Count to get the number of unique prime factors of 300
           
        }


        class LinqSamples
        {
           
            [Category("Aggregate Operators")]
            [Description("This sample uses Count to get the number of unique prime factors of 300.")]
            public void Linq73()
            {
                int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };

                int uniqueFactors = primeFactorsOf300.Distinct().Count();

                Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);
            }
        }
    }
}
