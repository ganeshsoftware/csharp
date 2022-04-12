#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace Wrox.ProCSharp.Generics
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

	public class ProcessDocuments<TDocument, TDocumentManager> 
		where TDocument: IDocument
		where TDocumentManager: IDocumentManager<TDocument>
	{
		public static void Start(TDocumentManager dm)
		{
//			ProcessDocuments<T, U> pd;
//			pd = new ProcessDocuments<T, U>(dm);
//			Thread t1 = new Thread(new ThreadStart(pd.Run));
//			t1.Start();

			// new Thread(new ThreadStart(new ProcessDocuments<T, U>(dm).Run)).Start();
			new Thread(new ProcessDocuments<TDocument, TDocumentManager>(dm).Run).Start();
		}

		protected ProcessDocuments(TDocumentManager dm)
		{
			documentManager = dm;
		}

		private TDocumentManager documentManager;

		protected void Run()
		{
			while (true)
			{
				if (documentManager.IsDocumentAvailable)
				{
					TDocument doc = documentManager.GetDocument();
					Console.WriteLine("Processing document {0}", doc.Title);
				}
				Thread.Sleep(20);
			}
		}
	}

	public interface IDocumentManager<T>
	{
		void AddDocument(T doc);
		T GetDocument();
		bool IsDocumentAvailable
		{
			get;
		}
	}

	public class DocumentManager<T> : IDocumentManager<T>
	{
		private Queue<T> documentQueue = new Queue<T>();

		public void AddDocument(T doc)
		{
			lock (this)
			{
				documentQueue.Enqueue(doc);
			}
		}

		public T GetDocument()
		{
			T doc;
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
				Document d1 = new Document("title" + i.ToString(), "content");
				dm.AddDocument(d1);
				Console.WriteLine("added document {0}", d1.Title);
				Thread.Sleep(10);
			}

		}
	}
}
