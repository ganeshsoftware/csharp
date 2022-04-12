using System;

namespace Mimsys.Examples.ObjectExample
{
	/*
		ToString()
		GetHashCode()
		GetType()
		Equals()	
	*/

	class Doctor
	{
		public Int32 Id {get; set;}
		public string HighestQual {get; set;}
		public string Speciality {get; set;}
		public double Height {get; set;}
		public double Weight {get; set;}
		
		public override bool Equals (Object o)
		{
			if (this.GetType()!= o.GetType())
			{
				return false;
			}
			
			Doctor doc = (Doctor)o;
			
			if ((this.HighestQual == doc.HighestQual) && (this.Speciality == doc.Speciality))
			{
				return true;
			}
				return false; 			
		}
		
		public override string ToString()
		{
			return "Id: " + Id + "|" + "Highest Qualification: " +  HighestQual + "|" + "Speciality: " + Speciality + "|" + "Doctor Height: " + Height + "|" + "Doctor Weight " + Weight;
		}
		
	}

	class Hospital
	{
		public Int32 NumOfStaff{get; set;}
		public Int32 NumOfDepts{get; set;}
	}

	class Test
	{
		public static void Main()
		{
			
			Doctor ramesh  = new Doctor()
			{
				Id = 1000,
				HighestQual = "FRCS",
				Speciality = "Cardiology",
				Height = 160,
				Weight = 70
			};
			
			Doctor suresh  = new Doctor()
			{
				Id = 1001,
				HighestQual = "FRCS",
				Speciality = "Cardiology",
				Height = 180,
				Weight = 75
			};
			Console.WriteLine(ramesh.Equals(suresh));
			Console.WriteLine(suresh.ToString());
			Console.WriteLine(ramesh.ToString());
			Console.WriteLine(suresh.GetHashCode());
			Console.WriteLine(ramesh.GetHashCode());
			
			
		}
	}
}


