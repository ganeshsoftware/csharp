using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mimsys.CSTraining2021.Lambda
{
class PulserLambdas
{
    static void Main()
    {
       Action<string> greet = name =>
	   {
			string greeting = @"Hello {name}!";
			Console.WriteLine(greeting);
	   };
	   greet("World");
    }
}
}