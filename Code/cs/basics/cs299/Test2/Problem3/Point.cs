// Alexander Luna | Test 2 | Point.cs
// Point class represents an x-y coordinate pair.
using System;
namespace ConsoleApplication1 {		
		public class Point
		{			
			private int x, y;			
			public Point(){				
			}
            			
			public Point( int xValue, int yValue )	{				
				X = xValue;
				Y = yValue;
			}

			// property X
			public int X {
				get	{
					return x;
				}

				set	{
					x = value; // no need for validation
				}

			} // end property X

			// property Y
			public int Y {
				get {
					return y;
				}
         
				set	{
					y = value; // no need for validation
				}

			} // end property Y

			// return string representation of Point
			public override string ToString() {
				return "[" + x + ", " + y + "]";
			}

		} // end class Point
	}

