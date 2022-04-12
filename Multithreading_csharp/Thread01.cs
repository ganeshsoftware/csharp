using System;
using System.Threading;

namespace MultiThreadI
{
    class FirstThread
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadJobA);
            Thread t2 = new Thread(threadJobB);
            t1.Start();
            t2.Start();
            threadJobMain();
            //t1.Start();
            //t2.Start();
        }

        static void threadJobA()
        {
            for (int i = 0; i < 101; i++)
            {
                Console.Write("A{0} ", i);
            }
        }

        static void threadJobB()
        {
            for (int i = 0; i < 101; i++)
            {
                Console.Write("B{0} ", i);
            }
        }

        static void threadJobMain()
        {
            for (int i = 0; i < 101; i++)
            {
                Console.Write("M{0} ", i);
            }
        }
    }
}