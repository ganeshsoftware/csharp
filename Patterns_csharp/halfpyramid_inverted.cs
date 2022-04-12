using System;

class HalfPyramid_Inverted
{
	public static void Main()
	{
		for(Int32 i=5; i>=1; --i)
		{
			for(int j=1;j<=i; ++j)
			{
				Console.Write(" *");
			}
			Console.WriteLine();
		}
    }
}