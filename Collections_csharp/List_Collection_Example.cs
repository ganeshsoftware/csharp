using System;
using System.Collections;
using System.Collections.Generic;

namespace Mimsys.CollectionExamples.Generics
{
	// Enumerator 
	class Doctor
	{
		public Int32 Id {get; set;}
		public string Name {get; set;}
		public string Speciality {get; set;}
		public DateTime DoctorJoinDate {get; set;}
		
		public override string ToString()
		{
			return Id + " | " + Name + " | " + Speciality + " | " +  DoctorJoinDate.ToString();
		}
	}
	

	class TestList
	{
		public static void Main()
		{
			
			// Creating a generic list of doctors.
			List<Doctor> doctors = new List<Doctor>();
			
			Doctor ramesh = new Doctor {Id = 100, Name= "Ramesh Kumar", Speciality = "Ophthalmology", DoctorJoinDate = Convert.ToDateTime("12/12/2019")};
			
			Doctor suresh = new Doctor {Id = 314, Name= "Suresh Jain", Speciality = "Cardiology", DoctorJoinDate = Convert.ToDateTime("01/03/2020")};
			
			doctors.Add(ramesh);
			doctors.Add(suresh);

			foreach(Doctor d in doctors)
			{
				Console.WriteLine(d.ToString());
			}
			
		}
	}
}