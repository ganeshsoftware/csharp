/*
In C#, it is possible to throw an exception programmatically. The 'throw' keyword is 
used for this purpose. The general form of throwing an exception is as follows. 

throw exception_obj; 
*/

using System;

class MyClient
{
    public static void Main()
    {
        try
        {
            throw new DivideByZeroException("Invalid Division done by GaneshN");
        }
		
        catch (DivideByZeroException ex)
        {
            //Console.WriteLine("Exception");
			Console.WriteLine(ex.ToString());
        }
		
        Console.WriteLine("LAST STATEMENT");
    }  
}


