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

using System;
using System.Threading;
using System.Collections.Generic;


public static class ServerCommunication
{
	public static void ReadDataFromChennaiServer()
	{
		for(Int32 counter=1; counter<=360; counter++)
		{
			Console.WriteLine("CHENNAI SERVER: The server is reading the {0} data segment.",counter);
			
		
		}
	}
	
	public static void WriteDataToTirupatiServer()
	{
		for(Int32 counter=1; counter<=720; counter++)
		{
			Console.WriteLine("TIRUPATHI SERVER: The server is writing the {0} data segment.",counter);	
		}		
	}	
}


public class BengaluruServer  
{
	
	public static void Main()
	{
		
		Thread thread01 = new Thread(ServerCommunication.ReadDataFromChennaiServer);
		Thread thread02 = new Thread(ServerCommunication.WriteDataToTirupatiServer);
		
		thread01.Start();
		thread02.Start();
		
    	Console.ReadLine();
	}

}






