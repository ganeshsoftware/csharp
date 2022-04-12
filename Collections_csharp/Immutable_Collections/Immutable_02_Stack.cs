using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Ganesh.Collections.Immutables
{
	class ImmutableStackDemo
	{      
		public static void Main(string[] args)
		{
			var immutstack = ImmutableStack<Int32>.Empty;
			
			for(int i = 0; i < 10; i++)
			{
				immutstack = immutstack.Push(i);
			}
			
			Console.WriteLine("No of elements in original stack: {0}",immutstack.Count());
			
			var immutstackNew = immutstack.Pop();
			
			Console.WriteLine("No of elements in new stack: {0} ",immutstackNew.Count());
			
			Console.ReadKey();
		}
	}
}