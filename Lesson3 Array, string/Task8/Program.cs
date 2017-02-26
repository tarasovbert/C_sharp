using System;

/*8.	Пользователь вводит русский текст. Подсчитать количество слов, которые заканчиваются на гласную букву. */

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string (russian text): ");
            string str = Console.ReadLine();
            int length = str.Length;
            if (length == 0)
            {
                Console.WriteLine("There are no words in string you entered.");
                Environment.Exit(0);
            }
            int quantity = 0;
            CheckForVowels(str, ref quantity, length - 1);
            for (int i = 0; i < length - 1; i++)

                if (str[i + 1] == ' ')
                    CheckForVowels(str, ref quantity, i);
            if (quantity == 0)
                Console.WriteLine("There ain't a word that end on a vowel in the string your entered.");
            else if (quantity == 1)
                Console.WriteLine("There is one word that ends on a vowel in the string your entered.");
            else
                Console.WriteLine("There are {0} words that end on a vowel in the string your entered.", quantity);
        }

        private static void CheckForVowels(string str, ref int quantity, int i)
        {
            if (str[i] == 'а' || str[i] == 'е' || str[i] == 'ё'|| str[i] == 'и' || str[i] == 'о' ||
                str[i] == 'у' || str[i] == 'э' || str[i] == 'ю' || str[i] == 'я')
            {
                quantity++;
            }
        }
    }
}
