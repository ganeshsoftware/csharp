using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
/*
A Multicast Delegate in C# is a delegate that holds the references of more than one function. When we invoke the multicast delegate, then all the functions which are referenced by the delegate are going to be invoked. If you want to call multiple methods using a delegate then all the method signatures should be the same.
*/

namespace Utils
{
    public delegate void RectangleDelete(double Width, double Height);

    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(@"Area is {0}", (Width * Height));
        }
		
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
        }
		
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