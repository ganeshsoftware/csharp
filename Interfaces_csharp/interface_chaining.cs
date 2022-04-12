using System;

interface IStudent
{
	string DisplayStudentDetails();
}

interface IDayStudent:IStudent
{
	string DisplayBusRoute();
}

class Student:IDayStudent
{
	public Int32 Id{get; set;}
	public string StudentName{get; set;}
	public string BusRoute{get; set;}
	
	public string DisplayStudentDetails()
	{
		return Id + " " + StudentName;
	}
	
	public string DisplayBusRoute()
	{
		return BusRoute;	
	}
}

class App 
{
	public static void Main()
	{
		Student ramesh = new Student();		
	}
}