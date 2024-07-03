using System;

namespace TestingProject
{

    public class Bank {

        private BankAccount[] accounts;

        public Bank(BankAccount[] collection)
        {
            accounts = collection;
        }

        // Properties
        public int Size {
            get {
                return accounts.Length;
            }
        }

        public BankAccount this[int index] {
            get {
                if (index >= 1 && index <= accounts.Length) {
                    return accounts[index - 1];
                } else {
                    return new BankAccount(0,"Illegal index");
                    // return accounts[0];
                  }
            }
            set {
                if (index >= 1 && index <= accounts.Length) {
                    accounts[index - 1] = value;
                }
            }
        }
    }
}

