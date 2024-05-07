// TextWriterProgram.cs - Writing a text string using three different encodings with 
// StreamWriters. 
using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
	public class TextWriterProg
	{

		public static void Main()
		{
			string str =      "A æ u å æ ø i æ å",
				strEquiv = "A \u00E6 u \u00E5 \u00E6 \u00F8 i \u00E6 \u00E5";
  
			TextWriter tw1 = new StreamWriter(                   // Iso-Latin-1
				new FileStream("f-iso.txt", FileMode.Create),
				Encoding.GetEncoding("iso-8859-1")),
				tw2 = new StreamWriter(                         // UTF-8
				new FileStream("f-utf8.txt", FileMode.Create),
				new UTF8Encoding()),
				tw3 = new StreamWriter(                         // UTF-16
				new FileStream("f-utf16.txt", FileMode.Create),
				new UnicodeEncoding());
  
			tw1.WriteLine(str);     tw1.WriteLine(strEquiv);
			tw2.WriteLine(str);     tw2.WriteLine(strEquiv);
			tw3.WriteLine(str);     tw3.WriteLine(strEquiv);

			tw1.Close();
			tw2.Close();
			tw3.Close();
		}

	}

}
