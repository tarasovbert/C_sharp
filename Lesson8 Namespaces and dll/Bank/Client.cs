using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Client
    {
        private int number;
        private string name;
        private string surname;
        private string passportNumber;
        private string login;
        private string password;
        const int quantityOfAccounts = 2;
        Account[] accounts;

        public Client()
        {
            number = Bank.QuantityOfClients + 1;
        }

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

        public void OpenAccounts()
        {
            accounts = new Account[quantityOfAccounts];
        }




    }
}
