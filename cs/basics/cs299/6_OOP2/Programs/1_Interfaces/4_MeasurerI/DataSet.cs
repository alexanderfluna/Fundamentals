using System;

namespace ConsoleApplication
{
    public class DataSet
    {
        private double sum;
        private int count;
        private Object maxmimum;
        private MeasurerI measurerI;

        // Constructor
        public DataSet(MeasurerI measurerI)
        {
            sum = 0;
            count = 0;
            maxmimum = null;
            this.measurerI = measurerI;
        }

        // Adds the measure of the object to sum,
        // updates maximum, and increments count
        public void Add(Object obj)
        {
            // Add the measure of the object to sum
            sum += measurerI.Measure(obj);

            // Update maximum if the new object is greater than the current
            if (count == 0
                || measurerI.Measure(maxmimum) < measurerI.Measure(obj))
                maxmimum = obj;

            count++; // Increment count
        }

        public double GetAverage()
        {
            if (count == 0) return 0;
            else return sum / count;
        }

        public Object GetMaximum()
        {
            return maxmimum;
        }
    }
}