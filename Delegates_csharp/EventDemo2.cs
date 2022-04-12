using System;

public class ShipArgs:EventArgs
{
	private string message;
	
	public ShipArgs(string message)
	{
		this.message = message;
	}
	
	public string Message
	{
		get
		{
			return message;
		}
	}
}

public class Shipment
{
	
	// 1. private variable declaration.
	private string trackingnumber;	
	
	// 2. The delegate we are assigning to our object
    public delegate void ShipmentHandler(object myObject, ShipArgs myArgs);
		
	//3. The event = OnShipmentMade | Delegate = ShipmentHandler
	public event ShipmentHandler OnShipmentMade;
	
	
	//4. Tracking number property that will be assigned.
	public string TrackingNumber
	{
		set 
		{
				trackingnumber = value;
				
				// we need to check weather a tracking number was assigned to the field.
				if(trackingnumber.Length !=0)
				{
					ShipArgs myArgs = new ShipArgs("Item has been shipped.");
					
					//Tracking number is available.
					OnShipmentMade(this, myArgs);
				}
		}
	}
	

	// Default constructor.
	public Shipment()
	{
					
	}
}



public class TestClass
{
	public static void Main()
	{
		Shipment myItem = new Shipment();
		
		myItem.OnShipmentMade += new Shipment.ShipmentHandler(ShowUserMessage);
		
		// we assumed that the item has been just shipped and we are assigning a tracking number to it.
        myItem.TrackingNumber = "1ZY444567";
		
		// The common procedure to see what is going on the console screen
        Console.Read(); 
	}

	static void ShowUserMessage(object a, ShipArgs e)
    {
        Console.WriteLine(e.Message);
    }
}












