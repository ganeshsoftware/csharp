// Jagged Array with the four 2-D array

using System;
namespace Mimsys.Arrays.JaggedArrays 
{
	class TwoDJaggedArrays 
	{
		public static void Main()
		{
			// Declaration and Initialization of
			// Jagged array with 4 2-D arrays
			int[][,] jaggy = new int[][,] 
								{
									new int[,] {{1, 3, 108}, {5, 7, 108},{35, 87, 98}, {45, 71, 2}, {5, 74, 108}},
									new int[,] {{0, 2}},
									new int[,] {{97, 18}, {31, 15}, {90, 46}},
									new int[,] {{17, 81}, {43, 17}}

								};
			Console.WriteLine(jaggy.Length); // number of arrays within the jagged = 4
			Console.WriteLine(jaggy[0].GetLength(0)); // number of arrays in the 0th jag = 3
			
			for (Int32 counter = 0; counter <= jaggy.Length; counter++)
			{
				Int32 X = 0;
				
				for (Int32 in_counter = 0; in_counter <= jaggy[counter].GetLength(X); in_counter++)
				{
					
					for(Int32 inner_counter = 0 ; inner_counter <= jaggy[in_counter].Rank; inner_counter++)
					{
						Console.Write(jaggy[counter][in_counter,inner_counter] + "   ");
						Console.WriteLine();
					}
					
				}
				X++;
				Console.WriteLine();
			}
		}
	}
}