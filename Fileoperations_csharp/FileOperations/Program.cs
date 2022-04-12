using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Immutable;
namespace FileOperations
{
    class Program
    {
		public static void Main(string[] args)
		{
			var immutstack = ImmutableStack<Int32>.Empty;

			for (int i = 0; i < 10; i++)
			{
				immutstack = immutstack.Push(i);
			}

			Console.WriteLine("No of elements in original stack: {0}", immutstack.Count());

			var immutstackNew = immutstack.Pop();

			Console.WriteLine("No of elements in new stack: {0} ", immutstackNew.Count());

			Console.ReadKey();
		}

	}
}
