// SerializationTester2.cs - The Die Application class - 
// with both serialization and deserialization.

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
	
	public class DieApp
	{
		public static void Main(string[] args)
		{
			if (args.Length > 0 && args[0] == "old")
				(new DieApp()).GoOld();
			else
				(new DieApp()).GoNew();
		}

		Die[] myDie =  new Die[5];

		public void GoOld()
		{
			// Read the myDie array
			myDie = ExtractGame("MyGame.dat");

			// Play Game
			for(int i = 0; i < 5; i++)
			{
				myDie[i].Toss();
				Console.WriteLine("{0}", myDie[i].NumberOfEyes);
			}

			// Save Game
			SaveGame(myDie, "MyGame.dat");
		}


		public void GoNew()
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

		public Die[] ExtractGame(string fileName)
		{
			Console.WriteLine("[Extracting dice from disk]");
			using(FileStream s = new FileStream(fileName, FileMode.Open))
				  {
				IFormatter f = new BinaryFormatter();
				return f.Deserialize(s) as Die[];
			}
		}

		public void SaveGame(Die[] dice, string fileName)
		{
			Console.WriteLine("[Saving dice to disk]");
			using(FileStream s = new FileStream(fileName, FileMode.Create))
				  {
				IFormatter f = new BinaryFormatter();
				f.Serialize(s, dice);
			}
		}


	}
}
