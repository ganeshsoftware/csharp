/************************************************************************************************
Namespace:  System
Assemblies: System.Runtime.dll, mscorlib.dll, netstandard.dll
*************************************************************************************************/


Compares two specified String objects and returns an integer that indicates their relative position in the sort order.





using System;

class StringFunctionDemo
{
	
	public static void Main()
	{
			string str1 = "The capital city of Karnataka state is Bengaluru!";
			string str2 = "Bengaluru is a City of Karnataka!";
			string str3 = "Capital city of Tamilnadu is Chennai!";
			
			Console.WriteLine(string.Compare(str1,str2));
	}
}