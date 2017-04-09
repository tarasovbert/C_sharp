using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    public class Car
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}.", Name, Price);
        }
    }
}
