// Invoking a Method Asynchronously.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting.Messaging;


public delegate Int32 BinaryOp(Int32 x, Int32 y);


class Program
{
	 public Int32 Add(Int32 a, Int32 b)
     {
		//Print out the ID of the executing thread
		Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

		//wait some time
		Thread.Sleep(5000);

		//perform the task
		return (a + b);
     }
	

	public static void Main(string[] args)
	{
		Console.WriteLine("------ Async Delegate Invocation -------");
		
		//Print out the ID of the executing thread
        Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
		
		 //Invoke Add() on a secondary thread. The object required here to access Add() inside static method so don't have to bother
		 BinaryOp b = new BinaryOp(new Program().Add);
		 
		 // Call the BeginInvoke().
		 IAsyncResult iAs =  b.BeginInvoke(5, 5, null, null);
		 
    	while (!iAs.IsCompleted)
		{
			//Do some other work on priamry thread..
			Console.WriteLine("Doing some work in Main thread!");
			Thread.Sleep(100);
		}
		 
		 //Do some other work on primary thread..
         Console.WriteLine("Doing some work in Main()!");
		 
		 // Obtain the result of Add() when ready.
		 Int32 result = b.EndInvoke(iAs);
		 Console.WriteLine("5 + 5 is {0}", result);
		 
		 Console.ReadLine();
	}
}