using System;
using System.IO;
//FileStreamRead.cs - A program that reads the written file
namespace ConsoleApplication1
{
	

	class WriteProg 
	{
		static void Main() 
		{
			Stream s = new FileStream("myFile.bin", FileMode.Open);
			int i, j, k, m, n;
			i = s.ReadByte();  // O   79  01001111
			j = s.ReadByte();  // O   79  01001111
			k = s.ReadByte();  // P   80  01010000
			m = s.ReadByte();  // -1  EOF
			n = s.ReadByte();  // -1  EOF

			Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, m, n);
			s.Close();
		}
	}
}
