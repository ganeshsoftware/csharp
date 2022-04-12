using System;
using System.Threading;

namespace MultiThreadI
{
    public class ThreadTest
    {
        public static void Main()
        {
            Thread newThread = new Thread(ThreadTest.threadJob);

            newThread.Start("Shared Thread");

            ThreadTest t = new ThreadTest();
            newThread = new Thread(t.moreThreadJob);

            newThread.Start("Instance Thread");
        }

        public static void threadJob(object data)
        {
            Console.WriteLine("{0}", data);
        }

        public void moreThreadJob(object data)
        {
            Console.WriteLine("{0}", data);
        }
    }
}