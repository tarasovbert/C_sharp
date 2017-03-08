using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArray
{
   public class WrongIndecesException:Exception
    {
       public WrongIndecesException(string message):
            base(message){ }
    }
}
