using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int, double, char, string> info = SomeTuple(33, "Vova Tarasov");
            Console.WriteLine("Hello, {1}.{0}Quadrate of your age is {2}.{0}Square root of your age is {3:f5}.{0}Your parameter is {4}.{0}Your upper name is {5}.{0}",
                Environment.NewLine, info.Item1, info.Item2, info.Item3, info.Item4, info.Item5);
            Console.WriteLine("info is {0}", info.ToString());
        }

        private static Tuple<string, int, double, char, string> SomeTuple(int value, string name)
        {
            int quad = value * value;
            double sqrt = Math.Sqrt(value);
            char param = name[0];
            string upper = name.ToUpper();
            return Tuple.Create<string, int, double, char, string>(name, quad, sqrt, param, upper);
        }
    }
}
