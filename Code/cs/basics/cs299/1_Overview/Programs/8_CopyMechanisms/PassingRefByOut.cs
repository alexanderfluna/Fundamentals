using System;

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class OutExample
	{
		static void Change(out int[] pArray)
		{
			//pArray[0] = 888;  // cannot do this before assigning to pArray
			pArray = new int[5] {-3, -1, -2, -3, -4};   // This change is local.
			System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
		}
		static void Main()
		{
			int[] arr = {1, 4, 5};
			System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr [0]);

			Change(out arr);
			System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr [0]);
		
		}
	}
}
