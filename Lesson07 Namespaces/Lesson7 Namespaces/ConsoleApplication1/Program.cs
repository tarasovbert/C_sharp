//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Custom;
using System;
using TestNameSpaces;
using TestNameSpaces.Entities;
using TestNameSpaces.Inner;
using TestNameSpaces.InnerAdd;
using Company = ITSTEP.CourseCSharp.Day_7; //pseudonim
using static System.Console;
using static System.Math;


namespace TestNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            classA clA = new classA();
            classB clB = new classB();
            classC clC = new classC();
            WriteLine(clC);
            classD clD = new classD();
            classF clF = new classF();
            classE clE = new classE();
            Company::ClassX clX = new Company::ClassX(); // to solve conflict!
            int a = (int)Sqrt(8899);
            WriteLine(a);
            Console.ReadKey();
          
            

        }
    }
    class Company
    {

    }

    class Radio
    {

    }
}

namespace Custom
{
    class Car
    {
        Radio radio;

        public Car()
        {
            radio = new Radio();
        }

    }
}

