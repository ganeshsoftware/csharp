using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            M1();
            M2();
            M3();
            Console.Read();
        }

        static void M1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("	M1 :" + i);
            }
        }
        
        static void M2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("	M2 :" + i);
            }
        }

        static void M3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("	M3 :" + i);
            }
        }
    }
}