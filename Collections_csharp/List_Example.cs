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



class DictionaryTest
{
	public static void Main()
	{
		/*
        List<Member> myMembers = new List<Member>();
		myMembers.Add(new Member("435342333098","Jitesh Kumar", DateTime.Parse("10/11/1979")));
		myMembers.Add(new Member("75354237321","Samir Dutta", DateTime.Parse("08/09/1978")));
		*/
		
		/*
		List<Member> myMembers = new List<Member>()
		{
			new Member("435342333098","Jitesh Kumar", DateTime.Parse("10/11/1979")),
			new Member("75354237321","Samir Dutta", DateTime.Parse("08/09/1978"))
		};
		*/
		
		
		List<Member> myMembers = new List<Member>()
		{
			new Member {AadharNo = "435342333098", Name ="Jitesh Kumar", DateofBirth=DateTime.Parse("10/11/1979")},
			new Member {AadharNo = "75354237321", Name ="Samir Dutta", DateofBirth=DateTime.Parse("08/09/1978")}
		};
		
		
		foreach(Member m in myMembers)
		{
			Console.WriteLine(m.ToString());
		}
		
	}
}