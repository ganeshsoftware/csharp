using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingEvents
{
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
                if (trackingnumber.Length != 0)
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
}
