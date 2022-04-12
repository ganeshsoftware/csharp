using System;
using System.Threading;

namespace MultiThreadI
{
    public class ThreadTest
    {
        static int count = 0;

        public static void Main()
        {
            new Thread(ThreadTest.staticJob).Start("s:");

            ThreadTest tt = new ThreadTest();
            new Thread(tt.instanceJob).Start("i:");
        }

        public static void staticJob(object data)
        {
            while (count < 30)
            {
                Console.Write("{0}{1} ", data, count++);
            }
        }

        public void instanceJob(object data)
        {
            while (count < 30)
            {
                Console.Write("{0}{1} ", data, count++);
            }
        }
    }
}