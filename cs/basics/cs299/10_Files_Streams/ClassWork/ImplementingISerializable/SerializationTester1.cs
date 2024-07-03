// SerializationTester.cs - The Die Application class - with serialization of the die array. 
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
	public class DieApp
	{

		public static void Main()
		{
			(new DieApp()).Go();
		}

		Die[] myDie =  new Die[5];

		public void Go()
		{

			// Make dice
			for(int i = 0; i < 5; i++)
				myDie[i] = new Die();


			// Play Game
			for(int i = 0; i < 5; i++)
			{
				myDie[i].Toss();
				Console.WriteLine("{0}", myDie[i].NumberOfEyes);
			}

			// Save Game
			SaveGame(myDie, "MyGame.dat");
		}

		public void SaveGame(Die[] dice, string fileName)
		{
			Console.WriteLine("[Saving dice to disk]");
			FileStream s = new FileStream(fileName, FileMode.Create);
			IFormatter f = new BinaryFormatter();
			f.Serialize(s, dice);
		}

	}

}