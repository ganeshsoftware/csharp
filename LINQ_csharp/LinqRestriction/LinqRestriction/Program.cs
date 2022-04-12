using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRestriction
{
    class LinqOperations
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums =
                from n in numbers
                where n < 5
                select n;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

public void Linq5()
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen" };

        var shortDigits = digits.Where((digit,index)=> digit.Length < index);

        Console.WriteLine("Short digits:");
        foreach (var d in shortDigits)
        {
            Console.WriteLine("The word {0} is shorter than its value.", d);
        }
    }


    }


    


    class Program
    {
        static void Main(string[] args)
        {
            LinqOperations l1= new LinqOperations();
            l1.Linq5();
            Console.ReadLine();
        }
    }
}
