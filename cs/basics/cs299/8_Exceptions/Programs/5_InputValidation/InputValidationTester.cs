using System;

namespace ExceptionHandling {
	class ExceptionTester 	{

		static void Main() 
		{
			UserInput app = new UserInput();
			app.GetUserInput();
			Console.WriteLine("Sum of values input by user:  " + app.Sum());
			Console.ReadLine();
		}    
	}
}
