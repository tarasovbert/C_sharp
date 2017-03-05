using System;
using BankSystem;

namespace Terminal
{
    public static class Menu
    {
    #region METHODS
        public static Client NewClient(Bank bank)
        {
            Client client = new Client();
            Console.Write(Environment.NewLine + "Client's number: {0}"
                + Environment.NewLine + "Name: ", client.Number);
            client.Name = Console.ReadLine();
            Console.Write("Surname: ");
            client.Surname = Console.ReadLine();
            Console.Write("PassportNumber: ");
            client.PassportNumber = Console.ReadLine();
            Console.Write("Login (at least 4 symbols): ");
            client.Login = Console.ReadLine();
            while (client.Login.Length < 4 || !bank.CheckUniquenessOfLogin(client.Login))
            {
                if (client.Login.Length < 4)
                    Console.Write("This login is too short! Enter another one: ");
                else
                    Console.Write("This login is already busy! Enter another one: ");
                client.Login = Console.ReadLine();
            }
            Console.Write("Password (at least 8 symbols): ");
            client.Password = Console.ReadLine();
            while (!bank.CheckPasswordSecurity(client.Password))
            {
                Console.Write("This password is too short! Enter another one: ");
                client.Password = Console.ReadLine();
            }
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
                + "Login: {4}", client.Number, client.Name, client.Surname, client.PassportNumber, client.Login);
        }

        public static void Client_sInterface(Client client)
        {
            bool possibility;
            int answerInt;
            int accIndex = 0;
            decimal money = 0m;
            while (true)
            {
                Console.Clear();
                possibility = !client.Accounts[client.QuantityOfAccounts - 1].Opened;//if last of client's possible account is not opened
                if (client.MultiAccount())
                    Console.WriteLine("Account number {0}.", accIndex + 1);
                Console.WriteLine("Choose the action:" + Environment.NewLine
                    + "1. Show the account ballance." + Environment.NewLine
                    + "2. Replenish the ballance." + Environment.NewLine
                    + "3. Cash out.");
                if (possibility)
                    Console.WriteLine("4. Open another account.");
                if (client.MultiAccount())
                    Console.WriteLine("4. Choose account.");
                Console.WriteLine("0. Exit.");
                while (!Int32.TryParse(Console.ReadLine(), out answerInt)
                    || answerInt < 0)
                {
                    Console.WriteLine("Input error! Enter again.");
                }
                switch (answerInt)
                {
                    case 0:
                        throw new ExceptionExit("Terminal is closing.");

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Your balance is {0:C5}" + Environment.NewLine
                            + "1. Get back to main menu." + Environment.NewLine
                            + "0. Close the terminal.", client.Accounts[accIndex].Balance);
                        while (!Int32.TryParse(Console.ReadLine(), out answerInt)
                            || answerInt < 0 || answerInt > 1)
                        {
                            Console.WriteLine("Input error! Enter again.");
                        }
                        switch (answerInt)
                        {
                            case 0:
                                throw new ExceptionExit("Terminal is closing.");

                            case 1:
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("How much to replenish? ");
                        while (!Decimal.TryParse(Console.ReadLine(), out money)
                             || money <= 0)
                        {
                            Console.WriteLine("Input error! Enter again.");
                        }
                        client.Accounts[accIndex].Balance += money;
                        Console.WriteLine("Account successfully replenished by {0:C5}.", money);
                        break;

                    case 3:
                        if (client.Accounts[accIndex].Balance > 0)
                        {
                            Console.WriteLine("How much to cash out? Bank's interest rate is {0:p5}.",
                                client.Accounts[accIndex].InterestRate);
                            while (!Decimal.TryParse(Console.ReadLine(), out money)
                               || money <= 0)
                            {
                                Console.WriteLine("Input error! Enter again.");
                            }
                            if (money * (1m + client.Accounts[accIndex].InterestRate) >= client.Accounts[accIndex].Balance)
                                Console.WriteLine("The balance in your account is too low, impossible to cash out such sum.");
                            else
                            {
                                client.Accounts[accIndex].Balance -= money * (1m + client.Accounts[accIndex].InterestRate);
                                Console.WriteLine(Environment.NewLine + "{0:C} cashed out successfully." + Environment.NewLine
                                    + "Bank's interest is {1:C5}."
                                    + "Take your money.", money, money * client.Accounts[accIndex].InterestRate);
                            }
                        }
                        else
                            Console.WriteLine("The balance in your account is too low, impossible to cash out such sum.");
                        break;

                    case 4:
                        if (possibility)
                        {
                            accIndex = client.NextAccIndex();
                            client.Accounts[accIndex] = new Account();
                            client.Accounts[accIndex].Opened = true;
                        }
                        if (client.MultiAccount())
                        {
                            try
                            {
                                accIndex = ChooseAccount(client) - 1;
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                        break;

                    default:                       
                        break;
                }
                Console.Write(Environment.NewLine + "Press any key to proceed: ");
                Console.ReadKey();
            }
        }

        private static int ChooseAccount(Client client)
        {
            int answerInt;
            Console.Write("You have {0} accounts." + Environment.NewLine
                + "Enter the number of account to proceed of enter '0' to exit: ", client.QuantityOfAccounts);
            while (!Int32.TryParse(Console.ReadLine(), out answerInt)) { }
            while (answerInt < 0 || answerInt > client.QuantityOfAccounts)
            {
                Console.WriteLine("Invalid number of account! Enter again: ");
                while (!Int32.TryParse(Console.ReadLine(), out answerInt)) { }
            }
            Console.WriteLine("Connecting to account number {0}, please wait.", answerInt);
            System.Threading.Thread.Sleep(500);
            if (answerInt == 0)
                throw new ExceptionExit("Terminal is closing.");
            return answerInt;
        }
        #endregion
    }
}

