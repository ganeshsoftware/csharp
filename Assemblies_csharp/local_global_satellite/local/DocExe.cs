using System;
using System.Collections.Generic;
using System.Reflection;
using Ganesh.Assemblies.Utils;

namespace Ganesh.Assemblies
{
	
	public class DocApp
	{
		public static void Main()
		{
			List<Doctor> myDoctors = new List<Doctor>();
			Doctor ramesh = new Doctor {Iden =100, Name ="Ramesh Kumar"}; 
			
			DocOps myOps = new DocOps();
			myOps.AddDoctor(ramesh);
			
			myDoctors = myOps.ListDoctors();
			
			foreach(Doctor doc in myDoctors)
			{
				Console.WriteLine(doc.ToString());
			}
		}
	
	}
}
