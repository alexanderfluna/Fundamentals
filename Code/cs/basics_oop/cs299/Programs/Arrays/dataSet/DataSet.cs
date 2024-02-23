using System;

namespace ConsoleApplication1
{
    ///<summary>
    /// This class computes the average of a set of data values.
    /// Uses one-dimensional array.
    ///</summary>
    
    public class DataSet {
        
        /// Constructs an empty data set
        public DataSet() {
            const int DATA_LENGTH = 100;
            data = new double[DATA_LENGTH];
            dataSize = 0;
        }

        /// Adds a data value to the data set
        /// param x  - a data value
        public void Add(double x)
        {
            if (dataSize >= data.Length)
            {
                // make a new array of twice the size
                double[] newData = new double[2 * data.Length];
                // copy over all elements from data to newData
                Array.Copy(data, newData, data.Length);
                // abandon the old array and store in data
                // a reference to the new array
                data = newData;
            }
            data[dataSize] = x;
            dataSize++;
        }

        
        ///  Gets the average of the added data.
        ///  Returns the average or 0 if no data has been added
        public double GetAverage()
        {
            if (dataSize == 0) return 0;
            double sum = 0;
            for (int i = 0; i < dataSize; i++)
                sum = sum + data[i];
            return sum / dataSize;
        }

        private double[] data;
        private int dataSize;
    }

}
