using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility
{
    internal class SavingsAccount : BankAccount
    {
        private int InterestRate { get; set; }

        public SavingsAccount(int balance, int interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        public int CalculateInterest()
        {
            int interest = PrintBalance() * 15;
            return interest;
        }
    }
}
