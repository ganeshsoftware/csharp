using System;
using System.Collections.Generic;

namespace Mimsys.Collections.Sets
{
	public class HashDemo1
	{
		public static void Main()
		{
			HashSet<Int32> numbers = new HashSet<Int32>();
			
			for(Int32 counter = 0; counter <=100; counter++)
			{
				numbers.Add(2*counter + 1);
			}
			
			// Duplicate numbers are not added in the hashset
			numbers.Add(101);
			numbers.Add(101);
			numbers.Add(101);
			numbers.Add(101);
			
			// Iterating the Set using a foreach.
			for(Int32 counter in numbers)
			{
				Console.WriteLine(counter);
			}			
			
			
			
			Console.WriteLine("The total number of items in this are {0}",numbers.Count);
			
			
			// Copying this to an array.
			Int32[] A = new Int32[numbers.Count];
            numbers.CopyTo(A);		
			
			// Contents of the Array in which the Set has been copied.
			for(Int32 counter =0; counter <= A.Length - 1; counter++)
			{
				Console.WriteLine("A[{0}] = {1}",counter-1,A[counter-1]);
			}			
		}		
	}
}
