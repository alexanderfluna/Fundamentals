// FileDemo.cs - A demonstration of the File class. 

using System;
using System.IO;


namespace ConsoleApplication1
{
	using System;
	using System.IO;

	public class FileDemo
	{

		public static void Main()
		{

			// Setup file names
			string fileName = "file.cs",             // this source file
				fileNameCopy = "fileCopy.cs";

			// Does this source file exist?
			Console.WriteLine("{0} does {1} exist", 
				fileName, File.Exists(fileName) ? "" : "not");

			// Copy this source file
			File.Copy(fileName, fileNameCopy);

			// Does the copy exist?
			Console.WriteLine("{0} does {1} exist", 
				fileNameCopy, 
				File.Exists(fileNameCopy) ? "" : "not");

			// Delete the copy again
			Console.WriteLine("Deleting {0}", fileNameCopy);
			File.Delete(fileNameCopy);

			// Does the deleted file exist
			Console.WriteLine("{0} does {1} exist", 
				fileNameCopy, 
				File.Exists(fileNameCopy) ? "" : "not");

			// Read all lines in source file and echo 
			// one of them to the console
			string[] lines = File.ReadAllLines(fileName);
			Console.WriteLine("Line {0}: {1}", 6, lines[6]);

		}

	}

}
