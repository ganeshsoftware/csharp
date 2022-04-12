using System;
using System.Linq;
using System.ComponentModel;

namespace Linq.RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();
            
            samples.Linq5(); // This sample demonstrates an indexed where clause that returns digits whose name is 
                               // shorter than their value
        }

        public class LinqSamples
        {
            
            [Description("This sample demonstrates an indexed where clause that returns digits whose name is " +
                    "shorter than their value.")]
            public void Linq5()
            {
                string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                var shortDigits = digits.Where((digit, index) => digit.Length < index);

                Console.WriteLine("Short digits:");
                foreach (var d in shortDigits)
                {
                    Console.WriteLine("The word {0} is shorter than its value.", d);
                }
            }

        }
    }
}
