using System;

class Sample01
{
		public static void Main()
		{
			Int32 number1,number2,option;
		
			Console.WriteLine("Please enter the following numbers for the desired operations:");
			
			Console.WriteLine("1 - Addition:");
			Console.WriteLine("2 - Subtraction:");
			Console.WriteLine("3 - Multiplication:");
			Console.WriteLine("4 - Division:");
			
			Console.Write("Enter the first number:");
			number1 = Convert.ToInt32(Console.ReadLine());
	
			Console.Write("Enter the second number:");
			number2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Please enter the option:	");
			option = Convert.ToInt32(Console.ReadLine());

			// A new instance of the Mathematical operation class.
			MathematicalOperations myoperations = new MathematicalOperations();
		
			
			switch (option)
			{
				case 1:
					Console.WriteLine("The sum of {0} and {1} is {2}",number1,number2, myoperations.Sum(number1,number2));	
				break;
				
				case 2:
			        Console.WriteLine("The difference of {0} and {1} is {2}",number1,number2,myoperations.Difference(number1,number2));	
				break;
				
				case 3:
					Console.WriteLine("The product of {0} and {1} is {2}",number1,number2,myoperations.Product(number1,number2));		
				break;
				
				case 4:
					Console.WriteLine("The quotient of {0} and {1} is {2}",number1,number2,myoperations.Quotient(number1,number2));		
				break;
				
				default:
					Console.WriteLine("Wrong Choice - Any number between 1 - 4.");
					break;
			}
			
		}
}

