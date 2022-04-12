using System;
using Utils;

namespace DoctorApplication
{
	class DoctorApp
	{
		// Extension Method 1
		public static void Main()
		{
			Doctor ramesh = new Doctor
			{
				Iden = 1008,
				CaptionId = "RamIyr",
				Name = "Ramesh Iyer",
		        DateOfJoin = DateTime.Parse("07/07/2001"),
				BloodGroup = "A+",
				Gender="Male",
				PPPhoto = "..//images//Ramesh_Iyer.jpg",
				Department = "OutPatient",
				Speciality = "General Physician"
			};
			
			Console.WriteLine("The Basic Details are {0}", ramesh.BasicDetails());
			Console.WriteLine("The speciality is {0}",ramesh.Speciality());
			Console.WriteLine();
			
		}
	}	
}	
	