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
        	new Client { Id = 2, Name = "Gambhir Prasad", Email = "gambhir.prasad@gmail.com" },
        	new Client { Id = 3, Name = "Virendra Kumar", Email = "veeru.kumar@gmail.com" },
        	new Client { Id = 4, Name = "Madanlal Tripathi", Email = "m_triphati@gmail.com" }
        };

	public static void Main()
	{
		
		// Lambda expression.
		IEnumerable<Client> myclients = LinqDemo.clients
										.Where(ty=>ty.Name == "Gane");
						



		foreach(Client myclnt in myclients)
		{
			Console.WriteLine(myclnt.Id + "  " + myclnt.Name + " " + myclnt.Email);
		}	

	}
}