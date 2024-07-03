using System;

namespace ExceptionHandling {

    public class UserInput {

        private int[] values = new int[5];

        public void GetUserInput() {
            for (int index = 0; index < 5; index++) {
                bool error = true;
                while (error) {
                    try {
                        Console.Write("Enter integer number " + (index + 1) + ": ");
                        String valueStr = Console.ReadLine();
                        values[index] = Convert.ToInt32(valueStr);
                        error = false;
                    } catch {
						Console.WriteLine("This was not an integer. Please try again");
                        error = true;
                    }
                }
            }
        }

        public int Sum() {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) {
                sum += values[i];
            }
            return sum;
        }      

        
    }
}
