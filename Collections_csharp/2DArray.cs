using System;

class TwoDArray
{
	public static void Main()
	{
		//4 rows, 2 columns
		int[,] array = new int[4,2]; 
		
		// Two-dimensional array.
		int[,] array2D = new int[,] { 
										{ 1, 2, 1, 5 }, 
										{ 3, 4, 5, 4 }, 
										{ 5, 6, 7, 8 }, 
										{ 7, 8, 8, 8 }, 
										{ 9, 0, 8, 0 } 
									};
		
		// The same array with dimensions specified.
		int[,] array2Da = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

		// A similar array with string elements.
		string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },{ "five", "six" } };
	
	    // Another 2-dimensional array.
		Int32[,] arr2d = new Int32[4,3] {{2,4,3},{1,6,9},{21,108,16},{11,12,29}};
		
		Console.WriteLine(arr2d[2,1]);
		Console.WriteLine(array2Da[3,1]);
		Console.WriteLine(array2D[2,2]);
	}
}