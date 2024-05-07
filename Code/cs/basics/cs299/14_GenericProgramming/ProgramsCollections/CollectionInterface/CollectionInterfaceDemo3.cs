// CollectionInterfaceDemo3.cs - A program based on ICollection<Animal> - 
// with a List<Animal>.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


class CollectionInterfaceDemo{

  public static void Main(){
    ICollection<Animal> lst = new List<Animal>();

    // Add elements to the end of the empty list:
    lst.Add(new Animal("Cat"));  lst.Add(new Animal("Dog", Sex.Female));
    lst.Add(new Animal("Mouse"));  lst.Add(new Animal("Rat"));
    lst.Add(new Animal("Mouse", Sex.Female));  lst.Add(new Animal("Rat"));
    lst.Add(new Animal("Herring", AnimalGroup.Fish, Sex.Female));  
    lst.Add(new Animal("Eagle", AnimalGroup.Bird, Sex.Male));   

    // Report in various ways on the animal collection:
    Print("Initial List", lst);
    ReportFemaleMale(lst);
    ReportGroup(lst);
  }

  public static void Print<T>(string explanation, ICollection<T> list){
    Console.WriteLine(explanation);
    foreach(T el in list)
      Console.WriteLine("{0, 3}", el);
    Console.WriteLine(); Console.WriteLine();
  }

  public static void ReportFemaleMale(ICollection<Animal> list){
    int numberOfMales = 0,
        numberOfFemales = 0;

    foreach(Animal a in list)
      if (a.Sex == Sex.Male) numberOfMales++;
      else if (a.Sex == Sex.Female) numberOfFemales++;

    Console.WriteLine("Males: {0}, Females: {1}", 
                       numberOfMales, numberOfFemales);
  }

  public static void ReportGroup(ICollection<Animal> list){
    int numberOfMammals = 0,
        numberOfBirds = 0,
        numberOfFish = 0;

    foreach(Animal a in list)
      if (a.Group == AnimalGroup.Mammal) numberOfMammals++;
      else if (a.Group == AnimalGroup.Bird) numberOfBirds++;
      else if (a.Group == AnimalGroup.Fish) numberOfFish++;

    Console.WriteLine("Mammals: {0}, Birds: {1}, Fish: {2}", 
                       numberOfMammals, numberOfBirds, numberOfFish);
  }

}


