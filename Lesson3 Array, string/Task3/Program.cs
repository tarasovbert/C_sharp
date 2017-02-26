using System;

/*3.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка,
 которая одинаково читается слева направо и справа налево.*/

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if (str[i++] != str[j--])
                {
                    Console.WriteLine("No! This string is not a palindrome.");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Yes! This string is a palindrome.");
        }
    }
}
