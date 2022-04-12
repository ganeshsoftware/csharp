using System;
using System.Linq;
using System.Linq.Expressions;


/*
These are expression lambdas and will have 
expressions on the right hand side.
*/

public delegate int del (int i);

class TestExpressionLambda
{

	public static void Main()
	{
			// returns the result of the expression.
			Expression<del> myET = a => a * a;
			Console.WriteLine(myET(10));
	}
}
