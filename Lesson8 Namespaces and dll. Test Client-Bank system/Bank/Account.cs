using BankSystem.Helpers;

namespace BankSystem
{
    public class Account
    {
        #region FIELDS 
        decimal interestRate;
        private decimal balance = 0;
        long accountNumber;
        bool opened = false;
        #endregion

        #region CTORS
        public Account()
        {
            Bank.QuantityOfAccounts++;
            accountNumber = Bank.QuantityOfAccounts;
            interestRate = (decimal)Randomer.NextDouble(1, 5) / 100;
        }
        #endregion

        #region PROPERTIES
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public bool Opened
        {
            get { return opened; }
            set { opened = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        #endregion
    }
}
