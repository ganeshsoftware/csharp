using System;
using System.Collections;
using System.Collections.Generic;


class IPAddress
{
	public Int32 SEG1 {get; set;}
	public Int32 SEG2 {get; set;}
	public Int32 SEG3 {get; set;}
	public Int32 SEG4 {get; set;}
	
//	45.78.76.45
	
}


  

public class Student
{
	public Int32 Id {get; set;}
	public string Name {get; set;}
	
}




public class SamplesStack  
{

   public static void Main()  
   {
	  Student ramesh = new Student();
	  
	  
	  
	  // Creates and initializes a new Stack.
      Stack<Int32> myStack = new Stack<Int32>();
      
	  myStack.Push(108);
      myStack.Push(1008);
	  myStack.Push(563);
	  myStack.Push(78);
	  myStack.Push(67809);  
      	  
		  
	  string val1 = (myStack.Peek()).ToString();
	  string val2 = (myStack.Pop()).ToString();

      // Displays the properties and values of the Stack.
      Console.WriteLine(val1);
	  //Console.WriteLine(val2);
	  
	  
	  
	  Console.WriteLine( "myStack" );
	  Console.WriteLine( "\tCount:    {0}", myStack.Count);
      Console.Write( "\tValues:" );

      PrintValues(myStack);
   }




   public static void PrintValues( IEnumerable myCollection )  
   {
      foreach (Int32 varib in myCollection )
         Console.Write( "    {0}", varib );
		 Console.WriteLine();
   }
}
