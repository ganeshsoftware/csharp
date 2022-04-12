using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;



public class Student
{
	public Int32 ID{get; set;}
	public string Name {get; set;}

	public Student()
	{
	}

	public Student(Int32 ID,string Name)
	{
		this.ID = ID;
		this.Name = Name;
	}
}




public class TestStudent
{
	public static void Main()
	{
		List<Student> students = new List<Student>()
		{
			new Student(108,"Ganesh"),
			new Student(109,"Ramesh"),
			new Student(110,"Ramanand"),
			new Student(111,"Atul")
		};
		// Find a given student is there in a list or not.

		//Predicate<Student> studentPredicate = new Predicate<Student>(FindStudent);
		Student stud = students.Find(stu => FindStudent(stu));
		
		Console.WriteLine("ID ={0}, Name ={1}",stud.ID, stud.Name);
		
	}
	
	
	
	
	
	/*
	Step 1 : Write a function, that matches to the following delegate signature.
    public delegate bool Predicate <in T> (T obj)
	*/
	
	public static bool FindStudent(Student student)
	{
		return student.ID == 108;		
	}
	
	
	
}