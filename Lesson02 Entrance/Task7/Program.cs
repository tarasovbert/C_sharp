using System;

/*Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению.
Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4 
5 5 5 5 5 
6 6 6 6 6 6 
7 7 7 7 7 7 7*/

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter natural integers:" + Environment.NewLine + "A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            int passage = A;
            while (passage <= B)
            {
                for (int i = 0; i < passage; i++)
                {
                    Console.Write(passage + " ");
                }
                Console.WriteLine();
                passage++;
            }
        }
    }
}
