using System;

public delegate Int32 CompareOperations(Int32 a, Int32 b);

class TestClass
{
	public static void Main()
	{
			
			CompareOperations cops = new CompareOperations(CheckNumbers)
			CompareOperations cops = delegate(Int32 x1, Int32 y1)
			{
						if (x1>y1)
						{
							 return 1;
						}
						else 
						{
							return 2;
						}
						//Console.WriteLine(result);
			};
			
			Console.WriteLine(cops(15,15));
	}
}

/*
public Int32 CheckNumbers(Int32 x, Int32 y)
{
	if (x>y)
	{
	   return 1;
	}
	else
	{
       return 2;
	}
}
*/