using System;

// Base class
class Animal
{
    public string Name { get; set; }

    // Constructor
    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

// Derived class inheriting from Animal
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

// Derived class inheriting from Animal
class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing.");
    }
}

class Program
{
    static void Main()
    {
        // Using the base class
        Animal genericAnimal = new Animal("Generic Animal");
        genericAnimal.Eat();
        genericAnimal.Sleep();

        Console.WriteLine();

        // Using the derived class (Dog)
        Dog myDog = new Dog("Buddy");
        myDog.Eat();
        myDog.Sleep();
        myDog.Bark();

        Console.WriteLine();

        // Using the derived class (Cat)
        Cat myCat = new Cat("Whiskers");
        myCat.Eat();
        myCat.Sleep();
        myCat.Meow();
    }
}
