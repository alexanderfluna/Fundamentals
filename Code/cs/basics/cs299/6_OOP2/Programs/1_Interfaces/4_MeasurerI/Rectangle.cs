using System;

namespace ConsoleApplication
{
    public class Rectangle
    {
        private double x;
        private double y;
        private double width;
        private double length;

        // Read-only property for width
        public double Width
        {
            get
            {
                return width;
            }
        }

        // Read-only property for length
        public double Length
        {
            get
            {
                return length;
            }
        }

        // Constructor
        public Rectangle(double x, double y, double width, double length)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.length = length;
        }

        // Overrides the ToString() function to return
        // the following string of the rectangle's properties
        public override string ToString()
        {
            return "[" +x+", "+y+", "+width+", "+length+ "]";
        }

    }
}