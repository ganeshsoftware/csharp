using System;
using System.Text;

class StringTest
{
	public static void Main()
	{
		// data type string.
		string str1 = "Karnataka";
		Console.WriteLine(str1.Equals("Karnataka"));
		
		// Static class string
		Console.WriteLine(String.Equals("Karnataka","karnataka"));
		
		//Starts with
		Console.WriteLine(str1.StartsWith("ShejA"));

	}
}