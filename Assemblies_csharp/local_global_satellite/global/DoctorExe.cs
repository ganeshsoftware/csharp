using System;
using System.Collections.Generic;
using System.Reflection;
using Ganesh.Assemblies;

namespace Ganesh.Assemblies
{
	class DoctorListings
	{
		
		
		public static void Main(string[] args)
		{
		   Assembly myDll =   Assembly.Load("DoctorLibrary, Version=1.1.235.1, Culture=en-US, PublicKeyToken=86b7147591ae5591");

			Type Doctor  = myDll.GetType("DoctorLibrary.Ganesh.Assemblies.Doctor");
			//Type DoctorOps  = myDll.GetType("DoctorLibrary.DoctorOps");
			
			
			object docOpsInstance = Activator.CreateInstance(Doctor);

   		    
			// Invoke a public instance method: public double Add(double number)
            string value = (string)Doctor.InvokeMember("GetDoctorDetails",BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,null, docOpsInstance, null);
			
			Console.WriteLine(value);
			
			
		}
	}
}

