using System;
using System.Collections.Generic;



class Test
{
	public static void Main()
	{
		Queue<Int32> counters = new Queue<Int32>();
		counters.Enqueue(10);
		counters.Enqueue(108);
		
		Int32 num1 = counters.Dequeue() + 1;
		Console.WriteLine(num1);


		
	}
}