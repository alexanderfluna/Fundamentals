
using System;
using System.Collections;
public class Insertsort 
{
  
	// recursive
	static void InsertInOrder (double[] A, int hi, double x) 
	{
		// Insert x into A[0]...A[hi-1], filling in
		// A[hi] in the process.  
		// A[0]...A[hi-1] are sorted.
		if (hi == 0 || A[hi-1] <= x)
			A[hi] = x;
		else 
		{
			A[hi] = A[hi-1];
			InsertInOrder(A, hi-1, x);
		}
	}

	// recursive
	static void InsertionSort (double[] A, int hi) 
	{
		// Sort  A[0] ... A[hi]
		if (hi > 0) 
		{
			InsertionSort(A, hi-1);
			InsertInOrder(A, hi, A[hi]);
		}
	}

	// method overloading
	static void InsertionSort (double[] A) 
	{
		InsertionSort(A, A.Length-1);
	}

	//  static final int SIZE = 1000;

	//  public static void Main () {
	//    double[] A = new double[SIZE];
	//    for (int i=0; i<SIZE; i++) A[i] = SIZE-i;
	//    InsertionSort(A, SIZE-1);
	//  }
    
	static double[] x = {1, 6, 5, 9, 2, 5, 14, 15, 11, 7};

	public static void Main () 
	{
		InsertionSort(x, 9);
		for (int i=0; i<10; i++)
			Console.WriteLine(x[i] + " ");
		Console.WriteLine("\n");
	}
}


