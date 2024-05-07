//AnimalFarmTester.cs - A sample client of AnimalFarm - 
// revealing use of protected Collection<Animal> methods. 

using System;
using System.Collections.ObjectModel;

class App
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
		af.Insert(0, new Animal("dog"));
		af.Insert(0, new Animal("cat"));
		ReportList("Inserting dog and cat at index 0 with Insert(0, ...)", af);

		// Mutate the animal farm:
		af[1] = new Animal("herring", AnimalGroup.Fish, Sex.Male);
		ReportList("After af[1] = herring", af);

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
