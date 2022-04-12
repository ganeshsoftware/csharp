using System;
/*
	Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are static methods, but they're called as if they were instance methods on the extended type. For client code written in C#, F# and Visual Basic, there's no apparent difference between calling an extension method and the methods defined in a type.	
*/

namespace Utils
{
	public class Doctor
	{
		public Int32 Iden { get; set; }
		public string CaptionId { get; set; }
		public string Name { get; set; }
		public DateTime DateOfJoin { get; set; }
		public string BloodGroup { get; set; }
		public string Gender { get; set; }
		public string PPPhoto { get; set; }
		public string Department { get; set; }
		public string Speciality { get; set; }
		
		// Base class Method-1.
		public string BasicDetails()
		{
			return Iden + "|" + CaptionId + "|" + Name;
		}
		
		// Base class Method-2.
		public string DateofJoin()
		{
			return this.DateOfJoin.ToString();
		}		
	}
}	
	




