using System;

namespace ConsoleApplication1
{
    public class TestArgumentEvaluation    {        
		static bool Test(bool b1, bool b2)
		{
            if (b1) return b2;
            else return false;
		}

		static void Main() 
		{
            int n = 0;
            bool result = Test(n > 0, 1 / n > 0.5);
            Console.WriteLine("The result is {0}.", result);
			
        }
        
    }
}
