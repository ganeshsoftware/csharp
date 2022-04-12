using System;
using System.Threading;

namespace MultiThreadI
{
    class ThreadInstanceTest
    {
        int count;

        static void Main(string[] args)
        {
            ThreadInstanceTest ti = new ThreadInstanceTest();
            new Thread(ti.threadJob).Start();
        }

        void threadJob()
        {
            while(count < 10)
            {
                Console.Write("{0} ", count++);
            }
        }
    }
}