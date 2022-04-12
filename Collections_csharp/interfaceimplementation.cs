using System;
using System.Collections;

interface IStudent
{
	
	public string BusRoute{get; set;}
	public Int32 DoorNo {get; set;}
	public string HostelName {get; set;}
}

class Student
{
	public Int32 Id{get; set;}
	public string Name{get; set;}	
} 

class DayStudent:Student,IStudent
{
	public string BusRoute{get; set;}
}

class HostelStudent: Student,IStudent
{
	public Int32 DoorNo {get; set;}
	public string HostelName {get; set;}
}



class TestClass
{
	public static void Main()
	{
				
	}
}








	
	public void GetStudentDetails()
	{
		  Console.WriteLine("ID: " + 
		                    this.ID + 
							"  " + 
							"Name: "  + 
							this.Name + 
							"  "  +   
							"Bus Route: " + 
							this.BusRoute + 
							"  "  + 
							"Area Name: " + 
							this.AreaName);
	}
}






public interface IStudent
{
	void GetStudentDetails();
}










class Democlass
{
	public IStudent SampleMethod()
	{
		DayStudent dev = new DayStudent();
		HostelStudent raj = new HostelStudent();
		
		return dev;
		//return raj;
	}
	
	
	
}






class TestClass
{
	public static void Main()
	{
				
		
	}
	
	
	
	
}