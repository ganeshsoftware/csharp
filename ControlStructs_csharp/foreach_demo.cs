using System;
using System.Collections.Generic;

class Student
{
	public Int32 Id {get; set;}
	public string Name {get; set;}
	public DateTime DOB {get; set;}
	public bool IsHostelier {get; set;}

	public override string ToString()
	{
		return this.Id + " " + this.Name + " " + this.DOB + "  " + this.IsHostelier;
	}
}


class LectureRoom:IEnumerable
{
	
	IEnumerator GetEnumerator()
	{
		
		
	}
	
}





class Test
{
	public static void Main()
	{
		LectureRoom room_01 = new LectureRoom();


		List<Student> myStudents = new List<Student>()
		{
		
			new Student {Id= 10, Name= "RAM",DOB = Convert.ToDateTime("09/08/2000"), IsHostelier= false},
			new Student {Id= 11, Name= "KRISHNA",DOB = Convert.ToDateTime("01/05/2000"), IsHostelier= false},
			new Student {Id= 12, Name= "KALKI",DOB = Convert.ToDateTime("01/02/1995"), IsHostelier= true},
			new Student {Id= 13, Name= "VAMAN",DOB = Convert.ToDateTime("09/08/1990"), IsHostelier= true }		
		};
		
		foreach(Student stud in room_01)
		{
			Console.WriteLine(stud.ToString());
		}
		
		
	}
}




