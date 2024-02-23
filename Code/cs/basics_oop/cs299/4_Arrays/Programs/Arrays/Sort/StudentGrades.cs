using System;
using System.Collections;

namespace SortingGrades 
{
	public class StudentGrades 
	{
		// Fields
		private int rows, cols;
		private String[,] scores;

		// Constructor
		public StudentGrades(String[,] scores, int rows, int cols) 
		{
			this.scores = scores;
			this.rows = rows;
			this.cols = cols;
		}

		/*
		 * This method rearranges all the rows using the elements
		 * in the given column as the key values for sorting
		*/
		public void SortGrades(int keyCol, bool ascending,
			bool stringType) 
		{
			// If stringType is false, it is assumed that sorting is on 
			// type double

			// Define the keyColumn - a one-dimensional array to control sorting
			String[] keyColumn = new String[rows];
			for (int row = 0; row < rows; row++) 
			{
				keyColumn[row] = scores[row, keyCol];
			}

			// Define the elements as an one-dimensional array of rows (arrays)
			String[][] elements = new String[rows][]; // Ragged array
			for (int row = 0; row < rows; row++) 
			{
				elements[row] = new String[cols]; // Initialize a row with cols elements
				for (int col = 0; col < cols; col++) 
				{
					elements[row][col] = scores[row, col];
				}
			}

			double[] keyValues = null;
			if (!stringType) 
			{
				keyValues = new double[rows];
				for (int index = 0; index < rows; index++) 
				{
					keyValues[index] = Convert.ToDouble(keyColumn[index]);
				}
			}

			// Use the static Sort method in class Array
            // Sorts a pair of one-dimensional Array objects 
            // (one contains the keys and the other contains the corresponding items) 
            // based on the keys in the first Array using the specified IComparer
			if (stringType) 
			{
                //Sort(Array, Array, IComparer);
                Array.Sort(keyColumn, elements,
                    //new CompareObjects(ascending));//No such class
                    new CaseInsensitiveComparer());//implements IComparer
                if (!ascending)
                    Array.Reverse(elements);
			} 
			else 
			{ 
                //Sort(Array, Array, IComparer)
				Array.Sort(keyValues, elements,
					//new CompareObjects(ascending));//No such class
                    new CaseInsensitiveComparer());//implements IComparer
                if (!ascending)
                    Array.Reverse(elements);
			}

			for (int row = 0; row < rows; row++) 
			{
				for (int col = 0; col < cols; col++) 
				{
					scores[row, col] = elements[row][col];
				}
			}
		}

		public void DisplayGrades() 
		{
            System.Console.WriteLine(
                "\n---------------------------------------------");
			for (int row = 0; row < rows; row++) 
			{				
				for (int col = 0; col < cols; col++) 
				{
					System.Console.Write(scores[row, col] + "\t");
				}
                System.Console.WriteLine();
			}
			System.Console.WriteLine(
				"----------------------------------------------\n\n");
		}
	}
}

  