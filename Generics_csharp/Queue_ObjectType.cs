using System;
using System.Collections;

class QueueObjectType
{
	public static void Main()
	{
		Queue busqueue = new Queue();
		busqueue.Enqueue(10);
		busqueue.Enqueue(true);
		busqueue.Enqueue("ganesh");
		busqueue.Enqueue('$');
		
		
		Int32 num1 = (Int32)(busqueue.Dequeue());
			
		bool result = (bool)(busqueue.Dequeue());
		
		
		foreach(object o in busqueue)
		{
			Console.WriteLine(o.ToString());
		}
	}
}