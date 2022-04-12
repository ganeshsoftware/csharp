using System;
using System.Threading;

/*
	As you can see in order to run the application code one thread is created and i.e. the Main Thread. So, this proves that, by default, every application is a single-threaded application.
*/


namespace Ganesh.MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the instance of the current thread.
			Thread t = Thread.CurrentThread;
            
			//By Default the Thread does not have any name - provide the name explicitly
            t.Name = "MAIN_THREAD"; 
            
			Console.WriteLine("Current Thread Executing is: " + t.Name);
            Console.WriteLine("Current Executing Thread name is: " + Thread.CurrentThread.Name);

            Console.Read();
        }
    }
}