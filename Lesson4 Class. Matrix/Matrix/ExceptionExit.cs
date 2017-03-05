using System;

namespace Matrix
{
    class ExceptionExit : Exception
    {
        public ExceptionExit(string message):
            base(message) { }

        public ExceptionExit(string message, Exception ex) :
           base(message, ex)
        { }
    }
}
