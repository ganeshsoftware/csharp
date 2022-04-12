using System;

class FullPyramid
{
	public static void Main()
	{
		try
		{
			Int32 n;
     		Console.WriteLine("Enter the number of rows!");		
			n = Int32.Parse(Console.ReadLine());	
			

			for(Int32 i=1; i<=n; ++i)
			{
		    
								
				for(int k=1; k<=n-i;++k)
				{
					Console.Write(" ");
				}

				for(int k=1; k<=i;++k)
				{
					Console.Write("*");
				}
		
				for(int k=n; k<=n+i;++k)
				{
					Console.Write("*");
				}
				Console.WriteLine();

			}
		}
			
		catch (Exception )
		{
				Console.WriteLine("Please enter a valid number!");
		}
	}
}