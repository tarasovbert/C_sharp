using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            
            Car car = new Car() { Number = 50, price = 45000.654m }; //ctor with initializer list
            try
            {
                ParkCar carPark = new ParkCar(@"D:\1.txt");
                Console.WriteLine(carPark.GetPriceByName("BMW"));
            }

            catch(ParkCarException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex?.InnerException.Message);
                Console.WriteLine(ex.Source);
               // Console.WriteLine(ex.StackTrace);                
            }

            Console.ReadKey();         
        }
    }
}
