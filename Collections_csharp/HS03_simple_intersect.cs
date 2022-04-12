using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace HashSetDemo 
{  
    class Program 
	{  
        static void Main(string[] args) 
		{  
            HashSet<string> names1 = new HashSet<string> 
			{  
                "Rajeev",  
                "Akash",  
                "Amit",
				"Vineet",
				"Ajay"
            };  
            
			HashSet<string> names2 = new HashSet<string> 
			{  
                "Rajeev",  
                "Akash",  
                "Amit",  
                "Deepak",  
                "Mohit"  
            };  
            names1.IntersectWith(names2);  
            
			foreach(var name in names1) 
			{  
                Console.WriteLine(name);  
            }  
            Console.ReadKey();  
        }  
    }  
}  