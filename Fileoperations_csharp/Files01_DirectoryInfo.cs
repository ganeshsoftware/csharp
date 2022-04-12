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
			string myDirPath = @"E:\official\COMPANIES\Mimsys\Ganesh_files";
			
			DirectoryInfo myDir = new DirectoryInfo(myDirPath);
			
			// Creation time of the Directory.
			Console.WriteLine("This folder was created on {0}", myDir.CreationTime);
			
			// Parent folder of the given folder.
			Console.WriteLine("This Parent folder is {0}", myDir.Parent);
			
			// to check if the directory exists. (Exists and Name Property)
			if (myDir.Exists)
			{
				Console.WriteLine("This folder with the name {0} exists.", myDir.Name);
			}
			else
			{
				Console.WriteLine("This folder with the name {0} doesn't exists.", myDir.Name);				
			}
			
			// Full Path with the Name.
			Console.WriteLine("{0} is the full path of the Folder.", myDir.FullName);
			
			
			// Last time the folder was accessed.
			Console.WriteLine("This folder was last accessed at {0}.", myDir.LastAccessTime);
			
			// Last time the folder was Write.
			Console.WriteLine("This folder was last modified at {0}.", myDir.LastWriteTime);			
			
			// This is the root portion of the Folder.
			Console.WriteLine("The root portion of the folder is {0}.", myDir.Root);			

		}
	}	
}

