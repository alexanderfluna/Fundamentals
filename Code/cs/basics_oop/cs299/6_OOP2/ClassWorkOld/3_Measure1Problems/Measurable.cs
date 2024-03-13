using System;

namespace TestingProject
{
	/// <summary>
	/// Describes any class whose objects can be measured.
	/// </summary>
	public interface Measurable
	{
		///   Computes the measure of the object.
		///   @return the measure
		double GetMeasure();
	}
}

