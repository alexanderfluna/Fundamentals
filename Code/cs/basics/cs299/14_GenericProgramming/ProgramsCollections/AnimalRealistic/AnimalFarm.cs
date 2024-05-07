// AnimalFarm.cs - The class AnimalFarm - a subclass of Collection<Animal>


using System;
using System.Collections.ObjectModel;

public class AnimalFarm: Collection<Animal>
									{

	// Auto insert animal of opposite sex
	protected override void InsertItem(int i, Animal a)
	{
		if(a.Sex == Sex.Male)
		{
			base.InsertItem(i,a);
			base.InsertItem(i, new Animal(a.Name, a.Group, Sex.Female));
		} 
		else 
		{
			base.InsertItem(i,a);
			base.InsertItem(i,new Animal(a.Name, a.Group, Sex.Male));
		}   
	}

	// Prevent removal
	protected override void RemoveItem(int i)
	{
		Console.WriteLine("[Removal denied]");
	}

	// Prevent clearing
	protected override void ClearItems()
	{
		Console.WriteLine("[Clearning denied]");
	}

	// Return all animals in a given group
	public AnimalFarm GetGroup(AnimalGroup g)
	{
		AnimalFarm res = new AnimalFarm();
		foreach(Animal a in this)
			if (a.Group == g && a.Sex == Sex.Male) res.Add(a);
		return res;
	}

}
