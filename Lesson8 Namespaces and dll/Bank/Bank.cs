using System;

namespace BankSystem
{
    public class Bank
    {
        #region FIELDS 
        private static int quantityOfClients = 0;
        private static int quantityOfAccounts = 0;
        private Client[] clients = new Client[quantityOfClients];
        private string bankName;
        #endregion

        #region PROPERTIES
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public static int QuantityOfClients
        {
            get { return quantityOfClients; }
            set { quantityOfClients = value; }
        }

        public static int QuantityOfAccounts
        {
            get { return quantityOfAccounts; }
            set { quantityOfAccounts = value; }
        }
        #endregion

        #region CTORS
        public Bank(string bankName)
        {
            this.bankName = bankName;
        }
        #endregion

        #region METHODS
        public void AddClient(Client newClient)
        {
            quantityOfClients++;
            int length = clients.Length;
            if (quantityOfClients > length)
                Array.Resize(ref clients, quantityOfClients);
            clients[length] = newClient;
        }

        public Client GetClient(int index)
        {
            return clients[index];
        }

        public Client GetClient(string login, out Client client)
        {
            client = null;
            for (int i = 0; i < quantityOfClients; i++)
            {
                if (login == clients[i].Login)
                {
                    client = clients[i];
                    break;
                }
            }
            return client;
        }

        public bool CheckUniquenessOfLogin(string Login)
        {
            int length = clients.Length;
            for (int i = 0; i < length - 1; i++)
                if (clients[i].Login == Login)
                    return false;
            return true;
        }

        public bool CheckPasswordSecurity(string password)
        {
            if (password.Length < 8)
                return false;
            return true;
        }
    }
    #endregion
}

