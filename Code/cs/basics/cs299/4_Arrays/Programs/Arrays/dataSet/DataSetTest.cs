using System;

namespace ConsoleApplication1
{
   ///<summary>
   /// This program tests the DataSet class by adding 10,000 numbers
   /// to the data set and computing the average.
   ///</summary>
   
    public class DataSetTest    {
        
        public static void Main() {
            Random generator = new Random();
            DataSet data = new DataSet();
            const int COUNT = 10000;
            Console.WriteLine("Adding " + COUNT + " random numbers.");
            for (int i = 0; i < COUNT; i++) {
                double x = generator.NextDouble();
                data.Add(x);
            }
            double average = data.GetAverage();
            Console.WriteLine("average=" + average);      
        }
    }

}
