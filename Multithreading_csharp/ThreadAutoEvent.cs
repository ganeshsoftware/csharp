using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample
{
    class Program
    {
        static AutoResetEvent autoEvent;

        static void DoWork()
        {
            Console.WriteLine("... Worker thread started.....Now waiting on Event!!!");
            autoEvent.WaitOne();
            Console.WriteLine("...Worker thread reactivated...Now exiting!!!...");
        }

		
        static void Main()
        {
            autoEvent = new AutoResetEvent(false);
			
            Console.WriteLine("main thread starting worker thread...");
		
			Thread t = new Thread(DoWork);
            t.Start();
	
			
            Console.WriteLine("main thread sleeping for 1 second...");
            Thread.Sleep(1000);
			
            Console.WriteLine("main thread signaling worker thread...");
            autoEvent.Set();
            Console.ReadLine();
        }
    }
}

