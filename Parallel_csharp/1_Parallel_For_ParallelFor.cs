using System;
using System.Threading;
using System.Threading.Tasks;

/*
	public static ParallelLoopResult Parallel.For(int fromInclusive, int toExclusive, Action<int> body);
*/


namespace ParallelProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# For Loop");
            int number = 10;
 
			for (int count = 0; count < number; count++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine("Value of count = {0}, thread = {1}",count,Thread.CurrentThread.ManagedThreadId);
            
				//Sleep the loop for 10 milliseconds
                Thread.Sleep(10);
            }
            
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			
			
			Console.WriteLine("Parallel For Loop");
            
			Parallel.For(0, number, count =>
            {
                Console.WriteLine("Value of count = {0}, thread = {1}",count,Thread.CurrentThread.ManagedThreadId);
                
				//Sleep the loop for 10 milliseconds
                Thread.Sleep(10);
            });
            
			Console.ReadLine();
        }
    }
}