using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Randomer:Random
    {
        public override int Next(int minValue, int maxValue)
        {
            return base.Next(minValue, maxValue);
        }
    }
}
