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
			// Give a valid directory path from your file system.
			string myFilePath = @"E:\official\COMPANIES\Mimsys\mimsys_syllabus_17Jan2022.docx";
			
			FileInfo myFile = new FileInfo(myFilePath);
			
			
			Console.WriteLine("This file was created on {0}", myFile.CreationTime);
			
			// The extension of the given file.
			Console.WriteLine("The extension of the given file is {0}", myFile.Extension);
			
			// to check if the directory exists. (Exists and Name Property)
			if (myFile.Exists)
			{
				Console.WriteLine("This File with the name {0} exists.", myFile.Name);
			}
			else
			{
				Console.WriteLine("This file with the name {0} doesn't exists.", myFile.Name);				
			}
			
			// Full Path of the file with the Name.
			Console.WriteLine("{0} is the full path of the File.", myFile.FullName);
			
			
			// Last time the file was accessed.
			Console.WriteLine("This file was last accessed at {0}.", myFile.LastAccessTime);
			
			// Last time the file was accessed.
			Console.WriteLine("This file was last modified at {0}.", myFile.LastWriteTime);			
			
			// Thde size in bytes for the file.
			Console.WriteLine("The file is {0} bytes in size.", myFile.Length);			
		}
	}	
}

