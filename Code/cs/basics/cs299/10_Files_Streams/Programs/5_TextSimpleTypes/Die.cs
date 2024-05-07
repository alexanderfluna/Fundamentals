using System;
namespace ConsoleApplication1
{
	public class Die 
	{
		private int numberOfEyes;
		private Random randomNumberSupplier; 
		private const int maxNumberOfEyes = 6;

		public Die()
		{
			randomNumberSupplier = Random.Instance();
			numberOfEyes = NewTossHowManyEyes();
		}   
    
		public void Toss()
		{
			numberOfEyes = NewTossHowManyEyes();
		}

		private int NewTossHowManyEyes ()
		{
			return randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
		}

		public int NumberOfEyes() 
		{
			return numberOfEyes;
		}

		public override String ToString()
		{
			return String.Format("[{0}]", numberOfEyes);
		}
	}
}