using System;
using System.Collections;

public class Student
{
	public Int32 Id {get; set;}
	public string Name {get; set;}
}

// LIFO

public class SamplesStack  
{

   public static void Main()  
   {
	  Student ramesh = new Student();
	  
	  // Creates and initializes a new Stack.
      Stack myStack = new Stack();
      
	  myStack.Push("Hello");
      myStack.Push("World");
	  myStack.Push(563);
	  myStack.Push(true);
	  myStack.Push(ramesh);  
      myStack.Push(Convert.ToDateTime("11/09/2019"));  
	  	  
	  Console.WriteLine("Count-1: {0}",myStack.Count);
	  
	  myStack.Pop();
	  Student stud = (Student)(myStack.Pop());
	  
	  
	  string val1 = (myStack.Peek()).ToString();
	  
	  Console.WriteLine("Count-2: {0}",myStack.Count);
	  
	  string val2 = (myStack.Peek()).ToString();

      // Displays the properties and values of the Stack.
      Console.WriteLine(val1);
	  //Console.WriteLine(val2);
	  
	
	  
	  Console.WriteLine( "myStack" );
	  Console.WriteLine( "\tCount:    {0}", myStack.Count);
      Console.Write( "\tValues:" );

      PrintValues(myStack);
   }

   public static void PrintValues(IEnumerable myCollection)  
   {
      foreach (Object obj in myCollection)
         Console.Write( "    {0}", obj );
      Console.WriteLine();
   }
   
}
