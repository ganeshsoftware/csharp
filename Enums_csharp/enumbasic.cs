using System;

// Group of constants read-only variables.
public enum BasicColor {Red, Green, Blue}


// the enum order has been overridden here and it has to be done carefully ... otherwise it will create a problem.. 
public enum MobileNetworks {Tata, Reliance, Airtel=1, Hutch=5, ACT}

class EnumDemo
{
	public static void Main()
	{
		BasicColor selectedColor = BasicColor.Red;
		Console.WriteLine(selectedColor);
		
		// Enum value has been typecasted to int.  
		int myintvar = (int)BasicColor.Red;
		Console.WriteLine(myintvar);
		
		
		
		
		// myMobile & mySecondMobile both will show 1 which is ambigious. so be careful.
		int myMobile = (int) MobileNetworks.Airtel;
	    Console.WriteLine(myMobile);
		  
		int mySecondMobile = (int) MobileNetworks.Reliance;
		Console.WriteLine(mySecondMobile);
		
		int myThirdMobile = (int) MobileNetworks.Hutch;
		Console.WriteLine(myThirdMobile);
		
	}
}








