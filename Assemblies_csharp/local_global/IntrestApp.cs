using System;
using Ganesh.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ganesh.Utils
{
	
	class IntrestCalculator
	{
		public static void Main()
		{
			
			try
			{
				Assembly mySimple = Assembly.Load("intrestcalculator, version=1.0.0.12,culture=en-IN,PublicKeyToken=3fbbcee0c21ddcb2");
				
				Type myType = mySimple.GetType("Interest");
				
				MethodInfo myMethod = myType.GetMethod("Message");

				object obj = Activator.CreateInstance(myType);
				
				object[] obj1 = new object[5];
				obj1[0] = 10000;
				obj1[1] = 4.6176;
				obj1[2] = 3.7;
				obj1[3] = 1;
				
				myMethod.Invoke(obj,null);
				
				Console.WriteLine();
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message.ToString());				
			}

		}
	}	
}

