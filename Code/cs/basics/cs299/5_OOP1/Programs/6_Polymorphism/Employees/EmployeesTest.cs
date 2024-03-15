// Fig. 10.14: EmployeesTest.cs
// Demonstrates polymorphism by displaying earnings
// for various Employee types.
using System;


namespace Employees
{
   public class EmployeesTest
   {
        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            
            Boss boss = new Boss("John", "Smith", 800);
            employees[0] = boss;

            CommissionWorker commissionWorker =
               new CommissionWorker("Sue", "Jones", 400, 3, 150);
            employees[1] = commissionWorker;

            PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis",
               Convert.ToDecimal(2.5), 200);
            employees[2] = pieceWorker;
            
            HourlyWorker hourlyWorker = new HourlyWorker("Karen",
               "Price", Convert.ToDecimal(13.75), 50);            
            employees[3] = hourlyWorker;
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(employees[i].ToString() +
                    " earned $" + employees[i].Earnings()
                    +"\n");
            }                     
      } // end method Main

      
   }
}
