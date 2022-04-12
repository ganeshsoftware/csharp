using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Limiting the maximum degree of parallelism to 4
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 4
            };

            int n = 10;
            Parallel.For(0, n, options, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}