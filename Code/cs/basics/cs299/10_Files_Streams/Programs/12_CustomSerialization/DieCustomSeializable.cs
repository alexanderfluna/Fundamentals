// DieCustomSeializable.cs - The Die class - With NonSerialized field 
// and OnDeserialization method. 

using System;
using System.Runtime.Serialization;

namespace ConsoleApplication1
{
	[Serializable]
	public class Die: IDeserializationCallback 
	{

		[NonSerialized] private int numberOfEyes;
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

		public int NumberOfEyes
		{
			get
			{
				return numberOfEyes;
			}
		}

		public override String ToString()
		{
			return String.Format("[{0}]", numberOfEyes);
		}

		public void OnDeserialization(Object notUsed)
		{
			Console.WriteLine("OnDeserialization: Show 1");
			// Cheat such that Die is extracted showing '1'. 
			numberOfEyes = 1;
		}

	}

}