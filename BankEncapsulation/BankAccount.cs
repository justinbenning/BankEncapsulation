using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() { }
        private double _balance = 0;

        //BankAccount MyBankAccount = new BankAccount();

        public void Deposit(double deposit)
        {
            _balance += deposit;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
