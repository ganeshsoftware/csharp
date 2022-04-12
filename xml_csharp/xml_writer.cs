using System;
using System.Xml;

class WriteXML
{
	public static void Main()
	{
		XmlWriterSettings settings = new XmlWriterSettings();
		settings.Indent = true;
		settings.IndentChars = ("    ");
		settings.CloseOutput = true;
		settings.OmitXmlDeclaration = true;        
		
		using (XmlWriter writer = XmlWriter.Create("SVCET.xml",settings))
		{
			writer.WriteStartElement("book");
			
				writer.WriteElementString("title", "A book on C#.NET");
				writer.WriteElementString("author", "Dileep K");
				writer.WriteElementString("publisher", "Tata McGraw Hill");
				writer.WriteElementString("price", "300.95");
			
				writer.WriteStartElement("location");
					writer.WriteElementString("city", "chennai");
					
					writer.WriteElementString("state", "TN");			
				writer.WriteEndElement();
			writer.WriteEndElement();
			writer.Flush();
		}
		
	}
	
}
