using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingEvents
{
    class Program
    {
        static void Main()
        {
            /*
            List<Shipment> theshipments = new List<Shipment>();

            Shipment shp1 = new Shipment();
            Shipment shp2 = new Shipment();
            Shipment shp3 = new Shipment();
            Shipment shp4 = new Shipment();

            theshipments.Add(shp1);
            theshipments.Add(shp2);
            theshipments.Add(shp3);
            theshipments.Add(shp4);

            foreach (Shipment shp in theshipments)
            {
                shp.OnShipmentMade += new Shipment.ShipmentHandler(ShowUserMessage);
            }

    */
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
}
