using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: Guid("E957C030-1FA1-45A6-9041-2AC20746F1CE")]
[assembly: AssemblyVersion("1.0.0.24")]
[assembly: AssemblyFileVersion("1.0.0.24")]
[assembly: ComVisible(false)]

[assembly: AssemblyTitle("Interest Calculations")]
[assembly: AssemblyDescription("Interest Calculations - SIMPLE")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("chellascode")]
[assembly: AssemblyProduct("chellascode")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("en-IN")]


namespace Ganesh.Utils
{
	public class Interest
	{
		public string CalculateInterest(double Principal, double Rate, double Time, Int32 periods)
		{
			double Returned_Amount;
			
			Returned_Amount = Principal*(1 + (Rate*Time));
			
			return "Simple Interested: " + "  " + "Principal: " + Principal + "  " + "Rate: " +  Rate + "   " + "Time: " + Time + "Returned Amount: " +  Returned_Amount;   
		}
		
		
		public string Message()
		{
			return "Make the right investment!"; 
		}
	}
}
