// ConsoleRedirect.cs - A program that redirects standard output and standard error to a file. 
using System;
using System.IO;


namespace ConsoleApplication1
{
	class App
	{
		public static void Main(string[] args)
		{

			TextWriter standardOutput = Console.Out;
			StreamWriter myOut = null,
				myError = null;

			if (args.Length == 2) 
			{
				Console.Out.WriteLine("Redirecting std output and error to files");
				myOut = new StreamWriter(args[0]);
				Console.SetOut(myOut);
				myError = new StreamWriter(args[1]);
				Console.SetError(myError);
			} 
			else 
			{
				Console.Out.WriteLine("Keeping standard output and error unchanged");
			}

			// Output from this section of the program may be redirected
			Console.Out.WriteLine("Text to std output - by Console.Out.WriteLine");
			Console.WriteLine("Text to standard output -  by Console.WriteLine(...)");
			Console.Error.WriteLine("Error msg - by Console.Error.WriteLine(...)");

			if (args.Length == 2) 
			{
				myOut.Close(); myError.Close();
			}     

			Console.SetOut(standardOutput);
			Console.Out.WriteLine("Now we are back again");
			Console.Out.WriteLine("Good Bye");
		}
	}

}
