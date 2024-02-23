// Fig. 10.13: HourlyWorker.cs
// HourlyWorker class derived from Employee.
using System;

namespace Employees
{
   public class HourlyWorker : Employee
   {
      private decimal wage;       // wage per hour of work
      private double hoursWorked; // hours worked during week

      // constructor
      public HourlyWorker( string firstNameValue, string LastNameValue,
         decimal wageValue, double hoursWorkedValue )
         : base( firstNameValue, LastNameValue )
      {
         Wage = wageValue;
         HoursWorked = hoursWorkedValue;
      }

      // property Wage
      public decimal Wage
      {
         get
         {
            return wage;
         }

         set
         {
            // ensure non-negative wage value
            if ( value > 0 )
               wage = value;
         }
      }

      // property HoursWorked
      public double HoursWorked
      {
         get
         {
            return hoursWorked;
         }

         set 
         {
            // ensure non-negative hoursWorked value
            if ( value > 0 )
               hoursWorked = value;
         }
      }

      // override base-class method to calculate 
      // HourlyWorker earnings
      public override decimal Earnings()
      {
            Console.WriteLine("Calculating Hourly Worker's earnings");
            // compensate for overtime (paid "time-and-a-half")
            if ( HoursWorked <= 40 )
         {
            return Wage * Convert.ToDecimal( HoursWorked );
         }

         else
         {
            // calculate base and overtime pay
            decimal basePay = Wage * Convert.ToDecimal( 40 );
            decimal overtimePay = Wage * 1.5M *
               Convert.ToDecimal( HoursWorked - 40 );

            return basePay + overtimePay;
         }
      }

      // return string representation of HourlyWorker
      public override string ToString()
      {
         return "HourlyWorker: " + base.ToString();
      }
   }
}
