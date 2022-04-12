using System;
using System.Collections;
using System.Collections.Generic;

namespace Ganesh.LambdaExpressions
{

	public delegate Int32 GanUnaryOps (Int32 x);

	class LambdaTest
	{
		public static void Main()
		{
			
			/*
			// Anonymous method equivalent of mysquare delegate instance.
			GanUnaryOps mysquare = new GanUnaryOps(
			delegate(int x)
			{
				Int32 result;
				result = x * x;
				return result;  
			});
			*/
			
			// lambda expression equivalent of mysquare delegate instance.
			GanUnaryOps mysquare = x => x * x;
			Console.WriteLine("The Square of {0} is {1} ",5,mysquare(5));

			
			
			/*
			// Anonymous method equivalent of mycube delegate instance.
			GanUnaryOps mycube = new GanUnaryOps(
			delegate(int x)
			{
				Int32 result;
				result = x * x * x;
				return result;  
			});
			*/
			// lambda expression equivalent of mycube delegate instance.
			GanUnaryOps mycube = x => x * x * x; 
			Console.WriteLine("The Cube of {0} is {1}",5, mycube(5));
		}
	}
}

