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
				// Copy the directory "E:\official\COMPANIES\Mimsys\Ganesh_files" => "C:\GanFls"
				// Give a valid directory path from your file system.
				string myDirPath = @"E:\official\COMPANIES\Mimsys\Ganesh_files\";
				DirectoryInfo myDir = new DirectoryInfo(myDirPath);
				
				myDir.CopyTo(@"E:\GanFls");
				
				//myDir.MoveTo(@"E:\MimsysFiles");
			}
			catch (System.IO.IOException ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}

			

		}
	}	
}

