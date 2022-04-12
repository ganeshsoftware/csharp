using System;
using System.Collections.Generic;

class Student
{
	public Int32 Id{get; set;}
	public string Name {get; set;}
	public string Address {get; set;}
   
    public Student()
	{
	}
    
	public Student(Int32 Id,string Name,string Address)
	{
      this.Id= Id;
	  this.Name = Name;
	  this.Address = Address;
	}

    public override string ToString()
    {
      return "Id: " + this.Id + "  " + "Name: " + this.Name + "   " + "Address:  " + this.Address;  
    }
	
	protected  override void Finalize()
	{
		// statements to write a log entry into a file.
	}
}






class TestStudent
{

 Student ram = new Student();

	public static void Main()
        {
     // List    -  (non generic version List)
     // List<T> -  (generic version List)     (T-Type) (T = Student)
    
	List<Student> students = new List<Student>()
    {
		new Student(108,"ramesh sundar", "103, hebbal"),
		new Student(109,"ganesh n", "303 hebbal")        
    }; 
     
    foreach(Student stu in classroom)
    {
        Console.WriteLine(stu.ToString());
    }

}


} //class TestStudent 



