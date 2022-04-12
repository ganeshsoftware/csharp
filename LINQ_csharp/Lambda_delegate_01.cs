using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambdaexample 
{
   class Program 
   {

      delegate int MyUnaryOps(int i);
      static void Main(string[] args) 
	  {
         MyUnaryOps myMyUnaryOps = y => y * y;
         int j = myMyUnaryOps(5);
         Console.WriteLine(j);
         Console.ReadLine();
      }
   }
}