using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SavingsAccount
    {
        private string accountNumber;
        private decimal interestRate;
        private decimal balance;

        public SavingsAccount()
        {
            accountNumber = "";
            interestRate = 0;
            balance = 0;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
