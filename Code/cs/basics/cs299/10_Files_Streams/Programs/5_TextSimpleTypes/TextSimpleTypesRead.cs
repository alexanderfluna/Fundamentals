// TextSimpleTypesRead.cs - A program that reads line of text and parses them to 
// values of simple types. 

using System;
using System.IO;

namespace ConsoleApplication1
{
	

	public class TextSimpleTypes
	{
  
		public static void Main()
		{
 
			using(TextReader twst = new StreamReader("simple-types.txt"))
				  {
				int i = Int32.Parse(twst.ReadLine()); 
				double d = Double.Parse(twst.ReadLine());  
				decimal m = Decimal.Parse(twst.ReadLine());  
				bool b = Boolean.Parse(twst.ReadLine());

				Console.WriteLine("{0} \n{1} \n{2} \n{3}", i, d, m, b);
			}

		}
	}
}
