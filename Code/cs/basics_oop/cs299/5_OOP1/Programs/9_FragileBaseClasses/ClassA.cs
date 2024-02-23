using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class6.
	/// </summary>
	
	// Original program. No problems.
	class A 
	{

		public void M1()
		{
			Console.WriteLine("Method 1");
		}
	}

	class B: A 
	{
  
		public void M2()
		{
			Console.WriteLine("Dangerous Method 2");
		}
	}

	class Client
	{
  
		public static void Main()
		{
			A a = new B();
			B b = new B();

			a.M1();  // Nothing dangerous expected
			//  a.M2();  // Compile-time error
			// 'A' does not contain a definition for 'M2'
			b.M2();  // Expects dangerous operation
		}
	}


   
	}
