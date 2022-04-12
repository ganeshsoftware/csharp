using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;
//using ObjectDumper;

namespace RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

              samples.Linq21(); // This sample uses Take to get only the first 3 elements of the array

        }
        
        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal Total { get; set; }
        }

        public class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public Order[] Orders { get; set; }
        }
        
        class LinqSamples
        {
            private List<Customer> customerList;
            
            [Category("Partitioning Operators")]
            [Description("This sample uses Take to get the first 3 orders from customers " +
                         "in Washington.")]
            public void Linq21()
            {
                List<Customer> customers = GetCustomerList();

                var first3WAOrders = (
                    from cust in customers
                    from order in cust.Orders
                    where cust.Region == "WA"
                    select new { cust.CustomerID, order.OrderID, order.OrderDate })
                    .Take(3);

                Console.WriteLine("First 3 orders in WA:");
                foreach (var order in first3WAOrders)
                {
                    Console.WriteLine(order);
                }
            }
            
            public List<Customer> GetCustomerList()
            {
                if (customerList == null)
                    createLists();

                return customerList;
            }

            private void createLists()
            {
                // Customer/Order data read into memory from XML file using XLinq:
                customerList = (
                    from e in XDocument.Load("Customers.xml").
                              Root.Elements("customer")
                    select new Customer
                    {
                        CustomerID = (string)e.Element("id"),
                        CompanyName = (string)e.Element("name"),
                        Address = (string)e.Element("address"),
                        City = (string)e.Element("city"),
                        Region = (string)e.Element("region"),
                        PostalCode = (string)e.Element("postalcode"),
                        Country = (string)e.Element("country"),
                        Phone = (string)e.Element("phone"),
                        Fax = (string)e.Element("fax"),
                        Orders = (
                            from o in e.Elements("orders").Elements("order")
                            select new Order
                            {
                                OrderID = (int)o.Element("id"),
                                OrderDate = (DateTime)o.Element("orderdate"),
                                Total = (decimal)o.Element("total")
                            })
                            .ToArray()
                    })
                    .ToList();
            }
        }
    }
}
