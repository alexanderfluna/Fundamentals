// Fig. 10.9: Employee.cs
// Abstract base class for company employees.
using System;

namespace Employees
{
   public abstract class Employee
   {
      private string firstName;
      private string lastName; 

      // constructor
      public Employee( string firstNameValue, 
         string lastNameValue )
      {
         FirstName = firstNameValue;
         LastName = lastNameValue;
      }

      // property FirstName
      public string FirstName
      {
         get
         {
            return firstName;
         }

         set
         {
            firstName = value;
         }
      }

      // property LastName
      public string LastName
      {
         get
         {
            return lastName;
         }

         set
         {
            lastName = value;
         }
      }

      // return string representation of Employee
      public override string ToString()
      {
         return FirstName + " " + LastName;
      }

      // abstract method that must be implemented for each derived
      // class of Employee to calculate specific earnings
      public abstract decimal Earnings();

   } // end class Employee
}
