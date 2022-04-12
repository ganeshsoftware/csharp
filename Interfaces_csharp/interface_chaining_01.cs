using System;

namespace Mimsys.Sample.Interfaces
{
	interface IProfessional
	{
		void RegisterProfessionalDetails();
	}

	interface IDoctor:IProfessional
	{
		string DisplayDoctorDetails();
	} 
	
	class Professional:IProfessional
	{
		public void RegisterProfessionalDetails()
		{
			
		}		
	}
	
	class Doctor:IDoctor
	{
		
		public void RegisterProfessionalDetails()
		{
			
		}
		
		public string DisplayDoctorDetails()
		{
				return "string";
		}
		
		public IProfessional ReadProfessional()
		{
			return new Professional();
		}
		
	}
	
	
	class Test
	{
		public static void Main()
		{
				
		}
	}
}
