// BinaryReadSimpleTypes.cs - Use of a BinaryReader to write the values written by means 
// of the BinaryWriter. 

using System;
using System.IO;


namespace ConsoleApplication1
{
	public class BinaryReadSimpleTypes
	{
  
		public static void Main()
		{
			string fn = "simple-types.bin";

			using(BinaryReader br = 
					  new BinaryReader(
					  new FileStream(fn, FileMode.Open)))
				  {

				int i = br.ReadInt32(); 
				double d = br.ReadDouble();  
				decimal dm = br.ReadDecimal(); 
				bool b = br.ReadBoolean();

				Console.WriteLine("Integer i: {0}", i);
				Console.WriteLine("Double d: {0}", d);
				Console.WriteLine("Decimal dm: {0}", dm);
				Console.WriteLine("Boolean b: {0}", b);
			}

		}
	}
}
