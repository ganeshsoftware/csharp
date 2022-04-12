﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel;

namespace AggregateOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not
            samples.Linq78(); // This sample uses Sum to add all the numbers in an array
            
        }


        class LinqSamples
        {
            //DONE Changed "get the total of" to "add all"
            [Category("Aggregate Operators")]
            [Description("This sample uses Sum to add all the numbers in an array.")]
            public void Linq78()
            {
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                double numSum = numbers.Sum();

                Console.WriteLine("The sum of the numbers is {0}.", numSum);
            }
        }
    }
}
