// IntSequenceTester.cs - A client of IntSequence. 

using System;

namespace ConsoleApplication1
{
	class IntSequenceTester
	{

		public static void Main()
		{
			IntSequence is1 = new IntSequence(-5, -1, 7, -8, 13),
				is2 = new IntSequence();

			ReportMinMax(is1);
			ReportMinMax(is2);     
		}

		public static void ReportMinMax(IntSequence iseq)
		{
			if (iseq.Min().HasValue && iseq.Max().HasValue)
				Console.WriteLine("Min: {0}. Max: {1}", 
					iseq.Min(), iseq.Max());
			else
				Console.WriteLine("Int sequence is empty");
		}

	}
}
