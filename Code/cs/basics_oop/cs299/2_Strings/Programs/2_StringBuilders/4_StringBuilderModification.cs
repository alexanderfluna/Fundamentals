using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program demonstrates the length and capacity methods 
	/// of the StringBuilder class.
	
	public class StringBuilderModification 
	{
		public static void Main()
		{
			Console.WriteLine("Stringresultfer length and capacity Methods\n");
			
			StringBuilder result =
				new StringBuilder( "hello there" );
			
			//string temp = result; //cannot convert
			//StringBuilder temp =(StringBuilder) result.ToString(3,6); //cannot convert
			string temp = result.ToString(6,3);
			Console.WriteLine("result = {0}, temp = {1}", result, temp);

			// Insert
			result.Insert(6, "hello ");
			Console.WriteLine("result = {0}", result);

			// Remove
			result.Remove(6, 6);
			Console.WriteLine("result = {0}", result);


			// Replace
			result.Replace('h','H');
			Console.WriteLine("result = {0}", result);

			result.Replace('H','h',6,1);
			Console.WriteLine("result = {0}", result);

			// result.Replace('H','h',6,result.Length); //overflow
			result.Replace('H','h',6,result.Length-6);
			Console.WriteLine("result = {0}", result);

			result.Replace("Hello","HELLO");
			Console.WriteLine("result = {0}", result);
			
			Console.WriteLine();						
		}
	}

}
