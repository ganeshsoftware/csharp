using System;
using System.Threading;

namespace MultiThreadII
{
    public class ThreadStats
    {
        public static void Main()
        {
            Thread pThread = Thread.CurrentThread;
            pThread.Name = "MyPrimaryThread";

            Console.WriteLine("Name of current AppDomain: {0}", Thread.GetDomain().FriendlyName);
            Console.WriteLine("ID of current Context: {0}",Thread.CurrentContext.ContextID);
            Console.WriteLine("Thread Name: {0}", pThread.Name);
            Console.WriteLine("thread started?: {0}", pThread.IsAlive);
            Console.WriteLine("Priority Level: {0}", pThread.Priority);
            Console.WriteLine("Thread State: {0}", pThread.ThreadState);
            Console.ReadLine();     
        }
    }
}