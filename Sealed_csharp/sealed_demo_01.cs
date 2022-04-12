using System;

namespace ConsoleApplication2
{
    class MyClass1
    {
        public virtual void Test()
        {
            Console.WriteLine("My Class1 Test");
        }
    }
	
    
	class MyClass2
    {
        public override sealed void Test()
        {
            Console.WriteLine("My Class2 Test");
        }
    }	
	
	
	
	
	
	
	class Program:MyClass2
    {
        public override sealed void Test()
        {
            Console.WriteLine("My class Program");
        }
        
		
		static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();
            Console.ReadLine();
        }
    }




}