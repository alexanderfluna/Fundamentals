// FileCopy.cs - A FileCopy method in a source file copy-file.cs - uses two FileStreams. 

using System;
using System.IO;

namespace ConsoleApplication1
{
	

	public class CopyApp 
	{

		public static void Main(string[] args) 
		{
			FileCopy(args[0], args[1]);
		}
 
		public static void FileCopy(string fromFile, string toFile)
		{
			try
			{
				FileStream fromStream = new FileStream(fromFile, FileMode.Open);
				FileStream toStream   = new FileStream(toFile, FileMode.Create);
				int c;
  
				do
				{
					c = fromStream.ReadByte();
					if(c != -1) toStream.WriteByte((byte)c);
				} while (c != -1);  
  
				fromStream.Close();
				toStream.Close();}
			catch(FileNotFoundException e)
			{
				Console.WriteLine("File {0} not found: ", e.FileName);
				throw;
			}
			catch(Exception)
			{
				Console.WriteLine("Other file copy exception");
				throw;
			}
		}

	}
}
