using System;

class MyClass
{
    public void Method()
    {
        try
        {
            int x = 0;
            int sum = 100 / x;
        }
        catch (DivideByZeroException)
        {
            throw;
        }
    }
}

class MyClient
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        
		try
        {
            mc.Method();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception caught here");
        }
        Console.WriteLine("LAST STATEMENT");
    }
}