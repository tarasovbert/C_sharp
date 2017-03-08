
namespace BankSystem
{
    public class Client
    {
        #region FIELDS
        private int number;
        private string name;
        private string surname;
        private string passportNumber;
        private string login;
        private string password;
        const int quantityOfAccounts = 2;        
        private Account[] accounts;
        #endregion

        #region CTORS
        public Client()
        {
            number = Bank.QuantityOfClients + 1;
            accounts = new Account[quantityOfAccounts];
            for (int i = 0; i < quantityOfAccounts; i++)
            {
                accounts[i] = new Account();
            }
            accounts[0].Opened = true;
        }
        #endregion

        #region PROPERTIES
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public Account[] Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public int QuantityOfAccounts
        {
            get { return quantityOfAccounts; }
        }
        #endregion

        #region METHODS
        public bool MultiAccount()
        {
            if (quantityOfAccounts > 1 && accounts[1].Opened == true)
                return true;
            return false;
        }

        public int NextAccIndex()
        {
            for (int i = 0; i < quantityOfAccounts; i++)
            {
                if (accounts[i].Opened == false)
                    return i;
            }
            return 0;
        }
        #endregion
    }
}
