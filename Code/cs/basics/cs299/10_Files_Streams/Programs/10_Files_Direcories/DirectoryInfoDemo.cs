// DirectoryInfoDemo.cs - A demonstration of the DirectoryInfo class. 

using System;
using System.IO;

namespace ConsoleApplication1
{
	public class DirectoryInfoDemo
	{
		public static void Main()
		{
			string fileName = "DirectoryInfoDemo.cs";    // The current source file

			// Get the DirectoryInfo of the current directory
			// from the FileInfo of the current source file 
			FileInfo fi = new FileInfo(fileName);     // This source file
			DirectoryInfo di = fi.Directory;
			di.CreateSubdirectory("NewSubdirectory");

			Console.WriteLine("The current directory is {0} \n", di);

			// Get the files and directories in the parent directory.
			FileInfo[] files = di.Parent.GetFiles();
			DirectoryInfo[] dirs = di.Parent.GetDirectories();

			// Show the name of files and directories on the console
			Console.WriteLine("\nListing directory {0}:", di.Parent.Name);
			foreach(DirectoryInfo d in dirs)
				Console.WriteLine(d.Name);
			foreach(FileInfo f in files)
				Console.WriteLine(f.Name);

		}
	}

}
