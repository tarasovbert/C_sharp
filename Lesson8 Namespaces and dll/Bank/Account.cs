using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Helpers;

namespace BankSystem
{
    public class Account
    {
        private decimal interestRate;
        private long accountNumber;

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public Account(string userName)
        {
            accountNumber = userName.GetHashCode();
            interestRate = (decimal)Randomer.NextDouble(1, 5);
        }
    }
}
