using System;

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class PassingValByRef
	{
		static void ChangeIt(out int x)
			// The parameter x is passed as out-parameter
			
		{   
			x = 100;
			System.Console.WriteLine("The value inside the method: {0}", x);
		}
		static void Main()
		{
			int n = 5;
			System.Console.WriteLine("The value before calling the method: {0}", n);

			ChangeIt(out n);  
			System.Console.WriteLine("The value after calling the method: {0}", n);
		}
	}


}
