using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAggregate
{
    class Aggregate
    {
        public void Linq73()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }

        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }


        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w=>w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Aggregate a1 = new Aggregate();
            //a1.Linq73();
            //a1.Linq74();
            a1.Linq79();
            Console.ReadLine();

        }
    }
}
