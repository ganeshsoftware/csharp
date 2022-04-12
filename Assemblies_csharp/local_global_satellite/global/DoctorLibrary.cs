using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

//[assembly:AssemblyDelaySign(false)]
//[assembly:AssemblyKeyFile(@"D:\CSHARP\csharp_assemblies\convutl.snk")]
[assembly:AssemblyCulture("en-US")]
[assembly:AssemblyVersion("1.1.235.1")]

namespace Ganesh.Assemblies
{
    public class Doctor
	{
		public Int32 DocId {get; set;}
		public string Name {get; set;}
		public string Degree {get; set;}
		
		public string GetDoctorDetails()
		{
			return  "100, Ganesh , MBBS";			
		}
	}
}