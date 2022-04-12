using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace lambdaexample {
   class Program {
      static void Main(string[] args) 
	  {
         int[] source = new[] { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };

         foreach (int i in source.Where(x =>
            {
               if (x <= 3)
                  return true;
               else if (x >= 7)
                  return true;
               return false;
            }
         ))
        Console.WriteLine(i);
        Console.ReadLine();
      }
   }
}