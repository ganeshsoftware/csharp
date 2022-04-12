using System;
using System.Collections.Generic;

interface IStudent
{
	string ReadStudent();
}

class Student:IStudent
{
	public string Name;
	public string ReadStudent()
	{
		return Name;
	}
	public override string ToString()
	{
		return Name;
	}
}

class Test
{
	public static void Main()
	{
		List<IStudent> myStudents = new List<IStudent>();
		Student ramesh = new Student{Name ="Ramesh Kumar"};
		myStudents.Add(ramesh);
		foreach(Student stud in myStudents)
		{
			Console.WriteLine(stud.ToString());
		}
        		
	}
}