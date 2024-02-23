// Fig. 8.9: Employee.cs
// Employee class definition encapsulates employee's first name,
// last name, birth date and hire date.

using System;

namespace CompositionTest
{
   // Employee class definition
   public class Employee : Object
   {
      private string firstName;
      private string lastName;
      private Date birthDate;  // reference to a Date object 
      private Date hireDate;   // reference to a Date object 

      // constructor initializes name, birth date and hire date
      public Employee( string first, string last, 
         int birthMonth, int birthDay, int birthYear, 
         int hireMonth, int hireDay, int hireYear )
      {
         firstName = first;
         lastName = last;

         // create new Date for Employee birth day
         birthDate = new Date( birthMonth, birthDay, birthYear );
         hireDate = new Date( hireMonth, hireDay, hireYear );

      } // end Employee constructor

      // convert Employee to String format
      public string ToEmployeeString()
      {
         return lastName + ", " + firstName +
            "  Hired: " + hireDate.ToDateString() +
            "  Birthday: " + birthDate.ToDateString();
      }

   }  // end class Employee
}

/*
 ************************************************************************** 
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/
