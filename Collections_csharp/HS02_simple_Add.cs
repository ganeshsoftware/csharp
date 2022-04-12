using System;
using System.Linq;  
using System.Text;  
using System.Collections.Generic;  
using System.Threading.Tasks;




namespace Collections.HashSet
{  
	class Program 
	{  
		static void Main(string[] args) 
		{  
			HashSet<string> names = new HashSet<string> 
			{  
				"Ganesh N",  
				"Ramesh Kumar",  
				"Vineet Saxena"  
			}; 
			
			// this name will not be added again/
			names.Add("Ganesh N");  
			
			// Duplicates are not added into the HashSet collection.   
			foreach(var name in names) 
			{  
				Console.WriteLine(name);  
			}
			Console.ReadKey();  
		}  
	}  
}  