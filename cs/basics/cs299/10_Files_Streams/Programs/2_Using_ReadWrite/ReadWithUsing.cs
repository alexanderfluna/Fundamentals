// ReadUsing.cs - The simple read program programmed with 'using'.
using System;
using System.IO;

namespace ConsoleApplication1
{

	class ReadUsing 
	{
		static void Main() 
		{
			int i, j, k, m, n;

			using(Stream s = new FileStream("myFile.bin", FileMode.Open))
				  {
				i = s.ReadByte();  // O   79  01001111
				j = s.ReadByte();  // O   79  01001111
				k = s.ReadByte();  // P   80  01010000
				m = s.ReadByte();  // -1  EOF
				n = s.ReadByte();  // -1  EOF
			}

			Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, m, n);
		}
	}
}
