using System;
using System.Threading.Tasks;
using System.Threading;
using System.Data;


namespace Ganesh.Tasks
{
	public class DatabaseOps
	{
		public DataTable ReadData()
		{
			DataTable dt = new DataTable();
			
			// This mimics a situation where we get data from the database using SqlReader.
			for(Int32 counter=0;counter<=100;counter++)
			{
				Console.WriteLine("Read {0} items from the database ...",counter);
				Thread.Sleep(100);
			}
			
			Console.WriteLine("Records successfully fetched and displayed!");
			return dt;
		}
		
		public async void SecondaryMethod()
		{
			Task<DataTable> task01 = new Task<DataTable>(ReadData);
			task01.Start();
			// Mimiced an operation.
			for(Int32 counter=0;counter<=100;counter++)
			{
				Console.WriteLine("Completed {0} iterations...",counter);
				Thread.Sleep(100);
			}
			
			DataTable dt1 = await task01;
			Console.WriteLine("Solid example!");
			Console.ReadKey();
		}
	}	
	
	public class DatabaseOpsTest
	{
		public static void Main()
		{
			DatabaseOps m_DatabaseOps = new DatabaseOps();
			m_DatabaseOps.SecondaryMethod();
		}		
	}
}