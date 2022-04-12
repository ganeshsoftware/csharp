using System;

class ThreeDArray
{
	public static void Main()
	{

		Int32[,,] marks = new Int32[3,4,4] {
			{
				{19,21,23,25},
				{78,44,23,45},
				{23,94,73,36},
				{22,44,34,91}
			},
			{
				{11,22,33,44},
				{90,08,42,22},
				{12,13,90,73},
				{01,22,33,35}
			},
			{
				{23,34,45,84},
				{41,78,75,99},
				{01,76,43,21},
				{32,67,75,90}
			}
			};
				
		Console.WriteLine(marks[2,3,3]);
		Console.WriteLine(marks[0,2,2]);
	}
}