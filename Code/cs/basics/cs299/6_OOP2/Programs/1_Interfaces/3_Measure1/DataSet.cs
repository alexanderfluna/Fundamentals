using System;

namespace TestingProject
{
	/// <summary>
	/// Computes the average of a set of data values.
	/// </summary>
	public class DataSet
	{
		///   Constructs an empty data set.
		public DataSet()
		{
			sum = 0;
			count = 0;
			maximum = null;
		}

		///   Adds a data value to the data set.
		///   @param x a data value
		public void Add(Measurable x)
		{
			sum = sum + x.GetMeasure();
			if (count == 0 || maximum.GetMeasure() < x.GetMeasure())
				maximum = x;
			count++;
		}

		/// Gets the average of the added data.
		/// @return the average or 0 if no data has been added
		public double GetAverage()
		{
			if (count == 0) return 0;
			else return sum / count;
		}

		/// Gets the largest of the added data.
		///  @return the maximum or 0 if no data has been added
		public Measurable GetMaximum()
		{
			return maximum;
		}

		private double sum;
		private Measurable maximum;
		private int count;
	}
}
