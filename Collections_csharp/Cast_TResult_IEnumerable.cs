/*
   The following code example demonstrates how to use Cast<TResult>(IEnumerable) to enable the use of the 
   standard query operators on an ArrayList.

*/
/*
The Cast<TResult>(IEnumerable) method enables the standard query operators to be invoked on non-generic 
collections by supplying the necessary type information. 

For example, ArrayList does not implement IEnumerable<T>, but by calling Cast<TResult>(IEnumerable) on the 
ArrayList object, the standard query operators can then be used to query the sequence.

*/

using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

class Test_Class_TResult_IEnumerable
{
	public static void Main()
	{
		System.Collections.ArrayList fruits = new System.Collections.ArrayList();
		fruits.Add("mango");
		fruits.Add("apple");
		fruits.Add("lemon");
		
		// The bekow will not work because it has not got casting done.
		//IEnumerable<string> query = fruits.OrderBy(fruit => fruit).Select(fruit => fruit);
		
		IEnumerable<string> query = fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);
		
		foreach(string str in query)
		{
			Console.WriteLine(str);			
		}
	}
}
