using System;

/*Задание 8. Найти все совершенные числа до 10000. Совершенное число - это такое число, 
которое равно сумме всех своих делителей, кроме себя самого. Например, число 6 является совершенным, 
т.к. кроме себя самого делится на числа 1, 2 и 3, которые в сумме дают 6.*/
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Perfect numbers from 1 to 10000: ");
            int sum;
            for (int i = 2; i <= 10000; i += 2) //because only the even numbers can be perfect
            {
                sum = 1;//because 1 is the divider for every number                        
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}


