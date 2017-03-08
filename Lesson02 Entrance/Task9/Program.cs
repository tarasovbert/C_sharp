using System;

/*Задание 9. Вывести на экран "прямоугольник", образованный из двух видов символов.
 Контур прямоугольника должен состоять из одного символа, а в "заливка" - из другого.
 Размеры прямоугольника и виды символов вводятся с клавиатуры.*/

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and height of the rectangle.");
            string answer = Console.ReadLine();
            int length = int.Parse(answer);
            answer = Console.ReadLine();
            int height = int.Parse(answer);
            Console.WriteLine("Enter symbols for the border and for the filling of the rectangle.");
            answer = Console.ReadLine();
            char border = char.Parse(answer);
            answer = Console.ReadLine();
            char filling = char.Parse(answer);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == length - 1)
                        Console.Write(border);
                    else
                        Console.Write(filling);
                }
                Console.WriteLine();
            }
                Console.Read();
        }
    }
}