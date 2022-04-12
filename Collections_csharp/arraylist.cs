using System;
using System.Collections;


public class Student
{
	public Int32 Id{get; set;}
	public string Name{get; set;}

	public override string ToString()
	{
		return this.Id + "  " + this.Name; 
	}
}


public class SamplesArrayList  
{
	public static void Main()  
	  {

		Student ram= new Student()
		{
		  Id = 108, Name = "Ram"
		};
	  
	  	  
      // Creates and initializes a new ArrayList.
      ArrayList myAL = new ArrayList();
       
	  myAL.Add(108.108);
	  	
	  
	  myAL.Add("ramg");
	
	  
	  myAL.Add("Thanks");
	  
	  myAL.Add("God");
	  
	  myAL.Add("Hello");
     
	  
	  myAL.Add("World");
 	
	  
	  myAL.Add("Thank");
	   
      myAL.Add("you");
	   
	 myAL.Add("God");
	  /*
	  myAL.Add("again");
     	  
	  myAL.Add(ram.ToString());
	  */
	  
	 // Displays the properties and values of the ArrayList.
      Console.WriteLine( "myAL" );
      Console.WriteLine( "    Count:    {0}", myAL.Count);
      Console.WriteLine( "    Capacity: {0}", myAL.Capacity);
	  
	 Console.Write("    Values:");
     PrintValues(myAL);
	 
  
   }

   public static void PrintValues(ArrayList myList)  
   {
      	  
	  foreach (object obj in myList)
	    Console.Write( "   {0}", obj );
	    Console.WriteLine();
   }
}