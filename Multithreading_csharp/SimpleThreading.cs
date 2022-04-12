using System;
using System.Threading;

public static class CountOperation
{

// Read from Delhi server.
public static void ReadfromDelhiServer()
	{
		try
			{
					for(Int32 i=1;i<=100;i++)
					{
						Console.WriteLine("READING DATA NO:{0} FROM DELHI SERVER",i);
						if(i==10)
						{
							throw new Exception();
							
						}
					}				
			}
			catch 
			{
				Console.WriteLine("The link has been cut.. network disconnected");
			}
	}

	// Write to the Chennai Server.
	public static void WritetoChennaiServer()
	{
					try
					{
			
						for(Int32 i=1;i<=100;i++)
							{
								Console.WriteLine("WRITING DATA NO:{0} TO CHENNAI SERVER",i);  
							}
						}
					catch 
					{
						Console.WriteLine("The link has been cut.. network disconnected");
					}
	}
	
}


public class ServerTest
{
	public static void Main()
	{
		
				
		Thread t1 = new Thread(CountOperation.ReadfromDelhiServer);
		Thread t2 = new Thread(CountOperation.WritetoChennaiServer);
		
		t1.Start();
		t2.Start();
		
		Console.ReadLine();
	}

} 

