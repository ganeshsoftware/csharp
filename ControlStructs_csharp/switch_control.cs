using System;

class switch_control
{
	public static void Main()
	{
		Console.WriteLine("Enter a valid day of the week!!!");
		
		string dayofweek = Console.ReadLine();
		
		switch(dayofweek)
		{
			case "Sunday":
				Console.WriteLine("Sunday is a Holiday... Funday");
				break;
			case "Monday":
				Console.WriteLine("First day of the work... Great day");
				break;	
			case "Tuesday":
				Console.WriteLine("A day of strength... where you have to be stable");
				break;
			case "Wednesday":
				Console.WriteLine("To sustain the inititaives taken through the week!");
				break;
			case "Thursday":
				Console.WriteLine("A day of divine strength... to carry ourselves forward.");
				break;
			case "Friday":
				Console.WriteLine("Weekend mood...take intelligent decisions for the next week!!!");
				break;
			case "Saturday":
				Console.WriteLine("Its Week end!!!");
				break;
			default:
				Console.WriteLine("Input properly..We are talking about weekdays !!!");
				break;
		}
		Console.ReadLine();
	}
	
}