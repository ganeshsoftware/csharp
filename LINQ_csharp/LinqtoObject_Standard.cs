using System;
using System.Linq;
using System.Collections.Generic;


public class Client
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
}


public class LinqDemo
{
	
        private static readonly List<Client> clients = new List<Client>(){
        	new Client { Id = 1, Name = "Ganesh N", Email = "ganeshsoftarch@gmail.com" },
        	new Client { Id = 2, Name = "Animesh Jha", Email = "animesh.jha@gmail.com" },
        	new Client { Id = 3, Name = "Chintamani Pradhan", Email = "chintamani.pradhan@gmail.com" },
        	new Client { Id = 4, Name = "Asha Kumari Singh", Email = "ashakumari.singh@gmail.com" }
        };


	public static void Main()
	{
		
		// Simple Query.
		var selectedClients = from mystudent in LinqDemo.clients
 				      where mystudent.Name.Contains("t")
                                      select mystudent;

		foreach(Client myclient in selectedClients)
		{
			Console.WriteLine(myclient.Id + "  " + myclient.Name + " " + myclient.Email);
		}	

	}
}