#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace QueueDemo
{

	public class Document
	{
		private string title;
		public string Title
		{
			get
			{
				return title;
			}
		}

		private string content;
		public string Content
		{
			get
			{
				return content;
			}
		}

		public Document(string title, string content)
		{
			this.title = title;
			this.content = content;
		}
	}

	public class ProcessDocuments
	{
		public static void Start(DocumentManager dm)
		{
			new Thread(new ThreadStart(new ProcessDocuments(dm).Run)).Start();
		}

		protected ProcessDocuments(DocumentManager dm)
		{
			documentManager = dm;
		}

		private DocumentManager documentManager;

		protected void Run()
		{
			while (true)
			{
				if (documentManager.IsDocumentAvailable)
				{
					Document doc = documentManager.GetDocument();
					Console.WriteLine("Processing document {0}", doc.Title);
				}
				Thread.Sleep(new Random().Next(20));
			}
		}
	}


	public class DocumentManager
	{
		private readonly Queue<Document> documentQueue = new Queue<Document>();

		public void AddDocument(Document doc)
		{
			lock (this)
			{
				documentQueue.Enqueue(doc);
			}
		}

		public Document GetDocument()
		{
			Document doc;
			lock (this)
			{
				doc = documentQueue.Dequeue();
			}
			return doc;
		}

		public bool IsDocumentAvailable
		{
			get
			{
				return (documentQueue.Count > 0) ? true : false;
			}
		}
	}



	class Program
	{
		static void Main(string[] args)
		{
			DocumentManager dm = new DocumentManager();

			ProcessDocuments.Start(dm);

			for (int i = 0; i < 1000; i++)
			{
				Document doc = new Document("Doc " + i.ToString(), "content");
				dm.AddDocument(doc);
				Console.WriteLine("added document {0}", doc.Title);
				Thread.Sleep(new Random().Next(20));
			}

		}
	}
}
