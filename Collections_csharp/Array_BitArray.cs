// C# code to create a BitArray

using System;
using System.Collections;

namespace Mimsys.CSTraining2021.Collections
{
	class ShowBitArray 	
	{
		public static void Main()
	    {
			BitArray bitarr_01 = new BitArray(4);
			
  
			bitarr_01[0] = true;
			bitarr_01[1] = true;
			bitarr_01[2] = false;
			bitarr_01[3] = true;
        
			Console.WriteLine("******** bitarr_01 *********");
			// display the values in the array.
			for(Int32 counter=0; counter<=bitarr_01.Length-1; counter++)
			{
				Console.WriteLine(bitarr_01.Get(counter));	
			}
			
			Console.WriteLine("Total number of elements in bitarr_01 are {0}",bitarr_01.Count);
			
			
			
			Console.WriteLine();
			Console.WriteLine();
			

			Console.WriteLine("******** bitarr_02 *********");			
			// another way of initialization - 
			BitArray bitarr_02 = new BitArray(new byte[] { 0, 0, 0, 1 }); 
			
			
			foreach(Object obj in bitarr_02)
			{
				Console.WriteLine(obj);
			}			
			
			Console.WriteLine("Total number of elements in bitarr_02 are {0}",bitarr_02.Count);
		}
	}
}