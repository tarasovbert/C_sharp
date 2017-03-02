using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank
    {
        static int quantityOfClients = 0;
        private Client[] clients = new Client[quantityOfClients];
        private string bankName;

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

        public Bank(string bankName)
        {
            this.bankName = bankName;
        }

        #endregion       

        public void AddClient(Client newClient)
        {
            quantityOfClients++;         
            int length = clients.Length;
            if (quantityOfClients >= length)
                Array.Resize(ref clients, quantityOfClients + 1);
            clients[length] = newClient;
        }

        public Client GetClient(int index)
        {
            return clients[index];
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


}

