// Fig. 10.16: Person.cs
// Class Person has a birthday.
using System;

public class Person : IAge
{
   private string firstName;
   private string lastName;
   private int yearBorn;

   // constructor
   public Person( string firstNameValue, string lastNameValue,
      int yearBornValue )
   {
      firstName = firstNameValue;
      lastName = lastNameValue;

      if ( yearBornValue > 0 && yearBornValue <= DateTime.Now.Year )
         yearBorn = yearBornValue;
      else
         yearBorn = DateTime.Now.Year;
   }

   // property Age implementation of interface IAge
   public int Age
   {
      get
      {
         return DateTime.Now.Year - yearBorn;
      }
   }

   // property Name implementation of interface IAge
   public string Name
   {
      get
      {
         return firstName + " " + lastName;
      }
   }

} // end class Person