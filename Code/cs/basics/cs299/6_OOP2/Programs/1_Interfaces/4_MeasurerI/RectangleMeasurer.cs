using System;

namespace ConsoleApplication
{
    public class RectangleMeasurer : MeasurerI
    {
        // Implementing the MeasureI method
        public double Measure(Object obj)
        {
            // Cast the Object obj to a Rectangle object
            Rectangle rectangle = (Rectangle)obj;

            // Compute and return the area of the Rectangle object
            return rectangle.Width * rectangle.Length;
        }
    }
}