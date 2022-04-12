using System;

// must namespace for all generic related examples.
using System.Collections.Generic;


// This is a type that will be used later.
class Student
{
	public Int32 RollNo{get; set;}
	public string Name{get; set;}
	public char Gender{get; set;}
	
	public override string ToString()
	{
	    string gender;
		if(Gender.Equals('M'))
		{
			gender = "MALE";			
		}
		else if(Gender.Equals('F'))
		{
			gender = "FEMALE";			
		}
		else
		{
			gender = "OTHERS";			
		}
		return RollNo + "   "  +  Name + "   " +  gender;
	}
}

class Test
{
	public static void Main()
	{
		//Generic List of students.
		List<Student> mystudents = new List<Student>();
		
		
		Student ram = new Student { RollNo= 100, Name = "Ram", Gender = 'M'};
		Student sitadevi = new Student { RollNo= 101, Name = "Sita devi", Gender = 'F'};
		
		Student lakshman = new Student { RollNo= 102, Name = "Lakshman", Gender = 'M'};
		
		mystudents.Add(ram);
		mystudents.Add(sitadevi);
		mystudents.Add(lakshman);
		
		foreach(Student stu in mystudents)
		{
			Console.WriteLine(stu.ToString());			
		}
	}
}



