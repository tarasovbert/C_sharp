using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunkard
{
    public class WrongQuantityOfPlayersException:Exception
    {
        public WrongQuantityOfPlayersException(string message) : base(message) { }
    }
}
