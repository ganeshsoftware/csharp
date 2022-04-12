/* 
	C# program to illustrate how a Anonymous type as a delegate
*/

using System;

namespace Mimsys.Training.Generics.AnonymousTypes
{
	public class Surgeon
	{
		static public void Details(dynamic val)
		{
			Console.WriteLine(val.Id + "  " + val.Name + "   " + val.Department);
		}

		static public void Main()
		{
			// Anonymous type object which has NO TYPE NAME.
			var Suresh_Kumar = new {Id = 134, Name = "Suresh Kumar", Department = "Out Patient Department!"};
			
			// Calling mymethod
			Details(Suresh_Kumar);
		}
	}
}