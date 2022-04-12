using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutexExample
{
    class MutexDemo
    {
        // Create a new Mutex. The creating thread doesnt own the mutex.
        private static Mutex mut = new Mutex();
        private const int numIterations = 1;
        private const int numThreads = 3;

        static void Main(string[] args)
        {
            // Create the threads that will use the protected resource...
            for (int i = 0; i < numThreads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc));
                newThread.Name = String.Format("Thread{0}", i + 1);
                newThread.Start();
            }

            /*
             The Main thread exits... 
             but the application continues to run until all foreground threads have exited...
            */
            Console.ReadLine();

        }

        private static void ThreadProc()
        {
            for (int i = 0; i < numIterations; i++)
            {
                UseResource();            
            }
        
        }

        
        
        /*
            This method is a resource that must be synchronized so that only one at a time can enter.         
         */
        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the Mutex", Thread.CurrentThread.Name);
            if (mut.WaitOne(1000))
            {
                Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);
                Thread.Sleep(5000);

                mut.ReleaseMutex();
                Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
            }
            else
            {
                Console.WriteLine("{0} will not acquire the mutex", Thread.CurrentThread.Name);
            }
        }

    }
}
