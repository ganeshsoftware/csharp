using System;
using System.Reflection;


public class ConversionApp
{
	public static void Main()
	{
		Assembly assem2350 = Assembly.Load("ConversionUtils, Version=1.0.235.0, Culture=en-US, PublicKeyToken=8fc2b763a59e6847"/*processorArchitecture=MSIL*/);
    
		Assembly assem2351 = Assembly.Load("ConversionUtils,Version=1.0.235.1,Culture=en-US,PublicKeyToken=8fc2b763a59e6847"/*processorArchitecture=MSIL*/);    
	
		Type T1 = assem2350.GetType("ConversionUtils");
		var t1 = Activator.CreateInstance(T1);
		
		
		Type T2 = assem2351.GetType("ConversionUtils");
		var t2 = Activator.CreateInstance(T2);
	
	
	
		Console.WriteLine("Enter the US-Dollar amount to be converted.");
		double usd1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("The equivalent INR value for the US Dollar = {0} is {1}",((ConversionUtils)t1).UsdToInr(usd1));	
		
		Console.WriteLine("Enter the US-Dollar amount to be converted.");
		double usd2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("The equivalent INR value for the US Dollar = {0} is {1}",((ConversionUtils)t2).UsdToInr(usd2));	
	
	
	/*
		Console.WriteLine("Enter the INR amount to be converted.");
	
		Console.WriteLine("Enter the INR amount to be converted.");
		*/
	}
}













