using System;
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
            Console.WriteLine("Welcome to bank {0}.", bank.BankName);
            Client client = Menu.NewClient(bank);
            bank.AddClient(client);
            Console.WriteLine("{0} {1}, welcome to bank {2}!" + Environment.NewLine + Environment.NewLine
                + "Your accounts: ", client.Name, client.Surname, bank.BankName);
            int length = client.Accounts.Length;
            for (int i = 0; i < length; i++)
            {
                if (client.Accounts[i].Opened == true)
                {
                    Console.WriteLine("Account number {0}." + Environment.NewLine
                        + "Interest rate of cashing: {1:p5}.", client.Accounts[i].AccountNumber, client.Accounts[i].InterestRate);
                }
                else break;
            }
            Console.Write("Press any key to proceed: ");
            Console.ReadKey();
            Console.Clear();
            Console.Write("{0} {1}, enter login and password to get access to your accounts." + Environment.NewLine
                + "Login: ", client.Name, client.Surname);
            string login = Console.ReadLine();
            client = bank.GetClient(login, out client);
            while (client == null)
            {
                Console.WriteLine(@"There's no client in {0} with such login." + Environment.NewLine
                    + "Enter again or enter '0' to exit.", bank.BankName);
                login = Console.ReadLine();
                if (login == "0") Environment.Exit(0);
                client = bank.GetClient(login, out client);
            }
            int attempts = 3;
            Console.Write("Password:");
            string password = Console.ReadLine();
            while (password != client.Password)
            {
                if (attempts == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please stay where you are. Police patrol departed.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Environment.Exit(0);
                }
                attempts--;
                Console.Write("Invalid password. {0} Attempts left." + Environment.NewLine
                    + "Please enter again or enter '0' to exit: ", attempts);
                password = Console.ReadLine();
                if (password == "0")
                    Environment.Exit(0);
            }
            Console.WriteLine("Password accepted. Please wait.");
            System.Threading.Thread.Sleep(500);
            try
            {
                Menu.Client_sInterface(client);
            }
            catch (ExceptionExit ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

