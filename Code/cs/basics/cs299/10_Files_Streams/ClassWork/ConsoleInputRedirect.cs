// ConsoleRedirect.cs - A program that redirects standard output and standard error to a file. 
using System;
using System.IO;


namespace ConsoleApplication1
{
	class App
	{
		public static void Main(string[] args)
		{
			TextReader standardInput = Console.In;
            StreamReader myIn = null;			
			Console.Out.WriteLine("Redirecting std input to read a file");
			myIn = new StreamReader("out.txt");
			Console.SetIn(myIn);
            string s = Console.ReadLine();
            Console.WriteLine(s);					
		}
	}

}
