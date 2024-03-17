using System;

namespace ConsoleApplication
{
    public class TableInt
    {
        public static void Main()
        {
            // Instantiate an array of size 20 
            // composed of OurInteger objects
            OurInteger[] arr = new OurInteger[20];

            // Load the OurInteger objects 
            // with random numbers 1-100
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                int randomNumber = r.Next() % 101;
                arr[i] = new OurInteger(randomNumber);
            }

            // Print out the unsorted array
            Console.WriteLine("The original array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].Value + " ");
            }

            // Call Sort.SelectionSort() passing in the
            // array and the arrays's lenth
            Sort.SelectionSort(arr, arr.Length);

            // Print the sorted array
            Console.WriteLine("\n\nThe sorted array is:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].Value + " ");
            }
            Console.WriteLine("\n");
        }
    }
}