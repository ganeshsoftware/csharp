using System;

class Numbers
{
	public static void Main()
	{
		try
		{
			int[] myRollNumbers = new int[8] { 1, 3, 5, 7, 9, 12, 13};
			myRollNumbers[8] =100;
				
			Int32 A = 30;
			Int32 B = 0;
	
			Int32 result = A/B;
		
			Console.WriteLine("The quotient of {0} and {1} is {2}",A,B,result);	
		}
		
		catch (Exception ex)
		{
			//Console.WriteLine(ex.ToString());
			Console.WriteLine("general exception");
		}	
		catch (DivideByZeroException dvex)
		{
			//Console.WriteLine(dvex.ToString());
			Console.WriteLine("Dividing by zero is not good!");
		}
		catch (IndexOutOfRangeException iex)
		{
			Console.WriteLine("Index outof range !");
		}
		catch (SystemException sysex)
		{
			Console.WriteLine("Index outof range !");
		}
		finally
		{
			Console.WriteLine("FINALLY EXECUTED!!!");
			myRollNumbers = null;
		}
	}
}