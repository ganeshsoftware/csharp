using System;
using System.Reflection;

[assembly:AssemblyDelaySign(false)]
[assembly:AssemblyKeyFile(@"D:\CSHARP\csharp_assemblies\convutl.snk")]
[assembly:AssemblyCulture("en-US")]
[assembly:AssemblyVersion("1.0.235.1")]

public class ConversionUtils
{
	public double InrToUsd(double inr)
	{
	   Console.WriteLine("The conversion rate is INR 1.0 = USD 0.0153");
	   return inr * 0.0153;
	}

	public double UsdToInr(double usd)
	{
	   Console.WriteLine("The conversion rate is USD 1.0 = INR 65.00");
	   return usd * 65.00;
	}
}