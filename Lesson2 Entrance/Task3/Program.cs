using System;

/*Задание 3. Вводится целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 
256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».*/

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int length;
            while (true)
            {
                do
                {
                    Console.Write("Enter an integer number from 100 to 999 or press '0' to exit: ");
                    number = Console.ReadLine();
                    length = (number.Length);
                    if (number[0] == '0')
                        Environment.Exit(0);
                } while (char.IsNumber(number[0]) == false || char.IsNumber(number[1]) == false
                || char.IsNumber(number[2]) == false || length != 3);
                NumberToText(number);
            }
        }


        private static void NumberToText(string number)
        {
            switch (number[0])
            {
                case '1':
                    {
                        Console.Write("One hundred");
                        break;
                    }
                case '2':
                    {
                        Console.Write("Two hundred");
                        break;
                    }
                case '3':
                    {
                        Console.Write("Three hundreds");
                        break;
                    }
                case '4':
                    {
                        Console.Write("Four hundreds");
                        break;
                    }
                case '5':
                    {
                        Console.Write("Five hundreds");
                        break;
                    }
                case '6':
                    {
                        Console.Write("Six hundreds");
                        break;
                    }
                case '7':
                    {
                        Console.Write("Seven hundreds");
                        break;
                    }
                case '8':
                    {
                        Console.Write("Eight hundreds");
                        break;
                    }
                case '9':
                    {
                        Console.Write("Nine hundreds");
                        break;
                    }
                default: break;
            }

            switch (number.Substring(1))
            {
                case "10":
                    {
                        Console.WriteLine(" and ten.");
                        Environment.Exit(0);
                        break;
                    }
                case "11":
                    {
                        Console.WriteLine(" and elenen.");
                        Environment.Exit(0);
                        break;
                    }
                case "12":
                    {
                        Console.WriteLine(" and twelve.");
                        Environment.Exit(0);
                        break;
                    }
                case "13":
                    {
                        Console.WriteLine(" and thirteen.");
                        Environment.Exit(0);
                        break;
                    }
                case "14":
                    {
                        Console.WriteLine(" and fournteen.");
                        Environment.Exit(0);
                        break;
                    }
                case "15":
                    {
                        Console.WriteLine(" and fivteen.");
                        Environment.Exit(0);
                        break;
                    }
                case "16":
                    {
                        Console.WriteLine(" and sixteen.");
                        Environment.Exit(0);
                        break;
                    }
                case "17":
                    {
                        Console.WriteLine(" and seventeen.");
                        Environment.Exit(0);
                        break;
                    }
                case "18":
                    {
                        Console.WriteLine(" and eigthteen.");
                        Environment.Exit(0);
                        break;
                    }
                case "19":
                    {
                        Console.WriteLine(" and nineteen.");
                        Environment.Exit(0);
                        break;
                    }
                default: break;
            }

            switch (number[1])
            {
                case '0':
                    {
                        if (number[2] != '0')
                            Console.Write(" and");
                        break;
                    }
                case '2':
                    {
                        Console.Write(" and twenty");
                        break;
                    }
                case '3':
                    {
                        Console.Write(" and thirty");
                        break;
                    }
                case '4':
                    {
                        Console.Write(" and fourty");
                        break;
                    }
                case '5':
                    {
                        Console.Write(" and fifty");
                        break;
                    }
                case '6':
                    {
                        Console.Write(" and sixty");
                        break;
                    }
                case '7':
                    {
                        Console.Write(" and seventy");
                        break;
                    }
                case '8':
                    {
                        Console.Write(" and eighty");
                        break;
                    }
                case '9':
                    {
                        Console.Write(" and ninety");
                        break;
                    }
                default: break;
            }

            switch (number[2])
            {
                case '1':
                    {
                        Console.Write(" one");
                        break;
                    }
                case '2':
                    {
                        Console.Write(" two");
                        break;
                    }
                case '3':
                    {
                        Console.Write(" three");
                        break;
                    }
                case '4':
                    {
                        Console.Write(" four");
                        break;
                    }
                case '5':
                    {
                        Console.Write(" five");
                        break;
                    }
                case '6':
                    {
                        Console.Write(" six");
                        break;
                    }
                case '7':
                    {
                        Console.Write(" seven");
                        break;
                    }
                case '8':
                    {
                        Console.Write(" eight");
                        break;
                    }
                case '9':
                    {
                        Console.Write(" nine");
                        break;
                    }
                default: break;
            }
            Console.WriteLine(".");
        }
    }
}
