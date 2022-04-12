using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ganesh.Tasks
{
	public static class TaskCancellationDemo
	{
		/// <summary>
		/// Compute a value for a long time.
		/// </summary>
		/// <returns>The value computed.</returns>
		/// <param name="loop">Number of iterations to do.</param>
		private static Task<decimal> LongRunningOperation(int loop)
		{
			// Start a task and return it
			return Task.Run(() =>
			{
				decimal result = 0;

				// Loop for a defined number of iterations
				for (int i = 0; i < loop; i++)
				{
					Console.WriteLine(i);
					// Do something that takes times like a Thread.Sleep in .NET Core 2.
					Thread.Sleep(10);
					result += i;
				}

				return result;
			});
		}
		
		public static async Task ExecuteTaskAsync()
		{
			//Console.WriteLine(nameof(ExecuteTaskAsync));
			Console.WriteLine("Result {0}", await LongRunningOperation(100));
			Console.WriteLine("Press enter to continue");
			Console.ReadLine();
		}			
		
	}	
	
	public class Program
	{
		public static void Main(string[] args)
		{
			TaskCancellationDemo.ExecuteTaskAsync();
						
		}
	}
	
	
}//nm