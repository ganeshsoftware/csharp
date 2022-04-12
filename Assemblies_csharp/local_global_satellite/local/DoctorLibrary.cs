using System;
using System.Collections.Generic;

namespace Ganesh.Assemblies
{

	public enum Qualification {MBBS, MD, FCRS, BHMS};

	class Doctor
	{
		public Int32 DocId {get; set;}
		public string Name {get; set;}
		public Qualification Degree {get; set;}
	}

	class DoctorOps
	{
		
		List<Doctor> doctors;
		
		// Constructor.
		public DoctorOps()
		{
			doctors = new List<Doctor>
			{
				new Doctor{DocId = 100,Name= "Ganesh", Degree=Qualification.MBBS}, 				
				new Doctor{DocId = 101,Name= "Devendra", Degree=Qualification.MD}
			};
		}
		
		public void AddDoctor(Doctor d)
		{
			if (!(doctors.Equals(null)))
			{
				doctors.Add(d);				
			}
		}
	}
}
