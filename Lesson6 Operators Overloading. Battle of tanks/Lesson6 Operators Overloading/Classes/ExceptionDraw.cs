using System;

namespace Lesson6_Operators_Overloading
{
   internal class ExceptionDraw: Exception
    {
        public ExceptionDraw(string message)
            : base(message)
        {
        }     
    }
}
