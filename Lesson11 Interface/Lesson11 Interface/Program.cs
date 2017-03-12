using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = { new Car() { Name = "BMW", Price = 5000 },
                new Car() { Name = "Ford", Price = 3000 },
                new Car() { Name = "Audi", Price = 4000 } };

            Array.Sort(cars, new CarsComparer());
            //Array.Reverse(cars);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }

            
            Car car1 = new Car() { Name = "Cadillac", Price = 6000 };
            car1.Radio.Type = "FM";
            Car carClone = (Car)car1.Clone();
            car1.Price = 7000;
            car1.Name = "Buick";
            car1.Radio.Type = "AM";
            Console.WriteLine(car1);
            Console.WriteLine(carClone);
        }


        static void Sort(Array cars, IComparer comparer)
        {
            var carsT = (Car[])cars;
            comparer.Compare(carsT.GetValue(1), carsT.GetValue(0));
        }
    }

}
