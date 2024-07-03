using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// The TableInt program
	/// for sorting a table, of integers in this case.
	/// Illustrates linking up to an independent sorter.
	/// </summary>
	public class TableInt 
	{

		public static void Main() 
		{
			OurInteger[] t = new OurInteger[10];

			Console.WriteLine("Type in 10 numbers, each on a separate line");
			for (int i = 0; i < 10; i++)
			{
				string temp = Console.ReadLine();
					t[i] = new OurInteger(int.Parse(temp));
			}

			Console.WriteLine("Original");
			Console.WriteLine("========");
			for (int i = 0; i < t.Length; i++)
				Console.Write(t[i].val+"  ");
			Console.WriteLine();

			Sort.SelectionSort(t,t.Length);

			Console.WriteLine();
			Console.WriteLine("Sorted");
			Console.WriteLine("======");
			for (int i = 0; i < t.Length; i++)
				Console.Write(t[i].val+"  ");
			Console.WriteLine();
		}

	}




}
