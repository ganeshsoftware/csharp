using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: Guid("AD4E901C-D83A-4EAA-9190-1D0522B01F69")]
[assembly: AssemblyVersion("1.0.0.12")]
[assembly: AssemblyFileVersion("1.0.0.12")]
[assembly: ComVisible(false)]
[assembly: AssemblyTitle("Interest Calculations")]
[assembly: AssemblyDescription("Interest Calculations - COMPLEX")]
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
			
			Returned_Amount = Math.Pow((Principal*(1 + Rate/periods)),(Time*periods));
			
			return "Compound Interested: " + "  " + "Principal: " + Principal + "  " + "Rate: " +  Rate + "   " + "Time: " + Time + "Returned Amount: " +  Returned_Amount;   
		}
	}
}