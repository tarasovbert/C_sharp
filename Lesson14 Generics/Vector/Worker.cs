using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class Worker : IComparable
    {
        public string Name { get; set; }
        public int Wage { get; set; }

        public Worker() { }
        public Worker(string name, int wage)
        {
            Name = name;
            Wage = wage;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, wage: {1:c}.", Name, Wage);
        }

        public int CompareTo(object obj)
        {
            Worker newWorker = (Worker)obj;
            return (Name.CompareTo(newWorker.Name));
        }
    }
}
