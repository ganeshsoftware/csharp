using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Linq.AggregateOperators
{
    class Program
    {
        public static void Main()
        {            
            string[] words = { "cherry", "apple", "blueberry" };
            
            //To get the length of the shortest word in an array.
            int shortestWord = words.Min(w => w.Length);
 
            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }
    }
}