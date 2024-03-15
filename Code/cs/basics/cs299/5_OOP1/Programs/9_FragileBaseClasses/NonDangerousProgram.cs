using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class9.
	/// </summary>
	// Non-Dangerous program.
	// Compiles and runs.
	// M2 is declared new in B.
	// A.M2 is not virtual.

	using System;

	// New version of A
	class A 
	{

		public void M1()
		{
			Console.WriteLine("Method 1");
			this.M2();
		}

		// New method in this version.
		// Same name as the dangerous operation in subclass B
		// M2 is not virtual.
		public void M2()
		{
			Console.WriteLine("M2 in new version of A");
		}

	}

	class B: A 
	{

		public  new  void M2()
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
			// Will call a.M2 - the non-dangerous version

			a.M2();  // Makes sense when M2 exists in class A
			// Will call a.M2 - the non-dangerous version

			b.M2();  // Expects dangerous operation
		}
	}


   
}
