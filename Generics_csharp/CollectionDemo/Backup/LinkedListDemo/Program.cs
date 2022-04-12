#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace LinkedListDemo
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

		private byte priority;
		public byte Priority
		{
			get
			{
				return priority;
			}
		}

		public Document(string title, string content, byte priority)
		{
			this.title = title;
			this.content = content;
			this.priority = priority;
		}
	}

	public class PriorityDocumentManager
	{
		private readonly LinkedList<Document> fullList = new LinkedList<Document>();

		// priorities 0..9
		private readonly List<LinkedListNode<Document>> priorityNodes;

		public PriorityDocumentManager()
		{
			priorityNodes = new List<LinkedListNode<Document>>(10);
			for (int i = 0; i < 10; i++)
			{
				priorityNodes.Add(new LinkedListNode<Document>(null));
			}
		}

		public void AddDocument(Document d)
		{
			AddDocumentToPriorityNode(d, d.Priority);
		}

		private void AddDocumentToPriorityNode(Document doc, int priority)
		{
			if (priority > 9)
				throw new ArgumentException("Priority must be between 0 and 9");

			if (priorityNodes[priority].Value == null)
			{
				priority--;
				if (priority >= 0)
				{
					// check for the next lower priority
					AddDocumentToPriorityNode(doc, priority);
				}
				else	// until now no priority node exists with the same priority or lower
				{
					fullList.AddLast(doc);
					priorityNodes[doc.Priority] = fullList.Last;
				}
				return;
			}
			else
			{
				LinkedListNode<Document> priorityNode = priorityNodes[priority];
				if (priority == doc.Priority)	// priority node with the same priority exists
				{
					fullList.AddAfter(priorityNode, doc);

					// set the priority node to the last document with the same priority
					priorityNodes[doc.Priority] = priorityNode.Next;
				}
				else // only priority node with a lower priority exists
				{
					// get the first node of the lower priority
					LinkedListNode<Document> firstPriorityNode = priorityNode;
					while (firstPriorityNode.Previous != null && firstPriorityNode.Previous.Value.Priority == priorityNode.Value.Priority)
					{
						firstPriorityNode = priorityNode.Previous;
					}

					fullList.AddBefore(firstPriorityNode, doc);

					// set the priority node to the new value
					priorityNodes[doc.Priority] = firstPriorityNode.Previous;
				}
			}
		}

		public void DisplayAllNodes()
		{
			foreach (Document doc in fullList)
			{
				Console.WriteLine("priority: {0}, title {1}", doc.Priority, doc.Title);
			}
		}

		// returns the document with the highest priority (that's first in the linked list)
		public Document GetDocument()
		{
			Document doc = fullList.First.Value;
			fullList.RemoveFirst();
			return doc;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			PriorityDocumentManager pdm = new PriorityDocumentManager();
			pdm.AddDocument(new Document("one", "Sample", 8));
			pdm.AddDocument(new Document("two", "Sample", 3));
			pdm.AddDocument(new Document("three", "Sample", 4));
			pdm.AddDocument(new Document("four", "Sample", 8));
			pdm.AddDocument(new Document("five", "Sample", 1));
			pdm.AddDocument(new Document("six", "Sample", 9));
			pdm.AddDocument(new Document("seven", "Sample", 1));
			pdm.AddDocument(new Document("eight", "Sample", 1));


			pdm.DisplayAllNodes();

			Console.ReadLine();

		}
	}
}
