using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// A cash register totals up sales and computes change due.
    /// </summary>
    /// 
    public class CashRegister  {
       
       ///Constructs a cash register with no money in it.
       public CashRegister()
       {
          purchase = 0;
          change = 0;
       }
       
        ///  Records the purchase price of an item.
        ///  @param amount the price of the purchased item
       public void RecordPurchase(double amount)
       {
          purchase = purchase + (int) Math.Round(amount * PENNIES_PER_DOLLAR);
       }
       
          /// Enters the payment received from the customer.
          /// @param dollars the number of dollars in the payment
          /// @param quarters the number of quarters in the payment
          /// @param dimes the number of dimes in the payment
          /// @param nickels the number of nickels in the payment
          /// @param pennies the number of pennies in the payment
       public void EnterPayment(int dollars, int quarters, 
          int dimes, int nickels, int pennies)
       {
          int payment = dollars * PENNIES_PER_DOLLAR 
             + quarters * PENNIES_PER_QUARTER + dimes * PENNIES_PER_DIME
             + nickels * PENNIES_PER_NICKEL + pennies;
          change = payment - purchase;            
          purchase = 0;
       }
       
        /// Computes the number of dollars due to the customer.
        /// @return the number of dollars in the change due
       public int GiveDollars()
       {
          int dollars = change / PENNIES_PER_DOLLAR; 
          change = change - dollars * PENNIES_PER_DOLLAR;
          return dollars;
       }

        ///  Computes the number of quarters due to the customer.
        ///  return the number of quarters in the change due
       public int GiveQuarters()
       {
          int quarters = change / PENNIES_PER_QUARTER; 
          change = change - quarters * PENNIES_PER_QUARTER;
          return quarters;
       }

       /// Computes the number of dimes due to the customer.
       /// @return the number of dimes in the change due
       public int GiveDimes()
       {
          int dimes = change / PENNIES_PER_DIME; 
          change = change - dimes * PENNIES_PER_DIME;
          return dimes;
       }

       /// Computes the number of nickels due to the customer.
       /// @return the number of nickels in the change due
       public int GiveNickels()
       {
          int nickels = change / PENNIES_PER_NICKEL; 
          change = change - nickels * PENNIES_PER_NICKEL;
          return nickels;
       }

       /// Computes the number of pennies due to the customer.
       /// @return the number of pennies in the change due
       public int GivePennies()
       {
          int pennies = change; 
          change = 0;
          return pennies;
       }

       private const int PENNIES_PER_DOLLAR = 100;
       private const int PENNIES_PER_QUARTER = 25;
       private const int PENNIES_PER_DIME = 10;
       private const int PENNIES_PER_NICKEL = 5;

       private int purchase;
       private int change;
    }

}
