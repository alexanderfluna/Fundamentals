using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// The Sort class 
	/// Provides one sorting method
	/// for arrays of objects of any length.
	/// where the objects' class implements the
	/// Sortable interface.Summary description for Class3.
	/// </summary>
	public class Sort 
	{
		public static void SelectionSort(Sortable [] a, int n) 
		{
			Sortable temp;
			int chosen;

			for (int leftmost = 0; leftmost < n-1; leftmost++) 
			{
				chosen = leftmost;
				for (int j = leftmost+1; j < n; j++)
					if (a[j].LessThan(a[chosen])) chosen = j;
				temp = a[chosen];
				a[chosen] = a[leftmost];
				a[leftmost] = temp;
			}
		}
	}


}
