using System;

/*Задание 2.  Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). 
Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости: 
D=  Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))),
Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: 
S = (p•(p – a)•(p – b)•(p – c))1/2,
где p = (a + b + c) / 2 — полупериметр.*/


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Initiating a triangle" + Environment.NewLine + "Coordinates of the first point P1:" + Environment.NewLine + "x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine + "Coordinates of the second point P2:" + Environment.NewLine + "x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine + "Coordinates of the third point P3:" + Environment.NewLine + "x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))),
                b = Math.Sqrt((Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))),
                c = Math.Sqrt((Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));

            if (a == 0 || b == 0 || c == 0)
            {
                Isn_tExist();
            }             

            Console.WriteLine(Environment.NewLine + "Distances between points are:" + Environment.NewLine +
                "P1 and P2: {0:N2}, P2 and P3: {1:N2}, P1 and P3: {0:N2}", a, b, c);
            double halfPerimeter = (a + b + c) / 2;
            double square = Math.Sqrt(halfPerimeter * ((halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c)));

            if (square == 0)
            {
                Isn_tExist();               
            }

            Console.WriteLine("The square of the triangle is {0:N2} .", square);
        }

        private static void Isn_tExist()
        {
            Console.WriteLine(Environment.NewLine + "A triangle with such parameters isn't exist.");
            Environment.Exit(0);
        }
    }
}
