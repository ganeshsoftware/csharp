//Sri Ganesh

using System;
using System.IO;
   
class MainClass {
    static public void Main() 
	{
        FileStream    BinaryFile = new FileStream("test.dat", FileMode.Create, FileAccess.ReadWrite);
			BinaryReader  Reader = new BinaryReader(BinaryFile);
        BinaryWriter  Writer = new BinaryWriter(BinaryFile);
        
        Writer.Write('a');
        Writer.Write(123);
        Writer.Write(456.789);
        Writer.Write("test string");

        char   ReadCharacter;
        double ReadDouble;
        int    ReadInteger;
        string ReadString;
        
        BinaryFile.Seek(0, SeekOrigin.Begin);
        ReadCharacter = Reader.ReadChar();
        ReadInteger = Reader.ReadInt32();
        ReadDouble = Reader.ReadDouble();
        ReadString = Reader.ReadString();
   
        Console.WriteLine("Character: {0}", ReadCharacter);
        Console.WriteLine("Integer: {0}", ReadInteger);
        Console.WriteLine("Double: {0}", ReadDouble);
        Console.WriteLine("String: {0}", ReadString);
    }
}
