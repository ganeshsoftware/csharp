class Student
{
	public UInt16 Id {get; set;}
	public string Name {get; set;}
	public ParentDetail myParentDetail {get; set;}
	
	/* 
	~Student()
	{
		this.Finalize();
	}
	*/
	Finalize()
	{
		this.myParentDetail = null;
	}
	
	
}


class ParentDetail
{
	public Int32 ParentDetailId {get; set;}
	public string MotherName {get; set;}	
	public string FatherName {get; set;}	
}


class Test
{
	public static void Main()
	{
		ParentDetail kushalparents = new ParentDetail();

		kushalparents.ParentDetailId = 1000;
		kushalparents.MotherName = "JanakiDevi";
		kushalparents.FatherName = "Ramanand";

        Student kushal = new Student();
		kushal.Id= 3638;
		kushal.Name = "Kushal Kumar";
		kushal.myParentDetail = kushalparents;

	    
	
	} 
}
