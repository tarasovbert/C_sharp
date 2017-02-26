
using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a1 = null;
            Console.WriteLine(a1);//nothing will be printed
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();

            Console.WriteLine("hello. Enter 3 numbers.");

            //ConsoleKeyInfo keyInput =  Console.ReadKey();
            //if(keyInput.Key == ConsoleKey.Q)
            //{           }

            string strA = Console.ReadLine();
            int a = Int32.Parse(strA);
            // double a = double.Parse(strA);
            string strB = Console.ReadLine();
            //  int b = Int32.Parse(strB);
            double b = double.Parse(strB);
            //double b = Convert.ToDouble(strB);
            Console.WriteLine("{0}", a + b);
            string str = String.Empty;
            Console.WriteLine((10D).GetType());

            Console.WriteLine("Ы! Y!");
            Console.Read();




        }
    }
}
