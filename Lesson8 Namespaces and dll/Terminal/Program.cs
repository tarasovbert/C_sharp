using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ItStepBank = new Bank("ItStepBank");
            RegistrationForm(ItStepBank);

        }

        static void RegistrationForm(Bank bank)
        {
            int answer;
            Console.WriteLine("Welcome to bank {0}."+ Environment.NewLine 
                + "1. Enter new client to bank.", bank.BankName);
            if (!Int32.TryParse(Console.ReadLine(), out answer));
            switch (answer)
            {
                case 1:
                    {
                        Client client = Menu.NewClient(bank);
                        bank.AddClient(client);
                        break;
                    }
            }
            Client client1 = Menu.NewClient(bank);
            bank.AddClient(client1);
            Menu.ShowClient(client1);
        }
    }
}
