using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace XMLOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			LinqSamples samples = new LinqSamples();
			samples.LinqXml();
		}
	}
	
	public class Book
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
		public decimal USprice { get; set; }
	}

	public class LinqSamples
	{
		private List<Book> bookList;
		
		public void LinqXml()
		{
			List<Book> books = GetBooksList();

			var allBooks =
				from book in books
				where book.Price >= 0.0M
				select book;

			Console.WriteLine("All Books from XML");
			foreach (var bookread in allBooks)
			{
				Console.WriteLine("Book Title: {0}, Book Price:{1}, USD Price: {2}", bookread.Title, bookread.Price, bookread.USprice);
			}
		}

		public List<Book> GetBooksList()
		{
			//Console.WriteLine("GetBooksList");
			if (bookList == null)
				createBooksLists();

			return bookList;
		}
		private void createBooksLists()
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
	}
}