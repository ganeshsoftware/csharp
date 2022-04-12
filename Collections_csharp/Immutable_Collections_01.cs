/*
static ImmutableList<int> numberList = new List<int> {1,2,3,4,5}.ToImmutableList

static Ditionary<Int32,string> numberDictionary = new Ditionary<Int32,string>
{
	1,"Ganesh N",
	2,"",
	3,"",
	4,"",
} 

1) Dispose() and Finalize()
2) Pointers in .NET
3) Custom RE with an Example.
4) 

ImmutableCollection
*/

using System;
using System.Collections;
using System.Collections.Immutable;
using System.Collections.Generic;



namespace Ganesh.Collections
{
	class Program
	{	
		static List<Int32> numberList = new List<Int32> {53,67,88,67,35}.ToImmutableList();
		
		public static void Main(string[] args)
		{
			//PrintList(numberList);
			
			//numberList = new List<Int32> {673,738,628};
			
			PrintList(numberList);
			
			//changing the values of the List<T>
			numberList[0] = 108;
			
			//adding values to the numberlist
			numberList.Add(1008);
			numberList.Add(1);
			PrintList(numberList);
		}

		// A static method to Print INTS.
		static void PrintList(List<Int32> mylist)
		{
			foreach(var ctr in mylist)
			{
				Console.Write(ctr + " , ");
			}
			Console.WriteLine();
		}
	}	
}