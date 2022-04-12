#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using Wrox.ProCSharp.COMInterop.Server;
using System.Runtime.InteropServices;

#endregion

namespace Wrox.ProCSharp.COMInterop.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			COMDemo obj = new COMDemo();
			IWelcome welcome = (IWelcome)obj;
			Console.Write(welcome.Greeting("Christian"));

			obj.Completed +=
			   new ICompletedEvents_CompletedEventHandler(Completed);


			IMath math;
			math = (IMath)obj;
			int x = math.Add(4, 5);
			Console.WriteLine(x);

			Marshal.ReleaseComObject(math);

			Console.ReadLine();


		}

		private static void Completed()
		{
			Console.WriteLine("Calculation completed");
		}

	}
}
