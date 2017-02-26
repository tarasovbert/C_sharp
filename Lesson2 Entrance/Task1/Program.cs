using System;

/*Задание 1. Дано значение температуры T в градусах Фаренгейта.Определить значение этой же температуры в градусах Цельсия.
Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:
TC = (TF – 32)•5/9.*/

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The temperature in Fahrenheit degrees is: ");
            double fahr = double.Parse(Console.ReadLine());
            Console.WriteLine("The temperature in Celsius degrees is {0:N2}.", (fahr - 32) * 5 / 9);
        }
    }
}
