using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTrip
{
   public static class Randomer
    {        
       static Random rnd = new Random();       
       
        public static double NextDouble(int a, int b)
        {
            return rnd.NextDouble() * rnd.Next(a, b);
        }
        public static int Next(int a, int b)
        {
            return rnd.Next(a, b);
        }

    }
}
