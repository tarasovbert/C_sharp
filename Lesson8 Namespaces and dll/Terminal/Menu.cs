using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace Terminal
{
    public static class Menu
    {
        public static Client NewClient(Bank bank)
        {
            Client client = new Client();
            Console.Write("Client's number: {0}" + Environment.NewLine
                + "Name: ", client.Number);
            client.Name = Console.ReadLine();
            Console.Write("Surname: ");
            client.Surname = Console.ReadLine();
            Console.Write("PassportNumber: ");
            client.PassportNumber = Console.ReadLine();
            Console.Write("Login: ");
            client.Login = Console.ReadLine();
            while (!bank.CheckUniquenessOfLogin(client.Login))
            {
                Console.Write("This login is already busy! Enter another one: ");
                client.Login = Console.ReadLine();
            }
            while (!bank.CheckPasswordSecurity(client.Password))
            {
                Console.Write("This login is already busy! Enter another one: ");
                client.Login = Console.ReadLine();
            }
            Console.Write("Password (not less than 8 symbols): ");
            client.Password = Console.ReadLine();

            return client;          
        }

        public static void ShowClients(Bank bank)
        {
            int length = Bank.QuantityOfClients;
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                ShowClient(bank.GetClient(i));
            }
        }

        public static void ShowClient(Client client)
        {
            Console.WriteLine("Client's number: {0}" + Environment.NewLine
                + "Name: {1}" + Environment.NewLine
                + "Surname: {2}" + Environment.NewLine
                + "Passport Number: {3} " + Environment.NewLine
                + "Login: {4}", 
                client.Number, client.Name, client.Surname, client.PassportNumber, client.Login);
        }
    }
}
