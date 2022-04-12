using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionTrees  
{
   class Program 
   {
      static void Main(string[] args) 
	  {
		System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
		Console.WriteLine(e);
      }
   }
}