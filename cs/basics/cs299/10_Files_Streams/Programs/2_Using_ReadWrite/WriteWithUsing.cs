using System;
using System.IO;

//Using.cs - The simple write-program programmed with 'using'
namespace ConsoleApplication1
{
	class ReadProg 
	{
		static void Main() 
		{
			using(Stream s = new FileStream("myFile.txt", 
					  FileMode.Create))
				  {
				s.WriteByte(79);  // O
				s.WriteByte(79);  // O
				s.WriteByte(80);  // P
			}
		}
	}

}
