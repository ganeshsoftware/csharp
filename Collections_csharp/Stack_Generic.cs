using System;
using System.Collections.Generic;

class Student
{
	public Int32 Id {get; set;}	
	public string Name {get; set;}	
}

class StackTest
{
	public static void Main()
	{
		Stack<Int32> myMarks = new Stack<Int32>();
		Stack<Student> studentdata = new Stack<Student>();
				
		myMarks.Push(98);
		myMarks.Push(96);
		myMarks.Push(92);
		myMarks.Push(97);
		
		studentdata.Push(new Student{Id =100, Name="Ram"});
		studentdata.Push(new Student{Id =101, Name="Tim"});
		
				
		DisplayCollectionContent(myMarks);
		Console.WriteLine("The capacity of my stack is {0}",myMarks.Count);
		
		DisplayCollectionStudent(studentdata);
		Console.WriteLine("The capacity of my stack is {0}",studentdata.Count);
		
		
		
		
		Int32 marks = myMarks.Pop();
		myMarks.Push(108);
		
		DisplayCollectionContent(myMarks);
		Console.WriteLine("The capacity of my stack is {0}",myMarks.Count);
		
		
		myMarks.Pop();
		
		DisplayCollectionContent(myMarks);
		Console.WriteLine("The capacity of my stack is {0}",myMarks.Count);
	}
	
	// Method to display the contents of the Stack<Int32>.
	static void DisplayCollectionContent(Stack<Int32> s)
	{
		foreach(Int32 a in s)
		{
			Console.WriteLine(a);
		}		
	}
	
	// Method to display the contents of the Stack<Student>.
	static void DisplayCollectionStudent(Stack<Student> stud)
	{
		foreach(Student s in stud)
		{
			Console.WriteLine(s.Id + "  " + s.Name);
	
		}
		
	}
	
}