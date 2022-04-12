using System;

public delegate double BasicOperation(double x, double y);

public static class MathOperations
{
	public static double Add(double a, double b)
	{
		return a + b;
	}
	public static double Subtract(double a, double b)
	{
		return a - b;
	}
}

class Program
{
	public static void Main()
	{
		
		// Wrapping the MathOperations.Add() with the BasicOperation delegate
		BasicOperation baseops = new BasicOperation(MathOperations.Add);
		
		// adding one more method to the baseops delegate instance.
		baseops += MathOperations.Subtract;

		Console.WriteLine();
        
		
		// Invoke the first delegate.
		double difference = baseops.Invoke(76.89, 23.11);
		
		baseops -= baseops.Subtract;
		
		double sum = baseops.Invoke(76.89, 23.11);
		
		Console.WriteLine(difference);
		Console.WriteLine(sum);
		
		Console.ReadLine();
	}
}


/*

    public class Rectangle
    {

		static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);
            //RectangleDelete rectDelegate = rect.GetArea;

            //binding a method with delegate object
            // In this example rectDelegate is a multicast delegate. You use += operator 
            // to chain delegates together and -= operator to remove.

            rectDelegate += rect.GetPerimeter;
            rectDelegate(23.45, 67.89);

            Console.WriteLine();
            rectDelegate.Invoke(13.45, 76.89);

            Console.WriteLine();
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);

            Console.ReadKey();
        }
    }
}
*/