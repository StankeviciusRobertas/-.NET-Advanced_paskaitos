using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility
{
    internal class BankAccount
    {
        private int Balance { get; set; }

        public BankAccount(int balance)
        {
            Balance = balance;
        }

        protected int PrintBalance()
        {
            return Balance;
        }
    }
}
