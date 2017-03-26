using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car() { Name = "BMW" };
            Console.WriteLine(car);//car.ToString()
            Car truck = new Truck() { Name = "KRaZ" };
            
            
            
    }
    }
}
