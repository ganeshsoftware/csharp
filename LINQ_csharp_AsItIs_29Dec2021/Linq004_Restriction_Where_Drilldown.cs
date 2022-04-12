using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using System.IO;
using System.Xml.Linq;

namespace Linq.RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            samples.Linq4(); // This sample uses the where  clause to find all customers in Washington and then it 
                               // uses a foreach loop to iterate over the orders collection that belongs to each 
                               // customer
        }

        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal Total { get; set; }
        }
		
		/*
		  <order>
			  <id>10643</id>
			  <orderdate>1997-08-25T00:00:00</orderdate>
			  <total>814.50</total>
		  </order>
		*/
		

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
		/*
			<id>ALFKI</id>
			<name>Alfreds Futterkiste</name>
			<address>Obere Str. 57</address>
			<city>Berlin</city>
			<postalcode>12209</postalcode>
			<country>Germany</country>
			<phone>030-0074321</phone>
			<fax>030-0076545</fax>
		*/
        public class LinqSamples
        {
            private List<Customer> customerList;

            [Description("This sample uses the where clause to find all customers in Washington " +
                     "and then it uses a foreach loop to iterate over the orders collection that belongs to each customer.")]
            public void Linq4()
            {
                List<Customer> customers = GetCustomerList();

                var waCustomers =
                    from cust in customers
                    where cust.Region == "WA"
                    select cust;

                Console.WriteLine("Customers from Washington and their orders:");
                foreach (var customer in waCustomers)
                {
                    Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                    }
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
