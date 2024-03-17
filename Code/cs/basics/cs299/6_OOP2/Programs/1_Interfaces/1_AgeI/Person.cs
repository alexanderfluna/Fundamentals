using System;

public class Person : AgeI
{
    // Private fields for a person
    private string firstName;
    private string lastName;
    private int birthYear;

    // Constructor
    public Person(string firstName,
        string lastName, int birthYear)
    {
        this.firstName = firstName;
        this.lastName = lastName;

        if (birthYear > 0 && birthYear <= DateTime.Now.Year)
            this.birthYear = birthYear;
        else
            this.birthYear = DateTime.Now.Year;
    }

    // Age property from AgeI
    public int Age
    {
        get
        {
            return DateTime.Now.Year - birthYear;
        }
    }

    // Name property from in AgeI
    public string Name
    {
        get
        {
            return firstName + " " + lastName;
        }
    }
}