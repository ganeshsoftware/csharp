using System;

class OneDimensionalArray
{
	public static void Main()
	{
		// an array of integers called as physicsmarks.
		int[] physicsmarks = new int[11]{12,14,17,21,108,89,92,95,95,93,34};
		
		// an array of integers called as chemistrymarks.
		int[] chemistrymarks = {89,92,95,95,93,14,17,12};
		
		
		try
		{
			for(Int32 count=0;count<11;count++)
			{
				Console.WriteLine(physicsmarks[count]);			
			}
		}
		catch(IndexOutOfRangeException indexp)
		{
			Console.WriteLine(indexp.ToString() + "    " + "INDEX OUT OF RANGE!!!");	
		}
	
		Console.WriteLine(physicsmarks[1] + 1);
		Console.WriteLine(chemistrymarks);
		
	}
}



