using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    public class KeyDoesNotExistException:Exception
    {
        public KeyDoesNotExistException(string message):
            base(message) { }
    }
}
