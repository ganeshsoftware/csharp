using System.Threading;
using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            //Creating Threads
            Thread t1 = new Thread(M1)
            {
                Name = "Thread1"
            };
			
            Thread t2 = new Thread(M2)
            {
                Name = "Thread2"
            };
            
			Thread t3 = new Thread(M3)
            {
                Name = "Thread3"
            };

            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
		
		
        static void M1()
        {
            Console.WriteLine("M1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("M1 :" + i);
            }
            Console.WriteLine("M1 Ended using " + Thread.CurrentThread.Name);
        }


        static void M2()
        {
            Console.WriteLine("M2 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("M2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 15 seconds
                    Thread.Sleep(15000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
            Console.WriteLine("M2 Ended using " + Thread.CurrentThread.Name);
        }


        
		static void M3()
        {
            Console.WriteLine("M3 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("M3 :" + i);
            }
            Console.WriteLine("M3 Ended using " + Thread.CurrentThread.Name);
        }
		
		
    }
}