using System;


/*4.	Подсчитать количество слов во введенном предложении. */
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int length = str.Length;
            if (length == 0)
            {
                Console.WriteLine("There are no words in string you entered.");
                Environment.Exit(0);              
            }
            int i = 0;
            while (str[i] == ' ' && i < length - 1)//if user entered a string that starts from space
                i++; 
            if (str[i] != ' ')
            {
                int quantity = 1;
                for (; i < length - 1; i++)
                    if (str[i] == ' ' && str[i + 1] != ' ')
                        quantity++;
                Console.WriteLine("The quantity of words: {0}.", quantity);
            }
            else
            {
            Console.WriteLine("You entered only spaces.");
            }
        }
    }
}
