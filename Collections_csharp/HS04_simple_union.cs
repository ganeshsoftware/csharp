using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  

namespace Collections.HashSet 
{  
    class Program 
	{  
        static void Main(string[] args) 
		{  
            HashSet<string> names1 = new HashSet<string> 
			{  
				"Ganesh N",  
				"Ramesh Kumar",  
				"Suresh Kumar" 
            };  
            
			HashSet<string> names2 = new HashSet<string> 
			{  
                "Sanjay Kumar",  
                "Ajay Pandey",  
                "Kiran Kumar",  
                "Dilip Purohit",  
                "Yogesh Dhingra"  
            };  
            
			// Union with .
			names1.UnionWith(names2);  
            foreach(var name in names1) 
			{  
                Console.WriteLine(name);  
            }  
            Console.ReadKey();  
        }  
    }  
}