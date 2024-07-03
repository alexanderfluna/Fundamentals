// Fig. 8.8: Date.cs
// Date class definition encapsulates month, day and year.

using System;

namespace CompositionTest
{
   // Date class definition
   public class Date : Object
   {
      private int month;  // 1-12
      private int day;    // 1-31 based on month
      private int year;   // any year

      // constructor confirms proper value for month;
      // call method CheckDay to confirm proper
      // value for day.
      public Date( int theMonth, int theDay, int theYear )
      {
         // validate month
         if ( theMonth > 0 && theMonth <= 12 )  
            month = theMonth;

         else 
         {
            month = 1;
            Console.WriteLine( 
               "Month {0} invalid. Set to month 1.", theMonth );
         }

         year = theYear;                 // could validate year
         day = CheckDay( theDay );       // validate day

      } // end Date constructor

      // utility method confirms proper day value
      // based on month and year
      private int CheckDay( int testDay )
      {
         int[] daysPerMonth = 
            { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
   
         // check if day in range for month
         if ( testDay > 0 && testDay <= daysPerMonth[ month ] )
            return testDay;
   
         // check for leap year
         if ( month == 2 && testDay == 29 &&
              ( year % 400 == 0 || 
                ( year % 4 == 0 && year % 100 != 0 ) ) )
            return testDay;
   
         Console.WriteLine( 
            "Day {0} invalid. Set to day 1.", testDay );
   
         return 1;  // leave object in consistent state
      }
   
      // return date string as month/day/year
      public string ToDateString()
      { 
         return month + "/" + day + "/" + year; 
      }

   }  // end class Date
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
