
using System;
using System.Collections;
public class Selectsort 
{

	static void Swap (double[] a, int i, int j) 
	{
		double temp = a[i];
		a[i] = a[j];
		a[j] = temp;
	}

	// recursive 
	static int FindMinimum (double[] A, int lo, int hi) 
	{
		if (lo == hi)
			return lo;
		else 
		{
			int locationOfMin = FindMinimum(A, lo+1, hi);
			if (A[lo] < A[locationOfMin])
				return lo;
			else
				return locationOfMin;
		}
	}

	static void SelectionSort (double[] A, 
		int lo, int hi) 
	{
		// Recursive selection sort
		// Author: Ruth N. Reingold,  April 22, 1995

		// A[0]..A[lo-1] contain the smallest values in A,
		// in ascending order.
		if (lo < hi) 
		{ // subarray has more than one element
			Swap(A, lo, FindMinimum(A, lo, hi));
			SelectionSort(A, lo+1, hi);
		}
	}

	// method overloading
	static void SelectionSort (double[] A) 
	{
		SelectionSort(A, 0, A.Length-1);
	}

	//static final int SIZE = 1000;

	//public static void Main () {
	//  double[] A = new double[SIZE];
	//  for (int i=0; i<SIZE; i++) A[i] = i;
	//  SelectionSort(A, 0, SIZE-1);
	//}

	static double[] x = {1, 6, 5, 9, 2, 5, 14, 15, 11, 7};

	public static void Main () 
	{
		SelectionSort(x,0,9);
		for (int i=0; i<10; i++)
			Console.WriteLine(x[i] + " ");
		Console.WriteLine("\n");
	}

  
}



