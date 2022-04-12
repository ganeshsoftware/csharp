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
            
            // To get the length of the longest word in an array.
            int longestLength = words.Max(w => w.Length);
 
            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }
    }
}