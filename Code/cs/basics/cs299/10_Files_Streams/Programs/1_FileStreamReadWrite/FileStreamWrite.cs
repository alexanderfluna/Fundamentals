// FileStreamWrite.cs - A program that writes 'O' 'O' 'P' to a file stream. 

using System.IO;

namespace ConsoleApplication1
{


	class ReadProg 
	{
		static void Main() 
		{
			Stream s = new FileStream("myFile.bin", FileMode.Create);
			s.WriteByte(79);  // O
			s.WriteByte(79);  // O
			s.WriteByte(80);  // P
			s.Close();
		}
	}
}
