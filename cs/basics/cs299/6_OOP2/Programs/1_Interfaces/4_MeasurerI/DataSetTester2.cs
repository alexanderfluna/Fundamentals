using System;

namespace ConsoleApplication
{
    public class DataSetTester
    {
        public static void Main()
        {
            // Create new MeasurerI measurer object
            MeasurerI measurer = new RectangleMeasurer();

            // Create new DataSet rectangleData object,
            // passing to the constructor the MeasurerI object
            DataSet rectangleData = new DataSet(measurer);

            rectangleData.Add(new Rectangle(5, 10, 20, 30));
            rectangleData.Add(new Rectangle(10, 20, 30, 40));
            rectangleData.Add(new Rectangle(20, 30, 5, 10));

            Console.WriteLine("Average rectangle area: {0:f2}", rectangleData.GetAverage());
            Rectangle maxmimum = (Rectangle)rectangleData.GetMaximum();
            Console.WriteLine("The rectangle with the maxmimum area: {0:f2}", maxmimum);
        }
    }
}