using System;

namespace GenericTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            User Vova = new User() { Name = "Vova", Account = 100 };
            User Artem = new User() { Name = "Artem", Account = 50 };
            Console.WriteLine("{0}: {1}.", Vova.Name, Vova.Account);
            Console.WriteLine("{0}: {1}.", Artem.Name, Artem.Account);
            Transaction<User> transaction = new Transaction<User>();
            transaction.Transact(Vova, Artem, 45);
            Console.WriteLine("{0}: {1}.", Vova.Name, Vova.Account);
            Console.WriteLine("{0}: {1}.", Artem.Name, Artem.Account);
        }

        private class User : IAccount
        {
            public double Account { get; set; }
            public string Name { get; set; }

            public User() { }

            public User(string name, double contribution)
            {
                Name = name;
                Account = contribution;
            }
        }
    }
}


