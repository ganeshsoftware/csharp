using System;
using System.Linq;
using System.Linq.Expressions;



class TheExpressionTree
{
	public static void Main(string[] args)
	{
		// Simple Delegated operation that performs string join.
		Func<string, string, string> StringJoin = (str1, str2) => string.Concat(str1, str2);


		/* 
			If Parsing / Analysis has to be done, this code has to be tretaed like Data. 
			An Expression for the above lambda expression will be something like this:
		*/
		Expression<Func<string,string,string>> StringJoinExpr = (str1, str2) => string.Concat(str1, str2);
		
		
		Console.WriteLine(StringJoinExpr);
		
		
		
		
		
		
		
		/*
			The Expression Tree can be visualized as with it’s major properties:
			--------------------------------------------------------------------
			1) Body         - string.Concat(str1, str2);
			2) Parameters   - {str1}, {str2}
			3) NodeType     - {Lambda}
			4) Return Type  - {String}
		*/
		

		/* Compile and Invoke the Expression */ 
		var func = StringJoinExpr.Compile();
		var result = func("Ganesh ", "N");
		Console.WriteLine(result);
		
	}
}

















