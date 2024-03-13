using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A rectangle with width and height.
	/// </summary>
	public class Rectangle {

		///	Constructs a rectangle.
		///	@param aWidth the width of the rectangle
		///	@param aHeight the height of the rectangle
		public Rectangle(double x, double y, double aWidth, double aHeight) 
		{ 
			xPosition = x;
			yPosition = y;
			width = aWidth; 
			height = aHeight;
		}

		/// Read-only property for Height
		public double Height 	{
			get
			{
				return height;
			}
		}

		///	Read-only property for Width
		public double Width {
			get
			{
				return width;
			}
		}

		public override string ToString()
		{
			return "["+xPosition+", "+yPosition+", "+width+", "+height+"]";
		}

		private double xPosition;
		private double yPosition;
		private double width;
		private double height;

}
}
