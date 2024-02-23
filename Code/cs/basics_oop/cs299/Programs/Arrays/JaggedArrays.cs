using System;

namespace JaggedArrays {

    public class JaggedArrays {

        static void Main() {
            int[][] data = new int[2][];
            Console.Write("What is the size of row 0: ");
            String str1 = Console.ReadLine();

            Console.Write("What is the size of row 1: ");
            String str2 = Console.ReadLine();

            int sizeRowZero = Convert.ToInt32(str1);
            int sizeRowOne = Convert.ToInt32(str2);

            data[0] = new int[sizeRowZero];
            data[1] = new int[sizeRowOne];

            // Load up jagged array
            for (int col = 0; col < sizeRowZero; col++) {
                data[0][col] = col;
            }
            for (int col = 0; col < sizeRowOne; col++) {
                data[1][col] = col;
            }
            // Compute the sum of values in the jagged array
            int sum = 0;
            for (int row = 0; row < 2; row++) {
                for (int col = 0; col < data[row].Length; col++) {
                    sum += data[row][col];
                }
            }
            Console.WriteLine("sum = " + sum);
            Console.ReadLine();
        }
    }
}
