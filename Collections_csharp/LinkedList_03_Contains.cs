using System;
using System.Collections.Generic;

class LinkedListContains
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

		// Check if the given element is available or not
		if (doctors.Contains("Diwakar Balaji") == true)
		{
			Console.WriteLine("Element Found...!!");
		}
		else
		{
			Console.WriteLine("Element Not found...!!");
		}
	}
}
