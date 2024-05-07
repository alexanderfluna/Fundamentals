// Fig. 9.4: Point.cs
// Point class represents an x-y coordinate pair.

using System;
namespace ConsoleApplication1
{
	
		// Point class definition implicitly inherits from Object
		public class Point
		{
			// point coordinate
			private int x, y;

			// default constructor
			public Point()
			{
				// implicit call to Object constructor occurs here
			}

			// constructor
			public Point( int xValue, int yValue )
			{
				// implicit call to Object constructor occurs here
				X = xValue;
				Y = yValue;
			}

			// property X
			public int X
			{
				get
				{
					return x;
				}

				set
				{
					x = value; // no need for validation
				}

			} // end property X

			// property Y
			public int Y
			{
				get
				{
					return y;
				}
         
				set
				{
					y = value; // no need for validation
				}

			} // end property Y

			// return string representation of Point
			public override string ToString()
			{
				return "[" + x + ", " + y + "]";
			}

		} // end class Point
	}


/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/