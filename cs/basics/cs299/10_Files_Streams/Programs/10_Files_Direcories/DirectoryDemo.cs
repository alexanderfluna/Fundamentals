// DirectoryDemo.cs - A demonstration of the Directory class - similar to 
// the DirectoryInfo demo program. 

using System;
using System.IO;

namespace ConsoleApplication1
{
	
	public class DirectoryDemo
	{

		public static void Main()
		{
			string fileName = "directory.cs";       // The current source file
			FileInfo fi = new FileInfo(fileName);   // This source file

			string thisFile =  fi.FullName,
				thisDir =   Directory.GetParent(thisFile).FullName,
				parentDir = Directory.GetParent(thisDir).FullName;

			Console.WriteLine("This file: {0}", thisFile);
			Console.WriteLine("This Directory: {0}", thisDir);
			Console.WriteLine("Parent directory: {0}", parentDir);

			string[] files = Directory.GetFiles(parentDir);
			string[] dirs =  Directory.GetDirectories(parentDir);

			Console.WriteLine("\nListing directory {0}:", parentDir);
			foreach(string d in dirs)
				Console.WriteLine(d);
			foreach(string f in files)
				Console.WriteLine(f);

		}
	}


}
