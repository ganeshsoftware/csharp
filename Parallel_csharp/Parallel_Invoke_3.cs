using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    public class ParallelInvoke
    {
        static void Main()
        {
            //Allowing three task to execute at a time
            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 3
            };
            //parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount - 1;

            //Passing ParallelOptions as the first parameter
            Parallel.Invoke(
                    parallelOptions,
                    () => DoSomeTask(1),
                    () => DoSomeTask(2),
                    () => DoSomeTask(3),
                    () => DoSomeTask(4),
                    () => DoSomeTask(5),
                    () => DoSomeTask(6),
                    () => DoSomeTask(7)
                );
            Console.ReadKey();
        }
        static void DoSomeTask(int number)
        {
            Console.WriteLine("DoSomeTask {0} started by Thread {1}",number,Thread.CurrentThread.ManagedThreadId);
            //Sleep for 5000 milliseconds
            Thread.Sleep(5000);
            Console.WriteLine("DoSomeTask {0} completed by Thread {1}",number,Thread.CurrentThread.ManagedThreadId);
        }
    }
}