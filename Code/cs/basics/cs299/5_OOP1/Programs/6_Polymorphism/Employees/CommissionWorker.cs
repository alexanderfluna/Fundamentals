// Fig. 10.11: CommissionWorker.cs
// CommissionWorker class derived from Employee
using System;

namespace Employees
{  
   public class CommissionWorker : Employee
   {
      private decimal salary;     // base weekly salary
      private decimal commission; // amount paid per item sold
      private int quantity;       // total items sold

      // constructor
      public CommissionWorker( string firstNameValue,
         string lastNameValue, decimal salaryValue,
         decimal commissionValue, int quantityValue ) 
         : base( firstNameValue, lastNameValue )
      {
         WeeklySalary = salaryValue;
         Commission = commissionValue;
         Quantity = quantityValue;
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
            // ensure non-negative salary value
            if ( value > 0 )
               salary = value;
         }
      }

      // property Commission
      public decimal Commission
      {
         get
         {
            return commission;
         }

         set
         {
            // ensure non-negative commission value
            if ( value > 0 )
               commission = value;
         }
      }

      // property Quantity
      public int Quantity
      {
         get
         {
            return quantity;
         }

         set
         {
            // ensure non-negative quantity value
            if ( value > 0 )
               quantity = value;
         }
      }

      // override base-class method to calculate 
      // CommissionWorker's earnings
      public override decimal Earnings()
      {
            Console.WriteLine("Calculating Commission Worker's earnings");
            return WeeklySalary + Commission * Quantity;
      }

      // return string representation of CommissionWorker
      public override string ToString()
      {
         return "CommissionWorker: " + base.ToString();
      }

   } // end class CommissionWorker
}
