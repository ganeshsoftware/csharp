using System;
using System.Threading;

namespace MultiThreadI
{
// *** Thread with a static counter ***


    class ThreadWithStaticCounter
    {
        static int count;

        static void Main(string[] args)
        {
            new Thread(threadJob).Start();

            threadJob();
        }

        static void threadJob()
        {
            while(count < 10)
            {
                Console.Write("{0} ", count);
                count++;
            }
        }
    }
}