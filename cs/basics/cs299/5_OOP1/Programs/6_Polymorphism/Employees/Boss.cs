// Fig. 10.10: Boss.cs
// Boss class derived from Employee.
using System;

namespace Employees
{
   public class Boss : Employee
   {
      private decimal salary; // Boss's salary

      // constructor
      public Boss( string firstNameValue, string lastNameValue,
         decimal salaryValue) 
         : base( firstNameValue, lastNameValue )
      {
         WeeklySalary = salaryValue;
      }

      // property WeeklySalary
      public decimal WeeklySalary
      {
         get
         {
            return salary;
         }

         set
         {
            // ensure positive salary value
            if ( value > 0 )
               salary = value;
         }
      }

      // override base-class method to calculate Boss's earnings
      public override decimal Earnings()
      {
            Console.WriteLine("Calculating Boss's earnings");
            return WeeklySalary;
      }

      // return string representation of Boss
      public override string ToString()
      {
         return "Boss: " + base.ToString();
      }
   }
}
