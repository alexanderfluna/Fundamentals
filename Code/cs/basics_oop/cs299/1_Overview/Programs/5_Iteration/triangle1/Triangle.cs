using System;

namespace ConsoleApplication1
{
   /// <summary>
   /// This class describes triangle objects that can be displayed
   /// as shapes like this:
   /// []
   /// [][]
   /// [][][]
   /// </summary>
    public class Triangle
    {
        ///  Constructs a triangle.
        ///  @param aWidth the number of [] in the last row of the triangle.
        public Triangle(int aWidth)
        {
            width = aWidth;
        }

        /// Computes a string representing the triangle.
        /// @return a string consisting of [] and newline characters
        public string ToString()
        {
            string r = "";
            for (int i = 1; i <= width; i++)
            {
                // Make triangle row
                for (int j = 1; j <= i; j++)
                    r = r + "[]";
                r = r + "\n";
            }
            return r;
        }

        private int width;
    }



}
