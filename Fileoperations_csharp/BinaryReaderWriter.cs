//Sri Ganesh

using System;
using System.Collections.Generic;
using System.IO;

namespace Ganesh.FileOperations
{
	public class Binary 
	{
		  public static void Main(string[] args) 
		  {
			/*
			BinaryWriter writer = new BinaryWriter(new FileStream("Test.dat",FileMode.Create));
			writer.Write(1000);
			writer.Write(4353.993);
		   	writer.Close();
			*/
			
			
			BinaryReader reader = new BinaryReader(new FileStream("Test.dat",FileMode.Open));
			Console.WriteLine("{0} ", reader.ReadInt32());
			Console.WriteLine("{0:F1} ", reader.ReadDouble());
			reader.Close();
			
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
