using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = {
                new Car(){Name = "BMW", Price = 10000},
                new Car(){Name = "Ford", Price = 8000},
                new Car(){Name = "Audi", Price = 12000},
                new Car(){Name = "BMW", Price = 11000}};
            var CarUnique = cars.Distinct(new Comparer());
            Console.WriteLine(CarUnique.Count());
        }

        class Comparer : IEqualityComparer<Car>
        {
            public bool Equals(Car x, Car y)
            {
                return x.Name.Equals(y.Name);
            }

            public int GetHashCode(Car obj)
            {
                return obj.Name.GetHashCode();
            }
        }
    }
}
