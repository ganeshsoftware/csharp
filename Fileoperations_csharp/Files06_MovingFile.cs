using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Ganesh.FileOperations
{
	class ReadWriteOps
	{
		public static void Main()
		{
			try
			{
				// Give a valid directory path from your file system.
				string myFilePath = @"E:\official\COMPANIES\Mimsys\mimsys_syllabus_17Jan2022.docx";
			
				FileInfo myFile = new FileInfo(myFilePath);
				myFile.CopyTo(@"E:\mimsys_syllabus.docx", true);
				
				
			}
			
			
			catch (System.IO.FileNotFoundException fnfex)
			{
				Console.WriteLine(fnfex.Message.ToString());				
			}
			
		}
	}	
}

