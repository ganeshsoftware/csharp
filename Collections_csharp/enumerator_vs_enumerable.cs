using System;
using System.Collections.Generic;

class Enumerable_Enumerator_Test
{
	static void Main(string[] args)
	{  
		List<string> Month = new List<string>();  
		Month.Add("January");  
		Month.Add("February");  
		Month.Add("March");  
		Month.Add("April");  
		Month.Add("May");  
		Month.Add("June");  
		Month.Add("July");  
		Month.Add("August");  
		Month.Add("September");  
		Month.Add("October");  
		Month.Add("November");  
		Month.Add("December");  

		
		// 1. Use a direct foreach.
		foreach(string str in Month)
		{
			Console.WriteLine(str);
			
		}
		
		// 2. Use a IEnumerable
		IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
		foreach(string month in iEnumerableOfString)
		{
			Console.WriteLine(month);			
		}

		// 3. Use a IEnumerator
		//to convert list into IEnumerator we can invoke the GetEnumerator method.
		IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();
  
		//To retrieve all the items from the above IEnumerator object.
		//we cannot use foreach loop instead of that we need to invoke MoveNext() Boolean method.  
		while(iEnumeratorOfString.MoveNext()) 
		{  
			Console.WriteLine(iEnumeratorOfString.Current);
		}  
		
		


	}  	
	
}


