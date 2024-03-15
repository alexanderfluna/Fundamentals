using System;
using System.IO;

namespace MoreComplexProperty {

	public class FileApplication 	{

		// Instance variables
		private String filename;
		private StreamWriter outputFile;

		// Property
		public String Filename 
		{
			set 
			{
				filename = value;
				outputFile = new StreamWriter(
					new FileStream(filename, 
					               FileMode.Create, 
					               FileAccess.Write));
				outputFile.WriteLine("Testing, testing, 123");
				outputFile.Close();
			}
		}
	}
}
