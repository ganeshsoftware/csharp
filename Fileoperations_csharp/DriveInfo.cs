//Sri Ganesh

using System;
using System.Collections.Generic;
using System.IO;

namespace Ganesh.DriveOperations
{
	public class Binary 
	{
		  public static void Main(string[] args) 
		  {
				DriveInfo[] dvinfo = DriveInfo.GetDrives();
				
				foreach(DriveInfo di in dvinfo)
				{
					Console.WriteLine();
					Console.WriteLine("************************************************");
					Console.WriteLine("The Name of the Drive is {0}",di.Name);
					Console.WriteLine("The DriveFormat is {0}",di.DriveFormat);
					Console.WriteLine("The Type of the Drive is {0}",di.DriveType);
					Console.WriteLine("The Ready status is {0}",di.IsReady.ToString());
					Console.WriteLine("The total free space is {0}",di.TotalFreeSpace);
					Console.WriteLine("The total size is {0}",di.TotalSize);
					Console.WriteLine("************************************************");
					Console.WriteLine();
				}
		  }
	}	
}

/*
FileMode.Append
FileMode.Create
FileMode.CreateNew
FileMode.Open
FileMode.OpenOrCreate
FileMode.Truncate
*/

/*
FileAccess.Read
FileAccess.Write
FileAccess.ReadWrite
*/
