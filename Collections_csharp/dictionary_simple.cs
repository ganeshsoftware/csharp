using System;
using System.Collections.Generic;


public class Member
{
	public string AadharNo{get; set;}
	public String Name{get; set;}
	public DateTime DateofBirth{get; set;}

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
            
			Member jitesh = new Member("435342333098","Jitesh Kumar", DateTime.Parse("10/11/1979"));
			Member samir = new Member("75354237321","Samir Dutta", DateTime.Parse("08/09/1978"));

			//Dictionary<TKey, TValue>	
			Dictionary<Int32,Member> myMembers = new Dictionary<Int32,Member>();
			
			
			myMembers.Add(100,jitesh);
			myMembers.Add(101,samir);
			
			
			
			foreach(KeyValuePair<Int32,Member> kvp in myMembers)
			{
				
				Console.WriteLine(kvp.Key);
				Console.WriteLine("*****************");
				Console.WriteLine(kvp.ToString());
				Console.WriteLine("*************************************************************");
			}
	}
}