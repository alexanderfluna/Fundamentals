// StringWrite.cs - A StringWriter program similar to the StreamReader program 
// shown earlier. 


using System;
using System.IO;
using System.Text;



namespace ConsoleApplication1
{
	public class TextSimpleTypes
	{
  
		public static void Main()
		{

			StringBuilder sb = new StringBuilder();   // A mutable string
 
			using(TextWriter tw = new StringWriter(sb))
				  {
				for (int i = 0; i < 5; i++)
				{
					tw.Write(5 * i);  tw.WriteLine();
					tw.Write(5.5 * i);  tw.WriteLine();
					tw.Write(5555M * i); tw.WriteLine();
					tw.Write(5 * i ==6); tw.WriteLine();}
			}

			Console.WriteLine(sb);

		}
	}
}
