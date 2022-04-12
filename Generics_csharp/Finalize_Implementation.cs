using System;

class ParentDetail
{
	public string FatherName{get;set;}
	public string MotherName{get;set;}
	
	public ParentDetail(string FatherName,string MotherName)
	{
		this.FatherName = FatherName;
		this.MotherName = MotherName;
	}
}

class Student
{
	public Int32 Id{get; set;}
	public ParentDetail ParentDetail{get; set;}
	
	public Student(Int32 Id, ParentDetail ParentDetail)
	{
		this.Id = Id;
		this.ParentDetail = ParentDetail;
	}
}

class Test
{
	public static void Main()
	{
		ParentDetail m_ParentDetail = new ParentDetail("RAM","SITADEVI");
		Student m_Student = new Student(108,m_ParentDetail);
	}
}