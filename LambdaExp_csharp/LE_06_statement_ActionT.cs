using System;
using System.Linq;
// using System.Collections.ObjectModel.ObservableCollection;

class Program
{
	public static void Main()
	{
            Action[] actions = new Action[2];

			
			
			Action<string> messagedisplay = msg => Console.WriteLine(msg);
			Action<int> intdisplay = intnumber => Console.WriteLine(intnumber+1);
			
			actions[0] = messagedisplay;
			actions[1] = intdisplay;

            messagedisplay("This is a wonderful city");
            //Console.ReadLine();
			
			// Statement Lambda with a Action<T> delegate.
			Action<string> greet = name =>
			{
				string greeting = "Hello " + name + "!";
				Console.WriteLine(greeting);
			};
			greet("Ganesh N");
	}
}

