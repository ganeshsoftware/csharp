using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mimsys.CSTraining2021.Classes
{
	public abstract class HealthProfessional
	{	
		public Int32 Id {get; set;}
		public string Name {get; set;}
		
		public abstract string PrintDetails();
	}
	
	public sealed class Doctor:HealthProfessional
	{
		public string Department {get; set;}
		
		public sealed override string PrintDetails()
		{
			return Id + "  " + Name + "   " + Department;
		}
	}
	
	/*
	public class Surgeon:Doctor 
	{
		public string Speciality {get; set;}
	}
	*/
	
	class Test
	{
		public static void Main()
		{
			new Doctor();
			
		}
	}
}