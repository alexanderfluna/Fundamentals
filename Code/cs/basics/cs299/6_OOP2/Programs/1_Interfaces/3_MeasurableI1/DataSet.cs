using System;

namespace ConsoleApplication
{
    public class DataSet
    {
        private double sum;
        private int count;
        private MeasurableI maximum;

        // Constructor
        public DataSet()
        {
            sum = 0;
            count = 0;
            maximum = null;
        }

        // Adds the MeasurableI object's balance to sum
        public void Add(MeasurableI obj)
        {
            sum += obj.GetMeasure(); // add object's balance to sum

            // Update maximum if the object's balance 
            // is greater than the current maximum
            if (count == 0 || maximum.GetMeasure() < obj.GetMeasure())
                maximum = obj;

            count++; // increment the count
        }

        // Returns the average balance of the MeasurableI objects
        public double GetAverage()
        {
            if (count == 0) return 0;
            else return sum / count;
        }

        // Returns the maximum balance of the MeasurableI objects
        public MeasurableI GetMaximum()
        {
            return maximum;
        }
    }
}