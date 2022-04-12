/*
	
	ThreadPool - public static class ThreadPool
	Parallel.Invoke(() => DoSomeWork(), () => DoSomeOtherWork());
	
	1) System.Threading.ThreadPool.dll, 
	2) mscorlib.dll, 
	3) netstandard.dll

*/

using System;
using System.Threading;

public class Example 
{
    public static void Main() 
    {
        // Queue the task.
        ThreadPool.QueueUserWorkItem(ThreadProc);
        Console.WriteLine("Main thread does some work, then sleeps.");
        Thread.Sleep(1000);

        Console.WriteLine("Main thread exits.");
    }



    // This thread procedure performs the task.
    static void ThreadProc(Object stateInfo) 
    {
        // No state object was passed to QueueUserWorkItem, so stateInfo is null.
        Console.WriteLine("Hello from the thread pool.");
    }
}
			
		
		// The example displays output like the following:
		// Main thread does some work, then sleeps.
		// Hello from the thread pool.
		// Main thread exits.


		
		/*
		If you comment out the call to the Thread.Sleep method, the main thread exits before method runs on the thread pool thread. 
		The thread pool uses background threads, which do not keep the application running if all foreground threads have terminated. 
		(This is a simple example of a race condition.)
		*/




