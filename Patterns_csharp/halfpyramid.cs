using System;

class HalfPyramid
{
	public static void Main()
	{
		for(Int32 i=1; i<=5; ++i)
		{
			for(int j=1;j<=i; ++j)
			{
				Console.Write(" *");
			}
			Console.WriteLine();
		}
    }
}