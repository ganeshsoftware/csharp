using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;


class PDFUtils
{
	public string ReadPdfFile(string fileName)
	{
		StringBuilder text = new StringBuilder();

		if (File.Exists(fileName))
		{
			PdfReader pdfReader = new PdfReader(fileName);
			for (int page = 1; page <= pdfReader.NumberOfPages; page++)
			{
				ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
				string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

				currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
				text.Append(currentText);
			}
			pdfReader.Close();
		}
		return text.ToString();
	}	
}

class Test
{
	public static void Main()
	{
		PDFUtils ganeshutils = new PDFUtils();
		Console.WriteLine(ganeshutils.ReadPdfFile("ExpPort1.pdf"));
	}
}