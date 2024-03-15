using System;

namespace ConsoleApplication1
{
   ///<summary>
   ///A tax return of a taxpayer in 1992.
   ///</summary>
public class TaxReturn
{  
   ///   Constructs a TaxReturn object for a given income and 
   ///   marital status.
   ///   @param anIncome the taxpayer income
   ///   @param aStatus either SINGLE or MARRIED   
   public TaxReturn(double anIncome, int aStatus)
   {  
      income = anIncome;
      status = aStatus;
   }

   public double GetTax()
   {  
      double tax = 0;

      if (status == SINGLE)
      {  
         if (income <= SINGLE_BRACKET1)
            tax = RATE1 * income;
         else if (income <= SINGLE_BRACKET2)
            tax = RATE1 * SINGLE_BRACKET1
                  + RATE2 * (income - SINGLE_BRACKET1);
         else
            tax = RATE1 * SINGLE_BRACKET1
                  + RATE2 * (SINGLE_BRACKET2 - SINGLE_BRACKET1)
                  + RATE3 * (income - SINGLE_BRACKET2);
      }
      else
      {  
         if (income <= MARRIED_BRACKET1)
            tax = RATE1 * income;
         else if (income <= MARRIED_BRACKET2)
            tax = RATE1 * MARRIED_BRACKET1
                  + RATE2 * (income - MARRIED_BRACKET1);
         else
            tax = RATE1 * MARRIED_BRACKET1
                  + RATE2 * (MARRIED_BRACKET2 - MARRIED_BRACKET1)
                  + RATE3 * (income - MARRIED_BRACKET2);
      }

      return tax;
   }

   public const int SINGLE = 1;
   public const int MARRIED = 2;

   private const double RATE1 = 0.15;
   private const double RATE2 = 0.28;
   private const double RATE3 = 0.31;

   private const double SINGLE_BRACKET1 = 21450;
   private const double SINGLE_BRACKET2 = 51900;

   private const double MARRIED_BRACKET1 = 35800;
   private const double MARRIED_BRACKET2 = 86500;

   private double income;
   private int status;
}
}
