using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LambdaExpressionTrees  
{
   class Program 
   {
      static void Main(string[] args) 
	  {

		Func<Task<string>> getWordAsync = async() => "hello world!";
	  }
   }
}

