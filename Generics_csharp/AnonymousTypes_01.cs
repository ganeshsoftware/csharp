// C# program to illustrate the concept of Anonymous Types.

using System;

namespace Mimsys.Training.Generics.AnonymousTypes
{
	public class Doctor  
	{
		// Main method 
		static public void Main()
		{
			// Creating and Initializing Anonymous Object
			var xyz = new 
			{
				Id = 108, 
				Name = "Suresh Kumar", 
				Department = "Out Patient Department!" 
			};
			
			// Accessing the object properties
			Console.WriteLine("Doctor Identification: " + xyz.Id);
			Console.WriteLine("Doctor Name: " + xyz.Name);
			Console.WriteLine("Language: " + xyz.Department);
		}
	}
}