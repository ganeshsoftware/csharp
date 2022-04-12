using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
	 The following example demonstrates how to use Parallel Invoke method in C# with other methods, 
	 anonymous methods (delegates), and lambda expressions.
*/




namespace ParallelProgrammingDemo
{
    public class Program
    {
        static void Main()
        {
            Parallel.Invoke(
                 NormalAction, // Invoking Normal Method
                 
				 delegate ()   // Invoking an inline delegate 
                 {
                     Console.WriteLine("Method 2, Thread={0}",Thread.CurrentThread.ManagedThreadId);
                 },
                
				() =>   // Invoking a lambda expression
                {
                    Console.WriteLine("Method 3, Thread={0}",Thread.CurrentThread.ManagedThreadId);
                }
				
            );
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void NormalAction()
        {
            Console.WriteLine("Method 1, Thread={0}",Thread.CurrentThread.ManagedThreadId);
        }
    }
}