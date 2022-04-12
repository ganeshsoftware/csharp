using System;

class HalfPyramid_Inverted
{
	public static void Main()
	{
		for(Int32 i=1; i<=5; ++i)
		{
			for(int j=i;j>=1; --j)
			{
				Console.Write(" *");
			}
			Console.WriteLine();
		}
    }
}