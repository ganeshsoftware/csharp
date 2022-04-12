using System;

namespace Ganesh.Pointers
{
	class PointerDemo
	{
		public static void Main(string[] args)
		{
			unsafe
			{
				Int32 x = 108;
				Int32 *ptr = &x;
				Console.WriteLine((Int32)ptr);
				Console.WriteLine(*ptr);				
			}
		}
	}
}
