using System;


namespace Mimsys.Examples.Interfaces
{
	interface IOperations
	{
		Int32 Add(Int32 A, Int32 B);
		Int32 Subtract(Int32 A, Int32 B);
	}

	class Mimsys:IOperations
	{
		public Int32 Add(Int32 A, Int32 B)
		{
			return A + B;
		}
	 
		public	Int32 Subtract(Int32 A, Int32 B)
		{
			return A - B;
		}
	}

	class Infosys:IOperations
	{
		public Int32 Add(Int32 A, Int32 B)
		{
			return A + B;
		}
	 
		public	Int32 Subtract(Int32 A, Int32 B)
		{
			return A - B;
		}
	}
	
	class Test
	{
		public static void Main()
		{
			Console.WriteLine(new Mimsys().Add(40,40));
			
		}
		
		
	}
	
	
}