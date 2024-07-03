// TextSimpleTypes.cs - Writing values of simple types and objects of our own classes. 

using System;
using System.IO;

namespace ConsoleApplication1
{
	public class TextSimpleTypes
	{
  
		public static void Main()
		{
 
			using(TextWriter tw = new StreamWriter("simple-types.txt"))
				  {
				tw.Write(5);  tw.WriteLine();
				tw.Write(5.5);  tw.WriteLine();
				tw.Write(5555M); tw.WriteLine();
				tw.Write(5==6); tw.WriteLine();
			}

			using(TextWriter twnst = new StreamWriter("non-simple-types.txt"))
				  {
				twnst.Write(new Point(1,2)); twnst.WriteLine();
				twnst.Write(new Die()); twnst.WriteLine();
			}

		}
	}

}
