// Fig. 10.12: PieceWorker.cs
// PieceWorker class derived from Employee.
using System;

namespace Employees
{
   public class PieceWorker : Employee 
   {
      private decimal wagePerPiece; // wage per piece produced
      private int quantity;         // quantity of pieces produced

      // constructor
      public PieceWorker( string firstNameValue, 
         string lastNameValue, decimal wagePerPieceValue, 
         int quantityValue )
         : base( firstNameValue, lastNameValue )
      {
         WagePerPiece = wagePerPieceValue;
         Quantity = quantityValue;
      }

      // property WagePerPiece
      public decimal WagePerPiece
      {
         get
         {
            return wagePerPiece;
         }

         set
         {
            if ( value > 0 )
               wagePerPiece = value;
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
            if ( value > 0 )
               quantity = value;
         }
      }

      // override base-class method to calculate 
      // PieceWorker's earnings
      public override decimal Earnings()
      {
            Console.WriteLine("Calculating PieceWorker's earnings");
            return Quantity * WagePerPiece;
      }

      // return string representation of PieceWorker
      public override string ToString()
      {
         return "PieceWorker: " + base.ToString();
      }
   }
}
