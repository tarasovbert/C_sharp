using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShopLib
{
   public class CarsShop 
    {
        private Car[] cars;
        public CarsShop()
        {
            cars = new Car[]
            {
                new Car() {Name = "BMW", Price = 50000 },
                new Car() {Price = 20000 , Name = "Ford"},
                new Car() {Name = "Vaz", Price = 1000 }
            };
        }

        public void AddCarInShop(Car newCar)
        {

        }

        public int CountCars
        {
            get { return cars.Length; }
        }


    }
}

