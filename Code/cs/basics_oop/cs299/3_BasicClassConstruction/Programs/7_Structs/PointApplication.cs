using System;
using ElapsedTime;

namespace StructApp1 {

	public class PointApplication {
        
		public static Point Twice(Point pt) 
		{
			return new Point(2 * pt.X, 2 * pt.Y);
		}

		public static PointClass Twice(PointClass pt) 
		{
			return new PointClass(2 * pt.X, 2 * pt.Y);
		}
	}
}

   