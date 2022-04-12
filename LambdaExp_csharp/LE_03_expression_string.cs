using System;  
using System.Collections.Generic;  
using System.Linq;  


class Doctor  
{  
    public Int32 Iden { get; set; }   
	public string Name { get; set; }  
} 

   
class Program
{  
    public static void Main()  
    {  
        List<Doctor> doctors  = new List<Doctor>() 
		{   
            new Doctor {Iden =1000, Name = "Suresh Kumar" },  
            new Doctor {Iden =1254, Name = "Dilip Chandra" },  
            new Doctor {Iden =7821, Name = "Pramila devi" }  
        };  
         
		var onlynames = doctors.Select(x => x.Name);  
        foreach (var name in onlynames)  
        {  
            Console.WriteLine(name);  
        }  
         Console.Read();  
    }  
}  