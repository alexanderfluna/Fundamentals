using System;

public class Tree : AgeI
{
    // Private field for a tree
    private int rings;

    public Tree(int yearPlanted)
    {
        // Every year there is a new ring on the tree
        rings = DateTime.Now.Year - yearPlanted;
    }

    // Increment rings
    public void AddRing()
    {
        rings++;
    }

    // Age property from AgeI
    public int Age
    {
        get
        {
            return rings;
        }
    }

    // Name property from AgeI
    public string Name
    {
        get
        {
            return "Tree";
        }
    }
}