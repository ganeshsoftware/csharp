using System;
using System.Collections.Generic;
using System.Reflection;

[assembly:AssemblyCulture("en-US")]
[assembly:AssemblyVersion("1.9.108.34")]

namespace Ganesh.Assemblies.Utils
{
	public class Doctor
	{
		public Int32 Iden {get; set;}
		public string Name {get; set;}
		
		public override string ToString()
		{
			return "The doctor details are: " + this.Iden + "  " + this.Name;
		}
	}

	public class DocOps
	{
		private List<Doctor> mydoctors;
		
		public DocOps()
		{
			mydoctors = new List<Doctor>();
		}
		
		public List<Doctor> ListDoctors()
		{
			return 	mydoctors;		
		}
		
		public void AddDoctor(Doctor d)
		{
			mydoctors.Add(d);			
		}
	}
}
