// AnimalFarmTester.cs - A sample client of AnimalFarm

using System;
using System.Collections.ObjectModel;

class AnimalFarmTester
{

	public static void Main()
	{

		AnimalFarm af = new AnimalFarm();

		// Populating the farm with Add
		af.Add(new Animal("elephant"));
		af.Add(new Animal("giraffe"));
		af.Add(new Animal("tiger"));
		ReportList("Adding elephant, giraffe, and tiger with Add(...)", af);

		// Additional population with Insert
		af.Insert(0, new Animal("blueJay", AnimalGroup.Bird));
		af.Insert(0, new Animal("goldenEagle", AnimalGroup.Bird));
		ReportList("Inserting blue jay and golden eagle at index 0 with Insert(0, ...)", af);

		// Extract birds:
		AnimalFarm birds = af.GetGroup(AnimalGroup.Bird);
		ReportList("The birds in farm - extraced with GetGroup", birds);

		// Remove tiger
		af.Remove(new Animal("tiger"));
		ReportList("Removing tiger with Remove(...)", af);

		// Remove animal at index 2
		af.RemoveAt(2);
		ReportList("Removing animal at index 2, with RemoveAt(2)", af);

		// Clear the farm
		af.Clear();
		ReportList("Clear the farm with Clear()", af);
	}

	public static void ReportList<T>(string explanation, Collection<T> list)
																	   {
	Console.WriteLine(explanation);
	foreach(T el in list)
	Console.WriteLine("{0, 3}", el);
	Console.WriteLine(); Console.WriteLine();
}
}
