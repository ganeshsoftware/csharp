using System;
using System.Collections.Generic;

class Patient
{
	public Int32 PatientId {get; set;}
	public string PatientName {get; set;}
}

class Test
{
	public static void Main()
	{
		// collection.
		List<Patient> patients = new List<Patient>
		{
			new Patient { PatientId =10, PatientName = "RAM"},
			new Patient { PatientId =11, PatientName = "TOM"},
			new Patient { PatientId =12, PatientName = "TIM"},
			new Patient { PatientId =13, PatientName = "KIM"},
		};	
		
		foreach(Patient p in patients)
		{
			Console.WriteLine(p.PatientId + "  " + "|" + p.PatientName);			
		}
		
		
		
	}

}




