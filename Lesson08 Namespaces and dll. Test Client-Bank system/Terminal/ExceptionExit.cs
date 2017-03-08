using System;

namespace Terminal
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
