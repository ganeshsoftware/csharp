using System;

class JaggedArray
{
	public static void Main()
	{
		/*
			[[
				1, 2, 3, 4 ],
				[108,90],
				[563,783],
				[11,22],
				[12,22,23],
				[11,235,91]
			]
		*/
		
		// Declare a jagged array
        int[][] jaggedArray = new int[6][];
		
		// Set the values of the first array in the jagged array structure
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        jaggedArray[1] = new int[2] { 108,90 };
	    jaggedArray[2] = new int[2] { 563,783 };
	    jaggedArray[3] = new int[2] { 11,22 };
	    jaggedArray[4] = new int[3] { 12,22,23 };
	    jaggedArray[5] = new int[3] { 11,235,91 };
		
		for(Int32 counter=0; counter<=jaggedArray.Length-1; counter++)
		{
			Console.WriteLine(jaggedArray[counter][2]); 
			
		}
	}
}	
	
	
	

		
