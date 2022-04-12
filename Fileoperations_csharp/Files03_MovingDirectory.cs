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
				// Move the directory "E:\official\COMPANIES\Mimsys\Ganesh_files" => "C:\Ops\GanFls"
				// Give a valid directory path from your file system.
				string myDirPath = @"E:\official\COMPANIES\Mimsys\Ganesh_files\";
				DirectoryInfo myDir = new DirectoryInfo(myDirPath);
				
				myDir.MoveTo(@"E:\GanFls");
				
				//myDir.MoveTo(@"E:\MimsysFiles");
			}
			catch (System.IO.IOException ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
		}
	}	
}

