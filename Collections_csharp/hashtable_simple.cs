using System;
using System.Collections;

namespace CollectionsApplication 
{
   
   class Student
   {
	   public Int32 Id{get; set;}
	   public string Name{get; set;}
	   public DateTime DOB{get; set;}
	   public bool RegularStudent{get; set;}

	   public override string ToString()
	   {
			return "Id= " +  Id  +  "  "  +  "Name=" +  Name +   "	 "  + "DOB= " + DOB +  "  "  +  "RegularStudent = " + RegularStudent;
	   }	   
    }
	
	
   
   class Program 
   {
      public static void Main() 
	  {
        try
		{ 
			Hashtable ht = new Hashtable();
         
		    Student ganesh = new Student{Id=108,Name="Ganesh",DOB=DateTime.Parse("11/10/1995"),RegularStudent=true};
		 
			ht.Add("001", ganesh);
			ht.Add("002", "Ramesh Kumar");
			ht.Add("003", "Vishwanath");
			ht.Add("004", "Sam Gonsolves");
			ht.Add("005", "Rajesh Khattar");
			ht.Add("006", "Sudesh Sharma");
			ht.Add("007", "Jayanth Sinha");
			ht.Add("008", "Dinesh K");
         
			//Adding a duplicate key provides a runtime exception.
			ht.Add("009","Ramesh Kumar");
		 
			
			if (ht.ContainsValue("Ramesh Kumar")) 
			{
				Console.WriteLine("This student name is already in the list");
			} 
			
			
			else 
			{
				ht.Add("002", "Ramesh Kumar");
				Console.WriteLine("Ramesh Kumar Added!");
			}
         
		 
			// Get a collection of the keys.
			ICollection ganeshn = ht.Keys;
			foreach (object o in ganeshn) 
			{
				Console.WriteLine(o.ToString() + "   " + ht[o]);
			}	
		}
		  
		catch (Exception)
		{
			  Console.WriteLine("duplicate values...");
	    }
 
      }
   }
}