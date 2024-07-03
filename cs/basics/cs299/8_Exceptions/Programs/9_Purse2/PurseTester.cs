using System;

namespace TestingProject
{
	class PurseTester 	{

		static void Main() 
		{
			Purse purse = new Purse();
            // Trying to get maximum from an empty purse
            Coin max = purse.GetMaximum();  
            purse.Add(new Coin(0.25,"quarter"));
            max = purse.GetMaximum();            
			Console.WriteLine("The greatest coin in the purse is a " 
                + max.GetName());
			
		}    
	}
}
