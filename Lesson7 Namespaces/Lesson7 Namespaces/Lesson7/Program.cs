using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsShopLib;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Name = "Audi", Price = 30000 };
            car.Show();
            car.AddDiscount(1000);
            car.Show();
            CarsShop Shop = new CarsShop();
            Shop.AddCarInShop(car);

        }
    }
}
