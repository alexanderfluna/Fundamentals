using System;

namespace TestingProject
{
	/// <summary>
	/// Computes the average of a set of data values.
	///</summary>
	public class DataSet
	{
		///   Constructs an empty data set with a given measurer.
		///   @param aMeasurer the measurer that is used to measure data values
		public DataSet(Measurer aMeasurer)
		{
			sum = 0;
			count = 0;
			maximum = null;
			measurer = aMeasurer;
		}

		/// Adds a data value to the data set.
		///  @param x a data value
		public void Add(Object x)
		{
			sum = sum + measurer.Measure(x);
			if (count == 0 
				|| measurer.Measure(maximum) < measurer.Measure(x))
				maximum = x;
			count++;
		}

		/// Gets the average of the added data.
		///  @return the average or 0 if no data has been added
		public double GetAverage()
		{
			if (count == 0) return 0;
			else return sum / count;
		}

		/// Gets the largest of the added data.
		/// @return the maximum or 0 if no data has been added
		public Object GetMaximum()
		{
			return maximum;
		}

		private double sum;
		private Object maximum;
		private int count;
		private Measurer measurer;
	}
}
