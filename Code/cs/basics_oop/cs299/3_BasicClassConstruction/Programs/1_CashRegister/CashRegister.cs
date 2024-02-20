using System;

namespace TestingProject
{
	/// <summary>
	/// A cash register totals up sales and computes change due.
	/// </summary>
	public class CashRegister
	{
		///   Constructs a cash register with no money in it.		
		public CashRegister()
		{
			purchase = 0;
			payment = 0;
		}

		///   Records the sale of an item.
		///   @param amount the price of the item
		public void RecordPurchase(double amount)
		{
			double total = purchase + amount;
			purchase = total;
		}

		/// Enters the payment received from the customer.
		///  @param amount the amount of the payment
		public void EnterPayment(double amount)
		{
			payment = amount;
		}

		/// Computes the change due and resets the machine for the next customer.
		/// @return the change due to the customer
		public double GiveChange()
		{   
			double change = payment - purchase;
			purchase = 0;
			payment = 0;
			return change;
		}
		private double purchase;
		private double payment;
	}
	}
