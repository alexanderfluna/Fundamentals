using System;

namespace TestingProject
{
	/// <summary>
	/// Objects of this class measure rectangles by area.
	/// </summary>
	public class RectangleMeasurer : Measurer	{
		public double Measure(Object anObject)  {
			Rectangle aRectangle = (Rectangle) anObject;
			double area = aRectangle.Width * aRectangle.Height;
			return area;
		}
	}

}
