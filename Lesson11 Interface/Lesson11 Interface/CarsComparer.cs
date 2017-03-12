using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Interface
{
    class CarsComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Car)x).Price.CompareTo(((Car)y).Price);
        }
    }
}
