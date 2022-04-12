using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;


public class Book
{
	public string Title { get; set; }
	public decimal Price { get; set; }
	public decimal USprice { get; set; }
}

static class XML_Curd
{
	static  List<Book> bookList;
	
	public static List<Book> GetBooksList()
	{
		//Console.WriteLine("GetBooksList");
		if (bookList == null)
			createBooksLists();

		return bookList;
	}
	
	private static void createBooksLists()
	{
		//Console.WriteLine("createBooksLists");
		// Books data read into memory from XML file using XLinq:
		bookList = (
			from e in XDocument.Load("Books.xml").
					  Root.Elements("book")
			select new Book
			{
				Title = (string)e.Element("title"),
				Price = (decimal)e.Element("price"),
				USprice = (decimal)e.Element("usprice"),
				
			})
			.ToList();
		//Console.WriteLine("showBooksLists");
	}
	
	public static void DisplayXml()
	{
		List<Book> books = GetBooksList();

		var allBooks =
			from book in books
			where book.Price >  0.0M
			select book;

		Console.WriteLine("All Books from XML");
		foreach (var bookread in allBooks)
		{
			Console.WriteLine("Book Title: {0}, Book Price:{1}, USD Price: {2}", bookread.Title, bookread.Price, bookread.USprice);
		}
	}
	
	public static void Main()
	{
		Int32 choice;
		Console.WriteLine("Please enter your choice..");
		Console.WriteLine("1 - List the XML File | 2 - Add an XML Node | 3- Delete and XML Node | 4 - Edit and XML Node");
		
		choice = Convert.ToInt32(Console.ReadLine());
		
		switch (choice)
		{
			case 1:
					Console.WriteLine("The XML File is as below:");
					DisplayXml();
			
			break;


			
			case 2:
					Console.WriteLine("Please enter the details as asked below");
					
					// create an instance of a new book.
					Book addBook = new Book();
					
					Console.WriteLine("Please enter the TITLE of the book");
					addBook.Title = Console.ReadLine();
					
					Console.WriteLine("Please enter the PRICE of the book");
					addBook.Price = Convert.ToDecimal(Console.ReadLine());
					
					Console.WriteLine("Please enter the PRICE in the US of the book in $");
					addBook.USprice = Convert.ToDecimal(Console.ReadLine());
					
					// We have the addBook object. Append this to the XML file.
					
					/*
						 //Add new Element
						 xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

						//Add new Element at First
						xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

						var result = xdoc.Element("Departments").Descendants();
				
					*/
		
			break;
			


			case 3:
					Console.WriteLine("Please enter the TITLE of the node to be deleted.");						
					string titleToDelete = Console.ReadLine();
					
										
					// Read XML File and convert it to List<Book> - Refer XML Reading.
					
					List<Book> mybooks = new List<Book>();
					
										
					foreach(Book book in mybooks)
					{
						if(book.Title.Equals(titleToDelete))
						{
							// write the linq query for deletion.
							/*
							         
								xdoc.Descendants().Where(s =>s.Value == titleToDelete).Remove(); 
								var result = xdoc.Element("Departments").Descendants();
							*/
														
							Console.WriteLine("The book with the title {0} has been successfully deleted.",titleToDelete);
							
							// display the values after deletion.
							foreach (XElement item in result) 
							{
								Console.WriteLine("Department Name - " + item.Value);
							}
						
						}
						else
						{
							Console.WriteLine("The book with the given title {0} doesn't exist in the catalog",titleToDelete);
						}
					}
					
					// Write the object back to the XML File - Refer XML Writing for this. 
			break;
			
			case 4:
					Console.WriteLine("Please enter the title of the node to be edited.");			
					string titleToEdit = Console.ReadLine();
					
					// Read XML File and convert it to List<Book> - Refer XML Reading.
					
					mybooks = new List<Book>();
					
					Book editBook = new Book();
					
				
					Console.WriteLine("Please enter the EDITED PRICE of the book");
					editBook.Price = Convert.ToDecimal(Console.ReadLine());
					
					Console.WriteLine("Please enter the EDITED PRICE in the US of the book in $");
					editBook.USprice = Convert.ToDecimal(Console.ReadLine());					
					
					// We have the editBook object. Write this to the XML file.
			
			break;
			
			
			default:
					Console.WriteLine("Its a wrong choice!");			
			break;
			
		}
	}
}

