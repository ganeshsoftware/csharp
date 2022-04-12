using System;
using System.Threading;

namespace MultiThreadI
{
    class ThreadWithLocalCounter
    {
        static void Main(string[] args)
        {
            new Thread(threadJob).Start();

            threadJob();
        }

        static void threadJob()
        {
            for (int count = 0; count < 10; count++)
            {
                Console.Write("{0} ", count);
            }
        }
    }
}