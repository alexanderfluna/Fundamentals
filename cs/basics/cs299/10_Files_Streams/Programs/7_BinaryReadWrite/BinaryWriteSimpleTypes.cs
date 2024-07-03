// BinaryWriteSimpleTypes.cs - Use of a BinaryWriter to write some values 
// of simple types. 


using System;
using System.IO;

namespace ConsoleApplication1
{
	public class BinaryWriteSimpleTypes
	{
  
		public static void Main()
		{
			string fn = "simple-types.bin";

			using(BinaryWriter bw = 
					  new BinaryWriter(
					  new FileStream(fn, FileMode.Create)))
				  {
				bw.Write(5);      // 4  bytes
				bw.Write(5.5);    // 8  bytes
				bw.Write(5555M);  // 16 bytes
				bw.Write(5==6);   // 1  bytes
			}

			FileInfo fi = new FileInfo(fn);
			Console.WriteLine("Length of {0}: {1}", fn, fi.Length);

		}
	}
}
