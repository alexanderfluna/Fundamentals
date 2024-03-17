using System;

public class InterfaceTest
{
    public static void Main()
    {
        // Instantiate new tree object
        Tree tree = new Tree(1978);

        // Instantiate new person object
        Person person = new Person("Alex", "Luna", 2001);

        // Instatiate array of size 2
        // consiting of AgeI objects
        AgeI[] ageIArray = new AgeI[2];

        ageIArray[0] = tree; // The first element is the tree
        ageIArray[1] = person; // The second element is the person

        // Display the tree's name and age
        string output = "The tree's name is: " + tree.Name +
            "\nThe tree's age is: " + tree.Age;

        // Display the person's name and age
        output += "\nThe person's name is: " + person.Name +
            "\nThe person's age is: " + person.Age;

        // Iterate through the ageIarray to print out the 
        // element's names and age
        foreach (AgeI ageI in ageIArray)
        {
            output += "\n"+ ageI.Name + " " + ageI.Age;
        }

        Console.WriteLine(output);
    }
}