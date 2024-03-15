using System;

namespace ArrayMethods {

    public class ArrayMethodsInAction {

        static void Display(double[] data) {
            foreach (double value in data) {
                System.Console.Write(value + " ");
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args) {
            			
			double[] data = 
				{ 2.6, 2.1, 2.8, -3.4, -3.2, 1.9, 5.1, 0.65 };
            
		
		// One dimensional array manipulations
            double[] dataCopy = new double[data.Length];

            // Copy data to dataCopy starting at index 0
            data.CopyTo(dataCopy, 0);
            Console.Write("dataCopy: ");
            Display(dataCopy);

            // Using quick-sort, sort data
            Array.Sort(data);
            Console.Write("Sorted data: ");
            Display(data);

            // Using Copy, copy 4 elements of data to newData
            double[] newData = new double[data.Length];
            Array.Copy(data, newData, 4);
            Console.Write("4 elements of data copied to newData: ");
            Display(newData);

            // Do a binary search for the value 2.1
            int index = Array.BinarySearch(data, 2.1);
            System.Console.WriteLine("index after binary search: " +
                                     index);
        }
    }
}
/* Output
dataCopy: 2.6 2.1 2.8 -3.4 -3.2 1.9 5.1 0.65
Sorted data: -3.4 -3.2 0.65 1.9 2.1 2.6 2.8 5.1
4 elements of data copied to newData: -3.4 -3.2 0.65 1.9 0 0 0 0
index after binary search: 4
*/
