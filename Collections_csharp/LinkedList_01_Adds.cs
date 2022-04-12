using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

class LinkedListAdds
{
	public static void Main()
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

		// Accessing the elements of
		// LinkedList Using foreach loop
		foreach(string doc in doctors)
		{
			Console.WriteLine(doc);
		}		
			
		
	}
}


