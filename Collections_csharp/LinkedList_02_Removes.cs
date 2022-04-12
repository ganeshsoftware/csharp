using System;
using System.Collections.Generic;

class LinkedListRemoves
{

	// Main Method
	static public void Main()
	{

		// Creating a linkedlist
		// Using LinkedList class
		LinkedList<String> doctors = new LinkedList<String>();

		// Adding elements in the LinkedList
		// Using AddLast() method
		doctors.AddLast("Suresh Kumar");
		doctors.AddLast("Rohit Sharma");
		doctors.AddLast("Diwakar Balaji");
		doctors.AddLast("Shoaib Akhtar");
		doctors.AddLast("Lata usgaonkar");
		doctors.AddLast("Kamal Kumar Mittal");

		Console.WriteLine("Best doctors of Columbia Asia:");

		// Accessing the elements of LinkedList Using foreach loop
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}	

		Console.WriteLine("---------------------------------------------------");
		
		// After using Remove(LinkedListNode) method
		Console.WriteLine("Best doctors of Columbia Asia:");
		doctors.Remove(doctors.First);
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}

		Console.WriteLine("---------------------------------------------------");
		
		// After using Remove(T) method
		Console.WriteLine("Best doctors of Columbia Asia:");
		doctors.Remove("Kamal Kumar Mittal");
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}

	    Console.WriteLine("---------------------------------------------------");

		// After using RemoveFirst() method
		Console.WriteLine("Best doctors of Columbia Asia:");
		doctors.RemoveFirst();
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}

		Console.WriteLine("---------------------------------------------------");

		// After using RemoveLast() method
		Console.WriteLine("Best doctors of Columbia Asia:");
		doctors.RemoveLast();
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}

		Console.WriteLine("---------------------------------------------------");
		
		// After using Clear() method
		doctors.Clear();
		Console.WriteLine("Number of Doctors: {0}", doctors.Count);
	}
}
