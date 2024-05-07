// TextReaderProgram.cs - Reading back the text strings encodeded in three different ways, with StreamReader.
using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
	public class TextReaderProg
	{

		public static void Main()
		{
  
			TextReader tr1 = new StreamReader(
				new FileStream("f-iso.txt", FileMode.Open),
				Encoding.GetEncoding("iso-8859-1")),
				tr2 = new StreamReader(
				new FileStream("f-utf8.txt", FileMode.Open),
				new UTF8Encoding()),
				tr3 = new StreamReader(             // UTF-16
				new FileStream("f-utf16.txt", FileMode.Open),
				new UnicodeEncoding());

			Console.WriteLine(tr1.ReadLine());  Console.WriteLine(tr1.ReadLine());  
			Console.WriteLine(tr2.ReadLine());  Console.WriteLine(tr2.ReadLine());  
			Console.WriteLine(tr3.ReadLine());  Console.WriteLine(tr3.ReadLine());  

			tr1.Close();
			tr2.Close();
			tr3.Close();

			// Raw reading of the files to control the contents at byte level
			FileStream  fs1 = new FileStream("f-iso.txt", FileMode.Open),
				fs2 = new FileStream("f-utf8.txt", FileMode.Open),
				fs3 = new FileStream("f-utf16.txt", FileMode.Open);

			StreamReport(fs1);   StreamReport(fs2);   StreamReport(fs3);

			fs1.Close();
			fs2.Close();
			fs3.Close();
		}

		public static void StreamReport(FileStream fs)
		{
			Console.WriteLine();
			int ch, i = 0;
			do
			{
				ch = fs.ReadByte();
				if (ch != -1) Console.Write("{0,4}", ch);
				i++;
				if (i%10 == 0) Console.WriteLine();
			} while (ch != -1);
			Console.WriteLine();
		}

	}

}
