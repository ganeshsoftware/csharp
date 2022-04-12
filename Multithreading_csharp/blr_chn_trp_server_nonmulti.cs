/*
	// Chennai server 
	Dataset 1
	Read 3600 Kb of data from this server to my application - Bengaluru server 

	// Bengaluru server 
	//Application execution 

	// Tirupati Server 
	Dataset 2
	// Write 7200 Kb of data from the application to this server.
*/


/* Non threaded version */

using System;
using System.Threading;

class BengaluruServer
{
	public static void Main()
	{
		// 1 - Reading from the chennai server.
		for(Int32 counter=1; counter<=3600; counter++)
		{
			Console.WriteLine("CHENNAI SERVER: The server is reading the {0} data segment.",counter);
			
			
			if(counter == 1000)
			{
				throw new Exception();
			}
		    
		}
		
		// 2 - Writing to the Tirupathi server
		for(Int32 counter=1; counter<=7200; counter++)
		{
				Console.WriteLine("TIRUPATHI SERVER: The server is writing the {0} data segment.",counter);	
		}		
	}		
	
}