using System;
using System.Collections;

public class Student
{
   public Int32 StudentID {get; set;}
   public string StudentName {get; set;}
}


class TestStudent
{

	public static void Main()
	{
	    ArrayList mystudents = new ArrayList();
		
		Student stu1 = new Student();
		stu1.StudentID=1008;
		stu1.StudentName = "Pradeep B";
		
		
		Student stu2 = new Student();     
		stu2.StudentID=1009;
		stu2.StudentName = "Satish Kumar";	
	
	
		mystudents.Add(stu1);
		mystudents.Add(stu2);
//---------------------------------------------------------------------------------

        foreach(Student st in mystudents)
		{
		   Console.WriteLine(st.StudentID.ToString() + "  " + st.StudentName);
		}
		Console.ReadLine();
	
	}


}