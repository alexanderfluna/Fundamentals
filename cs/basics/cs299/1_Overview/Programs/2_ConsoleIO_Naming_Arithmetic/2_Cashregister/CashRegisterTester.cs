using System;

namespace ConsoleApplication1
{
    /**
    This class tests the CashRegister class.
    */
    public class CashRegisterTester
    {
        public static void Main() {
          CashRegister register = new CashRegister();

          register.RecordPurchase(0.75);
          register.RecordPurchase(1.50);
          register.EnterPayment(2, 0, 5, 0, 0);
          Console.Write("Change=");
          Console.WriteLine(register.GiveChange());

          register.RecordPurchase(2.25);
          register.RecordPurchase(19.25);
          register.EnterPayment(23, 2, 0, 0, 0);
          Console.Write("Change=");
          Console.WriteLine(register.GiveChange());
       }
    }
}
