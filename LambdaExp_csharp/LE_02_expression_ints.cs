using System;  
using System.Collections.Generic;  
using System.Linq;  



public static class Program  
{  
    public static void Main()  
    {  
        
		// Source list.
		List<int> list = new List<int>() { 11, 22, 31, 42, 57, 68 };  


		// Lambda #1 :-  List<T>.FindAll() taking an expression as an parameter.
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  
        
		foreach (var num in evenNumbers)  
        {  
            Console.Write("{0} ", num);  
        } 

 		
		
		Console.WriteLine();  
		Console.WriteLine();  
		
		// Lambda #2 :-  Lambda expression used like an aggregation.
		List<int> numbers_greater_than_50 = list.Where(n => n > 50).ToList();
		int highernumbers_count = list.Where(n => n > 50).Count();
		
		foreach(var num in numbers_greater_than_50)
		{
			Console.Write("{0} ", num);  
		}
		
		Console.WriteLine();
		Console.WriteLine();
		
		Console.WriteLine("There are {0} numbers that are greater than 50",highernumbers_count);
		
        Console.WriteLine();  
        Console.Read();  
    }  
}  