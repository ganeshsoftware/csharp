using System;

namespace Ganesh.Pointers
{
	class PointerDemo
	{
		public PointerDemo()
		{
			unsafe
			{
				int x = 108;
				int *ptr = &x;
				Console.WriteLine((int)ptr);
				Console.WriteLine(*ptr);	

			}				
		}
		
		
		public static void Main(string[] args)
		{
				new PointerDemo();
		}
	}
}
