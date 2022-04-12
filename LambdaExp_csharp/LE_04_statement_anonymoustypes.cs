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
         
      
	  // Using the expression with anonymous types.
	  
	  var mydoctors = doctors.Select(x => new { Identity = x.Iden, FirstLetter = x.Name[2] });  
      foreach (var item in mydoctors)  
      {   
         Console.WriteLine(item);  
      }    
      // ------------------------------------------------------------------------------------
	  
	  
	  
	  Console.Read();  
    }  
}  