// using the XmlReader class.
using System;
using System.Xml;
using System.Text;

class ReadXML
{
	public static void Main()
	{
		
		StringBuilder builder = new StringBuilder();
		XmlReader reader = XmlReader.Create("books.xml");
		while(reader.Read())
		{
			if(reader.NodeType == XmlNodeType.Text)
			{
				builder.Append(reader.Value + "\n");
			}
		}
		Console.WriteLine(builder.ToString());
	
	}
}