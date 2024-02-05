
using System;
using System.Collections;

namespace BoxingUnBoxing {

    public class BoxingUnBoxingExample {

        static void Main() {

            Object obj1 = 17; // 17 is of type System.Int32
            Object obj2 = 18; // 18 is of type System.Int32
            String str = obj1.GetType().ToString();
            Console.WriteLine(str);
                // GetType query sent directly to the object 17
            Console.WriteLine(17.GetType().ToString());
                // ToString query sent directly to the object 17
            Console.WriteLine(17.ToString());

            int sumValues = (int) obj1 + (int) obj2;
            Console.WriteLine("sumValues = " + sumValues);

            // Add objects of type double to ArrayList
            ArrayList myList = new ArrayList();
             // Load myList with double value objects
            for (int i = 0; i < 100; i++) {
                myList.Add(Math.Sin(i));
            }

            // Output the sum of myList[0] and myList[1]
            double value1 = (double)myList[0];
            double value2 = (double)myList[1];
            Console.WriteLine("myList[0] + myList[1] = " + (value1 + value2));


            // Obtain the sum of the objects in myList
            double sum = 0.0;
            foreach (double value in myList) {
                sum += value;
            }
            Console.WriteLine("sum = " + sum);
            Console.ReadLine();
        }
    }
}
