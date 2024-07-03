// CustomSerializationTester1.cs - The Die Application class - 
// with deserialization and serialization - almost as the previous version. 


// Illustrates controlled serialization and deserialization.

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

		Die[] myDice =  new Die[5];

		public void GoOld()
		{
			// Read the myDice array
			myDice = ExtractGame("MyGame.dat");

			// Play Game: Toss 10 times 5 dice
			for(int i = 0; i < 10; i++)
			{
				// Toss all five dice:
				for(int j = 0; j < 5; j++)
				{
					Console.Write("{0,4}", myDice[j].NumberOfEyes);
					myDice[j].Toss();
				}
				Console.WriteLine();
			}

			// Save Game
			SaveGame(myDice, "MyGame.dat");
		}


		public void GoNew()
		{

			// Make dice
			for(int i = 0; i < 5; i++)
				myDice[i] = new Die();

			// Play Game: Toss 1 times 5 dice
			for(int i = 0; i < 5; i++)
			{
				myDice[i].Toss();
				Console.WriteLine("{0}", myDice[i].NumberOfEyes);
			}

			// Save Game
			SaveGame(myDice, "MyGame.dat");
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

		public Die[] ExtractGame(string fileName)
		{
			Console.WriteLine("[Extracting dice from disk]");
			using(FileStream s = new FileStream(fileName, FileMode.Open))
				  {
				IFormatter f = new BinaryFormatter();
				return f.Deserialize(s) as Die[];
			}
		}
	}
}