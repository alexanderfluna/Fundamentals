// Person.cs - A class Person

using System;

public class Person{

  private string name;
  private DateTime? dateOfBirth;

  public Person (string name){
    this.name = name;
    this.dateOfBirth = null;
  }

  public Person (string name, DateTime? dateOfBirth){
    this.name = name;
    this.dateOfBirth = dateOfBirth;
  }

  public string Name{
    get {return name;}
  }

  public DateTime? DateOfBirth{
    get {return dateOfBirth;}
  }


  public override string ToString(){
    return "Person: " + name + " " + dateOfBirth;
  }

}