using System;
using System.Collections;
using System.Collections.Generic;



string str1 = "This is a beautiful country in which you can see waterfalls";






class NotMoreThan10WordsException:Exception
{
	
	
}

catch(NotMoreThan10WordsException ex)
{
	
	
}



class ExceptionTesting
{
	public static void Main(string[] args)
	{
		try
		{
			Int32 x = 10;
			
			Int32 y = 0;
			
			Int32 result;
			
			result = x/y;
			
			
			
			
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Divide By Zero Exception");
		}		
		
		catch (ArithmeticException)
		{
			Console.WriteLine("Arithmetic Exception");
		}
		
		catch (Exception)
		{
			Console.WriteLine("General Exception");
		}		
		
	}
}