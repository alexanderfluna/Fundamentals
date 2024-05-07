// Animal.cs - The class Animal - Unchanged


using System;

public enum AnimalGroup {Mammal, Bird, Fish};
public enum Sex {Male, Female};

public class Animal: IComparable<Animal>
								 {
	string name;
	AnimalGroup group;
	Sex sex;

	public Animal(string name): 
		this(name, AnimalGroup.Mammal, Sex.Male)
	{
	}

	public Animal(string name, Sex sex): 
		this(name, AnimalGroup.Mammal, sex)
	{
	}

	public Animal(string name, AnimalGroup group): 
		this(name, group, Sex.Male)
	{
	}

	public Animal(string name, AnimalGroup group, Sex sex)
	{
		this.name = name;
		this.group = group;
		this.sex = sex;
	}

	public string Name
	{
		get
		{
			return name;
		}
	}

	public AnimalGroup Group
	{
		get
		{
			return group;
		}
	}

	public Sex Sex
	{
		get
		{
			return sex;
		}
	}

	public override string ToString()
	{
		if (sex == Sex.Male)
			return "Animal: " + name + "(Male)";
		else
			return "Animal: " + name + "(Female)";
	}

	public int CompareTo(Animal other)
	{
		return this.name.CompareTo(other.name);
	}

	public override bool Equals(Object obj)
	{
		if (obj == null)
			return false;
		else if (this.GetType() != obj.GetType())
			return false;
		else if (ReferenceEquals(this, obj))
			return true;
		else if (this.name == ((Animal)obj).name)
			return true;
		else return false;     
	}

}
