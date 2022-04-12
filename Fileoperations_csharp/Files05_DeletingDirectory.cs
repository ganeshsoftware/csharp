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
				// Delete the directory "E:\official\COMPANIES\Mimsys\Ganesh_files"
				string myDirPath = @"E:\official\COMPANIES\Mimsys\Ganesh_files\";
				DirectoryInfo myDir = new DirectoryInfo(myDirPath);
				
				myDir.Delete(true);
								
			}
			catch (System.IO.IOException ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
		}
	}	
}

