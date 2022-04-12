using System;
using System.Collections;

using System.Threading;


static class ServerOps
{
	public static void ReadNewDelhiData()
	{
		// Read from New Delhi Server 
		for(Int32 counter =0; counter<=720; counter++)
		{
			// ReadData.
			Console.WriteLine("NEW DELHI: Data block {0} has been read into Chennai server", counter);
			//Thread.Sleep(300);
		}
	}
	
	public static void ReadMumbaiData()
	{
		// Read from Mumbai Server
		for(Int32 counter =0; counter<=360; counter++)
		{
			// ReadData.
			Console.WriteLine("MUMBAI: Data block {0} has been read into Chennai server", counter);
			//Thread.Sleep(300);
		}
	}
}




class ReadData
{

	public static void Main()
	{
		Thread threadND = new Thread(ServerOps.ReadNewDelhiData);
		Thread threadMUM = new Thread(ServerOps.ReadMumbaiData);
		
		threadND.Start();
        threadMUM.Start();

	}
}


