using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsShopLib;

namespace Lesson7
{
    static class ExtendCar
    // extention on CarsShopLib.dll to not use there Console.WriteLine();
    {
        public static void Show(this Car car) //extending method
        {
            Console.WriteLine("{0} {1}", car.Name, car.Price);
        }

        public static void AddDiscount(this Car car, decimal discount)
        {
            car.Price -= discount;
        }
    }
}
