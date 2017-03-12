using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Carriers
{
    internal class DevicesException : Exception
    {
        public DevicesException() : base() { }
        public DevicesException(string message) : base(message) { }
        public DevicesException(string message, Exception ex) : base(message, ex) { }
    }
}
