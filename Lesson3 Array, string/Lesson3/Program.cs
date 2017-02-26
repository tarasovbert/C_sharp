using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
            Console.WriteLine(args[i]);
            }

            int[] mas = { 1, 2, 4, 3, 6, 5 };
            string info = String.Join(" ", mas);
            Console.WriteLine(info);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-10, 10));
            }
        }
    }
}
