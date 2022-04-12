using System;
using System.Collections.Generic;


public class Member
{
	public string AadharNo{get; set;}
	public String Name{get; set;}
	public DateTime DateofBirth{get; set;}

	public Member()
	{
		
	}
	
	
	public Member(string AadharNo,String Name,DateTime DateofBirth)
	{
		this.AadharNo= AadharNo;
		this.Name =Name;
		this.DateofBirth = DateofBirth;
	}
	
	
	
	public override string ToString()
	{
		return AadharNo + "  " + Name + "  " +  DateofBirth.ToString(); 
	}
}



class GenericTest
{
	public static void Main()
	{
		List<Member> mymembers = new List<Member>{
			new Member{AadharNo = "NJSK78562IU",Name = "RAMESH", DateofBirth = DateTime.Parse("09/08/2001")},
		    new Member{AadharNo = "AKJTS5643UT",Name = "ARUN KUMAR", DateofBirth = DateTime.Parse("05/04/1992")}
		};
		
        foreach(Member mem in mymembers)
		{
			
			Console.WriteLine("*******************************************");
			Console.WriteLine(mem.ToString());		
			Console.WriteLine("*******************************************");
		}
		
		
		
		
	}	
}