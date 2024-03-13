using System;

namespace TestingProject
{
	/// <summary>
	/// Describes any class whose objects can measure other objects.
	/// </summary>
	public interface Measurer
	{
		///   Computes the measure of an object.
		///   @param anObject the object to be measured
		///   @return the measure
		double Measure(Object anObject);
	}
}

