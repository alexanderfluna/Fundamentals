// ConverExample.cs - Sample encodings, conversions, and decodings of a string of 
// Danish characters. 

using System;
using System.Text;

namespace ConsoleApplication1
{
	/* Adapted from Microsoft's example */
	class ConvertExampleClass
	{
		public static void Main()
		{
			string unicodeStr =          // "A æ u å æ ø i æ å"
				"A \u00E6 u \u00E5 \u00E6 \u00F8 i \u00E6 \u00E5";  

			// Different encodings.
			Encoding ascii = Encoding.ASCII,
				unicode = Encoding.Unicode,
				utf8 = Encoding.UTF8,
				isoLatin1 = Encoding.GetEncoding("iso-8859-1");

			// Encodes the characters in a string to a byte array:
			byte[] unicodeBytes = unicode.GetBytes(unicodeStr),
				asciiBytes =   ascii.GetBytes(unicodeStr),
				utf8Bytes =   utf8.GetBytes(unicodeStr),
				isoLatin1Bytes =   utf8.GetBytes(unicodeStr);

			// Convert from byte array in unicode to byte array in utf8:
			byte[] utf8BytesFromUnicode = 
				Encoding.Convert(unicode, utf8, unicodeBytes);

			// Convert from byte array in utf8 to byte array in ascii:
			byte[] asciiBytesFromUtf8 = 
				Encoding.Convert(utf8, ascii, utf8Bytes);
            
			// Decodes the bytes in byte arrays to a char array:
			char[] utf8Chars = utf8.GetChars(utf8BytesFromUnicode);
			char[] asciiChars = ascii.GetChars(asciiBytesFromUtf8);

			// Convert char[] to string:
			string utf8String = new string(utf8Chars),
				asciiString = new String(asciiChars);

			// Display the strings created before and after the conversion.
			Console.WriteLine("Original string: {0}", unicodeStr);
			Console.WriteLine("String via UTF-8: {0}", utf8String);

			Console.WriteLine("Original string: {0}", unicodeStr);
			Console.WriteLine("ASCII converted string: {0}", asciiString);
		}
	}


}
