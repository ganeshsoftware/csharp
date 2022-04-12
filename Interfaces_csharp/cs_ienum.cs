using System;
using System.Collections.Generic;

class Student
{
	public Int32 Id{get; set;}
	public string Name{get; set;}

	public Student()
	{
	
	}
	public Student(Int32 Id,string Name)
	{
		this.Id = Id;
		this.Name = Name;
	}
	
	public override string ToString()
	{
		return this.Id + " " + this.Name;
		
	}

}


class Desk
{
	public Int32 Id{get; set;}
	public string Name{get; set;}
	
	public Desk()
	{
	
	}	
	
	public Desk(Int32 Id,string Name)
	{
		this.Id = Id;
		this.Name = Name;
	}
	
	public override string ToString()
	{
		return this.Id + " " + this.Name;
		
	}

}






class LectureRoom:IEnumerable
{
	public Int32 Id{get; set;}
	public string Name{get; set;}

	public List<Student> students {get; set;}
	public List<Desk> desks {get; set;}

	public LectureRoom()
	{
	
	}	
	
	public LectureRoom(Int32 Id,string Name)
	{
		this.Id = Id;
		this.Name = Name;
	}
	
	public LectureRoom(Int32 Id,string Name,List<Student> students,List<Desk> desks)
	{
		this.Id = Id;
		this.Name = Name;
		this.students= students;
		this.desks = desks;
	}

	public override string ToString()
	{
		return this.Id + " " + this.Name;
	}
	

}




class TestApplication
{
	public static void Main()
	{
			 
			 			 
			 Student bhuvaneswari = new Student(108,"Bhuvaneswari");
			 Student bhavana = new Student(109,"Bhavana");
			 Student srividya = new Student(110,"Srividya");
			 Student ramya = new Student(111,"Ramya");
			 Student ramesh = new Student(112,"Ramesh");
			 Student rajeev = new Student(113,"Rajeev");
			 Student venkat = new Student(114,"Venkat");
			 Student shiv = new Student(115,"Shivakumar");
			 
			 
			 
			 Desk desk1 = new Desk(1,"DESK#1");
			 Desk desk2 = new Desk(2,"DESK#2");
			 Desk desk3 = new Desk(3,"DESK#3");
			 Desk desk4 = new Desk(4,"DESK#4");
			 
			 

             List<Student> studentlist1 = new List<Student>();
			 List<Student> studentlist2 = new List<Student>();

			 studentlist1.Add(bhuvaneswari);
			 studentlist1.Add(bhavana);
			 studentlist1.Add(srividya);
			 studentlist1.Add(ramya);
			 
			 studentlist2.Add(ramesh);
			 studentlist2.Add(rajeev);
			 studentlist2.Add(venkat);
			 studentlist2.Add(shiv);
			 
			 
			 List<Desk> desklist1 = new List<Desk>();
			 List<Desk> desklist2 = new List<Desk>();
			 
			 desklist1.Add(desk1);
			 desklist1.Add(desk2);
			 desklist2.Add(desk3);
			 desklist2.Add(desk4);


			 //public LectureRoom(Int32 Id,string Name,List<Student> students,List<Desk> desks)
			 
			 LectureRoom l1 = new LectureRoom(100,"Hall#1",studentlist1,desklist1);
			 LectureRoom l1 = new LectureRoom(101,"Hall#2",studentlist2,desklist2);
			 
			 foreach(Student stu in l1)
			 {
				 Console.WriteLine(stu.ToString()); 		 
			 }
			 
			 foreach(Desk dsk in l1)
			 {
				 Console.WriteLine(dsk.ToString()); 		 
			 }
	}

}


























