using System;
using System.Collections.Generic;

class Student
{
	public Int32 Id {get; set;}	
	public string Name {get; set;}	
}

class QueueTest
{
	
	public static void Main()
	{
		Queue<Int32> myQueue = new Queue<Int32>();
		myQueue.Enqueue(98);
		myQueue.Enqueue(95);
		myQueue.Enqueue(92);
		myQueue.Enqueue(97);
				
		DisplayCollectionContent(myQueue);
		Console.WriteLine("The count of my queue is {0}",myQueue.Count);
		
		myQueue.Dequeue();
		myQueue.Enqueue(108);		
		DisplayCollectionContent(myQueue);
		Console.WriteLine("The count of my queue is {0}",myQueue.Count);
		
		myQueue.Dequeue();
		

		DisplayCollectionContent(myQueue);
		Console.WriteLine("The count of my queue is {0}",myQueue.Count);
	}
	
	static void DisplayCollectionContent(Queue<Int32> s)
	{
		foreach(var a in s)
		{
			Console.WriteLine(a);
		}		
	}
}









