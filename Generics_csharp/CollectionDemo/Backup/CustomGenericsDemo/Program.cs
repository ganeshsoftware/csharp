#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace CustomGenericsDemo
{
	public interface IDocument
	{
		string Title
		{
			get;
		}

		string Content
		{
			get;
		}
	}

	public class Document : IDocument
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

//	public class ProcessDocuments<T>
//		where T : IDocument
//	{
//		public static void Start(DocumentManager<T> dm)
//		{
//			new Thread(new ThreadStart(new ProcessDocuments<T>(dm).Run)).Start();
//		}
//
//		protected ProcessDocuments(DocumentManager<T> dm)
//		{
//			documentManager = dm;
//		}
//
//		private DocumentManager<T> documentManager;
//
//		protected void Run()
//		{
//			while (true)
//			{
//				if (documentManager.IsDocumentAvailable)
//				{
//					T doc = documentManager.GetDocument();
//					Console.WriteLine("Processing document {0}", doc.Title);
//				}
//				Thread.Sleep(new Random().Next(20));
//			}
//		}
//	}

	public class ProcessDocuments<T, U>
		where T : IDocument
		where U : IDocumentManager<T>
	{
		public static void Start(U dm)
		{
			new Thread(new ThreadStart(new ProcessDocuments<T, U>(dm).Run)).Start();
		}

		protected ProcessDocuments(U dm)
		{
			documentManager = dm;
		}

		private U documentManager;

		protected void Run()
		{
			while (true)
			{
				if (documentManager.IsDocumentAvailable)
				{
					T doc = documentManager.GetDocument();
					Console.WriteLine("Processing document {0}", doc.Title);
				}
				Thread.Sleep(new Random().Next(20));
			}
		}
	}


//	public class DocumentManager<T>
//	{
//		private readonly Queue<T> documentQueue = new Queue<T>();
//
//		public void AddDocument(T doc)
//		{
//			lock (this)
//			{
//				documentQueue.Enqueue(doc);
//			}
//		}
//
//		public T GetDocument()
//		{
//			T doc = default(T);
//			lock (this)
//			{
//				doc = documentQueue.Dequeue();
//			}
//			return doc;
//		}
//
//		public bool IsDocumentAvailable
//		{
//			get
//			{
//				return (documentQueue.Count > 0) ? true : false;
//			}
//		}
//	}

	public interface IDocumentManager<T>
	{
		void AddDocument(T doc);
		T GetDocument();
		bool IsDocumentAvailable
		{
			get;
		}
	}

	public class DocumentManager<T>
		: IDocumentManager<T>
	{
		private readonly Queue<T> documentQueue = new Queue<T>();

		public void AddDocument(T doc)
		{
			lock (this)
			{
				documentQueue.Enqueue(doc);
			}
		}

		public T GetDocument()
		{
			T doc = default(T);
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
			DocumentManager<Document> dm = new DocumentManager<Document>();

			ProcessDocuments<Document, DocumentManager<Document>>.Start(dm);

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
