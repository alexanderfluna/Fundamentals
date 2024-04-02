// Alexander Luna

using System;

namespace TestingProject
{
	/// <summary>
	/// Describes any class whose objects can measure other objects.
	/// </summary>
	public interface Measurable
	{
		///   Computes the measure of an object.
		///   @param anObject the object to be measured
		///   @return the measure
		double GetMeasure(Object anObject);
	}
}

