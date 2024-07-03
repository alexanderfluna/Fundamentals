using System;


// namespace
namespace StaticMethods {

    // class
    public class MathUtilities {

        // class constructor
        static MathUtilities() {
            randomValue = new Random();
            // Warm-up random number generator
            for (int i = 0; i < 100000; i++) {
                randomValue.NextDouble();
            }
        }

        // Fields
        private static Random randomValue;

        // Input: decimal number x
        // Input: decimal number precision
        public static decimal SquareRoot(decimal x, decimal precision) {
            decimal y = x;
            while (Math.Abs(y * y - x) > precision) {
                y = (y + x / y) / 2;
            }
            return y;
        }

        // Input: int NumberPoints
        public static double ApproximatePI(int NumberPoints) {
            int hits = 0;
            double x, y;

            for (int i = 0; i < NumberPoints; i++) {
                x = randomValue.NextDouble();
                y = randomValue.NextDouble();
                if (x * x + y * y <= 1.0)
                    hits++;
            }
            return 4.0 * hits / NumberPoints;
        }
    }
}
