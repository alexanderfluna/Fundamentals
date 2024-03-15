using System;

namespace TestingProject
{
	/// <summary>
	///	   This program demonstrates the use of a Measurer.
	/// </summary>
	public class DataSetTester2
	{
		public static void Main()
		{
			Measurer m = new RectangleMeasurer();

			DataSet data = new DataSet(m);

			data.Add(new Rectangle(5, 10, 20, 30));
			data.Add(new Rectangle(10, 20, 30, 40));
			data.Add(new Rectangle(20, 30, 5, 10));

			Console.WriteLine("Average area = " + data.GetAverage());
			Rectangle max = (Rectangle) data.GetMaximum();
			Console.WriteLine("Rectangle with maximum area = " + max);
		}
	}

}
