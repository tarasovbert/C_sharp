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

            ICloneable[] iCar =
                { new Car() { Name = "Volvo", Price = 10000 },
                new Car() { Name = "DAF", Price = 15000 },
                new Car() { Name = "Renault", Price = 16000 } };

            Console.WriteLine(iCar.ToString());
            Console.WriteLine(iCar[0].ToString());
            Console.WriteLine(iCar[1].ToString());
            Console.WriteLine(iCar[2].ToString());
            
            IBase car2 = new Car() { Name = "Buick", Price = 26000 };
            Console.WriteLine(car2.Work());
            IDerived car3 = new Car() { Name = "Volkswagen", Price = 24000 };
            Console.WriteLine(car2.Work());

        }


        static void Sort(Array cars, IComparer comparer)
        {
            var carsT = (Car[])cars;
            comparer.Compare(carsT.GetValue(1), carsT.GetValue(0));
        }
    }

}
