using System;
using System.Linq;

delegate void TestDelegate(string s);


class TestStatementLambda
{
	public static void Main()
	{
			TestDelegate del = n => { 
									  string s = n + " World"; 
									  Console.WriteLine(s); 
									};	
	
			del("PURUSHOTHAM");
		
	}


}


